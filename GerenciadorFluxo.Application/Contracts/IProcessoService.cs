using GerenciadorFluxo.Application.Dtos;
using GerenciadorFluxo.Domain.Entities;

namespace GerenciadorFluxo.Application.Contracts
{
    public interface IProcessoService
    {
        Task<ProcessoDto> GetAsync(int id);

        Task<List<ProcessoDto>> GetByFluxoAsync(int idFluxo);

        Task CreateAsync(ProcessoDto entity);

        Task UpdateAsync(ProcessoDto entity);

        Task DeleteAsync(int id);
    }
}