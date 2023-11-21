using GerenciadorFluxo.Application.Dtos;
using GerenciadorFluxo.Domain.Entities;

namespace GerenciadorFluxo.Application.Contracts
{
    public interface IFluxoService
    {
        Task<FluxoDto> GetByIdAsync(int id);

        Task<List<FluxoDto>> GetAllAsync();

        Task CreateAsync(FluxoDto entity);

        Task UpdateAsync(FluxoDto entity);

        Task DeleteAsync(int id);
    }
}