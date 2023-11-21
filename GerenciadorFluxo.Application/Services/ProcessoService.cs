using AutoMapper;
using GerenciadorFluxo.Application.Contracts;
using GerenciadorFluxo.Application.Dtos;
using GerenciadorFluxo.Domain.Contracts;
using GerenciadorFluxo.Domain.Entities;

namespace GerenciadorFluxo.Application.Services
{
    public class ProcessoService : IProcessoService
    {
        private readonly IProcessoRepository _processoRepository;
        private readonly IMapper _mapper;

        public ProcessoService(IProcessoRepository processoRepository, IMapper mapper)
        {
            _processoRepository = processoRepository;
            _mapper = mapper;
        }

        public async Task<ProcessoDto> GetAsync(int id)
        {
            Processo processo = await _processoRepository.GetAsync(id);
            return _mapper.Map<ProcessoDto>(processo);
        }

        public async Task<List<ProcessoDto>> GetByFluxoAsync(int idFluxo)
        {
            List<Processo> processos = await _processoRepository.GetByFluxoAsync(idFluxo);
            return _mapper.Map<List<ProcessoDto>>(processos);
        }

        public async Task CreateAsync(ProcessoDto dto)
        {
            Processo processo = _mapper.Map<Processo>(dto);
            await _processoRepository.CreateAsync(processo);
        }

        public async Task UpdateAsync(ProcessoDto dto)
        {
            Processo processo = _mapper.Map<Processo>(dto);
            await _processoRepository.UpdateAsync(processo);
        }

        public async Task DeleteAsync(int id)
        {
            await _processoRepository.DeleteAsync(id);
        }
    }
}