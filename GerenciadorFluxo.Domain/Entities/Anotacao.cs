namespace GerenciadorFluxo.Domain.Entities
{
    public class Anotacao
    {
        public Anotacao(int id, int idProcesso, string descricao)
        {
            Id = id;
            IdProcesso = idProcesso;
            Descricao = descricao;
        }

        protected Anotacao()
        {
        }

        public int Id { get; private set; }

        public int IdProcesso { get; set; }

        public Processo Processo { get; set; }

        public string Descricao { get; private set; }
    }
}