using GerenciadorFluxo.Domain.Entities;

namespace GerenciadorFluxo.Application.Dtos
{
    public class FluxoDto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public List<Processo>? Processos { get; set; }
    }
}