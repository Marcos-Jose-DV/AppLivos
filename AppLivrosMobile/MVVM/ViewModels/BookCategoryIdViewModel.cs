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
    public async Task InitializeAsync(int id)
    {
        try
        {
            var list = await _bookService.GetMainBookAsync();
            BookId = list.Where(book => book.CategoryId == id).ToList();
        }
        catch (Exception ex)
        {
            ex.ToString();
        }
        
    }
    public async void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        var num = int.Parse(query["id"].ToString());
        await InitializeAsync(num);
    }
}
