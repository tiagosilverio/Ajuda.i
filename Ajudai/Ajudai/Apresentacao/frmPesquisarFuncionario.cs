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
    public partial class frmPesquisarFuncionario : Form
    {
        public frmPesquisarFuncionario()
        {
            InitializeComponent();
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            String[] dados = { txbId.Text, txbUsuario.Text, txbNome.Text, txbEmail.Text, mskTelefone.Text,
                                    mskCelular.Text, txbNomeExibicao.Text };
            List<String> dadosFuncionario = new List<String>(dados);
            Modelo.Controle controle = new Modelo.Controle();
            Modelo.ddFuncionario funcionario = controle.PesquisarFuncionarioPorId(dadosFuncionario);
            txbUsuario.Text = funcionario.usuario;
            txbNome.Text = funcionario.nome;
            txbEmail.Text = funcionario.email;
            mskTelefone.Text = funcionario.telefone;
            mskCelular.Text = funcionario.celular;
            txbNomeExibicao.Text = funcionario.nomeExibicao;
            if (funcionario.nivelAcesso == "A")
                rdbAdministrador.Checked = true;
            if (funcionario.nivelAcesso == "T")
                rdbTecnico.Checked = true;
            if (funcionario.id == 0)
                MessageBox.Show("Dados não encontrados, verifique.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            String[] dados = { txbId.Text, txbUsuario.Text, txbNome.Text, txbEmail.Text, mskTelefone.Text,
                                    mskCelular.Text, txbNomeExibicao.Text };
            List<String> dadosFuncionairio = new List<String>(dados);
            Modelo.Controle controle = new Modelo.Controle();

            DialogResult result = MessageBox.Show("Deseja realmente excluir?",
                "Alerta de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                controle.ExcluirFuncionario(dadosFuncionairio);
                MessageBox.Show(controle.mensagem);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            String nivelAcesso = "";
            if (rdbAdministrador.Checked)
            {
                nivelAcesso = "A";
            }

            if (rdbTecnico.Checked)
            {
                nivelAcesso = "T";
            }

            String[] dados = { txbId.Text, txbUsuario.Text, txbNome.Text, txbEmail.Text, mskTelefone.Text,
                                    mskCelular.Text, nivelAcesso, txbNomeExibicao.Text };
            List<String> dadosFuncionairio = new List<String>(dados);
            Modelo.Controle controle = new Modelo.Controle();
            controle.EditarFuncionario(dadosFuncionairio);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNomeDeUsuário_Click(object sender, EventArgs e)
        {
            String[] dados = { "0", txbUsuario.Text, txbNome.Text, txbEmail.Text, mskTelefone.Text,
                                    mskCelular.Text, txbNomeExibicao.Text };
            List<String> dadosFuncionario = new List<String>(dados);
            Modelo.Controle controle = new Modelo.Controle();
            Modelo.ddFuncionario funcionario = controle.PesquisarFuncionarioPorNomeUsuario(dadosFuncionario);
            txbId.Text = funcionario.id.ToString();
            txbUsuario.Text = funcionario.usuario;
            txbNome.Text = funcionario.nome;
            txbEmail.Text = funcionario.email;
            mskTelefone.Text = funcionario.telefone;
            mskCelular.Text = funcionario.celular;
            txbNomeExibicao.Text = funcionario.nomeExibicao;
            if (funcionario.nivelAcesso == "A")
                rdbAdministrador.Checked = true;
            if (funcionario.nivelAcesso == "T")
                rdbTecnico.Checked = true;
            if (funcionario.usuario == null)
                MessageBox.Show("Usuário não encontrado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbId.Clear();
            txbUsuario.Clear();
            txbNome.Clear();
            txbEmail.Clear();
            mskTelefone.Clear();
            mskCelular.Clear();
            txbNomeExibicao.Clear();
            rdbAdministrador.Checked = false;
            rdbTecnico.Checked = false;
        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            /*String[] dados = { "0", txbUsuario.Text, txbNome.Text, txbEmail.Text, mskTelefone.Text,
                                    mskCelular.Text, txbNomeExibicao.Text };
            List<String> dadosFuncionario = new List<String>(dados);
            Modelo.Controle controle = new Modelo.Controle();
            controle.PesquisarFuncionarioPorNome(dadosFuncionario);

            if(Modelo.atbEstaticos.listaFuncionariosEstatico.Count == 1)
            {
                Modelo.ddFuncionario funcionario = Modelo.atbEstaticos.listaFuncionariosEstatico[0];
                txbId.Text = funcionario.id.ToString();
                txbUsuario.Text = funcionario.usuario;
                txbNome.Text = funcionario.nome;
                txbEmail.Text = funcionario.email;
                mskTelefone.Text = funcionario.telefone;
                mskCelular.Text = funcionario.celular;
                txbNomeExibicao.Text = funcionario.nomeExibicao;
                if (funcionario.nivelAcesso == "A")
                    rdbAdministrador.Checked = true;
                if (funcionario.nivelAcesso == "T")
                    rdbTecnico.Checked = true;
            }
            if (Modelo.atbEstaticos.listaFuncionariosEstatico.Count > 1)
            {
                frmListaFuncionarios frmLista = new frmListaFuncionarios();
                frmLista.ShowDialog();
                txbId.Text = Modelo.atbEstaticos.listaFuncionariosEstatico[0].ToString();
                txbUsuario.Text = Modelo.atbEstaticos.listaFuncionariosEstatico[0].usuario;
                txbNome.Text = Modelo.atbEstaticos.listaFuncionariosEstatico[0].nome;
                txbEmail.Text = Modelo.atbEstaticos.listaFuncionariosEstatico[0].email;
                mskTelefone.Text = Modelo.atbEstaticos.listaFuncionariosEstatico[0].telefone;
                mskCelular.Text = Modelo.atbEstaticos.listaFuncionariosEstatico[0].celular;
                txbNomeExibicao.Text = Modelo.atbEstaticos.listaFuncionariosEstatico[0].nomeExibicao;
                rdbAdministrador.Checked = false;
                rdbTecnico.Checked = false;

            }*/
        }
    }
}
