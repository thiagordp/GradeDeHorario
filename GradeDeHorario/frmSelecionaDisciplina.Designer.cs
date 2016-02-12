namespace GradeDeHorario
{
    partial class frmSelecionaDisciplina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelecionaDisciplina));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgSelecionaDisciplina = new System.Windows.Forms.DataGridView();
            this.SELECIONA_DISCIPLINA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CODIGO_DISCIPLINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_DISCIPLINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnLimpar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSelecionaDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalvar,
            this.btnLimpar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStrip1.Size = new System.Drawing.Size(434, 72);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dtgSelecionaDisciplina, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 219);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dtgSelecionaDisciplina
            // 
            this.dtgSelecionaDisciplina.AllowUserToAddRows = false;
            this.dtgSelecionaDisciplina.AllowUserToDeleteRows = false;
            this.dtgSelecionaDisciplina.AllowUserToResizeColumns = false;
            this.dtgSelecionaDisciplina.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgSelecionaDisciplina.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgSelecionaDisciplina.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgSelecionaDisciplina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgSelecionaDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSelecionaDisciplina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SELECIONA_DISCIPLINA,
            this.CODIGO_DISCIPLINA,
            this.NOME_DISCIPLINA});
            this.tableLayoutPanel1.SetColumnSpan(this.dtgSelecionaDisciplina, 2);
            this.dtgSelecionaDisciplina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgSelecionaDisciplina.Location = new System.Drawing.Point(10, 10);
            this.dtgSelecionaDisciplina.Margin = new System.Windows.Forms.Padding(10);
            this.dtgSelecionaDisciplina.Name = "dtgSelecionaDisciplina";
            this.dtgSelecionaDisciplina.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.dtgSelecionaDisciplina, 2);
            this.dtgSelecionaDisciplina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSelecionaDisciplina.Size = new System.Drawing.Size(414, 199);
            this.dtgSelecionaDisciplina.TabIndex = 0;
            // 
            // SELECIONA_DISCIPLINA
            // 
            this.SELECIONA_DISCIPLINA.HeaderText = "";
            this.SELECIONA_DISCIPLINA.Name = "SELECIONA_DISCIPLINA";
            this.SELECIONA_DISCIPLINA.Width = 25;
            // 
            // CODIGO_DISCIPLINA
            // 
            this.CODIGO_DISCIPLINA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA.HeaderText = "Código";
            this.CODIGO_DISCIPLINA.Name = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA.ReadOnly = true;
            this.CODIGO_DISCIPLINA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CODIGO_DISCIPLINA.Width = 65;
            // 
            // NOME_DISCIPLINA
            // 
            this.NOME_DISCIPLINA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOME_DISCIPLINA.DataPropertyName = "NOME_DISCIPLINA";
            this.NOME_DISCIPLINA.HeaderText = "Nome";
            this.NOME_DISCIPLINA.Name = "NOME_DISCIPLINA";
            this.NOME_DISCIPLINA.ReadOnly = true;
            this.NOME_DISCIPLINA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::GradeDeHorario.Properties.Resources.ic_button;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(44, 59);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::GradeDeHorario.Properties.Resources.ic_clean;
            this.btnLimpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(48, 62);
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmSelecionaDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 291);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 330);
            this.Name = "frmSelecionaDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSelecionaDisciplina";
            this.Load += new System.EventHandler(this.frmSelecionaDisciplina_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSelecionaDisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnLimpar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dtgSelecionaDisciplina;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECIONA_DISCIPLINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_DISCIPLINA;
    }
}