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
        public String mensagem;

        public void CadastrarFuncionario(List<String> dadosFuncionario)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarCadastro(dadosFuncionario);

            if (validacao.mensagem.Equals(""))
            {
                ddFuncionario funcionario = new ddFuncionario();
                funcionario.usuario = dadosFuncionario[1];
                funcionario.senha = dadosFuncionario[2];
                funcionario.confirmar = dadosFuncionario[3];
                funcionario.nome = dadosFuncionario[4];
                funcionario.email = dadosFuncionario[5];
                funcionario.telefone = dadosFuncionario[6];
                funcionario.celular = dadosFuncionario[7];
                funcionario.nivelAcesso = dadosFuncionario[8];
                funcionario.nomeExibicao = dadosFuncionario[9];
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
                ddFuncionario funcionario = new ddFuncionario();
                funcionario.usuario = dadosLogin[1];
                funcionario.senha = dadosLogin[2];
                funcionario.nivelAcesso = dadosLogin[3];
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

        public ddFuncionario PesquisarFuncionarioPorId(List<String> dadosFuncionario)
        {
            this.mensagem = "";
            ddFuncionario funcionario = new ddFuncionario();
            Validacao validacao = new Validacao();
            validacao.ValidarPesquisaPorId(dadosFuncionario);
            if (validacao.mensagem.Equals(""))
            {
                funcionario.id = validacao.id;
                DAL.FuncionarioDAO funcionarioDAO = new DAL.FuncionarioDAO();
                funcionario = funcionarioDAO.PesquisarFuncionarioPorId(funcionario);
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
            return funcionario;
        }

        public ddFuncionario PesquisarFuncionarioPorNomeUsuario(List<String> dadosFuncionario)
        {
            this.mensagem = "";
            ddFuncionario funcionario = new ddFuncionario();
            Validacao validacao = new Validacao();
            validacao.ValidarPesquisaPorNomeUsuario(dadosFuncionario);
            if (validacao.mensagem.Equals(""))
            {
                funcionario.usuario = dadosFuncionario[1];
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
                ddFuncionario funcionario = new ddFuncionario();
                funcionario.id = validacao.id;
                funcionario.usuario = dadosFuncionario[1];                
                funcionario.nome = dadosFuncionario[2];
                funcionario.email = dadosFuncionario[3];
                funcionario.telefone = dadosFuncionario[4];
                funcionario.celular = dadosFuncionario[5];
                funcionario.nivelAcesso = dadosFuncionario[6];
                funcionario.nomeExibicao = dadosFuncionario[7];
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
                ddFuncionario funcionario = new ddFuncionario();
                funcionario.id = validacao.id;
                DAL.FuncionarioDAO funcionarioDAO = new DAL.FuncionarioDAO();
                if (funcionarioDAO.PesquisarFuncionarioPorId(funcionario).usuario != null)
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
           /* this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarPesquisaPorNome(dadosFuncionario);
            if (validacao.mensagem.Equals(""))
            {
                DAL.FuncionarioDAO funcionarioDAO = new DAL.FuncionarioDAO();
                ddFuncionario funcionario = new ddFuncionario();
                funcionario.nome = dadosFuncionario[3];
                atbEstaticos.listaFuncionariosEstatico =
                    funcionarioDAO.PesquisarFuncionarioPorNome(funcionario);
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }*/
        }

        public void CadastrarProduto(List<String> dadosProduto)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarCadastroProduto(dadosProduto);
            if (validacao.mensagem.Equals(""))
            {
                Produto produto = new Produto();
                produto.Nome = dadosProduto[1];
                produto.Descricao = dadosProduto[2];
                DAL.ProdutoDAO produtoDAO = new DAL.ProdutoDAO();
                produtoDAO.CadastrarProduto(produto);
                this.mensagem = produtoDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public Produto PesquisarProdutoPorId(List<String> dadosProduto)
        {
            this.mensagem = "";
            Produto produto = new Produto();
            Validacao validacao = new Validacao();
            validacao.ValidarPesquisaProdutoPorId(dadosProduto);
            if (validacao.mensagem.Equals(""))
            {
                produto.idProduto = validacao.id;
                DAL.ProdutoDAO produtoDAO = new DAL.ProdutoDAO();
                produto = produtoDAO.PesquisarProdutoPorId(produto);
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
            return produto;
        }
    }
}
