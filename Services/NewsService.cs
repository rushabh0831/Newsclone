using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class NewsService
{
    private readonly HttpClient _httpClient;
    private const string BaseUrl = "https://newsapi.org/v2/top-headlines?country=us&apiKey=";
    private const string ApiKey = "b1ba9ca2fd7f4af99819e17f84f7e243";

    public NewsService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<NewsResponse> GetTopHeadlinesAsync()
    {
        try
        {
            var request = new HttpRequestMessage(HttpMethod.Get, BaseUrl + ApiKey);
            request.Headers.Add("User-Agent", "MyNewsApp/1.0"); // Required User-Agent header

            var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                string error = await response.Content.ReadAsStringAsync();
                throw new Exception($"API Error: {response.StatusCode} - {error}");
            }

            string jsonResponse = await response.Content.ReadAsStringAsync();
            Console.WriteLine("API Response: " + jsonResponse);

            var news = JsonSerializer.Deserialize<NewsResponse>(jsonResponse, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return news ?? throw new Exception("Failed to deserialize response.");
        }
        catch (HttpRequestException httpEx)
        {
            Console.WriteLine($"HTTP Request failed: {httpEx.Message}");
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
            throw;
        }
    }
    private const string BaseUrl1 = "https://newsapi.org/v2/top-headlines?country=us&category=business&apiKey=";
    private const string ApiKey1 = "b1ba9ca2fd7f4af99819e17f84f7e243";
    public async Task<NewsResponse> GetBussHeadlinesAsync()
    {
        try
        {
            var request = new HttpRequestMessage(HttpMethod.Get, BaseUrl1 + ApiKey1);
            request.Headers.Add("User-Agent", "MyNewsApp/1.0"); // Required User-Agent header

            var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                string error = await response.Content.ReadAsStringAsync();
                throw new Exception($"API Error: {response.StatusCode} - {error}");
            }

            string jsonResponse = await response.Content.ReadAsStringAsync();
            Console.WriteLine("API Response: " + jsonResponse);

            var news = JsonSerializer.Deserialize<NewsResponse>(jsonResponse, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return news ?? throw new Exception("Failed to deserialize response.");
        }
        catch (HttpRequestException httpEx)
        {
            Console.WriteLine($"HTTP Request failed: {httpEx.Message}");
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
            throw;
        }
    }
    private const string BaseUr2 = "https://newsapi.org/v2/top-headlines?sources=techcrunch&apiKey=";
    private const string ApiKey2 = "b1ba9ca2fd7f4af99819e17f84f7e243";
    public async Task<NewsResponse> GetTechHeadlinesAsync()
    {
        try
        {
            var request = new HttpRequestMessage(HttpMethod.Get, BaseUr2 + ApiKey2);
            request.Headers.Add("User-Agent", "MyNewsApp/1.0"); // Required User-Agent header

            var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                string error = await response.Content.ReadAsStringAsync();
                throw new Exception($"API Error: {response.StatusCode} - {error}");
            }

            string jsonResponse = await response.Content.ReadAsStringAsync();
            Console.WriteLine("API Response: " + jsonResponse);

            var news = JsonSerializer.Deserialize<NewsResponse>(jsonResponse, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return news ?? throw new Exception("Failed to deserialize response.");
        }
        catch (HttpRequestException httpEx)
        {
            Console.WriteLine($"HTTP Request failed: {httpEx.Message}");
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
            throw;
        }
    }
}


