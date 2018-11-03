using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ajudai.Apresentacao
{
    public partial class frmInicioAdm : Form
    {
        public frmInicioAdm()
        {
            InitializeComponent();            
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario cad = new frmCadastroUsuario();
            cad.ShowDialog();
        }

        private void tsmLogoffAdm_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Close();
            login.ShowDialog();            
        }

        private void tsmFecharAdm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisar pesquisar = new frmPesquisar();
            pesquisar.ShowDialog();
        }

        private void frmInicioAdm_Load(object sender, EventArgs e)
        {

        }
    }
}
