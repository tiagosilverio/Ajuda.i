using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Ajudai.Modelo;

namespace Ajudai.DAL
{
    public class FuncionarioDAO : intFuncionarioDAO
    {
        public bool acessoAdm = false;
        public bool acessoTec = false;
        public String mensagem;
        SqlDataReader dataReader;
        Conexao conexaoBD = new Conexao();

        public void CadastrarFuncionario(Funcionario funcionario)
        {
            this.mensagem = "";
            var hash = new Criptografia(SHA512.Create());

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Funcionario  
                                  (FuncionarioLogin, Senha, Nome, Email, Telefone, Celular, NivelAcesso, NomeExibicao)
                                 values (@usuario, @senha, @nome, @email, @telefone, @celular, @nivelAcesso, @nomeExibicao)";
            cmd.Parameters.AddWithValue("@usuario", funcionario.Usuario);
            cmd.Parameters.AddWithValue("@senha", hash.GerarHash(funcionario.Senha));
            cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
            cmd.Parameters.AddWithValue("@email", funcionario.Email);
            cmd.Parameters.AddWithValue("@telefone", funcionario.Telefone);
            cmd.Parameters.AddWithValue("@celular", funcionario.Celular);
            cmd.Parameters.AddWithValue("@nivelAcesso", funcionario.NivelAcesso);
            cmd.Parameters.AddWithValue("@nomeExibicao", funcionario.NomeExibicao);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Cadastrado com Sucesso!";
            }
            catch (SqlException )
            {
                this.mensagem = "Nome de usuário indisponível";
            }
        }

        public bool Acessar(Funcionario funcionario)
        {
            var hash = new Criptografia(SHA512.Create());
            string hashTxtSenha = hash.GerarHash(funcionario.Senha);
            string nivelT = "T";
            string nivelA = "A";
            funcionario.Senha = hash.GerarHash(funcionario.Senha);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from funcionario where FuncionarioLogin = @usuario and Senha = @senha and NivelAcesso = @nivel";
            cmd.Parameters.AddWithValue("@usuario", funcionario.Usuario);
            cmd.Parameters.AddWithValue("@senha", hashTxtSenha);
            cmd.Parameters.AddWithValue("@nivel", funcionario.NivelAcesso);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    if (funcionario.Senha == hashTxtSenha)
                    {
                        if (funcionario.NivelAcesso == nivelA)
                        {
                            return acessoAdm = true;
                        }                        
                        if (funcionario.NivelAcesso == nivelT)
                        {
                            return acessoTec = true;
                        }
                    }
                }
                conexaoBD.Desconectar();
                dataReader.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }
            return false;
        }

        public void EditarFuncionario(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public void ExcluirFuncionario(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public Funcionario PesquisarFuncionarioPorID(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public Funcionario PesquisarFuncionarioPorNivel(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> PesquisarFuncionarioPorNome(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }
    }
}
