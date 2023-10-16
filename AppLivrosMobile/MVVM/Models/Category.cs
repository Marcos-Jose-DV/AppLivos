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

    //private string _imageUrl;
    //public string ImageUrl
    //{
    //    get => _imageUrl;
    //    set
    //    {
    //        _imageUrl = $"https://raw.githubusercontent.com/Marcos-Jose-DV/AppLivos/main/AppLivrosApi/wwwroot/images/categorias/{value}";
    //    }
    //}
    public string ImageUrl { get; set; }

}
