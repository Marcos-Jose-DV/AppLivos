using AppLivrosApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AppLivrosApi.Data;

public class AppDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public AppDbContext(IConfiguration configuration)
    {
        _configuration = configuration;

    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Category> Categories { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite(_configuration.GetConnectionString("WebApiDatabase"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        SeedData(ref modelBuilder);
    }

    private static void SeedData(ref ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .HasData(
                new Category(1, "Tecnologia", "tecnologia", "tecnologia.png"),
                new Category(2, "Romance", "romance", "romance.png"),
                new Category(3, "Mistério", "misterio", "misterio.png"),
                new Category(4, "Ficção Científica", "ficcao-cientifica", "ficcao.png"),
                new Category(5, "Fantasia", "fantasia", "fantasia.png"),
                new Category(6, "Não Ficção", "nao-ficcao", "naoficcao.png"),
                new Category(7, "Aventura", "aventura", "aventura.png"),
                new Category(8, "Biografia", "biografia", "biografia.png"),
                new Category(9, "História", "historia", "historia.png"),
                new Category(10, "Autoajuda", "autoajuda", "autoajuda.png"),
                new Category(11, "Policial", "policial", "policial.png")
            );

        modelBuilder.Entity<Book>()
            .HasData(
                new Book(1, "Clean Code: Um Manual de Práticas Ágeis para Código Limpo", "Guia de sucesso para escrever código sustentável e de alta qualidade.", "Robert C. Martin", "clean_code.jpg", 464, true, 1),
                new Book(2, "Padrões de Design: Elementos de Software Orientado a Objetos Reutilizável", "Livro clássico sobre padrões de design orientados a objetos.", "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides", "design_patterns.jpg", 416, true, 1),
                new Book(3, "O Programador Pragmático: Sua Jornada para a Maestria", "Um guia para se tornar um programador mais eficiente e eficaz.", "Andrew Hunt, David Thomas", "pragmatic_programmer.jpg", 352, true, 1),
                new Book(4, "Introdução à Teoria da Computação", "Um livro didático abrangente sobre a teoria da computação.", "Michael Sipser", "theory_of_computation.jpg", 521, true, 1),
                new Book(5, "Desvendando a Entrevista de Programação: 189 Perguntas e Soluções", "Um guia para preparação de entrevistas técnicas com perguntas e soluções de programação.", "Gayle Laakmann McDowell", "cracking_the_coding_interview.jpg", 687, true, 1),
                new Book(6, "Python Crash Course: Uma Introdução Prática à Programação Baseada em Projetos", "Uma introdução prática à programação usando Python.", "Eric Matthes", "python_crash_course.jpg", 562, false, 1),
                new Book(7, "O Projeto Fênix: Um Romance sobre TI, DevOps e o Sucesso Empresarial", "Um romance que explora TI e DevOps no contexto empresarial.", "Gene Kim, Kevin Behr, George Spafford", "phoenix_project.jpg", 376, false, 1),
                new Book(8, "Aprendizado Profundo", "Um livro didático abrangente sobre aprendizado profundo e redes neurais.", "Ian Goodfellow, Yoshua Bengio, Aaron Courville", "deep_learning.jpg", 800, false, 1),
                new Book(9, "Inteligência Artificial: Uma Abordagem Moderna", "Um livro didático amplamente usado sobre inteligência artificial.", "Stuart Russell, Peter Norvig", "ai_modern_approach.jpg", 1132, false, 1)
                );
    }
}
