using AppLivrosMobile.MVVM.Models;

namespace AppLivrosMobile.Services; 

public interface  ICategoryService 
{
    Task<Category[]>  GetAllCategory(string query);
}
