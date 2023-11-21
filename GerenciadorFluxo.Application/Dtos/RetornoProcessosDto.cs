using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorFluxo.Application.Dtos
{
    public class RetornoProcessosDto
    {
        public string TituloFluxo { get; set; }

        public List<ProcessoDto> Processos { get; set; }
    }
}