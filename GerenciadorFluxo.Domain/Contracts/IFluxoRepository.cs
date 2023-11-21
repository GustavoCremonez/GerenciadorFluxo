using GerenciadorFluxo.Domain.Entities;

namespace GerenciadorFluxo.Domain.Contracts
{
    public interface IFluxoRepository
    {
        Task<Fluxo> GetByIdAsync(int id);

        Task<List<Fluxo>> GetAllAsync();

        Task CreateAsync(Fluxo entity);

        Task UpdateAsync(Fluxo entity);

        Task DeleteAsync(int id);
    }
}