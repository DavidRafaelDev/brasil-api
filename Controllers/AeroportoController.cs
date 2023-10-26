using crud.Models;
using crud.Repository;
using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers
{
    [ApiController]
    [Route("aeroporto")]
    public class AeroportoController : ControllerBase
    {   
        private readonly IAeroportoRepository _repository;
        private readonly IBrasilApiRepository _brasilApiRepository;
        public AeroportoController(IAeroportoRepository repository, IBrasilApiRepository brasilApiRepository){
            _repository = repository;  
            _brasilApiRepository = brasilApiRepository;                                                                                                                                                                                                                                                             
        }
        
       [HttpGet("{request}")]
        public async Task<IActionResult> GetClimaAeroporto(string request)
        {
            var response = await _brasilApiRepository.buscarClimaAeroporto(request);

            if (response != null)
            {
                await _repository.adicionaAeroporto(response);
                return Ok(response);
            }
            return Ok("Erro ao Buscar dados do aeroporto");
        }
    }
}
