using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace online_ticari_otomasyon.Migrations
{
    /// <inheritdoc />
    public partial class test3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Currents_Saless_SalesID",
                table: "Currents");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Saless_SalesID",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categoriess_CategoriesCategoryID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Saless_SalesID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoriesCategoryID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Employees_SalesID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Currents_SalesID",
                table: "Currents");

            migrationBuilder.DropColumn(
                name: "CategoriesCategoryID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SalesID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SalesID",
                table: "Currents");

            migrationBuilder.RenameColumn(
                name: "SalesDate",
                table: "Saless",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "SalesID",
                table: "Products",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_SalesID",
                table: "Products",
                newName: "IX_Products_CategoryID");

            migrationBuilder.AddColumn<int>(
                name: "CurrentID",
                table: "Saless",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "Saless",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Saless",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Saless_CurrentID",
                table: "Saless",
                column: "CurrentID");

            migrationBuilder.CreateIndex(
                name: "IX_Saless_EmployeeID",
                table: "Saless",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Saless_ProductID",
                table: "Saless",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categoriess_CategoryID",
                table: "Products",
                column: "CategoryID",
                principalTable: "Categoriess",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Saless_Currents_CurrentID",
                table: "Saless",
                column: "CurrentID",
                principalTable: "Currents",
                principalColumn: "CurrentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Saless_Employees_EmployeeID",
                table: "Saless",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Saless_Products_ProductID",
                table: "Saless",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categoriess_CategoryID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Saless_Currents_CurrentID",
                table: "Saless");

            migrationBuilder.DropForeignKey(
                name: "FK_Saless_Employees_EmployeeID",
                table: "Saless");

            migrationBuilder.DropForeignKey(
                name: "FK_Saless_Products_ProductID",
                table: "Saless");

            migrationBuilder.DropIndex(
                name: "IX_Saless_CurrentID",
                table: "Saless");

            migrationBuilder.DropIndex(
                name: "IX_Saless_EmployeeID",
                table: "Saless");

            migrationBuilder.DropIndex(
                name: "IX_Saless_ProductID",
                table: "Saless");

            migrationBuilder.DropColumn(
                name: "CurrentID",
                table: "Saless");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Saless");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Saless");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Saless",
                newName: "SalesDate");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Products",
                newName: "SalesID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                newName: "IX_Products_SalesID");

            migrationBuilder.AddColumn<int>(
                name: "CategoriesCategoryID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SalesID",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SalesID",
                table: "Currents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoriesCategoryID",
                table: "Products",
                column: "CategoriesCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SalesID",
                table: "Employees",
                column: "SalesID");

            migrationBuilder.CreateIndex(
                name: "IX_Currents_SalesID",
                table: "Currents",
                column: "SalesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Currents_Saless_SalesID",
                table: "Currents",
                column: "SalesID",
                principalTable: "Saless",
                principalColumn: "SalesID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Saless_SalesID",
                table: "Employees",
                column: "SalesID",
                principalTable: "Saless",
                principalColumn: "SalesID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categoriess_CategoriesCategoryID",
                table: "Products",
                column: "CategoriesCategoryID",
                principalTable: "Categoriess",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Saless_SalesID",
                table: "Products",
                column: "SalesID",
                principalTable: "Saless",
                principalColumn: "SalesID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
