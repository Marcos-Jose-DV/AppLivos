using AppLivrosApi.Data;
using AppLivrosApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppLivrosApi.Controllers;

[ApiController]
public class LivrosController : Controller
{
    private readonly AppDbContext _context;

    public LivrosController(AppDbContext dbContext)
    {
        _context = dbContext;
    }

    [HttpGet("v1/livros")]
    public async Task<IActionResult> GetBooks()
    {
        var books = await _context.Books.AsNoTracking().ToListAsync();
        if(books == null) return NotFound();


        return Ok(books);
    }

    [HttpGet("v1/livros/{id:int}")]
    public async Task<IActionResult> GetBookId([FromRoute] int id)
    {
        var book = await _context.Books.FirstOrDefaultAsync(x => x.Id == id);
        if(book == null) return NotFound();

        return Ok(book);
    }

    [HttpPost("v1/livros/Create")]
    public async Task<IActionResult> PutBookId([FromBody] Book model)
    {
        if (model == null) return NotFound();

        _context.Books.Add(model);
        await _context.SaveChangesAsync();

        return Created($"v1/lisvros/{model.Id}", model);
    }


    [HttpPut("v1/livros/{id:int}")]
    public async Task<IActionResult> PutBookId([FromRoute] int id, [FromBody] Book model)
    {
        var book = await _context.Books.FirstOrDefaultAsync(x => x.Id == id);
        if (book == null) return NotFound();

        book.Title = model.Title;
        book.Description = model.Description;
        book.Author = model.Author;
        book.ImageUrl = model.ImageUrl;
        book.PageTotal = model.PageTotal;
        book.Check = model.Check;
        book.PageIndex = model.PageIndex;
        book.DateCreate = DateTime.Now;

        _context.Books.Update(book);
        await _context.SaveChangesAsync();    

        return Ok(model);
    }

    [HttpDelete("v1/livros/{id:int}")]
    public async Task<IActionResult> DeleteBookId([FromRoute] int id)
    {
        var book = await _context.Books.FirstOrDefaultAsync(x => x.Id == id);
        if (book == null) return NotFound();

        _context.Books.Remove(book);
        await _context.SaveChangesAsync();

        return Ok(book);
    }
}
