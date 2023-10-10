

using AppLivrosMobile.MVVM.Models;
using AppLivrosMobile.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace AppLivrosMobile.MVVM.ViewModels;

public partial class BookViewModel : ObservableObject
{
    private readonly IBookService _bookService;

    [ObservableProperty]
    Book[] _books;
    public BookViewModel(IBookService bookService)
    {

        _bookService = bookService;
        GetAllCategory();


    }
    private async void GetAllCategory()
    {
        try
        {

            Book[] books = await _bookService.GetAllBooks("http://10.0.2.2:5068/v1/livros");

            if (books == null)
            {
                return;
            }

            Books = books;

        }
        catch (Exception ex)
        {
            ex.ToString();
        }
    }
}
