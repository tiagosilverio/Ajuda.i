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

    }
}
