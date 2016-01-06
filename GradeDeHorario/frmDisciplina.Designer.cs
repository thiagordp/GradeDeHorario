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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisciplina));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvarEdicao = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.dtgDisciplina = new System.Windows.Forms.DataGridView();
            this.CODIGO_DISCIPLINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_DISCIPLINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREDITO_DISCIPLINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALA_DISCIPLINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTAMENTO_DISCIPLINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRE_REQUISITO_DISCIPLINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.NOME_DISCIPLINA_REQUISITO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelecionaRequisito = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbDepartamento = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisciplina)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbDisciplina.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreditoDisplicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisciplinaRequisito)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(784, 69);
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
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
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
            this.NOME_DISCIPLINA,
            this.CREDITO_DISCIPLINA,
            this.SALA_DISCIPLINA,
            this.DEPARTAMENTO_DISCIPLINA,
            this.PRE_REQUISITO_DISCIPLINA});
            this.tableLayoutPanel1.SetColumnSpan(this.dtgDisciplina, 2);
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDisciplina.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgDisciplina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDisciplina.Location = new System.Drawing.Point(10, 115);
            this.dtgDisciplina.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.dtgDisciplina.MultiSelect = false;
            this.dtgDisciplina.Name = "dtgDisciplina";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDisciplina.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgDisciplina.RowHeadersVisible = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgDisciplina.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgDisciplina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDisciplina.Size = new System.Drawing.Size(764, 282);
            this.dtgDisciplina.TabIndex = 1;
            this.dtgDisciplina.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDisciplina_CellDoubleClick);
            // 
            // CODIGO_DISCIPLINA
            // 
            this.CODIGO_DISCIPLINA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA.HeaderText = "Código";
            this.CODIGO_DISCIPLINA.Name = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA.ReadOnly = true;
            this.CODIGO_DISCIPLINA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CODIGO_DISCIPLINA.Width = 70;
            // 
            // NOME_DISCIPLINA
            // 
            this.NOME_DISCIPLINA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOME_DISCIPLINA.HeaderText = "Nome";
            this.NOME_DISCIPLINA.MinimumWidth = 150;
            this.NOME_DISCIPLINA.Name = "NOME_DISCIPLINA";
            this.NOME_DISCIPLINA.ReadOnly = true;
            // 
            // CREDITO_DISCIPLINA
            // 
            this.CREDITO_DISCIPLINA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CREDITO_DISCIPLINA.HeaderText = "Créditos";
            this.CREDITO_DISCIPLINA.Name = "CREDITO_DISCIPLINA";
            this.CREDITO_DISCIPLINA.ReadOnly = true;
            this.CREDITO_DISCIPLINA.Width = 75;
            // 
            // SALA_DISCIPLINA
            // 
            this.SALA_DISCIPLINA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SALA_DISCIPLINA.HeaderText = "Sala";
            this.SALA_DISCIPLINA.Name = "SALA_DISCIPLINA";
            this.SALA_DISCIPLINA.ReadOnly = true;
            this.SALA_DISCIPLINA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SALA_DISCIPLINA.Width = 53;
            // 
            // DEPARTAMENTO_DISCIPLINA
            // 
            this.DEPARTAMENTO_DISCIPLINA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DEPARTAMENTO_DISCIPLINA.HeaderText = "Departamento";
            this.DEPARTAMENTO_DISCIPLINA.Name = "DEPARTAMENTO_DISCIPLINA";
            this.DEPARTAMENTO_DISCIPLINA.ReadOnly = true;
            this.DEPARTAMENTO_DISCIPLINA.Width = 106;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbDisciplina, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtgDisciplina, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 69);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 412);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // gbDisciplina
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbDisciplina, 2);
            this.gbDisciplina.Controls.Add(this.tableLayoutPanel2);
            this.gbDisciplina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDisciplina.Enabled = false;
            this.gbDisciplina.Location = new System.Drawing.Point(10, 10);
            this.gbDisciplina.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.gbDisciplina.Name = "gbDisciplina";
            this.gbDisciplina.Padding = new System.Windows.Forms.Padding(0);
            this.gbDisciplina.Size = new System.Drawing.Size(764, 95);
            this.gbDisciplina.TabIndex = 2;
            this.gbDisciplina.TabStop = false;
            this.gbDisciplina.Text = "Cadastro de disciplina";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
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
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 15);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(764, 80);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Créditos:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
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
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(122, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtNomeDisciplina
            // 
            this.txtNomeDisciplina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel2.SetColumnSpan(this.txtNomeDisciplina, 3);
            this.txtNomeDisciplina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNomeDisciplina.Location = new System.Drawing.Point(73, 29);
            this.txtNomeDisciplina.Name = "txtNomeDisciplina";
            this.txtNomeDisciplina.Size = new System.Drawing.Size(378, 22);
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
            this.nudCreditoDisplicina.Size = new System.Drawing.Size(122, 22);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
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
            this.NOME_DISCIPLINA_REQUISITO});
            this.tableLayoutPanel2.SetColumnSpan(this.dtgDisciplinaRequisito, 2);
            this.dtgDisciplinaRequisito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDisciplinaRequisito.Location = new System.Drawing.Point(457, 29);
            this.dtgDisciplinaRequisito.Name = "dtgDisciplinaRequisito";
            this.dtgDisciplinaRequisito.ReadOnly = true;
            this.dtgDisciplinaRequisito.RowHeadersVisible = false;
            this.tableLayoutPanel2.SetRowSpan(this.dtgDisciplinaRequisito, 2);
            this.dtgDisciplinaRequisito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgDisciplinaRequisito.Size = new System.Drawing.Size(304, 48);
            this.dtgDisciplinaRequisito.TabIndex = 8;
            // 
            // NOME_DISCIPLINA_REQUISITO
            // 
            this.NOME_DISCIPLINA_REQUISITO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            this.panel1.Location = new System.Drawing.Point(713, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(48, 20);
            this.panel1.TabIndex = 5;
            // 
            // btnSelecionaRequisito
            // 
            this.btnSelecionaRequisito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelecionaRequisito.Location = new System.Drawing.Point(0, 0);
            this.btnSelecionaRequisito.Name = "btnSelecionaRequisito";
            this.btnSelecionaRequisito.Size = new System.Drawing.Size(48, 20);
            this.btnSelecionaRequisito.TabIndex = 4;
            this.btnSelecionaRequisito.Text = "...";
            this.btnSelecionaRequisito.UseVisualStyleBackColor = true;
            this.btnSelecionaRequisito.Click += new System.EventHandler(this.btnSelecionaRequisito_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(457, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Disciplinas Pré-requisito";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(201, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Departamento:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbDepartamento
            // 
            this.cbbDepartamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDepartamento.FormattingEnabled = true;
            this.cbbDepartamento.Items.AddRange(new object[] {
            "DEC - Depto. de Computação",
            "ENS - Depto. de Energia e Sustentabilidade",
            "FQM - Depto. de Física Química e Matemática",
            "TIC - Depto. de Tecnologia da Informação e Comunicação"});
            this.cbbDepartamento.Location = new System.Drawing.Point(297, 55);
            this.cbbDepartamento.Name = "cbbDepartamento";
            this.cbbDepartamento.Size = new System.Drawing.Size(154, 21);
            this.cbbDepartamento.TabIndex = 11;
            // 
            // frmDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 520);
            this.Name = "frmDisciplina";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disciplina";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_DISCIPLINA_REQUISITO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRE_REQUISITO_DISCIPLINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTAMENTO_DISCIPLINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALA_DISCIPLINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREDITO_DISCIPLINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_DISCIPLINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA;
    }
}