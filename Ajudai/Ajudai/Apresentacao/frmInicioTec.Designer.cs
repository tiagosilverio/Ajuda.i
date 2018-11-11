namespace Ajudai.Apresentacao
{
    partial class frmInicioTec
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogoffTec = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFecharTec = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbcChamados = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAtualizarAbertos = new System.Windows.Forms.Button();
            this.lblDica = new System.Windows.Forms.Label();
            this.dgvChamadosAbertos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtualizarConcluidos = new System.Windows.Forms.Button();
            this.dgvChamadosConcluidos = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tbcChamados.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.clientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(566, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLogoffTec,
            this.tsmFecharTec});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // tsmLogoffTec
            // 
            this.tsmLogoffTec.Name = "tsmLogoffTec";
            this.tsmLogoffTec.Size = new System.Drawing.Size(109, 22);
            this.tsmLogoffTec.Text = "Logoff";
            this.tsmLogoffTec.Click += new System.EventHandler(this.tsmLogoffTec_Click);
            // 
            // tsmFecharTec
            // 
            this.tsmFecharTec.Name = "tsmFecharTec";
            this.tsmFecharTec.Size = new System.Drawing.Size(109, 22);
            this.tsmFecharTec.Text = "Fechar";
            this.tsmFecharTec.Click += new System.EventHandler(this.tsmFecharTec_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // listaDeClientesToolStripMenuItem
            // 
            this.listaDeClientesToolStripMenuItem.Name = "listaDeClientesToolStripMenuItem";
            this.listaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.listaDeClientesToolStripMenuItem.Text = "Lista de Clientes";
            // 
            // tbcChamados
            // 
            this.tbcChamados.Controls.Add(this.tabPage1);
            this.tbcChamados.Controls.Add(this.tabPage2);
            this.tbcChamados.Location = new System.Drawing.Point(12, 36);
            this.tbcChamados.Name = "tbcChamados";
            this.tbcChamados.SelectedIndex = 0;
            this.tbcChamados.Size = new System.Drawing.Size(542, 386);
            this.tbcChamados.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.btnAtualizarAbertos);
            this.tabPage1.Controls.Add(this.lblDica);
            this.tabPage1.Controls.Add(this.dgvChamadosAbertos);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(534, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chamados em Aberto";
            // 
            // btnAtualizarAbertos
            // 
            this.btnAtualizarAbertos.Location = new System.Drawing.Point(205, 316);
            this.btnAtualizarAbertos.Name = "btnAtualizarAbertos";
            this.btnAtualizarAbertos.Size = new System.Drawing.Size(112, 23);
            this.btnAtualizarAbertos.TabIndex = 4;
            this.btnAtualizarAbertos.Text = "Atualizar Lista";
            this.btnAtualizarAbertos.UseVisualStyleBackColor = true;
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
            // dgvChamadosAbertos
            // 
            this.dgvChamadosAbertos.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChamadosAbertos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChamadosAbertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChamadosAbertos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChamadosAbertos.Location = new System.Drawing.Point(6, 32);
            this.dgvChamadosAbertos.Name = "dgvChamadosAbertos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChamadosAbertos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChamadosAbertos.Size = new System.Drawing.Size(522, 241);
            this.dgvChamadosAbertos.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.label1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(266, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dê um clique duplo para visualizar os detalhes";
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChamadosConcluidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChamadosConcluidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChamadosConcluidos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvChamadosConcluidos.Location = new System.Drawing.Point(6, 32);
            this.dgvChamadosConcluidos.Name = "dgvChamadosConcluidos";
            this.dgvChamadosConcluidos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChamadosConcluidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvChamadosConcluidos.Size = new System.Drawing.Size(522, 241);
            this.dgvChamadosConcluidos.TabIndex = 0;
            this.dgvChamadosConcluidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // frmInicioTec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(566, 434);
            this.Controls.Add(this.tbcChamados);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInicioTec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio: Técnico";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbcChamados.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamadosAbertos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamadosConcluidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmLogoffTec;
        private System.Windows.Forms.ToolStripMenuItem tsmFecharTec;
        private System.Windows.Forms.TabControl tbcChamados;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAtualizarAbertos;
        private System.Windows.Forms.Label lblDica;
        private System.Windows.Forms.DataGridView dgvChamadosAbertos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAtualizarConcluidos;
        private System.Windows.Forms.DataGridView dgvChamadosConcluidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeClientesToolStripMenuItem;
    }
}