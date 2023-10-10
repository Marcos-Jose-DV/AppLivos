using AppLivrosMobile.MVVM.ViewModels;

namespace AppLivrosMobile.MVVM.Views;

public partial class HomePage : ContentPage
{
	public HomePage(HomeViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;

    }
}