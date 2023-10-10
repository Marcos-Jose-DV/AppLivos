using AppLivrosMobile.MVVM.Models;
using AppLivrosMobile.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using IntelliJ.Lang.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLivrosMobile.MVVM.ViewModels;

public partial class HomeViewModel : ObservableObject
{
    private readonly ICategoryService _categoryService;

    [ObservableProperty]
    Category[] _categories;
    public HomeViewModel(ICategoryService categoryService)
    {

        _categoryService = categoryService;
        GetAllCategory();


    }
    private async void GetAllCategory()
    {
        try
        {
            
            Category[] categories = await _categoryService.GetAllCategory("http://10.0.2.2:5068/v1/categorias");

            if (categories == null)
            {
                return;
            }

            Categories = categories;
          
        }
        catch (Exception ex)
        {
            ex.ToString();
        }
    }
}
