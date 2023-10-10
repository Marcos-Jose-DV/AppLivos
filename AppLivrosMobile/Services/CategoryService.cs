using AppLivrosMobile.MVVM.Models;
using System.Text.Json;
using static Android.App.DownloadManager;

namespace AppLivrosMobile.Services;

public class CategoryService : ICategoryService
{
    private readonly HttpClient _client;
    private readonly JsonSerializerOptions _jsonOptions;

    public CategoryService()
    {
        _client = new HttpClient();
        _jsonOptions = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
        };
    }

    public async Task<Category[]> GetAllCategory(string query)
    {
        Category[] category = null;
        try
        {
            var response = await _client.GetAsync(query);
            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                category = await JsonSerializer.DeserializeAsync<Category[]>(responseStream, _jsonOptions);
            }
        }
        catch (Exception ex)
        {
            ex.ToString();
        }

        return category;
    }
}
