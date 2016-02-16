namespace GradeDeHorario
{
    partial class frmDisciplina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisciplina));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvarEdicao = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.dtgDisciplina = new System.Windows.Forms.DataGridView();
            this.CODIGO_DISCIPLINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISCIPLINA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_DISCIPLINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREDITO_DISCIPLINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_DEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRE_REQUISITO_DISCIPLINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbDisciplina = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNomeDisciplina = new System.Windows.Forms.TextBox();
            this.nudCreditoDisplicina = new System.Windows.Forms.NumericUpDown();
            this.dtgDisciplinaRequisito = new System.Windows.Forms.DataGridView();
            this.CODIGO_DISCIPLINA_REQUISITO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_DISCIPLINA_REQUISITO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelecionaRequisito = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbDepartamento = new System.Windows.Forms.ComboBox();
            this.dtgSelecionaTurma = new System.Windows.Forms.DataGridView();
            this.CODIGO_TURMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelecionaTurma = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPesquisaDisciplina = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisciplina)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbDisciplina.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreditoDisplicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisciplinaRequisito)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSelecionaTurma)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnCancelar,
            this.btnSalvarEdicao,
            this.btnExcluir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(884, 69);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "k";
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
            this.btnNovo.ToolTipText = "Criar uma nova disciplina";
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
            this.btnCancelar.ToolTipText = "Reverte todas as alterações realizadas e que não foram salvas.";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvarEdicao
            // 
            this.btnSalvarEdicao.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalvarEdicao.Enabled = false;
            this.btnSalvarEdicao.Image = global::GradeDeHorario.Properties.Resources.ic_button;
            this.btnSalvarEdicao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvarEdicao.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalvarEdicao.Name = "btnSalvarEdicao";
            this.btnSalvarEdicao.Size = new System.Drawing.Size(44, 59);
            this.btnSalvarEdicao.Text = "Salvar";
            this.btnSalvarEdicao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvarEdicao.ToolTipText = "Salvar a nova disciplina criada";
            this.btnSalvarEdicao.Click += new System.EventHandler(this.btnSalvarEdicao_Click);
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
            this.btnExcluir.ToolTipText = "Excluir disciplina selecionada";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dtgDisciplina
            // 
            this.dtgDisciplina.AllowUserToAddRows = false;
            this.dtgDisciplina.AllowUserToDeleteRows = false;
            this.dtgDisciplina.AllowUserToResizeColumns = false;
            this.dtgDisciplina.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgDisciplina.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDisciplina.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgDisciplina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDisciplina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDisciplina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO_DISCIPLINA,
            this.DISCIPLINA1,
            this.NOME_DISCIPLINA,
            this.CREDITO_DISCIPLINA,
            this.NOME_DEPARTAMENTO,
            this.PRE_REQUISITO_DISCIPLINA,
            this.CODIGO_DEPARTAMENTO});
            this.tableLayoutPanel1.SetColumnSpan(this.dtgDisciplina, 2);
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDisciplina.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgDisciplina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDisciplina.Location = new System.Drawing.Point(13, 183);
            this.dtgDisciplina.MultiSelect = false;
            this.dtgDisciplina.Name = "dtgDisciplina";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDisciplina.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgDisciplina.RowHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgDisciplina.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgDisciplina.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgDisciplina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDisciplina.Size = new System.Drawing.Size(858, 174);
            this.dtgDisciplina.TabIndex = 1;
            this.dtgDisciplina.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDisciplina_CellDoubleClick);
            // 
            // CODIGO_DISCIPLINA
            // 
            this.CODIGO_DISCIPLINA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA.HeaderText = "Código";
            this.CODIGO_DISCIPLINA.Name = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA.ReadOnly = true;
            this.CODIGO_DISCIPLINA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CODIGO_DISCIPLINA.Width = 70;
            // 
            // DISCIPLINA1
            // 
            this.DISCIPLINA1.HeaderText = "Disc1ADO";
            this.DISCIPLINA1.Name = "DISCIPLINA1";
            this.DISCIPLINA1.Visible = false;
            // 
            // NOME_DISCIPLINA
            // 
            this.NOME_DISCIPLINA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOME_DISCIPLINA.DataPropertyName = "NOME_DISCIPLINA";
            this.NOME_DISCIPLINA.HeaderText = "Nome";
            this.NOME_DISCIPLINA.MinimumWidth = 150;
            this.NOME_DISCIPLINA.Name = "NOME_DISCIPLINA";
            this.NOME_DISCIPLINA.ReadOnly = true;
            // 
            // CREDITO_DISCIPLINA
            // 
            this.CREDITO_DISCIPLINA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CREDITO_DISCIPLINA.DataPropertyName = "CREDITO_DISCIPLINA";
            this.CREDITO_DISCIPLINA.HeaderText = "Créditos";
            this.CREDITO_DISCIPLINA.Name = "CREDITO_DISCIPLINA";
            this.CREDITO_DISCIPLINA.ReadOnly = true;
            this.CREDITO_DISCIPLINA.Width = 75;
            // 
            // NOME_DEPARTAMENTO
            // 
            this.NOME_DEPARTAMENTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NOME_DEPARTAMENTO.DataPropertyName = "NOME_DEPARTAMENTO";
            this.NOME_DEPARTAMENTO.HeaderText = "Departamento";
            this.NOME_DEPARTAMENTO.Name = "NOME_DEPARTAMENTO";
            this.NOME_DEPARTAMENTO.ReadOnly = true;
            this.NOME_DEPARTAMENTO.Width = 106;
            // 
            // PRE_REQUISITO_DISCIPLINA
            // 
            this.PRE_REQUISITO_DISCIPLINA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRE_REQUISITO_DISCIPLINA.HeaderText = "Pré-requisito";
            this.PRE_REQUISITO_DISCIPLINA.Name = "PRE_REQUISITO_DISCIPLINA";
            this.PRE_REQUISITO_DISCIPLINA.ReadOnly = true;
            this.PRE_REQUISITO_DISCIPLINA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PRE_REQUISITO_DISCIPLINA.Visible = false;
            // 
            // CODIGO_DEPARTAMENTO
            // 
            this.CODIGO_DEPARTAMENTO.DataPropertyName = "CODIGO_DEPARTAMENTO";
            this.CODIGO_DEPARTAMENTO.HeaderText = "CódigoDepto";
            this.CODIGO_DEPARTAMENTO.Name = "CODIGO_DEPARTAMENTO";
            this.CODIGO_DEPARTAMENTO.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbDisciplina, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtgDisciplina, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 69);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 369);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // gbDisciplina
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbDisciplina, 2);
            this.gbDisciplina.Controls.Add(this.tableLayoutPanel2);
            this.gbDisciplina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDisciplina.Enabled = false;
            this.gbDisciplina.Location = new System.Drawing.Point(13, 13);
            this.gbDisciplina.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.gbDisciplina.Name = "gbDisciplina";
            this.gbDisciplina.Size = new System.Drawing.Size(858, 102);
            this.gbDisciplina.TabIndex = 2;
            this.gbDisciplina.TabStop = false;
            this.gbDisciplina.Text = "Cadastro de disciplina";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.11036F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.88819F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.00145F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtCodigo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNomeDisciplina, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.nudCreditoDisplicina, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.dtgDisciplinaRequisito, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbbDepartamento, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.dtgSelecionaTurma, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSelecionaTurma, 7, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(852, 81);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Créditos:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigo.Location = new System.Drawing.Point(73, 3);
            this.txtCodigo.MaxLength = 7;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(64, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtNomeDisciplina
            // 
            this.txtNomeDisciplina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel2.SetColumnSpan(this.txtNomeDisciplina, 3);
            this.txtNomeDisciplina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNomeDisciplina.Location = new System.Drawing.Point(73, 29);
            this.txtNomeDisciplina.Name = "txtNomeDisciplina";
            this.txtNomeDisciplina.Size = new System.Drawing.Size(383, 22);
            this.txtNomeDisciplina.TabIndex = 4;
            // 
            // nudCreditoDisplicina
            // 
            this.nudCreditoDisplicina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudCreditoDisplicina.Location = new System.Drawing.Point(73, 55);
            this.nudCreditoDisplicina.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudCreditoDisplicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCreditoDisplicina.Name = "nudCreditoDisplicina";
            this.nudCreditoDisplicina.Size = new System.Drawing.Size(64, 22);
            this.nudCreditoDisplicina.TabIndex = 6;
            this.nudCreditoDisplicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCreditoDisplicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtgDisciplinaRequisito
            // 
            this.dtgDisciplinaRequisito.AllowUserToAddRows = false;
            this.dtgDisciplinaRequisito.AllowUserToDeleteRows = false;
            this.dtgDisciplinaRequisito.AllowUserToResizeColumns = false;
            this.dtgDisciplinaRequisito.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgDisciplinaRequisito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgDisciplinaRequisito.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgDisciplinaRequisito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDisciplinaRequisito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgDisciplinaRequisito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDisciplinaRequisito.ColumnHeadersVisible = false;
            this.dtgDisciplinaRequisito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO_DISCIPLINA_REQUISITO,
            this.NOME_DISCIPLINA_REQUISITO});
            this.tableLayoutPanel2.SetColumnSpan(this.dtgDisciplinaRequisito, 2);
            this.dtgDisciplinaRequisito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDisciplinaRequisito.Location = new System.Drawing.Point(462, 29);
            this.dtgDisciplinaRequisito.Name = "dtgDisciplinaRequisito";
            this.dtgDisciplinaRequisito.ReadOnly = true;
            this.dtgDisciplinaRequisito.RowHeadersVisible = false;
            this.tableLayoutPanel2.SetRowSpan(this.dtgDisciplinaRequisito, 2);
            this.dtgDisciplinaRequisito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgDisciplinaRequisito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDisciplinaRequisito.Size = new System.Drawing.Size(259, 49);
            this.dtgDisciplinaRequisito.TabIndex = 8;
            // 
            // CODIGO_DISCIPLINA_REQUISITO
            // 
            this.CODIGO_DISCIPLINA_REQUISITO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_REQUISITO.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_REQUISITO.HeaderText = "Código";
            this.CODIGO_DISCIPLINA_REQUISITO.Name = "CODIGO_DISCIPLINA_REQUISITO";
            this.CODIGO_DISCIPLINA_REQUISITO.ReadOnly = true;
            this.CODIGO_DISCIPLINA_REQUISITO.Width = 5;
            // 
            // NOME_DISCIPLINA_REQUISITO
            // 
            this.NOME_DISCIPLINA_REQUISITO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOME_DISCIPLINA_REQUISITO.DataPropertyName = "NOME_DISCIPLINA";
            this.NOME_DISCIPLINA_REQUISITO.HeaderText = "Disciplina";
            this.NOME_DISCIPLINA_REQUISITO.Name = "NOME_DISCIPLINA_REQUISITO";
            this.NOME_DISCIPLINA_REQUISITO.ReadOnly = true;
            this.NOME_DISCIPLINA_REQUISITO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NOME_DISCIPLINA_REQUISITO.ToolTipText = "Disciplina requisito";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSelecionaRequisito);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(674, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(47, 20);
            this.panel1.TabIndex = 5;
            // 
            // btnSelecionaRequisito
            // 
            this.btnSelecionaRequisito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelecionaRequisito.Location = new System.Drawing.Point(0, 0);
            this.btnSelecionaRequisito.Name = "btnSelecionaRequisito";
            this.btnSelecionaRequisito.Size = new System.Drawing.Size(47, 20);
            this.btnSelecionaRequisito.TabIndex = 4;
            this.btnSelecionaRequisito.Text = "...";
            this.btnSelecionaRequisito.UseVisualStyleBackColor = true;
            this.btnSelecionaRequisito.Click += new System.EventHandler(this.btnSelecionaRequisito_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(462, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Disciplinas Pré-requisito";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(143, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Departamento:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbDepartamento
            // 
            this.cbbDepartamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDepartamento.FormattingEnabled = true;
            this.cbbDepartamento.Location = new System.Drawing.Point(233, 55);
            this.cbbDepartamento.Name = "cbbDepartamento";
            this.cbbDepartamento.Size = new System.Drawing.Size(223, 21);
            this.cbbDepartamento.TabIndex = 11;
            // 
            // dtgSelecionaTurma
            // 
            this.dtgSelecionaTurma.AllowUserToAddRows = false;
            this.dtgSelecionaTurma.AllowUserToDeleteRows = false;
            this.dtgSelecionaTurma.AllowUserToResizeColumns = false;
            this.dtgSelecionaTurma.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgSelecionaTurma.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgSelecionaTurma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgSelecionaTurma.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgSelecionaTurma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgSelecionaTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSelecionaTurma.ColumnHeadersVisible = false;
            this.dtgSelecionaTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO_TURMA});
            this.tableLayoutPanel2.SetColumnSpan(this.dtgSelecionaTurma, 2);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgSelecionaTurma.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgSelecionaTurma.Location = new System.Drawing.Point(727, 29);
            this.dtgSelecionaTurma.Name = "dtgSelecionaTurma";
            this.dtgSelecionaTurma.RowHeadersVisible = false;
            this.tableLayoutPanel2.SetRowSpan(this.dtgSelecionaTurma, 2);
            this.dtgSelecionaTurma.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgSelecionaTurma.Size = new System.Drawing.Size(122, 49);
            this.dtgSelecionaTurma.TabIndex = 12;
            // 
            // CODIGO_TURMA
            // 
            this.CODIGO_TURMA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA.HeaderText = "Turma";
            this.CODIGO_TURMA.Name = "CODIGO_TURMA";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(727, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Turmas:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelecionaTurma
            // 
            this.btnSelecionaTurma.Location = new System.Drawing.Point(793, 3);
            this.btnSelecionaTurma.Name = "btnSelecionaTurma";
            this.btnSelecionaTurma.Size = new System.Drawing.Size(48, 20);
            this.btnSelecionaTurma.TabIndex = 14;
            this.btnSelecionaTurma.Text = "...";
            this.btnSelecionaTurma.UseVisualStyleBackColor = true;
            this.btnSelecionaTurma.Click += new System.EventHandler(this.btnSelecionaTurma_Click);
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.txtPesquisaDisciplina);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(13, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(858, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar disciplinas por nome";
            // 
            // txtPesquisaDisciplina
            // 
            this.txtPesquisaDisciplina.AccessibleDescription = "Pesquisa de disciplinas";
            this.txtPesquisaDisciplina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisaDisciplina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPesquisaDisciplina.Location = new System.Drawing.Point(5, 20);
            this.txtPesquisaDisciplina.Margin = new System.Windows.Forms.Padding(5);
            this.txtPesquisaDisciplina.Name = "txtPesquisaDisciplina";
            this.txtPesquisaDisciplina.Size = new System.Drawing.Size(848, 22);
            this.txtPesquisaDisciplina.TabIndex = 0;
            this.txtPesquisaDisciplina.TextChanged += new System.EventHandler(this.txtPesquisaDisciplina_TextChanged);
            // 
            // frmDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 438);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 477);
            this.Name = "frmDisciplina";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disciplina";
            this.Load += new System.EventHandler(this.frmDisciplina_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisciplina)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbDisciplina.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreditoDisplicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisciplinaRequisito)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSelecionaTurma)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.DataGridView dtgDisciplina;
        private System.Windows.Forms.ToolStripButton btnSalvarEdicao;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbDisciplina;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNomeDisciplina;
        private System.Windows.Forms.NumericUpDown nudCreditoDisplicina;
        private System.Windows.Forms.DataGridView dtgDisciplinaRequisito;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelecionaRequisito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISCIPLINA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_DISCIPLINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREDITO_DISCIPLINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_DEPARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRE_REQUISITO_DISCIPLINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DEPARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_REQUISITO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_DISCIPLINA_REQUISITO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPesquisaDisciplina;
        private System.Windows.Forms.DataGridView dtgSelecionaTurma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelecionaTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA;
    }
}