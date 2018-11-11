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
    public partial class frmDetalheChamado : Form
    {
        DateTime data = DateTime.Now;

        public frmDetalheChamado()
        {
            InitializeComponent();
            exibir();
        }
        
        public void exibir()
        {
            lblDataAbertura.Text = Convert.ToString(data);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDetalheChamado_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
