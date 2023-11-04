
using AppLivrosMobile.MVVM.Models;
using AppLivrosMobile.MVVM.Views;
using AppLivrosMobile.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace AppLivrosMobile.MVVM.ViewModels;

public partial class BookViewModel : ObservableObject
{
    private readonly BookService _bookService;
    private readonly INavigationService _navigationService;

    [ObservableProperty]
    IEnumerable<Book> _books;
    [ObservableProperty]
    Book _selectBook;

    public BookViewModel(BookService bookService, INavigationService navigationService)
    {
        _bookService = bookService;
        _navigationService = navigationService;
        PropertyChanged += BookIdPageViewModelPropertyChanged;
    }

    private async void BookIdPageViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        try
        {
          
            if (e.PropertyName == nameof(SelectBook))
            {
                var uri = $"{nameof(BookIdPage)}?id={SelectBook.Id}";
                await _navigationService.GoToAsync(uri);
            }
            return;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message} - {ex.StackTrace}");
            return;
        };
    }

    public async Task InitializeAsync()
    {
        Books = await _bookService.GetMainBookAsync("livros", "todos");
      
    }
   
    [RelayCommand]
    private async Task Att()
    {
        await InitializeAsync();
    }
}
