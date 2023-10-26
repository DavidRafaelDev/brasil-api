using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers
{
    [ApiController]
    [Route("aeroporto")]
    public class AeroportoController : ControllerBase
    {
        
        [HttpGet("aeroporto/{aeroporto}")]
        public async Task<IActionResult> GetClimaAeroporto(string aeroporto)
        {
            var client = new HttpClient();
            var url = $"https://brasilapi.com.br/api/cptec/v1/clima/aeroporto/{aeroporto}";
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
