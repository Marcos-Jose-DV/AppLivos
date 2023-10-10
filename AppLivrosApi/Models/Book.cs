namespace AppLivrosApi.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public string ImageUrl { get; set; }
    public int PageTotal { get; set; }
    public bool Check { get; set; }
    public int PageIndex { get; set; } = 0;

    public int CategoryId { get; set; }
}
