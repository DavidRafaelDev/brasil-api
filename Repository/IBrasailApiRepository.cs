using crud.Models;

namespace crud.Repository;

    public interface IBrasilApiRepository
    {
        Task<AeroportoDto> buscarClimaAeroporto(string request);
        Task<AeroportoDto> buscarClimaCidade(string request);
    }
