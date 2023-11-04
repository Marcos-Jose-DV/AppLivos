using AppLivrosMobile.Constants;
using AppLivrosMobile.MVVM.Models;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace AppLivrosMobile.Services;

public class BookService
{
    private readonly HttpClient _client;
    private readonly JsonSerializerOptions _serializerOptions;

    private IEnumerable<Book>? _books;

    public BookService(HttpClient client)
    {
         _client = client;
        _serializerOptions = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
        };
    }
       

    public async ValueTask<IEnumerable<Book>> GetBooksAsync(string query, string param)
    {
        var response = await _client.GetAsync($"{AppConstants.HttpClientName}/v1/{query}/{param}");
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            if (!string.IsNullOrEmpty(content))
                _books = JsonSerializer.Deserialize<IEnumerable<Book>>(content, _serializerOptions);
        }
        else
        {
            return Enumerable.Empty<Book>();
        }

        return _books;
    }

    public async ValueTask<IEnumerable<Book>> GetMainBookAsync(string query, string param)
        => await GetBooksAsync(query, param);

    public async Task PutForiteAsync(Book book)
    {
        
        var url = $"{AppConstants.HttpClientName}/livro/{book.Id}";
        string jsonResponse = JsonSerializer.Serialize(book, _serializerOptions);

        StringContent content = new StringContent(jsonResponse, Encoding.UTF8, "application/json");

        var response = await _client.PutAsync(url, content);
      
    }
}
