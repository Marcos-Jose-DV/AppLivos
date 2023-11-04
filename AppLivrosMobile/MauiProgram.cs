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
                    fonts.AddFont("Roboto-Bold.ttf", "RobotoBold");
                    fonts.AddFont("Salsa-Regular.ttf", "Salsa");
                });

            CreatePage(builder);
            void CreatePage(MauiAppBuilder builder)
            {
                builder.Services.AddSingleton<HomePage>();
                builder.Services.AddSingleton<HomeViewModel>();
                builder.Services.AddSingleton<BookPage>();
                builder.Services.AddSingleton<BookViewModel>();
                builder.Services.AddSingleton<BookCategoryIdPage>();
                builder.Services.AddSingleton<BookCategoryIdViewModel>();
                builder.Services.AddSingleton<UpdateBookPage>();
                builder.Services.AddSingleton<UpdateBookViewModel>();
                builder.Services.AddSingleton<BookIdPage>();
                builder.Services.AddSingleton<BookIdViewModel>();
                builder.Services.AddScoped<CategoryService>();
                builder.Services.AddScoped<BookService>();
                builder.Services.AddScoped<HttpClient>();
                builder.Services.AddSingleton<INavigationService, NavigationService>();
            }

            RegisterForRoute<BookCategoryIdPage>();
            RegisterForRoute<UpdateBookPage>();
            RegisterForRoute<BookIdPage>();
            RegisterForRoute<BookPage>();

            static void RegisterForRoute<T>()
            {
                Routing.RegisterRoute(typeof(T).Name, typeof(T));
            }

            //Routing.RegisterRoute(typeof(BookCategoryIdPage).Name, typeof(BookCategoryIdPage));
            //Routing.RegisterRoute(typeof(UpdateBookPage).Name, typeof(UpdateBookPage));

#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}