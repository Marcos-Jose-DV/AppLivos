using AppLivrosMobile.MVVM.ViewModels;

namespace AppLivrosMobile.MVVM.Views;

public partial class BookPage : ContentPage
{
	public BookPage(BookViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}