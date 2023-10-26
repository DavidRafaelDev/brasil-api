using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers
{
    [ApiController]
    [Route("cidade")]
    public class CidadeController : ControllerBase
    {
        [HttpGet("{cidade}")]
        public async Task<IActionResult> GetClimaCidade(string cidade)
        {
            var client = new HttpClient();
            var url = $"https://brasilapi.com.br/api/cptec/v1/clima/previsao/{cidade}";
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                return Ok(data);
            }
            else
            {
                return StatusCode((int)response.StatusCode, "Erro ao buscar dados do clima do aeroporto.");
            }
        }
    }
}
