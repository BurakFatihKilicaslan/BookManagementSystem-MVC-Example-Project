using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookManagementSystem.Migrations
{
    public partial class Versiyon1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeathDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AuthorName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    PublisherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Phone = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    FoundationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PublisherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.PublisherID);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageCount = table.Column<int>(type: "int", nullable: false),
                    PublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuthorID = table.Column<int>(type: "int", nullable: true),
                    PublisherID = table.Column<int>(type: "int", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    BookName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookID);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "Authors",
                        principalColumn: "AuthorID",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherID",
                        column: x => x.PublisherID,
                        principalTable: "Publishers",
                        principalColumn: "PublisherID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorID", "BirthDate", "DeathDate", "AuthorName" },
                values: new object[,]
                {
                    { 1, new DateTime(1965, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "J.K.Rowling" },
                    { 2, new DateTime(1564, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1616, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "William Shakespeare" },
                    { 3, new DateTime(1775, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1817, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Austen" },
                    { 4, new DateTime(1892, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "J.R.R. Tolkien" },
                    { 5, new DateTime(1890, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agatha Christie" },
                    { 6, new DateTime(1902, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Steinbeck" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Fictional prose narrative of considerable length, typically representing characters and actions in a realistic way.", "Novel" },
                    { 2, "Genre of speculative fiction that typically deals with imaginative and futuristic concepts, often incorporating advanced science and technology.", "Science Fiction" },
                    { 3, "Genre of fiction that involves solving a mysterious event or crime and usually creates a sense of suspense and excitement.", "Mystery and Thriller" },
                    { 4, "Genre of fiction that takes place in the past and often incorporates real historical events, figures, or settings while incorporating fictional elements.", "Historical Fiction" },
                    { 5, "Account of a person's life written by someone else, providing a detailed description of the person's experiences, achievements, and challenges.", "Biography" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherID", "Address", "FoundationDate", "PublisherName", "Phone" },
                values: new object[,]
                {
                    { 1, "Penguin Classics, 80 Strand, London, WC2R 0RL, United Kingdom", new DateTime(1946, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Penguin Classics", "+4402031226000" },
                    { 2, "HarperCollins Publishers, 195 Broadway, New York, NY 10007, United States", new DateTime(1817, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HarperCollins Publishers", "+12122077000" },
                    { 3, "Bloomsbury Publishing, 50 Bedford Square, London, WC1B 3DP, United Kingdom", new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloomsbury Publishing", "+4402076315600" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "AuthorID", "CategoryID", "BookName", "PageCount", "PublicationDate", "PublisherID" },
                values: new object[,]
                {
                    { 1, 2, 1, "Hamlet", 320, new DateTime(1603, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 3, 1, "Pride and Prejudice", 432, new DateTime(1813, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, 4, 2, "The Lord of the Rings", 1178, new DateTime(1954, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 4, 5, 3, "Murder on the Orient Express", 256, new DateTime(1934, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 5, 1, 2, "Harry Potter and the Philosopher's Stone", 223, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 6, 6, 1, "The Grapes of Wrath", 464, new DateTime(1939, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorID",
                table: "Books",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryID",
                table: "Books",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherID",
                table: "Books",
                column: "PublisherID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
