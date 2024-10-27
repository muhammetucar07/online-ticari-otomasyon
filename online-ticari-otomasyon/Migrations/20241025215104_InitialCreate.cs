using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace online_ticari_otomasyon.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminUserName = table.Column<string>(type: "Varchar(10)", maxLength: 10, nullable: false),
                    AdminPassword = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    Authorize = table.Column<string>(type: "Varchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "Categoriess",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoriess", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "Expensess",
                columns: table => new
                {
                    ExpensesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpensesName = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    ExpensesInfo = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    ExpensesAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpensesDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expensess", x => x.ExpensesID);
                });

            migrationBuilder.CreateTable(
                name: "Invoicess",
                columns: table => new
                {
                    InvoiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceSerialNo = table.Column<string>(type: "Char(1)", maxLength: 1, nullable: false),
                    InvoiceSequenceNumber = table.Column<string>(type: "Varchar(6)", maxLength: 6, nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaxOffice = table.Column<string>(type: "Varchar(60)", maxLength: 60, nullable: false),
                    InvoiceTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvoiceDeliverer = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    InvoiceReceiver = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoicess", x => x.InvoiceID);
                });

            migrationBuilder.CreateTable(
                name: "Saless",
                columns: table => new
                {
                    SalesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesProduct = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalesClient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalesDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saless", x => x.SalesID);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceItems",
                columns: table => new
                {
                    InvoiceItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceItemDescription = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    InvoiceItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoiceItemAmount = table.Column<int>(type: "int", nullable: false),
                    InvoiceItemPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InvoiceItemTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InvoicesInvoiceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceItems", x => x.InvoiceItemID);
                    table.ForeignKey(
                        name: "FK_InvoiceItems_Invoicess_InvoicesInvoiceID",
                        column: x => x.InvoicesInvoiceID,
                        principalTable: "Invoicess",
                        principalColumn: "InvoiceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Currents",
                columns: table => new
                {
                    CurrentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentName = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    CurrentSurname = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    CurrentCity = table.Column<string>(type: "Varchar(13)", maxLength: 13, nullable: false),
                    CurrentEmail = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    SalesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currents", x => x.CurrentID);
                    table.ForeignKey(
                        name: "FK_Currents_Saless_SalesID",
                        column: x => x.SalesID,
                        principalTable: "Saless",
                        principalColumn: "SalesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    EmployeeSurname = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    EmployeeCity = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    EmployeeEmail = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    EmployeeJob = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    EmployeeImage = table.Column<string>(type: "Varchar(250)", maxLength: 250, nullable: false),
                    SalesID = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Saless_SalesID",
                        column: x => x.SalesID,
                        principalTable: "Saless",
                        principalColumn: "SalesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    Brand = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    Stock = table.Column<short>(type: "smallint", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<string>(type: "Varchar(250)", maxLength: 250, nullable: false),
                    CategoriesCategoryID = table.Column<int>(type: "int", nullable: false),
                    SalesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categoriess_CategoriesCategoryID",
                        column: x => x.CategoriesCategoryID,
                        principalTable: "Categoriess",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Saless_SalesID",
                        column: x => x.SalesID,
                        principalTable: "Saless",
                        principalColumn: "SalesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Currents_SalesID",
                table: "Currents",
                column: "SalesID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentID",
                table: "Employees",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SalesID",
                table: "Employees",
                column: "SalesID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItems_InvoicesInvoiceID",
                table: "InvoiceItems",
                column: "InvoicesInvoiceID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoriesCategoryID",
                table: "Products",
                column: "CategoriesCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SalesID",
                table: "Products",
                column: "SalesID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Currents");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Expensess");

            migrationBuilder.DropTable(
                name: "InvoiceItems");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Invoicess");

            migrationBuilder.DropTable(
                name: "Categoriess");

            migrationBuilder.DropTable(
                name: "Saless");
        }
    }
}
