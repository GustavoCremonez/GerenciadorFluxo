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

        public Processo() { }

        public int Id { get; private set; }

        public int IdFluxo { get; private set; }

        public Fluxo Fluxo { get; private set; }

        public int? IdProcessoSuperior { get; private set; }

        public string Nome { get; private set; }

        public TipoProcesso TipoProcesso { get; private set; }

        public List<Anotacao> Anotacoes { get; private set; }
    }
}