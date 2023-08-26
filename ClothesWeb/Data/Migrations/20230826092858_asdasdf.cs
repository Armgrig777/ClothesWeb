using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothesWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class asdasdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Coats_CoatsId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Image_Pants_PantsId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Image_Shirts_ShirtsId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Image_Shoes_ShoesId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Image_Suits_SuitId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Image_Sweater_SweaterId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Sweater_Designers_DesignersId",
                table: "Sweater");

            migrationBuilder.DropTable(
                name: "Coats");

            migrationBuilder.DropTable(
                name: "Pants");

            migrationBuilder.DropTable(
                name: "Shirts");

            migrationBuilder.DropTable(
                name: "Shoes");

            migrationBuilder.DropTable(
                name: "Suits");

            migrationBuilder.DropIndex(
                name: "IX_Image_CoatsId",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Image_PantsId",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Image_ShirtsId",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Image_ShoesId",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Image_SweaterId",
                table: "Image");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sweater",
                table: "Sweater");

            migrationBuilder.DropColumn(
                name: "CoatsId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "PantsId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "ShirtId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "ShirtsId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "ShoesId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "SweaterId",
                table: "Image");

            migrationBuilder.RenameTable(
                name: "Sweater",
                newName: "Clothing");

            migrationBuilder.RenameColumn(
                name: "SuitId",
                table: "Image",
                newName: "ClothesId");

            migrationBuilder.RenameIndex(
                name: "IX_Image_SuitId",
                table: "Image",
                newName: "IX_Image_ClothesId");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Clothing",
                newName: "registration_date");

            migrationBuilder.RenameIndex(
                name: "IX_Sweater_DesignersId",
                table: "Clothing",
                newName: "IX_Clothing_DesignersId");

            migrationBuilder.AlterColumn<int>(
                name: "Size",
                table: "Clothing",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Clothing",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Clothing",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Pants_Name",
                table: "Clothing",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Polo_TShirts_Name",
                table: "Clothing",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Shoes_Name",
                table: "Clothing",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sweater_Name",
                table: "Clothing",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clothing",
                table: "Clothing",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clothing_Designers_DesignersId",
                table: "Clothing",
                column: "DesignersId",
                principalTable: "Designers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Clothing_ClothesId",
                table: "Image",
                column: "ClothesId",
                principalTable: "Clothing",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clothing_Designers_DesignersId",
                table: "Clothing");

            migrationBuilder.DropForeignKey(
                name: "FK_Image_Clothing_ClothesId",
                table: "Image");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clothing",
                table: "Clothing");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Clothing");

            migrationBuilder.DropColumn(
                name: "Pants_Name",
                table: "Clothing");

            migrationBuilder.DropColumn(
                name: "Polo_TShirts_Name",
                table: "Clothing");

            migrationBuilder.DropColumn(
                name: "Shoes_Name",
                table: "Clothing");

            migrationBuilder.DropColumn(
                name: "Sweater_Name",
                table: "Clothing");

            migrationBuilder.RenameTable(
                name: "Clothing",
                newName: "Sweater");

            migrationBuilder.RenameColumn(
                name: "ClothesId",
                table: "Image",
                newName: "SuitId");

            migrationBuilder.RenameIndex(
                name: "IX_Image_ClothesId",
                table: "Image",
                newName: "IX_Image_SuitId");

            migrationBuilder.RenameColumn(
                name: "registration_date",
                table: "Sweater",
                newName: "DateTime");

            migrationBuilder.RenameIndex(
                name: "IX_Clothing_DesignersId",
                table: "Sweater",
                newName: "IX_Sweater_DesignersId");

            migrationBuilder.AddColumn<int>(
                name: "CoatsId",
                table: "Image",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PantsId",
                table: "Image",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShirtId",
                table: "Image",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShirtsId",
                table: "Image",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShoesId",
                table: "Image",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SweaterId",
                table: "Image",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Size",
                table: "Sweater",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Sweater",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sweater",
                table: "Sweater",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Coats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignersId = table.Column<int>(type: "int", nullable: false),
                    Colors = table.Column<int>(type: "int", nullable: false),
                    DesignerID = table.Column<int>(type: "int", nullable: false),
                    Material = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    registation_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coats_Designers_DesignersId",
                        column: x => x.DesignersId,
                        principalTable: "Designers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignersId = table.Column<int>(type: "int", nullable: false),
                    Colors = table.Column<int>(type: "int", nullable: false),
                    DesignerID = table.Column<int>(type: "int", nullable: false),
                    Material = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    registation_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pants_Designers_DesignersId",
                        column: x => x.DesignersId,
                        principalTable: "Designers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shirts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignersId = table.Column<int>(type: "int", nullable: false),
                    Colors = table.Column<int>(type: "int", nullable: false),
                    DesignerID = table.Column<int>(type: "int", nullable: false),
                    Material = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    registration_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shirts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shirts_Designers_DesignersId",
                        column: x => x.DesignersId,
                        principalTable: "Designers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignersId = table.Column<int>(type: "int", nullable: false),
                    Colors = table.Column<int>(type: "int", nullable: false),
                    DesignerID = table.Column<int>(type: "int", nullable: false),
                    Material = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    registation_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shoes_Designers_DesignersId",
                        column: x => x.DesignersId,
                        principalTable: "Designers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignersId = table.Column<int>(type: "int", nullable: false),
                    Colors = table.Column<int>(type: "int", nullable: false),
                    DesignerID = table.Column<int>(type: "int", nullable: false),
                    Material = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    registration_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suits_Designers_DesignersId",
                        column: x => x.DesignersId,
                        principalTable: "Designers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_CoatsId",
                table: "Image",
                column: "CoatsId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_PantsId",
                table: "Image",
                column: "PantsId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_ShirtsId",
                table: "Image",
                column: "ShirtsId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_ShoesId",
                table: "Image",
                column: "ShoesId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_SweaterId",
                table: "Image",
                column: "SweaterId");

            migrationBuilder.CreateIndex(
                name: "IX_Coats_DesignersId",
                table: "Coats",
                column: "DesignersId");

            migrationBuilder.CreateIndex(
                name: "IX_Pants_DesignersId",
                table: "Pants",
                column: "DesignersId");

            migrationBuilder.CreateIndex(
                name: "IX_Shirts_DesignersId",
                table: "Shirts",
                column: "DesignersId");

            migrationBuilder.CreateIndex(
                name: "IX_Shoes_DesignersId",
                table: "Shoes",
                column: "DesignersId");

            migrationBuilder.CreateIndex(
                name: "IX_Suits_DesignersId",
                table: "Suits",
                column: "DesignersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Coats_CoatsId",
                table: "Image",
                column: "CoatsId",
                principalTable: "Coats",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Pants_PantsId",
                table: "Image",
                column: "PantsId",
                principalTable: "Pants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Shirts_ShirtsId",
                table: "Image",
                column: "ShirtsId",
                principalTable: "Shirts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Shoes_ShoesId",
                table: "Image",
                column: "ShoesId",
                principalTable: "Shoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Suits_SuitId",
                table: "Image",
                column: "SuitId",
                principalTable: "Suits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Sweater_SweaterId",
                table: "Image",
                column: "SweaterId",
                principalTable: "Sweater",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sweater_Designers_DesignersId",
                table: "Sweater",
                column: "DesignersId",
                principalTable: "Designers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
