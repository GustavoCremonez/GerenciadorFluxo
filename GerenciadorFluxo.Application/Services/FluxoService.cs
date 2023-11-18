using GerenciadorFluxo.Application.Contracts;
using GerenciadorFluxo.Domain.Contracts;
using GerenciadorFluxo.Domain.Entities;

namespace GerenciadorFluxo.Application.Services
{
    public class FluxoService : IFluxoService
    {
        private readonly IFluxoRepository _fluxoRepository;

        public FluxoService(IFluxoRepository fluxoRepository)
        {
            _fluxoRepository = fluxoRepository;
        }

        public Task<ICollection<Fluxo>> GetAllAsync()
        {
            return _fluxoRepository.GetAllAsync();
        }

        public Task<Fluxo> GetByIdAsync(int id)
        {
            return _fluxoRepository.GetByIdAsync(id);
        }

        public async Task<int> CreateAsync(Fluxo entity)
        {
            return await _fluxoRepository.CreateAsync(entity);
        }

        public async Task<int> UpdateAsync(Fluxo entity)
        {
            return await _fluxoRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _fluxoRepository.DeleteAsync(id);
        }
    }
}