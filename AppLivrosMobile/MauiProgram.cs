using AppLivrosMobile.MVVM.ViewModels;
using AppLivrosMobile.MVVM.Views;
using AppLivrosMobile.Services;
using Microsoft.Extensions.Logging;

namespace AppLivrosMobile
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

           
            builder.Services.AddSingleton<HomePage>();
            builder.Services.AddSingleton<HomeViewModel>();
            builder.Services.AddSingleton<BookPage>();
            builder.Services.AddSingleton<BookViewModel>();
            builder.Services.AddSingleton<BookCategoryIdPage>();
            builder.Services.AddSingleton<BookCategoryIdViewModel>();
            builder.Services.AddScoped<CategoryService>();
            builder.Services.AddScoped<BookService>();
            builder.Services.AddScoped<HttpClient>();

            builder.Services.AddSingleton<INavigationService, NavigationService>();
            Routing.RegisterRoute(nameof(BookCategoryIdPage), typeof(BookCategoryIdPage));
            Routing.RegisterRoute(nameof(BookPage), typeof(BookPage));


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}