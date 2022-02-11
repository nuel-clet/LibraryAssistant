using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryAssistant.Migrations
{
    public partial class addedInventoryAndPatron : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book_Patrons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber = table.Column<long>(type: "bigint", nullable: false),
                    NationalID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book_Patrons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Book_Inventorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsCheckedIn = table.Column<bool>(type: "bit", nullable: false),
                    CheckedOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckedInDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    BookPatronId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book_Inventorys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_Inventorys_Book_Patrons_BookPatronId",
                        column: x => x.BookPatronId,
                        principalTable: "Book_Patrons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_Inventorys_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_Inventorys_BookId",
                table: "Book_Inventorys",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_Inventorys_BookPatronId",
                table: "Book_Inventorys",
                column: "BookPatronId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_Patrons_NationalID",
                table: "Book_Patrons",
                column: "NationalID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book_Inventorys");

            migrationBuilder.DropTable(
                name: "Book_Patrons");
        }
    }
}
