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
            _imageUrl = $"https://firebasestorage.googleapis.com/v0/b/applivros-ea1a0.appspot.com/o/Categorias%2F{value}?alt=media&token=aaf72a59-dc3f-4adc-af41-fd512b2b8f60&_gl=1*1fdsx21*_ga*MTI3MDEwMjkyOC4xNjk2MDEyOTk2*_ga_CW55HF8NVT*MTY5NzQ2NTgzNy40LjEuMTY5NzQ2NjE2NC42MC4wLjA.";
        }
    }
    //public string ImageUrl { get; set; }

}
