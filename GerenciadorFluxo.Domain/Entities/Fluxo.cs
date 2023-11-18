namespace GerenciadorFluxo.Domain.Entities
{
    public class Fluxo
    {
        public Fluxo(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Processos = new List<Processo>();
        }

        protected Fluxo()
        {
        }

        public int Id { get; private set; }

        public string Nome { get; private set; }

        public string Descricao { get; private set; }

        public List<Processo>? Processos { get; private set; }
    }
}