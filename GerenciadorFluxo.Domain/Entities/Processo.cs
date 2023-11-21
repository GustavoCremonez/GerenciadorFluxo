using GerenciadorFluxo.Domain.Contracts;

namespace GerenciadorFluxo.Domain.Entities
{
    public sealed class Processo
    {
        public Processo(int idFluxo, int? idProcessoSuperior, string nome, TipoProcesso tipoProcesso)
        {
            IdFluxo = idFluxo;
            IdProcessoSuperior = idProcessoSuperior;
            Nome = nome;
            TipoProcesso = tipoProcesso;
        }

        public Processo()
        { }

        public int Id { get; set; }

        public int IdFluxo { get; set; }

        public Fluxo Fluxo { get; set; }

        public int? IdProcessoSuperior { get; set; }

        public string Nome { get; set; }

        public TipoProcesso TipoProcesso { get; set; }

        public Processo ProcessoSuperior { get; set; }

        public List<Processo> SubProcessos { get; set; }
    }
}