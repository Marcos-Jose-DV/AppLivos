using AppLivrosMobile.MVVM.Views;
using AppLivrosMobile.Services;

namespace AppLivrosMobile
{
    public partial class App : Application
    {
        public App(BookPage page)
        {
            InitializeComponent();
           

            MainPage = page;
        }
    }
}