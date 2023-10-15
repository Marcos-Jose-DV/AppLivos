using AppLivrosMobile.Constants;
using AppLivrosMobile.MVVM.Models;
using System.Text.Json;

namespace AppLivrosMobile.Services;

public class CategoryService 
{
    private IEnumerable<Category>? _categories;

    private readonly HttpClient _client;

    public CategoryService(HttpClient client)    
        => _client = client;
    
    public async ValueTask<IEnumerable<Category>> GetCategoriesAsync()
    {
        if (_categories is null)
        {
            var response = await _client.GetAsync($"{AppConstants.HttpClientName}/v1/categorias");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(content))
                    _categories = JsonSerializer.Deserialize<IEnumerable<Category>>(content, new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true,
                    });
            }
            else
            {
                return Enumerable.Empty<Category>();
            }
        }
        return _categories;
    }
    public async ValueTask<IEnumerable<Category>> GetMainCategoriesAsync()
        => await GetCategoriesAsync()
;
}
