namespace AppLivrosMobile.MVVM.Models;

public class Book
{
    public Book(int id, string title, string description, string author, string imageUrl, int pageTotal, bool check, int pageIndex, int categoryId)
    {
        Id = id;
        Title = title;
        Description = description;
        Author = author;
        ImageUrl = imageUrl;
        PageTotal = pageTotal;
        Check = check;
        PageIndex = pageIndex;
        CategoryId = categoryId;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }

    private string _imageUrl;
    public string ImageUrl
    {
        get => _imageUrl;
        set
        {
            _imageUrl = $"https://firebasestorage.googleapis.com/v0/b/applivros-ea1a0.appspot.com/o/{value}?alt=media&token=4c17d2d2-2e84-4ffb-9aa4-2a6b13b20d21&_gl=1*uvylmf*_ga*NzE4OTM5NjkwLjE2OTcxNTQ1NDU.*_ga_CW55HF8NVT*MTY5NzM5NzU0MS4yLjEuMTY5NzM5ODM0NS41Mi4wLjA.";
        }
    }
    public int PageTotal { get; set; }
    public bool Check { get; set; }
    public int PageIndex { get; set; }
    public int CategoryId { get; set; }
}


