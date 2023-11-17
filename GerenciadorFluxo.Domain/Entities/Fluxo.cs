namespace GerenciadorFluxo.Domain.Entities
{
    public class Fluxo
    {
        public Fluxo(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }

        protected Fluxo()
        {
        }

        public int Id { get; private set; }

        public string Nome { get; private set; }

        public string Descricao { get; private set; }

        public ICollection<Processo> Processos { get; set; }
    }
}