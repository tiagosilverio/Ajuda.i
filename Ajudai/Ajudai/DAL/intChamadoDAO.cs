using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ajudai.Modelo;

namespace Ajudai.DAL
{
    interface intChamadoDAO
    {
        List<Chamado> ListarChamadosAbertos();
        List<Chamado> ListarChamadosConcluidos();
    }
}
