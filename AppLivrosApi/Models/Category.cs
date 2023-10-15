using Microsoft.Extensions.Hosting;

namespace AppLivrosApi.Models;

public class Category
{
    public Category(int id, string name, string slug, string imageUrl)
    {
        Id = id;
        Name = name;
        Slug = slug;
        ImageUrl = imageUrl;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
    public string ImageUrl { get; set; }
}
