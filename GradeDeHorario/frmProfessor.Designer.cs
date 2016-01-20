namespace GradeDeHorario
{
    partial class frmProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfessor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgProfessor = new System.Windows.Forms.DataGridView();
            this.CODIGO_PROFESSOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_PROFESSOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_DEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbProfessor = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoProfessor = new System.Windows.Forms.TextBox();
            this.txtNomeProfessor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbDepartamento = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfessor)).BeginInit();
            this.gbProfessor.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(639, 69);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::GradeDeHorario.Properties.Resources.ic_new;
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
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
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 59);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.ToolTipText = "Cancelar cadastro do novo professor";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelarEdicao_Click);
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
            this.btnSalvar.ToolTipText = "Salvar o cadastro do novo professor";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvarEdicao_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
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
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dtgProfessor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbProfessor, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(639, 399);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dtgProfessor
            // 
            this.dtgProfessor.AllowUserToAddRows = false;
            this.dtgProfessor.AllowUserToDeleteRows = false;
            this.dtgProfessor.AllowUserToResizeColumns = false;
            this.dtgProfessor.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            this.dtgProfessor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProfessor.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgProfessor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProfessor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProfessor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO_PROFESSOR,
            this.NOME_PROFESSOR,
            this.NOME_DEPARTAMENTO,
            this.CODIGO_DEPARTAMENTO});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProfessor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgProfessor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgProfessor.Location = new System.Drawing.Point(5, 115);
            this.dtgProfessor.Margin = new System.Windows.Forms.Padding(5);
            this.dtgProfessor.Name = "dtgProfessor";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProfessor.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgProfessor.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgProfessor.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgProfessor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProfessor.Size = new System.Drawing.Size(629, 279);
            this.dtgProfessor.TabIndex = 2;
            this.dtgProfessor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProfessor_CellDoubleClick);
            // 
            // CODIGO_PROFESSOR
            // 
            this.CODIGO_PROFESSOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_PROFESSOR.DataPropertyName = "CODIGO_PROFESSOR";
            this.CODIGO_PROFESSOR.HeaderText = "Código";
            this.CODIGO_PROFESSOR.Name = "CODIGO_PROFESSOR";
            this.CODIGO_PROFESSOR.ReadOnly = true;
            this.CODIGO_PROFESSOR.Width = 70;
            // 
            // NOME_PROFESSOR
            // 
            this.NOME_PROFESSOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOME_PROFESSOR.DataPropertyName = "NOME_PROFESSOR";
            this.NOME_PROFESSOR.HeaderText = "Nome";
            this.NOME_PROFESSOR.Name = "NOME_PROFESSOR";
            this.NOME_PROFESSOR.ReadOnly = true;
            // 
            // NOME_DEPARTAMENTO
            // 
            this.NOME_DEPARTAMENTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NOME_DEPARTAMENTO.DataPropertyName = "NOME_DEPARTAMENTO";
            this.NOME_DEPARTAMENTO.HeaderText = "Departamento";
            this.NOME_DEPARTAMENTO.MinimumWidth = 200;
            this.NOME_DEPARTAMENTO.Name = "NOME_DEPARTAMENTO";
            this.NOME_DEPARTAMENTO.ReadOnly = true;
            this.NOME_DEPARTAMENTO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NOME_DEPARTAMENTO.Width = 200;
            // 
            // CODIGO_DEPARTAMENTO
            // 
            this.CODIGO_DEPARTAMENTO.DataPropertyName = "CODIGO_DEPARTAMENTO";
            this.CODIGO_DEPARTAMENTO.HeaderText = "idDepto";
            this.CODIGO_DEPARTAMENTO.Name = "CODIGO_DEPARTAMENTO";
            this.CODIGO_DEPARTAMENTO.Visible = false;
            // 
            // gbProfessor
            // 
            this.gbProfessor.Controls.Add(this.tableLayoutPanel2);
            this.gbProfessor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProfessor.Enabled = false;
            this.gbProfessor.Location = new System.Drawing.Point(5, 5);
            this.gbProfessor.Margin = new System.Windows.Forms.Padding(5);
            this.gbProfessor.Name = "gbProfessor";
            this.gbProfessor.Size = new System.Drawing.Size(629, 100);
            this.gbProfessor.TabIndex = 3;
            this.gbProfessor.TabStop = false;
            this.gbProfessor.Text = "Cadastro de professor";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtCodigoProfessor, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNomeProfessor, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbbDepartamento, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(623, 79);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // txtCodigoProfessor
            // 
            this.txtCodigoProfessor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoProfessor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigoProfessor.Location = new System.Drawing.Point(93, 3);
            this.txtCodigoProfessor.Name = "txtCodigoProfessor";
            this.txtCodigoProfessor.Size = new System.Drawing.Size(94, 22);
            this.txtCodigoProfessor.TabIndex = 3;
            // 
            // txtNomeProfessor
            // 
            this.txtNomeProfessor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel2.SetColumnSpan(this.txtNomeProfessor, 3);
            this.txtNomeProfessor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNomeProfessor.Location = new System.Drawing.Point(93, 29);
            this.txtNomeProfessor.Name = "txtNomeProfessor";
            this.txtNomeProfessor.Size = new System.Drawing.Size(527, 22);
            this.txtNomeProfessor.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Departamento:";
            // 
            // cbbDepartamento
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbbDepartamento, 2);
            this.cbbDepartamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDepartamento.FormattingEnabled = true;
            this.cbbDepartamento.Location = new System.Drawing.Point(93, 55);
            this.cbbDepartamento.Name = "cbbDepartamento";
            this.cbbDepartamento.Size = new System.Drawing.Size(364, 21);
            this.cbbDepartamento.TabIndex = 5;
            // 
            // frmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 468);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(655, 507);
            this.Name = "frmProfessor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Professor";
            this.Load += new System.EventHandler(this.frmProfessor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfessor)).EndInit();
            this.gbProfessor.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtNomeProfessor;
        private System.Windows.Forms.ComboBox cbbDepartamento;
        private System.Windows.Forms.TextBox txtCodigoProfessor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dtgProfessor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.GroupBox gbProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_PROFESSOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_DEPARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DEPARTAMENTO;
    }
}