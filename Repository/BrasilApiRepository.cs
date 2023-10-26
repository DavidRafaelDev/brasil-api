using Newtonsoft.Json;
using crud.Models;
using crud.Repository;

public class BrasilApiRepository : IBrasilApiRepository
{
    public async Task<AeroportoDto> buscarClimaAeroporto(string request)
    {
        var client = new HttpClient();
        var url = $"https://brasilapi.com.br/api/cptec/v1/clima/aeroporto/{request.Id}";
        var response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            var responseContent = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<AeroportoDto>(responseContent);
            return result;
        }
        else
        {
            throw new Exception($"Erro na requisição HTTP: {response.StatusCode}");
        }
    }

    public Task<AeroportoDto> buscarClimaCidade(string request)
    {
        throw new NotImplementedException();
    }
}
