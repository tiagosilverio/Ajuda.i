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
        Modelo.AjudaiEntities funcionarioEntity = new Modelo.AjudaiEntities();

        public void CadastrarFuncionario(ddFuncionario funcionario)
        {
            this.mensagem = "";
            var hash = new Criptografia(SHA512.Create());
            hash.GerarHash(funcionario.senha);        

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Funcionario  
                                  (FuncionarioLogin, Senha, Nome, Email, Telefone, Celular, NivelAcesso, NomeExibicao)
                                 values (@usuario, @senha, @nome, @email, @telefone, @celular, @nivelAcesso, @nomeExibicao)";
            cmd.Parameters.AddWithValue("@usuario", funcionario.usuario);
            cmd.Parameters.AddWithValue("@senha", hash.GerarHash(funcionario.senha));
            cmd.Parameters.AddWithValue("@nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@email", funcionario.email);
            cmd.Parameters.AddWithValue("@telefone", funcionario.telefone);
            cmd.Parameters.AddWithValue("@celular", funcionario.celular);
            cmd.Parameters.AddWithValue("@nivelAcesso", funcionario.nivelAcesso);
            cmd.Parameters.AddWithValue("@nomeExibicao", funcionario.nomeExibicao);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Cadastrado com Sucesso!";            
            }
            catch (SqlException e )
            {
                this.mensagem = e.ToString();
                this.mensagem = "Nome de Usuário Indisponível";

            }
        }

        public bool Acessar(ddFuncionario funcionario)
        {
            var hash = new Criptografia(SHA512.Create());
            string hashTxtSenha = hash.GerarHash(funcionario.senha);
            string nivelT = "T";
            string nivelA = "A";
            funcionario.senha = hash.GerarHash(funcionario.senha);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from funcionario where FuncionarioLogin = @usuario and Senha = @senha and NivelAcesso = @nivel";
            cmd.Parameters.AddWithValue("@usuario", funcionario.usuario);
            cmd.Parameters.AddWithValue("@senha", hashTxtSenha);
            cmd.Parameters.AddWithValue("@nivel", funcionario.nivelAcesso);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    if (funcionario.senha == hashTxtSenha)
                    {
                        if (funcionario.nivelAcesso == nivelA)
                        {
                            return acessoAdm = true;
                        }                        
                        if (funcionario.nivelAcesso == nivelT)
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

        public void EditarFuncionario(ddFuncionario funcionario)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Funcionario set FuncionarioLogin = @usuario, Nome = @nome, 
                            Email = @email, Telefone = @telefone, Celular = @celular, 
                            NivelAcesso = @nivelAcesso, NomeExibicao = @nomeExibicao 
                            where idFuncionario = @id";
            cmd.Parameters.AddWithValue("@id", funcionario.id);
            cmd.Parameters.AddWithValue("@usuario", funcionario.usuario);            
            cmd.Parameters.AddWithValue("@nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@email", funcionario.email);
            cmd.Parameters.AddWithValue("@telefone", funcionario.telefone);
            cmd.Parameters.AddWithValue("@celular", funcionario.celular);
            cmd.Parameters.AddWithValue("@nivelAcesso", funcionario.nivelAcesso);
            cmd.Parameters.AddWithValue("@nomeExibicao", funcionario.nomeExibicao);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Editado com Sucesso!";
            }
            catch (SqlException)
            {
                this.mensagem = "Nome de Usuário Indisponível";
            }
        }

        public void ExcluirFuncionario(ddFuncionario funcionario)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from funcionario where idFuncionario = @id";
            cmd.Parameters.AddWithValue("@id", funcionario.id);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Usuário excluído com sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public ddFuncionario PesquisarFuncionarioPorId(ddFuncionario funcionario)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from Funcionario
                            where idFuncionario = @id";
            cmd.Parameters.AddWithValue("@id", funcionario.id);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    funcionario.usuario = dataReader["FuncionarioLogin"].ToString();                    
                    funcionario.nome = dataReader["Nome"].ToString();
                    funcionario.email = dataReader["Email"].ToString();
                    funcionario.telefone = dataReader["Telefone"].ToString();
                    funcionario.celular = dataReader["Celular"].ToString();
                    funcionario.nivelAcesso = dataReader["NivelAcesso"].ToString();
                    funcionario.nomeExibicao = dataReader["NomeExibicao"].ToString();
                }
                else
                {
                    funcionario.id = 0;
                }
                dataReader.Close();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
            return funcionario;
        }

        public ddFuncionario PesquisarFuncionarioPorNomeUsuario(ddFuncionario funcionario)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from Funcionario
                            where FuncionarioLogin = @usuario";
            cmd.Parameters.AddWithValue("@usuario", funcionario.usuario);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    funcionario.id = Convert.ToInt32(dataReader["idFuncionario"].ToString());
                    funcionario.usuario = dataReader["FuncionarioLogin"].ToString();
                    funcionario.nome = dataReader["Nome"].ToString();
                    funcionario.email = dataReader["Email"].ToString();
                    funcionario.telefone = dataReader["Telefone"].ToString();
                    funcionario.celular = dataReader["Celular"].ToString();
                    funcionario.nivelAcesso = dataReader["NivelAcesso"].ToString();
                    funcionario.nomeExibicao = dataReader["NomeExibicao"].ToString();
                }
                else
                {
                    funcionario.usuario = null;
                }
                dataReader.Close();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
            return funcionario;
        }

        public List<ddFuncionario> PesquisarFuncionarioPorNome(ddFuncionario funcionario)
        {
           /* this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            List<Funcionario> listaFuncionarios = new List<Funcionario>();
            cmd.CommandText = @"select * from Funcionario
                            where Nome like @nome";
            cmd.Parameters.AddWithValue("@nome", funcionario.nome + "%");
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Funcionario listaUsuario = new Funcionario();
                    listaUsuario.id = Convert.ToInt32(dataReader["idFuncionario"].ToString());
                    listaUsuario.usuario = dataReader["FuncionarioLogin"].ToString();
                    listaUsuario.nome = dataReader["Nome"].ToString();
                    listaUsuario.email = dataReader["Email"].ToString();
                    listaUsuario.telefone = dataReader["Telefone"].ToString();
                    listaUsuario.celular = dataReader["Celular"].ToString();
                    listaUsuario.nivelAcesso = dataReader["NivelAcesso"].ToString();
                    listaUsuario.nomeExibicao = dataReader["NomeExibicao"].ToString();
                    listaFuncionarios.Add(listaUsuario);
                }
                dataReader.Close();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }*/
            return null;
        }
    }
}
