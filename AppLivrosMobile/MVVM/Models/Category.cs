namespace AppLivrosMobile.MVVM.Models;

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

    private string _imageUrl;
    public string ImageUrl
    {
        get => _imageUrl;
        set
        {
            _imageUrl = $"https://firebasestorage.googleapis.com/v0/b/applivros-ea1a0.appspot.com/o/{value}?alt=media&token=4c17d2d2-2e84-4ffb-9aa4-2a6b13b20d21&_gl=1*uvylmf*_ga*NzE4OTM5NjkwLjE2OTcxNTQ1NDU.*_ga_CW55HF8NVT*MTY5NzM5NzU0MS4yLjEuMTY5NzM5ODM0NS41Mi4wLjA.";
        }
    }
    //public string ImageUrl { get; set; }

}
