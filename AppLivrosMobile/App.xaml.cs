using AppLivrosMobile.MVVM.Views;

namespace AppLivrosMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}