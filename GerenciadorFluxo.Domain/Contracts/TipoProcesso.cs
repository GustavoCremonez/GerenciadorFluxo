using System.ComponentModel;

namespace GerenciadorFluxo.Domain.Contracts
{
    public enum TipoProcesso : byte
    {
        [Description("Processo sistêmico")]
        ProcessoSistemica = 1,

        [Description("Processo manual")]
        ProcessoManual = 2,

        [Description("Processo com auxílio de ferramentas")]
        ProcessoAuxilioFerramentas = 3,
    }
}