﻿namespace GradeDeHorario
{
    partial class frmFase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFase));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.tbFase = new System.Windows.Forms.TableLayoutPanel();
            this.dtgDisciplinaFase = new System.Windows.Forms.DataGridView();
            this.CODIGO_DISCIPLINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_DISCIPLINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREDITO_DISCIPLINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbbFase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgListaDisciplina = new System.Windows.Forms.DataGridView();
            this.CODIGO_DISCIPLINA_FASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_DISCIPLINA_FASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREDITO_DISCIPLINA_FASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisaDisciplina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tbFase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisciplinaFase)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCancelar,
            this.btnSalvar,
            this.btnEditar,
            this.btnExcluir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(852, 69);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // btnEditar
            // 
            this.btnEditar.Image = global::GradeDeHorario.Properties.Resources.ic_edit;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(44, 63);
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::GradeDeHorario.Properties.Resources.ic_delete;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(48, 59);
            this.btnExcluir.Text = "Limpar";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.ToolTipText = "Limpar as disciplina da fase selecionada";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // tbFase
            // 
            this.tbFase.ColumnCount = 3;
            this.tbFase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tbFase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbFase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tbFase.Controls.Add(this.dtgDisciplinaFase, 0, 1);
            this.tbFase.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tbFase.Controls.Add(this.dtgListaDisciplina, 2, 2);
            this.tbFase.Controls.Add(this.txtPesquisaDisciplina, 2, 1);
            this.tbFase.Controls.Add(this.label2, 2, 0);
            this.tbFase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFase.Location = new System.Drawing.Point(0, 69);
            this.tbFase.Name = "tbFase";
            this.tbFase.Padding = new System.Windows.Forms.Padding(3);
            this.tbFase.RowCount = 3;
            this.tbFase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbFase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbFase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbFase.Size = new System.Drawing.Size(852, 425);
            this.tbFase.TabIndex = 1;
            // 
            // dtgDisciplinaFase
            // 
            this.dtgDisciplinaFase.AllowUserToAddRows = false;
            this.dtgDisciplinaFase.AllowUserToDeleteRows = false;
            this.dtgDisciplinaFase.AllowUserToResizeColumns = false;
            this.dtgDisciplinaFase.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgDisciplinaFase.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDisciplinaFase.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgDisciplinaFase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDisciplinaFase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDisciplinaFase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDisciplinaFase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO_DISCIPLINA,
            this.NOME_DISCIPLINA,
            this.CREDITO_DISCIPLINA});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDisciplinaFase.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgDisciplinaFase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDisciplinaFase.Enabled = false;
            this.dtgDisciplinaFase.Location = new System.Drawing.Point(6, 36);
            this.dtgDisciplinaFase.Name = "dtgDisciplinaFase";
            this.dtgDisciplinaFase.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDisciplinaFase.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgDisciplinaFase.RowHeadersVisible = false;
            this.dtgDisciplinaFase.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tbFase.SetRowSpan(this.dtgDisciplinaFase, 2);
            this.dtgDisciplinaFase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgDisciplinaFase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDisciplinaFase.Size = new System.Drawing.Size(489, 383);
            this.dtgDisciplinaFase.TabIndex = 0;
            this.dtgDisciplinaFase.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDisciplinaFase_CellDoubleClick);
            // 
            // CODIGO_DISCIPLINA
            // 
            this.CODIGO_DISCIPLINA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CODIGO_DISCIPLINA.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA.HeaderText = "Código";
            this.CODIGO_DISCIPLINA.Name = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA.ReadOnly = true;
            this.CODIGO_DISCIPLINA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CODIGO_DISCIPLINA.Width = 70;
            // 
            // NOME_DISCIPLINA
            // 
            this.NOME_DISCIPLINA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOME_DISCIPLINA.DataPropertyName = "NOME_DISCIPLINA";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NOME_DISCIPLINA.DefaultCellStyle = dataGridViewCellStyle3;
            this.NOME_DISCIPLINA.HeaderText = "Disciplina";
            this.NOME_DISCIPLINA.Name = "NOME_DISCIPLINA";
            this.NOME_DISCIPLINA.ReadOnly = true;
            // 
            // CREDITO_DISCIPLINA
            // 
            this.CREDITO_DISCIPLINA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CREDITO_DISCIPLINA.DataPropertyName = "CREDITO_DISCIPLINA";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CREDITO_DISCIPLINA.DefaultCellStyle = dataGridViewCellStyle4;
            this.CREDITO_DISCIPLINA.HeaderText = "Créditos";
            this.CREDITO_DISCIPLINA.Name = "CREDITO_DISCIPLINA";
            this.CREDITO_DISCIPLINA.ReadOnly = true;
            this.CREDITO_DISCIPLINA.Width = 75;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.cbbFase, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 24);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // cbbFase
            // 
            this.cbbFase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbFase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFase.FormattingEnabled = true;
            this.cbbFase.Location = new System.Drawing.Point(100, 3);
            this.cbbFase.Name = "cbbFase";
            this.cbbFase.Size = new System.Drawing.Size(386, 21);
            this.cbbFase.TabIndex = 0;
            this.cbbFase.SelectedIndexChanged += new System.EventHandler(this.cbbFase_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fase";
            // 
            // dtgListaDisciplina
            // 
            this.dtgListaDisciplina.AllowUserToAddRows = false;
            this.dtgListaDisciplina.AllowUserToDeleteRows = false;
            this.dtgListaDisciplina.AllowUserToOrderColumns = true;
            this.dtgListaDisciplina.AllowUserToResizeColumns = false;
            this.dtgListaDisciplina.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgListaDisciplina.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgListaDisciplina.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgListaDisciplina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListaDisciplina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgListaDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaDisciplina.ColumnHeadersVisible = false;
            this.dtgListaDisciplina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO_DISCIPLINA_FASE,
            this.NOME_DISCIPLINA_FASE,
            this.CREDITO_DISCIPLINA_FASE});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgListaDisciplina.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgListaDisciplina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgListaDisciplina.Enabled = false;
            this.dtgListaDisciplina.Location = new System.Drawing.Point(521, 66);
            this.dtgListaDisciplina.Name = "dtgListaDisciplina";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListaDisciplina.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgListaDisciplina.RowHeadersVisible = false;
            this.dtgListaDisciplina.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgListaDisciplina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListaDisciplina.Size = new System.Drawing.Size(325, 353);
            this.dtgListaDisciplina.TabIndex = 1;
            this.dtgListaDisciplina.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListaDisciplina_CellDoubleClick);
            // 
            // CODIGO_DISCIPLINA_FASE
            // 
            this.CODIGO_DISCIPLINA_FASE.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_FASE.HeaderText = "Código";
            this.CODIGO_DISCIPLINA_FASE.Name = "CODIGO_DISCIPLINA_FASE";
            this.CODIGO_DISCIPLINA_FASE.ReadOnly = true;
            // 
            // NOME_DISCIPLINA_FASE
            // 
            this.NOME_DISCIPLINA_FASE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOME_DISCIPLINA_FASE.DataPropertyName = "NOME_DISCIPLINA";
            this.NOME_DISCIPLINA_FASE.HeaderText = "Disciplina";
            this.NOME_DISCIPLINA_FASE.Name = "NOME_DISCIPLINA_FASE";
            this.NOME_DISCIPLINA_FASE.ReadOnly = true;
            this.NOME_DISCIPLINA_FASE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CREDITO_DISCIPLINA_FASE
            // 
            this.CREDITO_DISCIPLINA_FASE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CREDITO_DISCIPLINA_FASE.DataPropertyName = "CREDITO_DISCIPLINA";
            this.CREDITO_DISCIPLINA_FASE.HeaderText = "Crédito";
            this.CREDITO_DISCIPLINA_FASE.Name = "CREDITO_DISCIPLINA_FASE";
            this.CREDITO_DISCIPLINA_FASE.Visible = false;
            // 
            // txtPesquisaDisciplina
            // 
            this.txtPesquisaDisciplina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisaDisciplina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPesquisaDisciplina.Location = new System.Drawing.Point(521, 36);
            this.txtPesquisaDisciplina.Name = "txtPesquisaDisciplina";
            this.txtPesquisaDisciplina.Size = new System.Drawing.Size(325, 22);
            this.txtPesquisaDisciplina.TabIndex = 3;
            this.txtPesquisaDisciplina.TextChanged += new System.EventHandler(this.txtPesquisaDisciplina_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(521, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pesquisa de disciplinas:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmFase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 494);
            this.Controls.Add(this.tbFase);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(868, 490);
            this.Name = "frmFase";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fase";
            this.Load += new System.EventHandler(this.frmFase_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tbFase.ResumeLayout(false);
            this.tbFase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisciplinaFase)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaDisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.TableLayoutPanel tbFase;
        private System.Windows.Forms.DataGridView dtgDisciplinaFase;
        private System.Windows.Forms.DataGridView dtgListaDisciplina;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbbFase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.TextBox txtPesquisaDisciplina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_DISCIPLINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREDITO_DISCIPLINA;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_FASE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_DISCIPLINA_FASE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREDITO_DISCIPLINA_FASE;
    }
}