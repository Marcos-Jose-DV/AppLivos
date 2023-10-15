using AppLivrosMobile.MVVM.Views;

namespace AppLivrosMobile.Services;

public interface INavigationService 
{
    Task GoToAsync(string uri);
    Task GoToAsync(string uri, IDictionary<string, object> parameters);
    Task PushAsync(BookPage bookPage);
}

