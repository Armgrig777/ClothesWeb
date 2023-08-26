using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothesWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class asdasd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Clothing_ClothesId",
                table: "Image");

            migrationBuilder.AlterColumn<int>(
                name: "ClothesId",
                table: "Image",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Clothing_ClothesId",
                table: "Image",
                column: "ClothesId",
                principalTable: "Clothing",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Clothing_ClothesId",
                table: "Image");

            migrationBuilder.AlterColumn<int>(
                name: "ClothesId",
                table: "Image",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Clothing_ClothesId",
                table: "Image",
                column: "ClothesId",
                principalTable: "Clothing",
                principalColumn: "Id");
        }
    }
}
