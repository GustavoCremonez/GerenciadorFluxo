using AutoMapper;
using GerenciadorFluxo.Application.Contracts;
using GerenciadorFluxo.Application.Dtos;
using GerenciadorFluxo.Domain.Contracts;
using GerenciadorFluxo.Domain.Entities;

namespace GerenciadorFluxo.Application.Services
{
    public class FluxoService : IFluxoService
    {
        private readonly IFluxoRepository _fluxoRepository;
        private readonly IMapper _mapper;

        public FluxoService(IFluxoRepository fluxoRepository, IMapper mapper)
        {
            _fluxoRepository = fluxoRepository;
            _mapper = mapper;
        }

        public async Task<List<FluxoDto>> GetAllAsync()
        {
            List<Fluxo> fluxos = await _fluxoRepository.GetAllAsync();
            return _mapper.Map<List<FluxoDto>>(fluxos);
        }

        public async Task<FluxoDto> GetByIdAsync(int id)
        {
            Fluxo fluxo = await _fluxoRepository.GetByIdAsync(id);
            return _mapper.Map<FluxoDto>(fluxo);
        }

        public async Task CreateAsync(FluxoDto dto)
        {
            Fluxo entity = _mapper.Map<Fluxo>(dto);
            await _fluxoRepository.CreateAsync(entity);
        }

        public async Task UpdateAsync(FluxoDto dto)
        {
            Fluxo entity = _mapper.Map<Fluxo>(dto);
            await _fluxoRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _fluxoRepository.DeleteAsync(id);
        }
    }
}