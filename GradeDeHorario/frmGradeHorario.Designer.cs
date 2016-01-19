namespace GradeDeHorario
{
    partial class frmGradeHorario
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.cbbSelectFase = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cbbSelectSemestre = new System.Windows.Forms.ToolStripComboBox();
            this.btnCarregaGrade = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGerarRelatorio = new System.Windows.Forms.ToolStripButton();
            this.tblGrade = new System.Windows.Forms.TableLayoutPanel();
            this.dtgGradeHorario = new System.Windows.Forms.DataGridView();
            this.SEGUNDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TERCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUARTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUINTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SABADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Disciplinas = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPesquisaDisciplina = new System.Windows.Forms.TextBox();
            this.dtgPesquisaDisciplina = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.tblGrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGradeHorario)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.Disciplinas.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnCancelar,
            this.btnSalvar,
            this.cbbSelectFase,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.cbbSelectSemestre,
            this.btnCarregaGrade,
            this.toolStripSeparator2,
            this.btnGerarRelatorio});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 69);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(33, 63);
            this.toolStripLabel1.Text = "Fase:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCancelar.Image = global::GradeDeHorario.Properties.Resources.ic_menu_close;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 59);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalvar.Image = global::GradeDeHorario.Properties.Resources.ic_button;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(44, 59);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // cbbSelectFase
            // 
            this.cbbSelectFase.AutoToolTip = true;
            this.cbbSelectFase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbbSelectFase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSelectFase.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbbSelectFase.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbbSelectFase.Items.AddRange(new object[] {
            "1ª Fase",
            "2ª Fase",
            "3ª Fase",
            "4ª Fase"});
            this.cbbSelectFase.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cbbSelectFase.MaxDropDownItems = 10;
            this.cbbSelectFase.Name = "cbbSelectFase";
            this.cbbSelectFase.Size = new System.Drawing.Size(150, 69);
            this.cbbSelectFase.ToolTipText = "Selecione a fase";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 69);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(58, 63);
            this.toolStripLabel2.Text = "Semestre:";
            // 
            // cbbSelectSemestre
            // 
            this.cbbSelectSemestre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbbSelectSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSelectSemestre.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbbSelectSemestre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cbbSelectSemestre.Name = "cbbSelectSemestre";
            this.cbbSelectSemestre.Size = new System.Drawing.Size(121, 69);
            // 
            // btnCarregaGrade
            // 
            this.btnCarregaGrade.Image = global::GradeDeHorario.Properties.Resources.ic_open;
            this.btnCarregaGrade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCarregaGrade.Margin = new System.Windows.Forms.Padding(5);
            this.btnCarregaGrade.Name = "btnCarregaGrade";
            this.btnCarregaGrade.Size = new System.Drawing.Size(56, 59);
            this.btnCarregaGrade.Text = "Carregar";
            this.btnCarregaGrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 59);
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnGerarRelatorio.Image = global::GradeDeHorario.Properties.Resources.ic_relatorio;
            this.btnGerarRelatorio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGerarRelatorio.Margin = new System.Windows.Forms.Padding(5);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(58, 59);
            this.btnGerarRelatorio.Text = "Relatório";
            this.btnGerarRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGerarRelatorio.ToolTipText = "Gerar relatório com os horários estabelecidos";
            // 
            // tblGrade
            // 
            this.tblGrade.ColumnCount = 2;
            this.tblGrade.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblGrade.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblGrade.Controls.Add(this.dtgGradeHorario, 0, 0);
            this.tblGrade.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tblGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblGrade.Location = new System.Drawing.Point(0, 69);
            this.tblGrade.Name = "tblGrade";
            this.tblGrade.RowCount = 1;
            this.tblGrade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblGrade.Size = new System.Drawing.Size(1008, 592);
            this.tblGrade.TabIndex = 1;
            // 
            // dtgGradeHorario
            // 
            this.dtgGradeHorario.AllowUserToAddRows = false;
            this.dtgGradeHorario.AllowUserToDeleteRows = false;
            this.dtgGradeHorario.AllowUserToResizeColumns = false;
            this.dtgGradeHorario.AllowUserToResizeRows = false;
            this.dtgGradeHorario.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgGradeHorario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgGradeHorario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgGradeHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGradeHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SEGUNDA,
            this.TERCA,
            this.QUARTA,
            this.QUINTA,
            this.SEXTA,
            this.SABADO});
            this.dtgGradeHorario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgGradeHorario.Location = new System.Drawing.Point(3, 3);
            this.dtgGradeHorario.Name = "dtgGradeHorario";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgGradeHorario.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgGradeHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgGradeHorario.Size = new System.Drawing.Size(800, 586);
            this.dtgGradeHorario.TabIndex = 0;
            // 
            // SEGUNDA
            // 
            this.SEGUNDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SEGUNDA.HeaderText = "Segunda-feira";
            this.SEGUNDA.Name = "SEGUNDA";
            this.SEGUNDA.ReadOnly = true;
            // 
            // TERCA
            // 
            this.TERCA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TERCA.HeaderText = "Terça-feira";
            this.TERCA.Name = "TERCA";
            this.TERCA.ReadOnly = true;
            // 
            // QUARTA
            // 
            this.QUARTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QUARTA.HeaderText = "Quarta-feira";
            this.QUARTA.Name = "QUARTA";
            this.QUARTA.ReadOnly = true;
            // 
            // QUINTA
            // 
            this.QUINTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QUINTA.HeaderText = "Quinta-feira";
            this.QUINTA.Name = "QUINTA";
            this.QUINTA.ReadOnly = true;
            // 
            // SEXTA
            // 
            this.SEXTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SEXTA.HeaderText = "Sexta-feira";
            this.SEXTA.Name = "SEXTA";
            this.SEXTA.ReadOnly = true;
            // 
            // SABADO
            // 
            this.SABADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SABADO.HeaderText = "Sábado";
            this.SABADO.Name = "SABADO";
            this.SABADO.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Disciplinas, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(809, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(196, 586);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 389);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(196, 197);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salas e Laboratórios";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.textBox2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dataGridView2, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(190, 178);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 20);
            this.textBox2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.Location = new System.Drawing.Point(3, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(184, 147);
            this.dataGridView2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 192);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(196, 197);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Professores";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(190, 178);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView4.Location = new System.Drawing.Point(3, 28);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(184, 147);
            this.dataGridView4.TabIndex = 1;
            // 
            // Disciplinas
            // 
            this.Disciplinas.Controls.Add(this.tableLayoutPanel2);
            this.Disciplinas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Disciplinas.Location = new System.Drawing.Point(0, 0);
            this.Disciplinas.Margin = new System.Windows.Forms.Padding(0);
            this.Disciplinas.Name = "Disciplinas";
            this.tableLayoutPanel1.SetRowSpan(this.Disciplinas, 2);
            this.Disciplinas.Size = new System.Drawing.Size(196, 192);
            this.Disciplinas.TabIndex = 6;
            this.Disciplinas.TabStop = false;
            this.Disciplinas.Text = "Disciplinas";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtPesquisaDisciplina, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtgPesquisaDisciplina, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(190, 173);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtPesquisaDisciplina
            // 
            this.txtPesquisaDisciplina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisaDisciplina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPesquisaDisciplina.Location = new System.Drawing.Point(3, 3);
            this.txtPesquisaDisciplina.Name = "txtPesquisaDisciplina";
            this.txtPesquisaDisciplina.Size = new System.Drawing.Size(184, 20);
            this.txtPesquisaDisciplina.TabIndex = 0;
            // 
            // dtgPesquisaDisciplina
            // 
            this.dtgPesquisaDisciplina.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgPesquisaDisciplina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgPesquisaDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPesquisaDisciplina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPesquisaDisciplina.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgPesquisaDisciplina.Location = new System.Drawing.Point(3, 28);
            this.dtgPesquisaDisciplina.Name = "dtgPesquisaDisciplina";
            this.dtgPesquisaDisciplina.Size = new System.Drawing.Size(184, 142);
            this.dtgPesquisaDisciplina.TabIndex = 1;
            // 
            // frmGradeHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.tblGrade);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(1024, 700);
            this.Name = "frmGradeHorario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade de Horários";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tblGrade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGradeHorario)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.Disciplinas.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaDisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TableLayoutPanel tblGrade;
        private System.Windows.Forms.DataGridView dtgGradeHorario;
        private System.Windows.Forms.ToolStripButton btnCarregaGrade;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripComboBox cbbSelectFase;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cbbSelectSemestre;
        private System.Windows.Forms.ToolStripButton btnGerarRelatorio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtPesquisaDisciplina;
        private System.Windows.Forms.DataGridView dtgPesquisaDisciplina;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.GroupBox Disciplinas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEGUNDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TERCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUARTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUINTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SABADO;
    }
}