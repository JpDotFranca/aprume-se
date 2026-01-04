using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aprumese.Api.Migrations
{
    /// <inheritdoc />
    public partial class IncomeCategory_Nullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_IncomeCategory_CategoryId",
                table: "Incomes");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Incomes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_IncomeCategory_CategoryId",
                table: "Incomes",
                column: "CategoryId",
                principalTable: "IncomeCategory",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_IncomeCategory_CategoryId",
                table: "Incomes");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Incomes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_IncomeCategory_CategoryId",
                table: "Incomes",
                column: "CategoryId",
                principalTable: "IncomeCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
