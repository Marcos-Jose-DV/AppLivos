using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppLivrosApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Author = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    PageTotal = table.Column<int>(type: "INTEGER", nullable: false),
                    Check = table.Column<bool>(type: "INTEGER", nullable: false),
                    PageIndex = table.Column<int>(type: "INTEGER", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Slug = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImageUrl", "Name", "Slug" },
                values: new object[,]
                {
                    { 1, "tecnologia.png", "Tecnologia", "tecnologia" },
                    { 2, "romance.png", "Romance", "romance" },
                    { 3, "misterio.png", "Mistério", "misterio" },
                    { 4, "ficcao.png", "Ficção Científica", "ficcao-cientifica" },
                    { 5, "fantasia.png", "Fantasia", "fantasia" },
                    { 6, "naoficcao.png", "Não Ficção", "nao-ficcao" },
                    { 7, "aventura.png", "Aventura", "aventura" },
                    { 8, "biografia.png", "Biografia", "biografia" },
                    { 9, "historia.png", "História", "historia" },
                    { 10, "autoajuda.png", "Autoajuda", "autoajuda" },
                    { 11, "policial.png", "Policial", "policial" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
