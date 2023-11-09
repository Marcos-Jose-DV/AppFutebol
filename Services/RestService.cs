

using AppFutebol.Models;
using System.Text.Json;

namespace AppFutebol.Services;

public class RestService : IRestService
{
    HttpClient _client;
    JsonSerializerOptions _jsonOptions;

    public RestService()
    {
        _client = new HttpClient();
        _jsonOptions = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
        };
    }

    public async Task<Matchs[]> GetMatchData(string entity)
    {
        Matchs[] data = null;
        try
        {
            var response = await _client.GetAsync(entity);
            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                data = await JsonSerializer.DeserializeAsync<Matchs[]>(responseStream, _jsonOptions);
            }
        }
        catch (Exception ex)
        {
            ex.ToString();
        }

        return data;
    }
}