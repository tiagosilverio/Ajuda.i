namespace Ajudai.Apresentacao
{
    partial class frmDetalheChamado
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
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.txbIdChamado = new System.Windows.Forms.TextBox();
            this.txbIdCliente = new System.Windows.Forms.TextBox();
            this.txbIdProduto = new System.Windows.Forms.TextBox();
            this.lblIdChamado = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.lblIdProduto = new System.Windows.Forms.Label();
            this.rtbResposta = new System.Windows.Forms.RichTextBox();
            this.lblIdFuncionario = new System.Windows.Forms.Label();
            this.txbIdFuncionario = new System.Windows.Forms.TextBox();
            this.lblDataAbertura = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataSolucao = new System.Windows.Forms.DateTimePicker();
            this.rtbSolucao = new System.Windows.Forms.RichTextBox();
            this.lblDataSolucao = new System.Windows.Forms.Label();
            this.lblSolucao = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txbAvaliacao = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbPrioridade = new System.Windows.Forms.TextBox();
            this.lblPrioridade = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDataAtendimento = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.Enabled = false;
            this.rtbDescricao.Location = new System.Drawing.Point(7, 89);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.ReadOnly = true;
            this.rtbDescricao.Size = new System.Drawing.Size(418, 57);
            this.rtbDescricao.TabIndex = 0;
            this.rtbDescricao.Text = "";
            this.rtbDescricao.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txbIdChamado
            // 
            this.txbIdChamado.Enabled = false;
            this.txbIdChamado.Location = new System.Drawing.Point(7, 32);
            this.txbIdChamado.Name = "txbIdChamado";
            this.txbIdChamado.ReadOnly = true;
            this.txbIdChamado.Size = new System.Drawing.Size(100, 20);
            this.txbIdChamado.TabIndex = 1;
            // 
            // txbIdCliente
            // 
            this.txbIdCliente.Enabled = false;
            this.txbIdCliente.Location = new System.Drawing.Point(113, 32);
            this.txbIdCliente.Name = "txbIdCliente";
            this.txbIdCliente.ReadOnly = true;
            this.txbIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txbIdCliente.TabIndex = 2;
            // 
            // txbIdProduto
            // 
            this.txbIdProduto.Enabled = false;
            this.txbIdProduto.Location = new System.Drawing.Point(219, 32);
            this.txbIdProduto.Name = "txbIdProduto";
            this.txbIdProduto.ReadOnly = true;
            this.txbIdProduto.Size = new System.Drawing.Size(100, 20);
            this.txbIdProduto.TabIndex = 3;
            // 
            // lblIdChamado
            // 
            this.lblIdChamado.AutoSize = true;
            this.lblIdChamado.Location = new System.Drawing.Point(7, 16);
            this.lblIdChamado.Name = "lblIdChamado";
            this.lblIdChamado.Size = new System.Drawing.Size(81, 13);
            this.lblIdChamado.TabIndex = 4;
            this.lblIdChamado.Text = "ID do Chamado";
            this.lblIdChamado.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(110, 16);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(68, 13);
            this.lblIdCliente.TabIndex = 5;
            this.lblIdCliente.Text = "ID do Cliente";
            // 
            // lblIdProduto
            // 
            this.lblIdProduto.AutoSize = true;
            this.lblIdProduto.Location = new System.Drawing.Point(216, 16);
            this.lblIdProduto.Name = "lblIdProduto";
            this.lblIdProduto.Size = new System.Drawing.Size(73, 13);
            this.lblIdProduto.TabIndex = 6;
            this.lblIdProduto.Text = "ID do Produto";
            // 
            // rtbResposta
            // 
            this.rtbResposta.Location = new System.Drawing.Point(7, 32);
            this.rtbResposta.Name = "rtbResposta";
            this.rtbResposta.Size = new System.Drawing.Size(418, 57);
            this.rtbResposta.TabIndex = 7;
            this.rtbResposta.Text = "";
            // 
            // lblIdFuncionario
            // 
            this.lblIdFuncionario.AutoSize = true;
            this.lblIdFuncionario.Location = new System.Drawing.Point(322, 16);
            this.lblIdFuncionario.Name = "lblIdFuncionario";
            this.lblIdFuncionario.Size = new System.Drawing.Size(91, 13);
            this.lblIdFuncionario.TabIndex = 9;
            this.lblIdFuncionario.Text = "ID do Funcionário";
            // 
            // txbIdFuncionario
            // 
            this.txbIdFuncionario.Enabled = false;
            this.txbIdFuncionario.Location = new System.Drawing.Point(325, 32);
            this.txbIdFuncionario.Name = "txbIdFuncionario";
            this.txbIdFuncionario.ReadOnly = true;
            this.txbIdFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txbIdFuncionario.TabIndex = 8;
            // 
            // lblDataAbertura
            // 
            this.lblDataAbertura.AutoSize = true;
            this.lblDataAbertura.Location = new System.Drawing.Point(6, 16);
            this.lblDataAbertura.Name = "lblDataAbertura";
            this.lblDataAbertura.Size = new System.Drawing.Size(87, 13);
            this.lblDataAbertura.TabIndex = 10;
            this.lblDataAbertura.Text = "Data de abertura";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Hardware",
            "Software"});
            this.cmbTipo.Location = new System.Drawing.Point(10, 108);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(187, 21);
            this.cmbTipo.TabIndex = 11;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(7, 73);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(173, 13);
            this.lblDescricao.TabIndex = 12;
            this.lblDescricao.Text = "Descrição e comentários do cliente";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(7, 92);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(89, 13);
            this.lblTipo.TabIndex = 14;
            this.lblTipo.Text = "Tipo do problema";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Resposta";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Aguardando atendimento",
            "Em atendimento",
            "Concluído"});
            this.cmbStatus.Location = new System.Drawing.Point(238, 108);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(187, 21);
            this.cmbStatus.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Status do chamado";
            // 
            // dtpDataSolucao
            // 
            this.dtpDataSolucao.Checked = false;
            this.dtpDataSolucao.CustomFormat = "07/11/2018 13:50";
            this.dtpDataSolucao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataSolucao.Location = new System.Drawing.Point(10, 153);
            this.dtpDataSolucao.Name = "dtpDataSolucao";
            this.dtpDataSolucao.Size = new System.Drawing.Size(259, 20);
            this.dtpDataSolucao.TabIndex = 18;
            this.dtpDataSolucao.Value = new System.DateTime(2018, 11, 7, 13, 50, 0, 0);
            this.dtpDataSolucao.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // rtbSolucao
            // 
            this.rtbSolucao.Location = new System.Drawing.Point(7, 194);
            this.rtbSolucao.Name = "rtbSolucao";
            this.rtbSolucao.Size = new System.Drawing.Size(418, 42);
            this.rtbSolucao.TabIndex = 19;
            this.rtbSolucao.Text = "";
            // 
            // lblDataSolucao
            // 
            this.lblDataSolucao.AutoSize = true;
            this.lblDataSolucao.Location = new System.Drawing.Point(7, 137);
            this.lblDataSolucao.Name = "lblDataSolucao";
            this.lblDataSolucao.Size = new System.Drawing.Size(256, 13);
            this.lblDataSolucao.TabIndex = 20;
            this.lblDataSolucao.Text = "Data da solução (em caso de chamado solucionado)";
            this.lblDataSolucao.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblSolucao
            // 
            this.lblSolucao.AutoSize = true;
            this.lblSolucao.Location = new System.Drawing.Point(7, 178);
            this.lblSolucao.Name = "lblSolucao";
            this.lblSolucao.Size = new System.Drawing.Size(46, 13);
            this.lblSolucao.TabIndex = 21;
            this.lblSolucao.Text = "Solução";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(15, 110);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(103, 13);
            this.lbl.TabIndex = 22;
            this.lbl.Text = "Avaliação do cliente";
            // 
            // txbAvaliacao
            // 
            this.txbAvaliacao.Enabled = false;
            this.txbAvaliacao.Location = new System.Drawing.Point(56, 126);
            this.txbAvaliacao.Name = "txbAvaliacao";
            this.txbAvaliacao.ReadOnly = true;
            this.txbAvaliacao.Size = new System.Drawing.Size(26, 20);
            this.txbAvaliacao.TabIndex = 23;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(479, 329);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 23);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(479, 400);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox1.Controls.Add(this.lblDataAbertura);
            this.groupBox1.Location = new System.Drawing.Point(6, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 37);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data de abertura";
            // 
            // txbPrioridade
            // 
            this.txbPrioridade.Enabled = false;
            this.txbPrioridade.Location = new System.Drawing.Point(394, 58);
            this.txbPrioridade.Name = "txbPrioridade";
            this.txbPrioridade.ReadOnly = true;
            this.txbPrioridade.Size = new System.Drawing.Size(31, 20);
            this.txbPrioridade.TabIndex = 28;
            // 
            // lblPrioridade
            // 
            this.lblPrioridade.AutoSize = true;
            this.lblPrioridade.Location = new System.Drawing.Point(334, 61);
            this.lblPrioridade.Name = "lblPrioridade";
            this.lblPrioridade.Size = new System.Drawing.Size(54, 13);
            this.lblPrioridade.TabIndex = 27;
            this.lblPrioridade.Text = "Prioridade";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDataAtendimento);
            this.groupBox2.Location = new System.Drawing.Point(6, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 37);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data de atendimento";
            // 
            // lblDataAtendimento
            // 
            this.lblDataAtendimento.AutoSize = true;
            this.lblDataAtendimento.Location = new System.Drawing.Point(6, 16);
            this.lblDataAtendimento.Name = "lblDataAtendimento";
            this.lblDataAtendimento.Size = new System.Drawing.Size(106, 13);
            this.lblDataAtendimento.TabIndex = 10;
            this.lblDataAtendimento.Text = "Data de atendimento";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox3.Controls.Add(this.rtbDescricao);
            this.groupBox3.Controls.Add(this.txbIdChamado);
            this.groupBox3.Controls.Add(this.txbPrioridade);
            this.groupBox3.Controls.Add(this.txbIdCliente);
            this.groupBox3.Controls.Add(this.lblPrioridade);
            this.groupBox3.Controls.Add(this.txbIdProduto);
            this.groupBox3.Controls.Add(this.lblIdChamado);
            this.groupBox3.Controls.Add(this.lblIdCliente);
            this.groupBox3.Controls.Add(this.lblIdProduto);
            this.groupBox3.Controls.Add(this.txbIdFuncionario);
            this.groupBox3.Controls.Add(this.lblIdFuncionario);
            this.groupBox3.Controls.Add(this.lblDescricao);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 157);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.rtbResposta);
            this.groupBox4.Controls.Add(this.cmbTipo);
            this.groupBox4.Controls.Add(this.lblTipo);
            this.groupBox4.Controls.Add(this.cmbStatus);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lblSolucao);
            this.groupBox4.Controls.Add(this.dtpDataSolucao);
            this.groupBox4.Controls.Add(this.lblDataSolucao);
            this.groupBox4.Controls.Add(this.rtbSolucao);
            this.groupBox4.Location = new System.Drawing.Point(12, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(433, 248);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.lbl);
            this.groupBox5.Controls.Add(this.txbAvaliacao);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Location = new System.Drawing.Point(451, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(142, 157);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(479, 283);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 23);
            this.btnLimpar.TabIndex = 33;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // frmDetalheChamado
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(605, 438);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDetalheChamado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes do Chamado";
            this.Load += new System.EventHandler(this.frmDetalheChamado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.Label lblIdChamado;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Label lblIdProduto;
        public System.Windows.Forms.RichTextBox rtbResposta;
        private System.Windows.Forms.Label lblIdFuncionario;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txbIdChamado;
        public System.Windows.Forms.TextBox txbIdCliente;
        public System.Windows.Forms.TextBox txbIdProduto;
        public System.Windows.Forms.TextBox txbIdFuncionario;
        public System.Windows.Forms.RichTextBox rtbSolucao;
        private System.Windows.Forms.Label lblDataSolucao;
        private System.Windows.Forms.Label lblSolucao;
        private System.Windows.Forms.Label lbl;
        public System.Windows.Forms.TextBox txbAvaliacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblDataAbertura;
        public System.Windows.Forms.ComboBox cmbTipo;
        public System.Windows.Forms.ComboBox cmbStatus;
        public System.Windows.Forms.DateTimePicker dtpDataSolucao;
        public System.Windows.Forms.TextBox txbPrioridade;
        private System.Windows.Forms.Label lblPrioridade;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lblDataAtendimento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnLimpar;
    }
}