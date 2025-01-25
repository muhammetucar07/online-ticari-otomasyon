using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace online_ticari_otomasyon.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateeee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "date",
                table: "Saless",
                newName: "Date");

            migrationBuilder.AlterColumn<string>(
                name: "SalesProduct",
                table: "Saless",
                type: "Varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SalesClient",
                table: "Saless",
                type: "Varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Saless",
                newName: "date");

            migrationBuilder.AlterColumn<string>(
                name: "SalesProduct",
                table: "Saless",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "SalesClient",
                table: "Saless",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(100)",
                oldMaxLength: 100);
        }
    }
}
