using AppLivrosMobile.MVVM.Models;
using AppLivrosMobile.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace AppLivrosMobile.MVVM.ViewModels;

public partial class BookCategoryIdViewModel : ObservableObject, IQueryAttributable
{
    private readonly BookService _bookService;

    [ObservableProperty]
    IEnumerable<Book> _bookId;

    public BookCategoryIdViewModel(BookService bookService)
    {
        _bookService = bookService;
    }
    public async Task InitializeAsync(string id)
    {
        try
        {
            BookId = await _bookService.GetMainBookAsync($"livros", id);
        }
        catch (Exception ex)
        {
            ex.ToString();
        }
        
    }
    public async void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        var num = (query["id"].ToString());
        await InitializeAsync(num);
    }
}
