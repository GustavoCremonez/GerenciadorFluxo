namespace GerenciadorFluxo.Domain.Entities
{
    public sealed class Fluxo
    {
        public Fluxo(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }

        public Fluxo() { }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public List<Processo> Processos { get; set; }
    }
}