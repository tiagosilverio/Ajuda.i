using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajudai.DAL
{
    public class Conexao
    {
        SqlConnection conexaoBD;

        public Conexao()
        {
            conexaoBD = new SqlConnection();
            conexaoBD.ConnectionString = @"Data Source=HUSTIAN\SQLEXPRESS;
                             Initial Catalog=AJUDA_I;Integrated Security=True";
            //conexaoBD.ConnectionString = @"Data Source=pim2018.mysql.dbaas.com.br;
            //            Initial Catalog=pim2018;User ID=pim2018; Password=pim2018;Integrated Security=True";
        }

        public SqlConnection Conectar()
        {
            if (conexaoBD.State == System.Data.ConnectionState.Closed)
                conexaoBD.Open();
            return conexaoBD;
        }

        public void Desconectar()
        {
            if (conexaoBD.State == System.Data.ConnectionState.Open)
                conexaoBD.Close();
        }
    }
}
