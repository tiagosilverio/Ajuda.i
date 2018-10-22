namespace Ajudai.Apresentacao
{
    partial class frmCadastroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTecnico = new System.Windows.Forms.RadioButton();
            this.rdbAdministrador = new System.Windows.Forms.RadioButton();
            this.txbNomeExibicao = new System.Windows.Forms.TextBox();
            this.lblNomeExibicao = new System.Windows.Forms.Label();
            this.txbCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbConfirmar = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCamposObrigatorios = new System.Windows.Forms.Label();
            this.lblCampos = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(41, 190);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(367, 20);
            this.txbEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(38, 173);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-mail*";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(41, 363);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTecnico);
            this.groupBox1.Controls.Add(this.rdbAdministrador);
            this.groupBox1.Location = new System.Drawing.Point(197, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nível de Acesso*";
            // 
            // rdbTecnico
            // 
            this.rdbTecnico.AutoSize = true;
            this.rdbTecnico.Location = new System.Drawing.Point(141, 20);
            this.rdbTecnico.Name = "rdbTecnico";
            this.rdbTecnico.Size = new System.Drawing.Size(64, 17);
            this.rdbTecnico.TabIndex = 10;
            this.rdbTecnico.TabStop = true;
            this.rdbTecnico.Text = "Técnico";
            this.rdbTecnico.UseVisualStyleBackColor = true;
            // 
            // rdbAdministrador
            // 
            this.rdbAdministrador.AutoSize = true;
            this.rdbAdministrador.Location = new System.Drawing.Point(7, 20);
            this.rdbAdministrador.Name = "rdbAdministrador";
            this.rdbAdministrador.Size = new System.Drawing.Size(88, 17);
            this.rdbAdministrador.TabIndex = 9;
            this.rdbAdministrador.TabStop = true;
            this.rdbAdministrador.Text = "Administrador";
            this.rdbAdministrador.UseVisualStyleBackColor = true;
            // 
            // txbNomeExibicao
            // 
            this.txbNomeExibicao.Location = new System.Drawing.Point(41, 299);
            this.txbNomeExibicao.Name = "txbNomeExibicao";
            this.txbNomeExibicao.Size = new System.Drawing.Size(144, 20);
            this.txbNomeExibicao.TabIndex = 8;
            // 
            // lblNomeExibicao
            // 
            this.lblNomeExibicao.AutoSize = true;
            this.lblNomeExibicao.Location = new System.Drawing.Point(38, 282);
            this.lblNomeExibicao.Name = "lblNomeExibicao";
            this.lblNomeExibicao.Size = new System.Drawing.Size(93, 13);
            this.lblNomeExibicao.TabIndex = 0;
            this.lblNomeExibicao.Text = "Nome de Exibição";
            // 
            // txbCelular
            // 
            this.txbCelular.Location = new System.Drawing.Point(231, 240);
            this.txbCelular.Name = "txbCelular";
            this.txbCelular.Size = new System.Drawing.Size(177, 20);
            this.txbCelular.TabIndex = 7;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(228, 223);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 0;
            this.lblCelular.Text = "Celular";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(41, 240);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(177, 20);
            this.txbTelefone.TabIndex = 6;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(38, 223);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 0;
            this.lblTelefone.Text = "Telefone";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(41, 142);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(367, 20);
            this.txbNome.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(38, 125);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(86, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome Completo*";
            // 
            // txbConfirmar
            // 
            this.txbConfirmar.Location = new System.Drawing.Point(231, 94);
            this.txbConfirmar.Name = "txbConfirmar";
            this.txbConfirmar.Size = new System.Drawing.Size(177, 20);
            this.txbConfirmar.TabIndex = 3;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Location = new System.Drawing.Point(228, 77);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(89, 13);
            this.lblConfirmar.TabIndex = 0;
            this.lblConfirmar.Text = "Confirmar Senha*";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(41, 94);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(177, 20);
            this.txbSenha.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(38, 77);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(42, 13);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha*";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(41, 44);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(177, 20);
            this.txbUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(38, 27);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(93, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Nome de Usuário*";
            // 
            // lblCamposObrigatorios
            // 
            this.lblCamposObrigatorios.AutoSize = true;
            this.lblCamposObrigatorios.Location = new System.Drawing.Point(300, 9);
            this.lblCamposObrigatorios.Name = "lblCamposObrigatorios";
            this.lblCamposObrigatorios.Size = new System.Drawing.Size(0, 13);
            this.lblCamposObrigatorios.TabIndex = 36;
            // 
            // lblCampos
            // 
            this.lblCampos.AutoSize = true;
            this.lblCampos.Location = new System.Drawing.Point(285, 27);
            this.lblCampos.Name = "lblCampos";
            this.lblCampos.Size = new System.Drawing.Size(123, 13);
            this.lblCampos.TabIndex = 0;
            this.lblCampos.Text = "( * ) Campos Obrigatórios";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(333, 363);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(454, 422);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblCampos);
            this.Controls.Add(this.lblCamposObrigatorios);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbNomeExibicao);
            this.Controls.Add(this.lblNomeExibicao);
            this.Controls.Add(this.txbCelular);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbConfirmar);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTecnico;
        private System.Windows.Forms.RadioButton rdbAdministrador;
        private System.Windows.Forms.TextBox txbNomeExibicao;
        private System.Windows.Forms.Label lblNomeExibicao;
        private System.Windows.Forms.TextBox txbCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbConfirmar;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCamposObrigatorios;
        private System.Windows.Forms.Label lblCampos;
        private System.Windows.Forms.Button btnCancelar;
    }
}