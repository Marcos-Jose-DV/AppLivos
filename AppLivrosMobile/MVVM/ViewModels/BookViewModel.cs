
using AppLivrosMobile.MVVM.Models;
using AppLivrosMobile.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace AppLivrosMobile.MVVM.ViewModels;

public partial class BookViewModel : ObservableObject
{
    private readonly BookService _bookService;

    public BookViewModel(BookService bookService)
    {
        _bookService = bookService;

    }
    public ObservableCollection<Book> Books { get; set; } = new();
    public async Task InitializeAsync()
    {
        foreach (var book in await _bookService.GetMainBookAsync("livros",""))
        {
            Books.Add(book);
        }
    }
    [RelayCommand]
    private async Task Att()
    {
        await InitializeAsync();
    }
}
