using AppLivrosMobile.MVVM.ViewModels;

namespace AppLivrosMobile.MVVM.Views;

public partial class BookIdPage : ContentPage
{
	public BookIdPage(BookIdViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}