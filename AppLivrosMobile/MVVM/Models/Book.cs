using AppLivrosMobile.MVVM.Views;
using System.Windows.Input;

namespace AppLivrosMobile.MVVM.Models;

public class Book
{
    public Book(int id, string title, string description, string author, string imageUrl, int pageTotal, bool check, int pageIndex, int categoryId, int userId)
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
        UserId = userId;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    //public string ImageUrl { get; set; }

    private string _imageUrl;
    public string ImageUrl
    {
        get => _imageUrl;
        set
        {
            _imageUrl = $"https://firebasestorage.googleapis.com/v0/b/applivros-ea1a0.appspot.com/o/Books%2F{value}?alt=media&token=a393ffdd-4ac8-4bd0-b8ca-40dd9fc3dba1&_gl=1*1d5u7jy*_ga*MTI3MDEwMjkyOC4xNjk2MDEyOTk2*_ga_CW55HF8NVT*MTY5NzQ4MjE3MC41LjEuMTY5NzQ4MjUwNS40My4wLjA.";
        }
    }

    public int PageTotal { get; set; }
    public bool Check { get; set; }
    public int PageIndex { get; set; }
    public int CategoryId { get; set; }
    public int UserId { get; set; }
}


