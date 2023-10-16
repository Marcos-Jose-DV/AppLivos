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
    }
}
