using AppLivrosMobile.MVVM.Models;
using AppLivrosMobile.MVVM.Views;
using AppLivrosMobile.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
using System.Windows.Input;

namespace AppLivrosMobile.MVVM.ViewModels;

public partial class HomeViewModel : ObservableObject
{
    private readonly CategoryService _categoryService;
    private readonly BookService _bookService;
    private readonly INavigationService _navigationService;

    [ObservableProperty]
    Category _selectedCategory;
    [ObservableProperty]
    Book _selectedBook;

    [ObservableProperty]
    bool _IsBusy;

    [ObservableProperty]
    IEnumerable<Category> _categories;
    [ObservableProperty]
    IEnumerable<Book> _books;

   
    public HomeViewModel(CategoryService categoryService, BookService bookService, INavigationService navigation)
    {
        IsBusy = true;
        _categoryService = categoryService;
        _bookService = bookService;
        _navigationService = navigation;
        PropertyChanged += BookPageViewModelPropertyChanged;

    }

    private async void BookPageViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        try
        {
            if (e.PropertyName == nameof(SelectedCategory))
            {
                var uri = $"{nameof(BookCategoryIdPage)}?id={SelectedCategory.Id}";
                await _navigationService.GoToAsync(uri);
            }

            if (e.PropertyName == nameof(SelectedBook))
            {
                var uri = $"{nameof(BookIdPage)}?id={SelectedBook.Id}";
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
        try
        {
            Categories = await _categoryService.GetMainCategoriesAsync();
            Books = await _bookService.GetMainBookAsync();
            await Task.Delay(3000);
        }
        finally
        {
            IsBusy = false;
        }
    }
}
