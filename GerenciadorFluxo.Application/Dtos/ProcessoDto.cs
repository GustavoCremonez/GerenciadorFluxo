using GerenciadorFluxo.Domain.Contracts;
using GerenciadorFluxo.Domain.Entities;

namespace GerenciadorFluxo.Application.Dtos
{
    public class ProcessoDto
    {
        public int Id { get; set; }

        public int IdFluxo { get; set; }

        public int? IdProcessoSuperior { get; set; }

        public string Nome { get; set; }

        public TipoProcesso TipoProcesso { get; set; }

        public List<ProcessoDto>? SubProcessos { get; set; }
    }
}