using AppLivrosMobile.Constants;
using AppLivrosMobile.MVVM.Models;
using System.Net.Http;
using System.Text.Json;

namespace AppLivrosMobile.Services;

public class BookService
{
    private readonly HttpClient _client;
    private IEnumerable<Book>? _books;

    public BookService(HttpClient client)
        => _client = client;

    public async ValueTask<IEnumerable<Book>> GetBooksAsync()
    {
        if (_books is null)
        {
            var response = await _client.GetAsync($"{AppConstants.HttpClientName}/v1/livros");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(content))
                    _books = JsonSerializer.Deserialize<IEnumerable<Book>>(content, new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true,
                    });
            }
            else
            {
                return Enumerable.Empty<Book>();
            }
        }

        return _books;
    }

    public async ValueTask<IEnumerable<Book>> GetMainBookAsync()
        => await GetBooksAsync();
}
