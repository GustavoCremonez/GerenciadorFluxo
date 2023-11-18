using GerenciadorFluxo.Domain.Entities;

namespace GerenciadorFluxo.Application.Contracts
{
    public interface IFluxoService
    {
        Task<Fluxo> GetByIdAsync(int id);

        Task<ICollection<Fluxo>> GetAllAsync();

        Task<int> CreateAsync(Fluxo entity);

        Task<int> UpdateAsync(Fluxo entity);

        Task DeleteAsync(int id);
    }
}