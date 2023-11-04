namespace AppLivrosApi.Models;

public class Book
{


    public Book(int id, string title, string description, string author, string imageUrl, int pageTotal, bool check, int categoryId)
    {
        Id = id;
        Title = title;
        Description = description;
        Author = author;
        ImageUrl = imageUrl;
        PageTotal = pageTotal;
        Check = check;
        CategoryId = categoryId;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public string ImageUrl { get; set; }
    public bool Favorite { get; set; }
    public int PageTotal { get; set; }
    public bool Check { get; set; }
    public DateTime DateCreate { get; set; }
    public int CategoryId { get; set; }
}
