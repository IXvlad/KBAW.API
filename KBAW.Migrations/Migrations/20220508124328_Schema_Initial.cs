using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KBAW.Migrations.Migrations
{
    public partial class Schema_Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecommendedBooks",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Book = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecommendedBooks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ydks",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YdKs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    K1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    K2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    K3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YdkId = table.Column<long>(type: "bigint", nullable: false),
                    RecommendedBookId = table.Column<long>(type: "bigint", nullable: false),
                    PlacePublication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_RecommendedBooks_RecommendedBookId",
                        column: x => x.RecommendedBookId,
                        principalTable: "RecommendedBooks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Articles_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Articles_YdKs_YdkId",
                        column: x => x.YdkId,
                        principalTable: "YdKs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    K1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    K2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    K3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YdkId = table.Column<long>(type: "bigint", nullable: false),
                    RecommendedBookId = table.Column<long>(type: "bigint", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    SourceId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Books_RecommendedBooks_RecommendedBookId",
                        column: x => x.RecommendedBookId,
                        principalTable: "RecommendedBooks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Books_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Books_YdKs_YdkId",
                        column: x => x.YdkId,
                        principalTable: "YdKs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Patents",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    K1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    K2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    K3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YdkId = table.Column<long>(type: "bigint", nullable: false),
                    RecommendedBookId = table.Column<long>(type: "bigint", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    SourceId = table.Column<long>(type: "bigint", nullable: false),
                    Number = table.Column<long>(type: "bigint", nullable: false),
                    Classification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    СertificateAuthorship = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patents_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patents_RecommendedBooks_RecommendedBookId",
                        column: x => x.RecommendedBookId,
                        principalTable: "RecommendedBooks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patents_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patents_YdKs_YdkId",
                        column: x => x.YdkId,
                        principalTable: "YdKs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AuthorOfArticles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleId = table.Column<long>(type: "bigint", nullable: false),
                    AuthorId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorOfArticles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorOfArticles_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AuthorOfArticles_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AuthorOfBooks",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<long>(type: "bigint", nullable: false),
                    AuthorId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorOfBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorOfBooks_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AuthorOfBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AuthorOfPatents",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatentId = table.Column<long>(type: "bigint", nullable: false),
                    AuthorId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorOfPatents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorOfPatents_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AuthorOfPatents_Patents_PatentId",
                        column: x => x.PatentId,
                        principalTable: "Patents",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_RecommendedBookId",
                table: "Articles",
                column: "RecommendedBookId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_SourceId",
                table: "Articles",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_YdkId",
                table: "Articles",
                column: "YdkId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorOfArticles_ArticleId",
                table: "AuthorOfArticles",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorOfArticles_AuthorId",
                table: "AuthorOfArticles",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorOfBooks_AuthorId",
                table: "AuthorOfBooks",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorOfBooks_BookId",
                table: "AuthorOfBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorOfPatents_AuthorId",
                table: "AuthorOfPatents",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorOfPatents_PatentId",
                table: "AuthorOfPatents",
                column: "PatentId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CountryId",
                table: "Books",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_RecommendedBookId",
                table: "Books",
                column: "RecommendedBookId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_SourceId",
                table: "Books",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_YdkId",
                table: "Books",
                column: "YdkId");

            migrationBuilder.CreateIndex(
                name: "IX_Patents_CountryId",
                table: "Patents",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Patents_RecommendedBookId",
                table: "Patents",
                column: "RecommendedBookId");

            migrationBuilder.CreateIndex(
                name: "IX_Patents_SourceId",
                table: "Patents",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Patents_YdkId",
                table: "Patents",
                column: "YdkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorOfArticles");

            migrationBuilder.DropTable(
                name: "AuthorOfBooks");

            migrationBuilder.DropTable(
                name: "AuthorOfPatents");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Patents");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "RecommendedBooks");

            migrationBuilder.DropTable(
                name: "Sources");

            migrationBuilder.DropTable(
                name: "YdKs");
        }
    }
}
