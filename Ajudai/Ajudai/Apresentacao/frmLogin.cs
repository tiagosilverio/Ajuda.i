using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ajudai.Modelo;
using Ajudai.Apresentacao;

namespace Ajudai
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String nivelAcesso = "";

            if (rdbLogAdm.Checked)
            {
                nivelAcesso = "A";
            }

            if (rdbLogTec.Checked)
            {
                nivelAcesso = "T";
            }

            List<String> dadosLogin = new List<String>(); // Coleta os dados digitados para fazer acesso ao sistema.
            dadosLogin.Add("0");
            dadosLogin.Add(txbUsuario.Text);
            dadosLogin.Add(txbSenha.Text);
            dadosLogin.Add(nivelAcesso);
            Controle controle = new Controle();
            controle.Acessar(dadosLogin);

            if (controle.mensagem.Equals(""))
            {
                if (controle.acessoAdmin) // Verifica se é administrador e acessa a tela de administrador.
                {                   
                    frmInicioAdm inicioAdm = new frmInicioAdm();                    
                    inicioAdm.Show();
                    this.Hide();
                    txbUsuario.Clear();
                    txbSenha.Clear();
                }
                else if (controle.acessoTecn) // Verifica se é técnico e acessa a tela de técnico.
                {                    
                    frmInicioTec inicioTec = new frmInicioTec();
                    inicioTec.Show();
                    this.Hide();
                    txbUsuario.Clear();
                    txbSenha.Clear();
                }
                else // Mensagem de erro de acesso pelos dados verificados.
                {
                    MessageBox.Show("Dados incorretos. Verifique ou contate seu administrador.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }        
            }
            else // Mensagem de erro de acesso pelos dados digitados.
            {
                MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }                      
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
