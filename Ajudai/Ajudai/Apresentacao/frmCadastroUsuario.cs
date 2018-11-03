﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ajudai.Modelo;

namespace Ajudai.Apresentacao
{
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }      

        private void btnCadastrar_Click(object sender, EventArgs e)
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

            List<String> dadosFuncionario = new List<String>();
            dadosFuncionario.Add("0");
            dadosFuncionario.Add(txbUsuario.Text);
            dadosFuncionario.Add(txbSenha.Text);
            dadosFuncionario.Add(txbConfirmar.Text);
            dadosFuncionario.Add(txbNome.Text);
            dadosFuncionario.Add(txbEmail.Text);
            dadosFuncionario.Add(mskTelefone.Text);
            dadosFuncionario.Add(mskCelular.Text);
            dadosFuncionario.Add(nivelAcesso);
            dadosFuncionario.Add(txbNomeExibicao.Text);

            Controle controle = new Controle();
            controle.CadastrarFuncionario(dadosFuncionario);            
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            
            /*txbUsuario.Text = "";
            txbSenha.Text = "";
            txbConfirmar.Text = "";
            txbNome.Text = "";
            txbEmail.Text = "";
            mskTelefone.Text = "";
            mskCelular.Text = "";
            txbNomeExibicao.Text = "";*/
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
