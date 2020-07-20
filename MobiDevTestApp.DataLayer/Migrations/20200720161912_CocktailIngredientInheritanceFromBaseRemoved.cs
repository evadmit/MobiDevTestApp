using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobiDevTestApp.DataLayer.Migrations
{
    public partial class CocktailIngredientInheritanceFromBaseRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "CocktailIngredients");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CocktailIngredients");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "CocktailIngredients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "CocktailIngredients",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "CocktailIngredients",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "CocktailIngredients",
                type: "text",
                nullable: true);
        }
    }
}
