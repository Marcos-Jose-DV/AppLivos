using AppLivrosMobile.MVVM.Models;
using System.Text.Json;

namespace AppLivrosMobile.Services;

internal class BookService : IBookService
{
    private readonly HttpClient _client;
    private readonly JsonSerializerOptions _jsonOptions;

    public BookService()
    {
        _client = new HttpClient();
        _jsonOptions = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
        };
    }

    public async Task<Book[]> GetAllBooks(string query)
    {
        Book[] books = null;
        try
        {
            var response = await _client.GetAsync(query);
            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                books = await JsonSerializer.DeserializeAsync<Book[]>(responseStream, _jsonOptions);
            }
        }
        catch (Exception ex)
        {
            ex.ToString();
        }

        return books;
    }
}
