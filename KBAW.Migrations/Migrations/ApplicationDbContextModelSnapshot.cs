﻿// <auto-generated />


#nullable disable

using System;
using KBAW.DataAccess.ApplicationDb;
using KBAW.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
namespace KBAW.Migrations.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataAccess.DomainModels.Article", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("K1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("K2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("K3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("K4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlacePublication")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RecommendedBookId")
                        .HasColumnType("bigint");

                    b.Property<long>("SourceId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("YdkId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RecommendedBookId");

                    b.HasIndex("SourceId");

                    b.HasIndex("YdkId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("DataAccess.DomainModels.Author", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("DataAccess.DomainModels.AuthorOfArticle", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("ArticleId")
                        .HasColumnType("bigint");

                    b.Property<long>("AuthorId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("AuthorId");

                    b.ToTable("AuthorOfArticles");
                });

            modelBuilder.Entity("DataAccess.DomainModels.AuthorOfBook", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("AuthorId")
                        .HasColumnType("bigint");

                    b.Property<long>("BookId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("AuthorOfBooks");
                });

            modelBuilder.Entity("DataAccess.DomainModels.AuthorOfPatent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("AuthorId")
                        .HasColumnType("bigint");

                    b.Property<long>("PatentId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PatentId");

                    b.ToTable("AuthorOfPatents");
                });

            modelBuilder.Entity("DataAccess.DomainModels.Book", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("CountryId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("K1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("K2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("K3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RecommendedBookId")
                        .HasColumnType("bigint");

                    b.Property<long>("SourceId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("YdkId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("RecommendedBookId");

                    b.HasIndex("SourceId");

                    b.HasIndex("YdkId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("DataAccess.DomainModels.Country", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("DataAccess.DomainModels.Patent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Classification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CountryId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("K1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("K2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("K3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Number")
                        .HasColumnType("bigint");

                    b.Property<long>("RecommendedBookId")
                        .HasColumnType("bigint");

                    b.Property<long>("SourceId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("YdkId")
                        .HasColumnType("bigint");

                    b.Property<string>("СertificateAuthorship")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("RecommendedBookId");

                    b.HasIndex("SourceId");

                    b.HasIndex("YdkId");

                    b.ToTable("Patents");
                });

            modelBuilder.Entity("DataAccess.DomainModels.RecommendedBook", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<byte[]>("Book")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RecommendedBooks");
                });

            modelBuilder.Entity("DataAccess.DomainModels.Source", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sources");
                });

            modelBuilder.Entity("DataAccess.DomainModels.Ydk", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("YdKs");
                });

            modelBuilder.Entity("DataAccess.DomainModels.Article", b =>
                {
                    b.HasOne("DataAccess.DomainModels.RecommendedBook", "RecommendedBook")
                        .WithMany("Articles")
                        .HasForeignKey("RecommendedBookId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DataAccess.DomainModels.Source", "Source")
                        .WithMany("Articles")
                        .HasForeignKey("SourceId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DataAccess.DomainModels.Ydk", "Ydk")
                        .WithMany("Articles")
                        .HasForeignKey("YdkId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("RecommendedBook");

                    b.Navigation("Source");

                    b.Navigation("Ydk");
                });

            modelBuilder.Entity("DataAccess.DomainModels.AuthorOfArticle", b =>
                {
                    b.HasOne("DataAccess.DomainModels.Article", "Article")
                        .WithMany("AuthorOfArticles")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DataAccess.DomainModels.Author", "Author")
                        .WithMany("AuthorOfArticles")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("DataAccess.DomainModels.AuthorOfBook", b =>
                {
                    b.HasOne("DataAccess.DomainModels.Author", "Author")
                        .WithMany("AuthorOfBooks")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DataAccess.DomainModels.Book", "Book")
                        .WithMany("AuthorOfBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("DataAccess.DomainModels.AuthorOfPatent", b =>
                {
                    b.HasOne("DataAccess.DomainModels.Author", "Author")
                        .WithMany("AuthorOfPatents")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DataAccess.DomainModels.Patent", "Patent")
                        .WithMany("AuthorOfPatents")
                        .HasForeignKey("PatentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Patent");
                });

            modelBuilder.Entity("DataAccess.DomainModels.Book", b =>
                {
                    b.HasOne("DataAccess.DomainModels.Country", "Country")
                        .WithMany("Books")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DataAccess.DomainModels.RecommendedBook", "RecommendedBook")
                        .WithMany("Books")
                        .HasForeignKey("RecommendedBookId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DataAccess.DomainModels.Source", "Source")
                        .WithMany("Books")
                        .HasForeignKey("SourceId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DataAccess.DomainModels.Ydk", "Ydk")
                        .WithMany("Books")
                        .HasForeignKey("YdkId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("RecommendedBook");

                    b.Navigation("Source");

                    b.Navigation("Ydk");
                });

            modelBuilder.Entity("DataAccess.DomainModels.Patent", b =>
                {
                    b.HasOne("DataAccess.DomainModels.Country", "Country")
                        .WithMany("Patents")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DataAccess.DomainModels.RecommendedBook", "RecommendedBook")
                        .WithMany("Patents")
                        .HasForeignKey("RecommendedBookId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DataAccess.DomainModels.Source", "Source")
                        .WithMany("Patents")
                        .HasForeignKey("SourceId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DataAccess.DomainModels.Ydk", "Ydk")
                        .WithMany("Patents")
                        .HasForeignKey("YdkId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("RecommendedBook");

                    b.Navigation("Source");

                    b.Navigation("Ydk");
                });

            modelBuilder.Entity("DataAccess.DomainModels.Article", b =>
                {
                    b.Navigation("AuthorOfArticles");
                });

            modelBuilder.Entity("DataAccess.DomainModels.Author", b =>
                {
                    b.Navigation("AuthorOfArticles");

                    b.Navigation("AuthorOfBooks");

                    b.Navigation("AuthorOfPatents");
                });

            modelBuilder.Entity("DataAccess.DomainModels.Book", b =>
                {
                    b.Navigation("AuthorOfBooks");
                });

            modelBuilder.Entity("DataAccess.DomainModels.Country", b =>
                {
                    b.Navigation("Books");

                    b.Navigation("Patents");
                });

            modelBuilder.Entity("DataAccess.DomainModels.Patent", b =>
                {
                    b.Navigation("AuthorOfPatents");
                });

            modelBuilder.Entity("DataAccess.DomainModels.RecommendedBook", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Books");

                    b.Navigation("Patents");
                });

            modelBuilder.Entity("DataAccess.DomainModels.Source", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Books");

                    b.Navigation("Patents");
                });

            modelBuilder.Entity("DataAccess.DomainModels.Ydk", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Books");

                    b.Navigation("Patents");
                });
#pragma warning restore 612, 618
        }
    }
}
