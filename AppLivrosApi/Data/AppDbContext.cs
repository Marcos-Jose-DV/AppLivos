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
}
