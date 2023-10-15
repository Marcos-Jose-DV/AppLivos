using AppLivrosMobile.MVVM.ViewModels;

namespace AppLivrosMobile.MVVM.Views;

public partial class BookPage : ContentPage
{
    private readonly BookViewModel _viewModel;
    public BookPage(BookViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;

    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.InitializeAsync();
    }
}