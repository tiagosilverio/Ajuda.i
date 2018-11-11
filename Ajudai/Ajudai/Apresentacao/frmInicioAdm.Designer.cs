namespace Ajudai.Apresentacao
{
    partial class frmInicioAdm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogoffAdm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFecharAdm = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbcChamados = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrioridade = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnAtualizarAbertos = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblDica = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvChamadosAbertos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtualizarConcluidos = new System.Windows.Forms.Button();
            this.dgvChamadosConcluidos = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tbcChamados.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamadosAbertos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamadosConcluidos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(566, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLogoffAdm,
            this.tsmFecharAdm});
            this.sistemaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // tsmLogoffAdm
            // 
            this.tsmLogoffAdm.Name = "tsmLogoffAdm";
            this.tsmLogoffAdm.Size = new System.Drawing.Size(109, 22);
            this.tsmLogoffAdm.Text = "Logoff";
            this.tsmLogoffAdm.Click += new System.EventHandler(this.tsmLogoffAdm_Click);
            // 
            // tsmFecharAdm
            // 
            this.tsmFecharAdm.Name = "tsmFecharAdm";
            this.tsmFecharAdm.Size = new System.Drawing.Size(109, 22);
            this.tsmFecharAdm.Text = "Fechar";
            this.tsmFecharAdm.Click += new System.EventHandler(this.tsmFecharAdm_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastrar,
            this.tsmPesquisar});
            this.usuáriosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.usuáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // tsmCadastrar
            // 
            this.tsmCadastrar.Name = "tsmCadastrar";
            this.tsmCadastrar.Size = new System.Drawing.Size(190, 22);
            this.tsmCadastrar.Text = "Cadastrar Funcionário";
            this.tsmCadastrar.Click += new System.EventHandler(this.cadastrarUsuárioToolStripMenuItem_Click);
            // 
            // tsmPesquisar
            // 
            this.tsmPesquisar.Name = "tsmPesquisar";
            this.tsmPesquisar.Size = new System.Drawing.Size(190, 22);
            this.tsmPesquisar.Text = "Pesquisar Funcionário";
            this.tsmPesquisar.Click += new System.EventHandler(this.pesquisarToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // pesquisarClienteToolStripMenuItem
            // 
            this.pesquisarClienteToolStripMenuItem.Name = "pesquisarClienteToolStripMenuItem";
            this.pesquisarClienteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.pesquisarClienteToolStripMenuItem.Text = "Lista de Clientes";
            this.pesquisarClienteToolStripMenuItem.Click += new System.EventHandler(this.pesquisarClienteToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.pesquisarToolStripMenuItem});
            this.produtosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar Produto";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar Produto";
            this.pesquisarToolStripMenuItem.Click += new System.EventHandler(this.pesquisarToolStripMenuItem_Click_1);
            // 
            // tbcChamados
            // 
            this.tbcChamados.Controls.Add(this.tabPage1);
            this.tbcChamados.Controls.Add(this.tabPage2);
            this.tbcChamados.Location = new System.Drawing.Point(12, 36);
            this.tbcChamados.Name = "tbcChamados";
            this.tbcChamados.SelectedIndex = 0;
            this.tbcChamados.Size = new System.Drawing.Size(542, 386);
            this.tbcChamados.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblPrioridade);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.btnAtualizarAbertos);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.lblDica);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.dgvChamadosAbertos);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(534, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chamados em Aberto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(252, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Funcionário responsável";
            // 
            // lblPrioridade
            // 
            this.lblPrioridade.AutoSize = true;
            this.lblPrioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrioridade.Location = new System.Drawing.Point(132, 247);
            this.lblPrioridade.Name = "lblPrioridade";
            this.lblPrioridade.Size = new System.Drawing.Size(64, 15);
            this.lblPrioridade.TabIndex = 6;
            this.lblPrioridade.Text = "Prioridade";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(135, 265);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // btnAtualizarAbertos
            // 
            this.btnAtualizarAbertos.Location = new System.Drawing.Point(26, 322);
            this.btnAtualizarAbertos.Name = "btnAtualizarAbertos";
            this.btnAtualizarAbertos.Size = new System.Drawing.Size(112, 23);
            this.btnAtualizarAbertos.TabIndex = 4;
            this.btnAtualizarAbertos.Text = "Atualizar Lista";
            this.btnAtualizarAbertos.UseVisualStyleBackColor = true;
            this.btnAtualizarAbertos.Click += new System.EventHandler(this.btnAtualizarAbertos_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(395, 322);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Salvar Alterações";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDica.Location = new System.Drawing.Point(266, 14);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(262, 15);
            this.lblDica.TabIndex = 2;
            this.lblDica.Text = "Dê um clique duplo para visualizar os detalhes";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(255, 264);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // dgvChamadosAbertos
            // 
            this.dgvChamadosAbertos.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvChamadosAbertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamadosAbertos.Location = new System.Drawing.Point(6, 32);
            this.dgvChamadosAbertos.Name = "dgvChamadosAbertos";
            this.dgvChamadosAbertos.Size = new System.Drawing.Size(522, 202);
            this.dgvChamadosAbertos.TabIndex = 0;
            this.dgvChamadosAbertos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamadosAbertos_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnAtualizarConcluidos);
            this.tabPage2.Controls.Add(this.dgvChamadosConcluidos);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(534, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chamados Concluídos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(266, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dê um clique duplo para visualizar os detalhes";
            // 
            // btnAtualizarConcluidos
            // 
            this.btnAtualizarConcluidos.Location = new System.Drawing.Point(205, 316);
            this.btnAtualizarConcluidos.Name = "btnAtualizarConcluidos";
            this.btnAtualizarConcluidos.Size = new System.Drawing.Size(112, 23);
            this.btnAtualizarConcluidos.TabIndex = 5;
            this.btnAtualizarConcluidos.Text = "Atualizar Lista";
            this.btnAtualizarConcluidos.UseVisualStyleBackColor = true;
            // 
            // dgvChamadosConcluidos
            // 
            this.dgvChamadosConcluidos.AllowUserToAddRows = false;
            this.dgvChamadosConcluidos.AllowUserToDeleteRows = false;
            this.dgvChamadosConcluidos.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvChamadosConcluidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamadosConcluidos.Location = new System.Drawing.Point(6, 32);
            this.dgvChamadosConcluidos.Name = "dgvChamadosConcluidos";
            this.dgvChamadosConcluidos.ReadOnly = true;
            this.dgvChamadosConcluidos.Size = new System.Drawing.Size(522, 241);
            this.dgvChamadosConcluidos.TabIndex = 0;
            this.dgvChamadosConcluidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamadosConcluidos_CellDoubleClick);
            // 
            // frmInicioAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(566, 434);
            this.Controls.Add(this.tbcChamados);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmInicioAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio: Administrador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbcChamados.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamadosAbertos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamadosConcluidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrar;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmLogoffAdm;
        private System.Windows.Forms.ToolStripMenuItem tsmFecharAdm;
        private System.Windows.Forms.ToolStripMenuItem tsmPesquisar;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.TabControl tbcChamados;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAtualizarAbertos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblDica;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvChamadosAbertos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvChamadosConcluidos;
        private System.Windows.Forms.Label lblPrioridade;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtualizarConcluidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarClienteToolStripMenuItem;
    }
}