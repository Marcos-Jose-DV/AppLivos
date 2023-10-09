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

    [HttpGet("/livros")]
    public IActionResult GetBooks()
    {
        var books = _dbContext.Books.AsNoTracking().ToListAsync();
        return Ok(books);
    }
    [HttpGet("{id:int}")]
    public IActionResult GetBookId([FromServices] int id)
    {
        var book = _dbContext.Books.Where(x => x.Id == id);
        return Ok(book);
    }
}
