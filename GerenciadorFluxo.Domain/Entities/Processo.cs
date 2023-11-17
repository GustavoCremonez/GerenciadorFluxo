using GerenciadorFluxo.Domain.Contracts;

namespace GerenciadorFluxo.Domain.Entities
{
    public class Processo
    {
        public Processo(int id, int? idProcessoSuperior, int idFluxo, string nome, TipoProcesso tipoProcesso)
        {
            Id = id;
            IdProcessoSuperior = idProcessoSuperior;
            IdFluxo = idFluxo;
            Nome = nome;
            TipoProcesso = tipoProcesso;
        }

        protected Processo()
        {
        }

        public int Id { get; private set; }

        public int? IdProcessoSuperior { get; set; }

        public int IdFluxo { get; set; }

        public Fluxo Fluxo { get; set; }

        public string Nome { get; private set; }

        public TipoProcesso TipoProcesso { get; set; }

        public ICollection<Anotacao> Anotacoes { get; private set; }
    }
}