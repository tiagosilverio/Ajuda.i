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
    public partial class frmListaFuncionarios : Form
    {
        public frmListaFuncionarios()
        {
            InitializeComponent();
        }

        public void InicializarDataGrid()
        {
            grdLista.DataSource = Modelo.atbEstaticos.listaFuncionariosEstatico;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdLista_SelectionChanged(object sender, EventArgs e)
        {
            Modelo.atbEstaticos.listaFuncionariosEstatico.Clear();
            Modelo.atbEstaticos.listaFuncionariosEstatico.Add((Modelo.Funcionario)grdList);
        }
    }
}
