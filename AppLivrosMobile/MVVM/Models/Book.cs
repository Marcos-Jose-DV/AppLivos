using AppLivrosMobile.MVVM.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace AppLivrosMobile.MVVM.Models;

public class Book 
{
    public Book(int id, string title, string description, string author, string imageUrl, int pageTotal, bool check, int categoryId, int userId, bool favorite, string favoriteImage)
    {
        Id = id;
        Title = title;
        Description = description;
        Author = author;
        ImageUrl = imageUrl;
        PageTotal = pageTotal;
        Check = check;
        CategoryId = categoryId;
        UserId = userId;
        Favorite = favorite;
        FavoriteImage = favoriteImage;
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
            _imageUrl = $"https://firebasestorage.googleapis.com/v0/b/applivros-ea1a0.appspot.com/o/Books%2F{value}?alt=media&token=a393ffdd-4ac8-4bd0-b8ca-40dd9fc3dba1&_gl=1*1d5u7jy*_ga*MTI3MDEwMjkyOC4xNjk2MDEyOTk2*_ga_CW55HF8NVT*MTY5NzQ4MjE3MC41LjEuMTY5NzQ4MjUwNS40My4wLjA.";
        }
    }

    public int PageTotal { get; set; }
    public bool Check { get; set; }

    public bool Favorite { get; set; }

    private string _favoriteImage;
    public string FavoriteImage
    {
        get => _favoriteImage;
        set
        {
            if (!this.Favorite)
            {
                _favoriteImage = "https://firebasestorage.googleapis.com/v0/b/applivros-ea1a0.appspot.com/o/Books%2Fcoracao_black.png?alt=media&token=645f6e0f-2a93-4671-8d85-a01016102945&_gl=1*3gmwe1*_ga*NzE4OTM5NjkwLjE2OTcxNTQ1NDU.*_ga_CW55HF8NVT*MTY5ODExODI0Ni4xMy4wLjE2OTgxMTgyNDYuNjAuMC4w";
            }
            else
            {
                _favoriteImage = "https://firebasestorage.googleapis.com/v0/b/applivros-ea1a0.appspot.com/o/Books%2Fcoracao_red.png?alt=media&token=0e8f7a25-c176-4884-acad-ce3b2eed4cd3&_gl=1*1jsvuah*_ga*NzE4OTM5NjkwLjE2OTcxNTQ1NDU.*_ga_CW55HF8NVT*MTY5ODExODI0Ni4xMy4xLjE2OTgxMTgzNjUuNDQuMC4w";
            }
        }
    }

    public int CategoryId { get; set; }
    public int UserId { get; set; }
}


