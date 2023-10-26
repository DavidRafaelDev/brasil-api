using crud.Models;

namespace crud.Repository;

    public interface IAeroportoRepository
    {
        Task<bool> adicionaAeroporto(AeroportoDto request);
}
