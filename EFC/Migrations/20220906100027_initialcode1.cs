using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFC.Migrations
{
    public partial class initialcode1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MyOrder",
                columns: table => new
                {
                    Order_ID = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderAmt = table.Column<int>(type: "int", nullable: false),
                    custID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyOrder", x => x.Order_ID);
                    table.ForeignKey(
                        name: "FK_MyOrder_Customer_custID",
                        column: x => x.custID,
                        principalTable: "Customer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyOrder_custID",
                table: "MyOrder",
                column: "custID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyOrder");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
