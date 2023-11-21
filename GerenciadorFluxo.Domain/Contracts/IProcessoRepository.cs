using GerenciadorFluxo.Domain.Entities;

namespace GerenciadorFluxo.Domain.Contracts
{
    public interface IProcessoRepository
    {
        Task<Processo> GetAsync(int id);

        Task<List<Processo>> GetByFluxoAsync(int idFluxo);

        Task CreateAsync(Processo entity);

        Task UpdateAsync(Processo entity);

        Task DeleteAsync(int id);
    }
}