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

        public Funcionario PesquisarFuncionarioPorId(List<String> dadosFuncionario)
        {
            this.mensagem = "";
            Funcionario funcionario = new Funcionario();
            Validacao validacao = new Validacao();
            validacao.ValidarPesquisaPorId(dadosFuncionario);
            if (validacao.mensagem.Equals(""))
            {
                funcionario.Id = validacao.id;
                DAL.FuncionarioDAO funcionarioDAO = new DAL.FuncionarioDAO();
                funcionario = funcionarioDAO.PesquisarFuncionarioPorId(funcionario);
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
            return funcionario;
        }

        public Funcionario PesquisarFuncionarioPorNomeUsuario(List<String> dadosFuncionario)
        {
            this.mensagem = "";
            Funcionario funcionario = new Funcionario();
            Validacao validacao = new Validacao();
            validacao.ValidarPesquisaPorNomeUsuario(dadosFuncionario);
            if (validacao.mensagem.Equals(""))
            {
                funcionario.Usuario = dadosFuncionario[1];
                DAL.FuncionarioDAO funcionarioDAO = new DAL.FuncionarioDAO();
                funcionario = funcionarioDAO.PesquisarFuncionarioPorNomeUsuario(funcionario);
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
            return funcionario;
        }

        public void EditarFuncionario(List<String> dadosFuncionario)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarEdicao(dadosFuncionario);

            if (validacao.mensagem.Equals(""))
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Id = validacao.id;
                funcionario.Usuario = dadosFuncionario[1];                
                funcionario.Nome = dadosFuncionario[2];
                funcionario.Email = dadosFuncionario[3];
                funcionario.Telefone = dadosFuncionario[4];
                funcionario.Celular = dadosFuncionario[5];
                funcionario.NivelAcesso = dadosFuncionario[6];
                funcionario.NomeExibicao = dadosFuncionario[7];
                DAL.FuncionarioDAO funcionarioDAO = new DAL.FuncionarioDAO();
                funcionarioDAO.EditarFuncionario(funcionario);
                this.mensagem = funcionarioDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void ExcluirFuncionario(List<String> dadosFuncionario)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarPesquisaPorId(dadosFuncionario);
            if (validacao.mensagem.Equals(""))
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Id = validacao.id;
                DAL.FuncionarioDAO funcionarioDAO = new DAL.FuncionarioDAO();
                if (funcionarioDAO.PesquisarFuncionarioPorId(funcionario).Usuario != null)
                {
                    funcionarioDAO.ExcluirFuncionario(funcionario);
                    this.mensagem = funcionarioDAO.mensagem;
                }
                else
                {
                    this.mensagem = "Não existe este usuário";
                }
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void PesquisarFuncionarioPorNome(List<String> dadosFuncionario)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarPesquisaPorNome(dadosFuncionario);
            if (validacao.mensagem.Equals(""))
            {
                DAL.FuncionarioDAO funcionarioDAO = new DAL.FuncionarioDAO();
                Funcionario funcionario = new Funcionario();
                funcionario.Nome = dadosFuncionario[3];
                atbEstaticos.listaFuncionariosEstatico =
                    funcionarioDAO.PesquisarFuncionarioPorNome(funcionario);
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}
