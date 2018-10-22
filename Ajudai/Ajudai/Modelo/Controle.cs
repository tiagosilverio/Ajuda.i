using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajudai.Modelo
{
    public class Controle
    {
        public bool acessoAdmin;
        public bool acessoTecn;
        public bool acesso = true;
        public String mensagem = "";

        public void CadastrarFuncionario(List<String> dadosFuncionario)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarCadastro(dadosFuncionario);
            if (validacao.mensagem.Equals(""))
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Usuario = dadosFuncionario[1];
                funcionario.Senha = dadosFuncionario[2];
                funcionario.Confirmar = dadosFuncionario[3];
                funcionario.Nome = dadosFuncionario[4];
                funcionario.Email = dadosFuncionario[5];
                funcionario.Telefone = dadosFuncionario[6];
                funcionario.Celular = dadosFuncionario[7];
                funcionario.NivelAcesso = dadosFuncionario[8];
                funcionario.NomeExibicao = dadosFuncionario[9];
                DAL.FuncionarioDAO funcionarioDAO = new DAL.FuncionarioDAO();
                funcionarioDAO.CadastrarFuncionario(funcionario);
                this.mensagem = funcionarioDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        internal bool Acessar(List<String> dadosLogin)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarLogin(dadosLogin);
            if (validacao.mensagem.Equals(""))
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Usuario = dadosLogin[1];
                funcionario.Senha = dadosLogin[2];
                funcionario.NivelAcesso = dadosLogin[3];
                DAL.FuncionarioDAO funcionarioDAO = new DAL.FuncionarioDAO();
                acessoAdmin = funcionarioDAO.Acessar(funcionario);
                this.acessoAdmin = funcionarioDAO.acessoAdm;
                this.acessoTecn = funcionarioDAO.acessoTec;

                if (acessoAdmin == true)
                {
                    acessoTecn = false;
                    acesso = acessoAdmin;
                }
                else
                if (acessoTecn == true)
                {
                    acessoAdmin = false;
                    acesso = acessoTecn;
                }
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
            return acesso;

        }
    }
}
