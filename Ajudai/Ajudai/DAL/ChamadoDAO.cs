using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ajudai.Modelo;

namespace Ajudai.DAL
{
    public class ChamadoDAO : intChamadoDAO
    {
        public String mensagem;
        AjudaiEntities chamadoEntity = new AjudaiEntities();

        public List<Chamado> ListarChamadosAbertos()
        {
            List<Chamado> listaChamadosAbertos = new List<Chamado>();
            IQueryable lista = from p in chamadoEntity.Chamado.Where
                               (p => p.Status == "Aberto" ||
                               p.Status == "Em atendimento")
                               select p;
            foreach (Chamado p in lista)
            {
                listaChamadosAbertos.Add(p);
            }
            return listaChamadosAbertos;
        }

        public List<Chamado> ListarChamadosConcluidos()
        {
            List<Chamado> listaChamadosConcluidos = new List<Chamado>();
            IQueryable lista = from p in chamadoEntity.Chamado.Where
                               (p => p.Status == "Concluído")
                               select p;
            foreach (Chamado p in lista)
            {
                listaChamadosConcluidos.Add(p);
            }
            return listaChamadosConcluidos;
        }
    }
}
