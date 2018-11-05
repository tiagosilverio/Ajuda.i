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
    public partial class frmPesquisarProduto : Form
    {
        public frmPesquisarProduto()
        {
            InitializeComponent();
        }

        private void btnPesquisarId_Click(object sender, EventArgs e)
        {
            List<String> dadosProduto = new List<String>();
            dadosProduto.Add(txbId.Text);
            dadosProduto.Add("");
            dadosProduto.Add("");
            Modelo.Controle controle = new Modelo.Controle();
            Modelo.Produto produto = controle.PesquisarProdutoPorId(dadosProduto);
            if (string.IsNullOrEmpty(txbId.Text))
            {
                MessageBox.Show("Insira o ID que deseja pesquisar", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (produto != null)
            {
                txbNome.Text = produto.Nome;
                txbDescricao.Text = produto.Descricao;
            }
            else
            {
                MessageBox.Show("Produto não encontrado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbId.Clear();
                txbNome.Clear();
                txbDescricao.Clear();
            }            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbId.Clear();
            txbNome.Clear();
            txbDescricao.Clear();
        }
    }
}
