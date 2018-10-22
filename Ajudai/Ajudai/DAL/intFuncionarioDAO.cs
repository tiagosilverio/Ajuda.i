using Ajudai.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajudai.DAL
{
    interface intFuncionarioDAO
    {
        void CadastrarFuncionario(Funcionario funcionario);
        bool Acessar(Funcionario funcionario);
        void EditarFuncionario(Funcionario funcionario);
        void ExcluirFuncionario(Funcionario funcionario);
        Funcionario PesquisarFuncionarioPorID(Funcionario funcionario);
        Funcionario PesquisarFuncionarioPorNivel(Funcionario funcionario);
        List<Funcionario> PesquisarFuncionarioPorNome(Funcionario funcionario);
    }
}
