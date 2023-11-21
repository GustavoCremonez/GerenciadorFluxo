namespace GerenciadorFluxo.Domain.Entities
{
    public sealed class Anotacao
    {
        public Anotacao() { }

        public Anotacao(int id, int idProcesso, string descricao)
        {
            Id = id;
            IdProcesso = idProcesso;
            Descricao = descricao;
        }

        public int Id { get; private set; }

        public int IdProcesso { get; private set; }

        public Processo Processo { get; private set; }

        public string Descricao { get; private set; }
    }
}