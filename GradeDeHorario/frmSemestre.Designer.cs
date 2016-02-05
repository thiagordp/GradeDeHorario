namespace GradeDeHorario
{
    partial class frmSemestre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSemestre));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbSemestre = new System.Windows.Forms.GroupBox();
            this.tblDado = new System.Windows.Forms.TableLayoutPanel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dtgSemestre = new System.Windows.Forms.DataGridView();
            this.SEQ_SEMESTRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_SEMESTRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbSemestre.SuspendLayout();
            this.tblDado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSemestre)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnCancelar,
            this.btnSalvar,
            this.btnExcluir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(255, 69);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::GradeDeHorario.Properties.Resources.ic_new;
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(44, 59);
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = global::GradeDeHorario.Properties.Resources.ic_menu_close;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 59);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = global::GradeDeHorario.Properties.Resources.ic_button;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(44, 59);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::GradeDeHorario.Properties.Resources.ic_delete;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(45, 59);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbSemestre, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtgSemestre, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 69);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(255, 220);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gbSemestre
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbSemestre, 2);
            this.gbSemestre.Controls.Add(this.tblDado);
            this.gbSemestre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSemestre.Enabled = false;
            this.gbSemestre.Location = new System.Drawing.Point(8, 8);
            this.gbSemestre.Name = "gbSemestre";
            this.gbSemestre.Size = new System.Drawing.Size(239, 74);
            this.gbSemestre.TabIndex = 2;
            this.gbSemestre.TabStop = false;
            this.gbSemestre.Text = "Semestre";
            // 
            // tblDado
            // 
            this.tblDado.ColumnCount = 2;
            this.tblDado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblDado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDado.Controls.Add(this.txtNome, 1, 1);
            this.tblDado.Controls.Add(this.label2, 0, 1);
            this.tblDado.Controls.Add(this.label1, 0, 0);
            this.tblDado.Controls.Add(this.txtCodigo, 1, 0);
            this.tblDado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDado.Location = new System.Drawing.Point(3, 16);
            this.tblDado.Name = "tblDado";
            this.tblDado.RowCount = 2;
            this.tblDado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDado.Size = new System.Drawing.Size(233, 55);
            this.tblDado.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNome.Location = new System.Drawing.Point(53, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(177, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(53, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(177, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // dtgSemestre
            // 
            this.dtgSemestre.AllowUserToAddRows = false;
            this.dtgSemestre.AllowUserToDeleteRows = false;
            this.dtgSemestre.AllowUserToResizeColumns = false;
            this.dtgSemestre.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgSemestre.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgSemestre.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgSemestre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgSemestre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSemestre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SEQ_SEMESTRE,
            this.NOME_SEMESTRE});
            this.tableLayoutPanel1.SetColumnSpan(this.dtgSemestre, 2);
            this.dtgSemestre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgSemestre.Location = new System.Drawing.Point(10, 90);
            this.dtgSemestre.Margin = new System.Windows.Forms.Padding(5);
            this.dtgSemestre.Name = "dtgSemestre";
            this.dtgSemestre.ReadOnly = true;
            this.dtgSemestre.RowHeadersVisible = false;
            this.dtgSemestre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgSemestre.Size = new System.Drawing.Size(235, 120);
            this.dtgSemestre.TabIndex = 1;
            this.dtgSemestre.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSemestre_CellDoubleClick);
            // 
            // SEQ_SEMESTRE
            // 
            this.SEQ_SEMESTRE.DataPropertyName = "SEQ_SEMESTRE";
            this.SEQ_SEMESTRE.HeaderText = "Código";
            this.SEQ_SEMESTRE.Name = "SEQ_SEMESTRE";
            this.SEQ_SEMESTRE.ReadOnly = true;
            this.SEQ_SEMESTRE.Visible = false;
            // 
            // NOME_SEMESTRE
            // 
            this.NOME_SEMESTRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOME_SEMESTRE.DataPropertyName = "NOME_SEMESTRE";
            this.NOME_SEMESTRE.HeaderText = "Nome";
            this.NOME_SEMESTRE.Name = "NOME_SEMESTRE";
            this.NOME_SEMESTRE.ReadOnly = true;
            this.NOME_SEMESTRE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // frmSemestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 289);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 328);
            this.MinimumSize = new System.Drawing.Size(233, 328);
            this.Name = "frmSemestre";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semestres";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbSemestre.ResumeLayout(false);
            this.tblDado.ResumeLayout(false);
            this.tblDado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSemestre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tblDado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dtgSemestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_TURMA;
        private System.Windows.Forms.GroupBox gbSemestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEQ_SEMESTRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_SEMESTRE;
    }
}