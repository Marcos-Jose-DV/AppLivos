using AppLivrosMobile.MVVM.Models;

namespace AppLivrosMobile.Services;

public interface IBookService
{
    Task<Book[]> GetAllBooks(string query);
}
