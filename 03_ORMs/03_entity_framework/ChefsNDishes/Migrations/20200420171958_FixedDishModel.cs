using Microsoft.EntityFrameworkCore.Migrations;

namespace ChefsNDishes.Migrations
{
    public partial class FixedDishModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Chefs_DishCreatorChefId",
                table: "Dishes");

            migrationBuilder.RenameColumn(
                name: "DishCreatorChefId",
                table: "Dishes",
                newName: "ChefId");

            migrationBuilder.RenameIndex(
                name: "IX_Dishes_DishCreatorChefId",
                table: "Dishes",
                newName: "IX_Dishes_ChefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Chefs_ChefId",
                table: "Dishes",
                column: "ChefId",
                principalTable: "Chefs",
                principalColumn: "ChefId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Chefs_ChefId",
                table: "Dishes");

            migrationBuilder.RenameColumn(
                name: "ChefId",
                table: "Dishes",
                newName: "DishCreatorChefId");

            migrationBuilder.RenameIndex(
                name: "IX_Dishes_ChefId",
                table: "Dishes",
                newName: "IX_Dishes_DishCreatorChefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Chefs_DishCreatorChefId",
                table: "Dishes",
                column: "DishCreatorChefId",
                principalTable: "Chefs",
                principalColumn: "ChefId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
