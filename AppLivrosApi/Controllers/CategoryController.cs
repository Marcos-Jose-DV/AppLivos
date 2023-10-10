using AppLivrosApi.Data;
using AppLivrosApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppLivrosApi.Controllers;


[ApiController]
public class CategoryController : ControllerBase
{
    private readonly AppDbContext _context;

    public CategoryController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("v1/categorias")]
    [HttpGet("v1/categories")]
    public async Task<IActionResult> GetAsync()
    {
        var categories = await _context.Categories.ToListAsync();
        if (categories == null) return NotFound();

        return Ok(categories);
    }

    [HttpGet("v1/categorias/{id:int}")]
    [HttpGet("v1/categories/{id:int}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
    {
        var category = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
        if (category == null) return NotFound();
        return Ok(category); ;
    }

    [HttpPost("v1/categorias")]
    [HttpPost("v1/categories")]
    public async Task<IActionResult> PostAsync([FromBody] Category model)
    {
        await _context.Categories.AddAsync(model);
        await _context.SaveChangesAsync();

        return Created($"v1/categories/{model.Id}", model);
    }

    [HttpPut("v1/categorias/{id:int}")]
    [HttpPut("v1/categories/{id:int}")]
    public async Task<IActionResult> PutAsync([FromBody] Category model, [FromRoute] int id)
    {
        var categories = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);

        if (categories == null) return NotFound();
        categories.Name = model.Name;
        categories.Slug = model.Slug;

        _context.Categories.Update(categories);
        await _context.SaveChangesAsync();

        return Ok(model);
    }

    [HttpDelete("v1/categorias/{id:int}")]
    [HttpDelete("v1/categories/{id:int}")]
    public async Task<IActionResult> DeteleAsync([FromRoute] int id)
    {
        var category = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);

        if (category == null) return NotFound();

        _context.Categories.Remove(category);
        await _context.SaveChangesAsync();

        return Ok(category);
    }
}
