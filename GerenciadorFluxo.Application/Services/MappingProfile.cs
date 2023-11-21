using AutoMapper;
using GerenciadorFluxo.Application.Dtos;
using GerenciadorFluxo.Domain.Entities;

namespace GerenciadorFluxo.Application.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Fluxo, FluxoDto>().ReverseMap();
            CreateMap<Processo, ProcessoDto>().ReverseMap();
        }
    }
}