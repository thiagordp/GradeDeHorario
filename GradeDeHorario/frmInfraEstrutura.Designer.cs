namespace GradeDeHorario
{
    partial class frmInfraEstrutura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfraEstrutura));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbSala = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nudNumComputador = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudCapacidade = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.chkInternet = new System.Windows.Forms.CheckBox();
            this.chkProjetor = new System.Windows.Forms.CheckBox();
            this.chkQuadroVidro = new System.Windows.Forms.CheckBox();
            this.chkQuadroBranco = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdentificacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTipoEspaco = new System.Windows.Forms.ComboBox();
            this.dtgInfraestrutura = new System.Windows.Forms.DataGridView();
            this.CODIGO_ESPACO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_ESPACO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAPACIDADE_ESPACO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPUTADOR_ESPACO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INTERNET_ESPACO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PROJETOR_ESPACO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QUADRO_BRANCO_ESPACO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QUADRO_VIDRO_ESPACO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DISCIPLINA_TURMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbSala.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumComputador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfraestrutura)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(804, 69);
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
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 66);
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
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(45, 66);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbSala, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtgInfraestrutura, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 372);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gbSala
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbSala, 2);
            this.gbSala.Controls.Add(this.tableLayoutPanel2);
            this.gbSala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSala.Enabled = false;
            this.gbSala.Location = new System.Drawing.Point(5, 5);
            this.gbSala.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.gbSala.Name = "gbSala";
            this.gbSala.Padding = new System.Windows.Forms.Padding(0);
            this.gbSala.Size = new System.Drawing.Size(794, 95);
            this.gbSala.TabIndex = 3;
            this.gbSala.TabStop = false;
            this.gbSala.Text = "Cadastro de sala ou laboratório";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.54386F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.54386F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.54386F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.68421F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.68421F));
            this.tableLayoutPanel2.Controls.Add(this.nudNumComputador, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.nudCapacidade, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.chkInternet, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.chkProjetor, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.chkQuadroVidro, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.chkQuadroBranco, 6, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtIdentificacao, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbbTipoEspaco, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 15);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 80);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // nudNumComputador
            // 
            this.nudNumComputador.Location = new System.Drawing.Point(336, 55);
            this.nudNumComputador.Name = "nudNumComputador";
            this.nudNumComputador.Size = new System.Drawing.Size(99, 22);
            this.nudNumComputador.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capacidade:";
            // 
            // nudCapacidade
            // 
            this.nudCapacidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudCapacidade.Location = new System.Drawing.Point(98, 55);
            this.nudCapacidade.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudCapacidade.Name = "nudCapacidade";
            this.nudCapacidade.Size = new System.Drawing.Size(113, 22);
            this.nudCapacidade.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Computadores:";
            // 
            // chkInternet
            // 
            this.chkInternet.AutoSize = true;
            this.chkInternet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkInternet.Location = new System.Drawing.Point(482, 29);
            this.chkInternet.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.chkInternet.Name = "chkInternet";
            this.chkInternet.Size = new System.Drawing.Size(147, 20);
            this.chkInternet.TabIndex = 11;
            this.chkInternet.Text = "Internet";
            this.chkInternet.UseVisualStyleBackColor = true;
            // 
            // chkProjetor
            // 
            this.chkProjetor.AutoSize = true;
            this.chkProjetor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkProjetor.Location = new System.Drawing.Point(482, 55);
            this.chkProjetor.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.chkProjetor.Name = "chkProjetor";
            this.chkProjetor.Size = new System.Drawing.Size(147, 22);
            this.chkProjetor.TabIndex = 12;
            this.chkProjetor.Text = "Projetor";
            this.chkProjetor.UseVisualStyleBackColor = true;
            // 
            // chkQuadroVidro
            // 
            this.chkQuadroVidro.AutoSize = true;
            this.chkQuadroVidro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkQuadroVidro.Location = new System.Drawing.Point(642, 29);
            this.chkQuadroVidro.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.chkQuadroVidro.Name = "chkQuadroVidro";
            this.chkQuadroVidro.Size = new System.Drawing.Size(149, 20);
            this.chkQuadroVidro.TabIndex = 14;
            this.chkQuadroVidro.Text = "Quadro de Vidro";
            this.chkQuadroVidro.UseVisualStyleBackColor = true;
            // 
            // chkQuadroBranco
            // 
            this.chkQuadroBranco.AutoSize = true;
            this.chkQuadroBranco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkQuadroBranco.Location = new System.Drawing.Point(642, 55);
            this.chkQuadroBranco.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.chkQuadroBranco.Name = "chkQuadroBranco";
            this.chkQuadroBranco.Size = new System.Drawing.Size(149, 22);
            this.chkQuadroBranco.TabIndex = 13;
            this.chkQuadroBranco.Text = "Quadro branco";
            this.chkQuadroBranco.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label6, 2);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(475, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "O local possui:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIdentificacao
            // 
            this.txtIdentificacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel2.SetColumnSpan(this.txtIdentificacao, 3);
            this.txtIdentificacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIdentificacao.Location = new System.Drawing.Point(98, 3);
            this.txtIdentificacao.Name = "txtIdentificacao";
            this.txtIdentificacao.Size = new System.Drawing.Size(351, 22);
            this.txtIdentificacao.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identificação:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo de Espaço:";
            // 
            // cbbTipoEspaco
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbbTipoEspaco, 3);
            this.cbbTipoEspaco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbTipoEspaco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoEspaco.FormattingEnabled = true;
            this.cbbTipoEspaco.Items.AddRange(new object[] {
            "SALA",
            "LABORATÓRIO"});
            this.cbbTipoEspaco.Location = new System.Drawing.Point(98, 29);
            this.cbbTipoEspaco.Name = "cbbTipoEspaco";
            this.cbbTipoEspaco.Size = new System.Drawing.Size(351, 21);
            this.cbbTipoEspaco.TabIndex = 5;
            // 
            // dtgInfraestrutura
            // 
            this.dtgInfraestrutura.AllowUserToAddRows = false;
            this.dtgInfraestrutura.AllowUserToDeleteRows = false;
            this.dtgInfraestrutura.AllowUserToResizeColumns = false;
            this.dtgInfraestrutura.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgInfraestrutura.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgInfraestrutura.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgInfraestrutura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgInfraestrutura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgInfraestrutura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInfraestrutura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO_ESPACO,
            this.TIPO_ESPACO,
            this.CAPACIDADE_ESPACO,
            this.COMPUTADOR_ESPACO,
            this.INTERNET_ESPACO,
            this.PROJETOR_ESPACO,
            this.QUADRO_BRANCO_ESPACO,
            this.QUADRO_VIDRO_ESPACO,
            this.DISCIPLINA_TURMA});
            this.tableLayoutPanel1.SetColumnSpan(this.dtgInfraestrutura, 2);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgInfraestrutura.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgInfraestrutura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgInfraestrutura.Location = new System.Drawing.Point(10, 110);
            this.dtgInfraestrutura.Margin = new System.Windows.Forms.Padding(5);
            this.dtgInfraestrutura.MultiSelect = false;
            this.dtgInfraestrutura.Name = "dtgInfraestrutura";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgInfraestrutura.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgInfraestrutura.RowHeadersVisible = false;
            this.dtgInfraestrutura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgInfraestrutura.Size = new System.Drawing.Size(784, 252);
            this.dtgInfraestrutura.TabIndex = 1;
            this.dtgInfraestrutura.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgInfraestrutura_CellDoubleClick);
            // 
            // CODIGO_ESPACO
            // 
            this.CODIGO_ESPACO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_ESPACO.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO.HeaderText = "Identificação";
            this.CODIGO_ESPACO.MinimumWidth = 100;
            this.CODIGO_ESPACO.Name = "CODIGO_ESPACO";
            this.CODIGO_ESPACO.ReadOnly = true;
            // 
            // TIPO_ESPACO
            // 
            this.TIPO_ESPACO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TIPO_ESPACO.DataPropertyName = "TIPO_ESPACO";
            this.TIPO_ESPACO.HeaderText = "Tipo";
            this.TIPO_ESPACO.MinimumWidth = 100;
            this.TIPO_ESPACO.Name = "TIPO_ESPACO";
            this.TIPO_ESPACO.ReadOnly = true;
            this.TIPO_ESPACO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CAPACIDADE_ESPACO
            // 
            this.CAPACIDADE_ESPACO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CAPACIDADE_ESPACO.DataPropertyName = "CAPACIDADE_ESPACO";
            this.CAPACIDADE_ESPACO.HeaderText = "Capacidade";
            this.CAPACIDADE_ESPACO.Name = "CAPACIDADE_ESPACO";
            this.CAPACIDADE_ESPACO.ReadOnly = true;
            this.CAPACIDADE_ESPACO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CAPACIDADE_ESPACO.Width = 92;
            // 
            // COMPUTADOR_ESPACO
            // 
            this.COMPUTADOR_ESPACO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COMPUTADOR_ESPACO.DataPropertyName = "NUMERO_PC_ESPACO";
            this.COMPUTADOR_ESPACO.HeaderText = "Computadores";
            this.COMPUTADOR_ESPACO.Name = "COMPUTADOR_ESPACO";
            this.COMPUTADOR_ESPACO.ReadOnly = true;
            this.COMPUTADOR_ESPACO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.COMPUTADOR_ESPACO.Width = 108;
            // 
            // INTERNET_ESPACO
            // 
            this.INTERNET_ESPACO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.INTERNET_ESPACO.DataPropertyName = "INTERNET_ESPACO";
            this.INTERNET_ESPACO.HeaderText = "Internet";
            this.INTERNET_ESPACO.Name = "INTERNET_ESPACO";
            this.INTERNET_ESPACO.ReadOnly = true;
            this.INTERNET_ESPACO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.INTERNET_ESPACO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.INTERNET_ESPACO.Width = 73;
            // 
            // PROJETOR_ESPACO
            // 
            this.PROJETOR_ESPACO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PROJETOR_ESPACO.DataPropertyName = "PROJETOR_ESPACO";
            this.PROJETOR_ESPACO.HeaderText = "Projetor";
            this.PROJETOR_ESPACO.Name = "PROJETOR_ESPACO";
            this.PROJETOR_ESPACO.ReadOnly = true;
            this.PROJETOR_ESPACO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PROJETOR_ESPACO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PROJETOR_ESPACO.Width = 73;
            // 
            // QUADRO_BRANCO_ESPACO
            // 
            this.QUADRO_BRANCO_ESPACO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.QUADRO_BRANCO_ESPACO.DataPropertyName = "QUADRO_BRANCO_ESPACO";
            this.QUADRO_BRANCO_ESPACO.HeaderText = "Quadro branco";
            this.QUADRO_BRANCO_ESPACO.MinimumWidth = 100;
            this.QUADRO_BRANCO_ESPACO.Name = "QUADRO_BRANCO_ESPACO";
            this.QUADRO_BRANCO_ESPACO.ReadOnly = true;
            this.QUADRO_BRANCO_ESPACO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.QUADRO_BRANCO_ESPACO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.QUADRO_BRANCO_ESPACO.Width = 110;
            // 
            // QUADRO_VIDRO_ESPACO
            // 
            this.QUADRO_VIDRO_ESPACO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.QUADRO_VIDRO_ESPACO.DataPropertyName = "QUADRO_VIDRO_ESPACO";
            this.QUADRO_VIDRO_ESPACO.HeaderText = "Quadro de vidro";
            this.QUADRO_VIDRO_ESPACO.MinimumWidth = 100;
            this.QUADRO_VIDRO_ESPACO.Name = "QUADRO_VIDRO_ESPACO";
            this.QUADRO_VIDRO_ESPACO.ReadOnly = true;
            this.QUADRO_VIDRO_ESPACO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.QUADRO_VIDRO_ESPACO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.QUADRO_VIDRO_ESPACO.Width = 116;
            // 
            // DISCIPLINA_TURMA
            // 
            this.DISCIPLINA_TURMA.DataPropertyName = "DISCIPLINA_TURMA";
            this.DISCIPLINA_TURMA.HeaderText = "DISCIPLINA_TURMA";
            this.DISCIPLINA_TURMA.Name = "DISCIPLINA_TURMA";
            this.DISCIPLINA_TURMA.ReadOnly = true;
            this.DISCIPLINA_TURMA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DISCIPLINA_TURMA.Visible = false;
            // 
            // frmInfraEstrutura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(740, 480);
            this.Name = "frmInfraEstrutura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Infra Estrutura de salas e laboratórios";
            this.Load += new System.EventHandler(this.frmInfraEstrutura_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbSala.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumComputador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfraestrutura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dtgInfraestrutura;
        private System.Windows.Forms.GroupBox gbSala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdentificacao;
        private System.Windows.Forms.NumericUpDown nudCapacidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbTipoEspaco;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudNumComputador;
        private System.Windows.Forms.CheckBox chkInternet;
        private System.Windows.Forms.CheckBox chkProjetor;
        private System.Windows.Forms.CheckBox chkQuadroVidro;
        private System.Windows.Forms.CheckBox chkQuadroBranco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_ESPACO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAPACIDADE_ESPACO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPUTADOR_ESPACO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn INTERNET_ESPACO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PROJETOR_ESPACO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QUADRO_BRANCO_ESPACO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QUADRO_VIDRO_ESPACO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISCIPLINA_TURMA;
    }
}