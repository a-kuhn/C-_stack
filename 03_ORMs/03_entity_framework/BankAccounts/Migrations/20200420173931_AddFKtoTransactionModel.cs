using Microsoft.EntityFrameworkCore.Migrations;

namespace BankAccounts.Migrations
{
    public partial class AddFKtoTransactionModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Users_TransactionUserUserId",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "TransactionUserUserId",
                table: "Transactions",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_TransactionUserUserId",
                table: "Transactions",
                newName: "IX_Transactions_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Users_UserId",
                table: "Transactions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Users_UserId",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Transactions",
                newName: "TransactionUserUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_UserId",
                table: "Transactions",
                newName: "IX_Transactions_TransactionUserUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Users_TransactionUserUserId",
                table: "Transactions",
                column: "TransactionUserUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
