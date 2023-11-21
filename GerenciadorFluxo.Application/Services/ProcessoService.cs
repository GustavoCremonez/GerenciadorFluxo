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
        private readonly IFluxoRepository _fluxoRepository;
        private readonly IMapper _mapper;

        public ProcessoService(IProcessoRepository processoRepository, IFluxoRepository fluxoRepository, IMapper mapper)
        {
            _processoRepository = processoRepository;
            _fluxoRepository = fluxoRepository;
            _mapper = mapper;
        }

        public async Task<ProcessoDto> GetAsync(int id)
        {
            Processo processo = await _processoRepository.GetAsync(id);
            return _mapper.Map<ProcessoDto>(processo);
        }

        public async Task<RetornoProcessosDto> GetByFluxoAsync(int idFluxo)
        {
            RetornoProcessosDto retorno = new();
            List<Processo> processos = await _processoRepository.GetByFluxoAsync(idFluxo);

            retorno.Processos = _mapper.Map<List<ProcessoDto>>(processos);

            Fluxo fluxo = await _fluxoRepository.GetByIdAsync(idFluxo);
            retorno.TituloFluxo = fluxo.Nome;

            return retorno;
        }

        public async Task CreateAsync(ProcessoDto dto)
        {
            Processo processo = _mapper.Map<Processo>(dto);
            await _processoRepository.CreateAsync(processo);
        }

        public async Task UpdateAsync(ProcessoDto dto)
        {
            Processo processo = await _processoRepository.GetAsync(dto.Id);

            processo.Nome = dto.Nome;
            processo.TipoProcesso = dto.TipoProcesso;

            await _processoRepository.UpdateAsync(processo);
        }

        public async Task DeleteAsync(int id)
        {
            await _processoRepository.DeleteAsync(id);
        }
    }
}