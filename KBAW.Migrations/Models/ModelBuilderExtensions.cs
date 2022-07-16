using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;

namespace KBAW.Migrations.Models;

public static class ModelBuilderExtensions
{
    public static OperationBuilder<SqlOperation> ExecuteSql(this MigrationBuilder migrationBuilder, string sqlCommand,
        bool suppressTransaction = false)
    {
        if (migrationBuilder == null)
        {
            throw new ArgumentNullException(nameof(migrationBuilder));
        }

        if (string.IsNullOrEmpty(sqlCommand))
        {
            throw new ArgumentNullException(nameof(sqlCommand));
        }

        var operation = new SqlOperation { Sql = sqlCommand, SuppressTransaction = suppressTransaction };

        return new OperationBuilder<SqlOperation>(operation);
    }

    public static void ExecuteSqlFile(this MigrationBuilder migrationBuilder, int? index = null)
    {
        if (migrationBuilder == null)
        {
            throw new ArgumentNullException(nameof(migrationBuilder));
        }

        var declaringType = new StackTrace()
            .GetFrame(1)
            ?.GetMethod()
            ?.DeclaringType;

        if (declaringType == null)
        {
            throw new ArgumentNullException(nameof(declaringType));
        }

        var migrationId = declaringType.GetCustomAttribute<MigrationAttribute>()?.Id;

        var sqlResourceStream = Assembly.GetExecutingAssembly()
            .GetManifestResourceStream(
                $"KBAW.Migrations.{migrationId}{(index != null ? '_' + index.Value : string.Empty)}.sql");

        if (sqlResourceStream == null)
        {
            throw new InvalidOperationException($"SQL script not found for {migrationId}.");
        }

        using var reader = new StreamReader(sqlResourceStream);

        var sql = reader.ReadToEnd();

        if (string.IsNullOrEmpty(sql))
        {
            throw new InvalidOperationException("SQL script is empty");
        }

        migrationBuilder.Sql(sql);
    }
}