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

            List<String> dadosLogin = new List<String>();
            dadosLogin.Add("0");
            dadosLogin.Add(txbUsuario.Text);
            dadosLogin.Add(txbSenha.Text);
            dadosLogin.Add(nivelAcesso);
            Controle controle = new Controle();
            controle.Acessar(dadosLogin);

            if (controle.mensagem.Equals(""))
            {
                if (controle.acessoAdmin)
                {
                    //MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmInicioAdm inicioAdm = new frmInicioAdm();
                    inicioAdm.Show();                    
                }
                else if (controle.acessoTecn)
                {
                    //MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmInicioTec inicioTec = new frmInicioTec();
                    inicioTec.Show();                    
                }
                else
                {
                    MessageBox.Show("Dados incorretos. Verifique ou contate seu administrador.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                
            }
            else
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
