using AppLivrosMobile.MVVM.ViewModels;

namespace AppLivrosMobile.MVVM.Views;

public partial class BookCategoryIdPage : ContentPage
{
	public BookCategoryIdPage(BookCategoryIdViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}