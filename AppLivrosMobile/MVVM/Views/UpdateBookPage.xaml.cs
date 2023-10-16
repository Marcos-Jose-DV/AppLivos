using AppLivrosMobile.MVVM.ViewModels;

namespace AppLivrosMobile.MVVM.Views;

public partial class UpdateBookPage : ContentPage
{
	public UpdateBookPage(UpdateBookViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}