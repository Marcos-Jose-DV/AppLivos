using AppLivrosApi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppLivrosApi.Controllers;

[ApiController]
public class LivrosController : Controller
{
    private readonly AppDbContext _dbContext;

    public LivrosController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult Index()
    {
        var books = _dbContext.Books.AsNoTracking().ToListAsync();
        return Ok(books);
    }
}
