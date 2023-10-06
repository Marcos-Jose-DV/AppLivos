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

   public DbSet<Books> Books { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)  
        => options.UseSqlite(_configuration.GetConnectionString("WebApiDatabase"));
}
