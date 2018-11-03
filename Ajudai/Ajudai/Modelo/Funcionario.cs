using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajudai.Modelo
{
    public class Funcionario
    {
        public int Id { get; set; }
        public String Usuario { get; set; }
        public String Senha { get; set; }
        public String Confirmar { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public String Celular { get; set; }
        public String NivelAcesso { get; set; }
        public String NomeExibicao { get; set; }
    }
}
