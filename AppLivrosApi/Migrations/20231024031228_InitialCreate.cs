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
                    Favorite = table.Column<bool>(type: "INTEGER", nullable: false),
                    PageTotal = table.Column<int>(type: "INTEGER", nullable: false),
                    Check = table.Column<bool>(type: "INTEGER", nullable: false),
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
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "Check", "DateCreate", "Description", "Favorite", "ImageUrl", "PageTotal", "Title" },
                values: new object[,]
                {
                    { 1, "Robert C. Martin", 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guia de sucesso para escrever código sustentável e de alta qualidade.", false, "clean_code.jpg", 464, "Clean Code: Um Manual de Práticas Ágeis para Código Limpo" },
                    { 2, "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides", 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Livro clássico sobre padrões de design orientados a objetos.", false, "design_patterns.jpg", 416, "Padrões de Design: Elementos de Software Orientado a Objetos Reutilizável" },
                    { 3, "Andrew Hunt, David Thomas", 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Um guia para se tornar um programador mais eficiente e eficaz.", false, "pragmatic_programmer.jpg", 352, "O Programador Pragmático: Sua Jornada para a Maestria" },
                    { 4, "Michael Sipser", 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Um livro didático abrangente sobre a teoria da computação.", false, "theory_of_computation.jpg", 521, "Introdução à Teoria da Computação" },
                    { 5, "Gayle Laakmann McDowell", 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Um guia para preparação de entrevistas técnicas com perguntas e soluções de programação.", false, "cracking_the_coding_interview.jpg", 687, "Desvendando a Entrevista de Programação: 189 Perguntas e Soluções" },
                    { 6, "Eric Matthes", 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uma introdução prática à programação usando Python.", false, "python_crash_course.jpg", 562, "Python Crash Course: Uma Introdução Prática à Programação Baseada em Projetos" },
                    { 7, "Gene Kim, Kevin Behr, George Spafford", 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Um romance que explora TI e DevOps no contexto empresarial.", false, "phoenix_project.jpg", 376, "O Projeto Fênix: Um Romance sobre TI, DevOps e o Sucesso Empresarial" },
                    { 8, "Ian Goodfellow, Yoshua Bengio, Aaron Courville", 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Um livro didático abrangente sobre aprendizado profundo e redes neurais.", false, "deep_learning.jpg", 800, "Aprendizado Profundo" },
                    { 9, "Stuart Russell, Peter Norvig", 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Um livro didático amplamente usado sobre inteligência artificial.", false, "ai_modern_approach.jpg", 1132, "Inteligência Artificial: Uma Abordagem Moderna" }
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
