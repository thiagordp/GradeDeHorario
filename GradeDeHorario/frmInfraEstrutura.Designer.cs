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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfraEstrutura));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbDisciplina = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nudNumComputador = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNomeDisciplina = new System.Windows.Forms.TextBox();
            this.nudCapacidade = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTipoEspaco = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkInternet = new System.Windows.Forms.CheckBox();
            this.chkProjetor = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkQuadroVidro = new System.Windows.Forms.CheckBox();
            this.chkQuadroBranco = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbDisciplina.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumComputador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(724, 69);
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
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::GradeDeHorario.Properties.Resources.ic_button;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(44, 59);
            this.toolStripButton2.Text = "Salvar";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::GradeDeHorario.Properties.Resources.ic_delete;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(45, 66);
            this.toolStripButton3.Text = "Excluir";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbDisciplina, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(724, 372);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gbDisciplina
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbDisciplina, 2);
            this.gbDisciplina.Controls.Add(this.tableLayoutPanel2);
            this.gbDisciplina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDisciplina.Location = new System.Drawing.Point(5, 5);
            this.gbDisciplina.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.gbDisciplina.Name = "gbDisciplina";
            this.gbDisciplina.Padding = new System.Windows.Forms.Padding(0);
            this.gbDisciplina.Size = new System.Drawing.Size(714, 95);
            this.gbDisciplina.TabIndex = 3;
            this.gbDisciplina.TabStop = false;
            this.gbDisciplina.Text = "Cadastro de sala ou laboratório";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.54386F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.54386F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.54386F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.68421F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.68421F));
            this.tableLayoutPanel2.Controls.Add(this.nudNumComputador, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtCodigo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNomeDisciplina, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.nudCapacidade, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbbTipoEspaco, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.chkInternet, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.chkProjetor, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.chkQuadroVidro, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.chkQuadroBranco, 6, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 15);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(714, 80);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // nudNumComputador
            // 
            this.nudNumComputador.Location = new System.Drawing.Point(303, 55);
            this.nudNumComputador.Name = "nudNumComputador";
            this.nudNumComputador.Size = new System.Drawing.Size(99, 22);
            this.nudNumComputador.TabIndex = 10;
            this.nudNumComputador.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capacidade:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identificação:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigo.Location = new System.Drawing.Point(93, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(99, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtNomeDisciplina
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtNomeDisciplina, 3);
            this.txtNomeDisciplina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNomeDisciplina.Location = new System.Drawing.Point(93, 29);
            this.txtNomeDisciplina.Name = "txtNomeDisciplina";
            this.txtNomeDisciplina.Size = new System.Drawing.Size(309, 22);
            this.txtNomeDisciplina.TabIndex = 4;
            // 
            // nudCapacidade
            // 
            this.nudCapacidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudCapacidade.Location = new System.Drawing.Point(93, 55);
            this.nudCapacidade.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudCapacidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCapacidade.Name = "nudCapacidade";
            this.nudCapacidade.Size = new System.Drawing.Size(99, 22);
            this.nudCapacidade.TabIndex = 6;
            this.nudCapacidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo de Espaço:";
            // 
            // cbbTipoEspaco
            // 
            this.cbbTipoEspaco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbTipoEspaco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoEspaco.FormattingEnabled = true;
            this.cbbTipoEspaco.Items.AddRange(new object[] {
            "Sala",
            "Laboratório"});
            this.cbbTipoEspaco.Location = new System.Drawing.Point(303, 3);
            this.cbbTipoEspaco.Name = "cbbTipoEspaco";
            this.cbbTipoEspaco.Size = new System.Drawing.Size(99, 21);
            this.cbbTipoEspaco.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Computadores:";
            // 
            // chkInternet
            // 
            this.chkInternet.AutoSize = true;
            this.chkInternet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkInternet.Location = new System.Drawing.Point(435, 29);
            this.chkInternet.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.chkInternet.Name = "chkInternet";
            this.chkInternet.Size = new System.Drawing.Size(130, 20);
            this.chkInternet.TabIndex = 11;
            this.chkInternet.Text = "Internet";
            this.chkInternet.UseVisualStyleBackColor = true;
            // 
            // chkProjetor
            // 
            this.chkProjetor.AutoSize = true;
            this.chkProjetor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkProjetor.Location = new System.Drawing.Point(435, 55);
            this.chkProjetor.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.chkProjetor.Name = "chkProjetor";
            this.chkProjetor.Size = new System.Drawing.Size(130, 22);
            this.chkProjetor.TabIndex = 12;
            this.chkProjetor.Text = "Projetor";
            this.chkProjetor.UseVisualStyleBackColor = true;
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
            // chkQuadroVidro
            // 
            this.chkQuadroVidro.AutoSize = true;
            this.chkQuadroVidro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkQuadroVidro.Location = new System.Drawing.Point(578, 29);
            this.chkQuadroVidro.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.chkQuadroVidro.Name = "chkQuadroVidro";
            this.chkQuadroVidro.Size = new System.Drawing.Size(133, 20);
            this.chkQuadroVidro.TabIndex = 14;
            this.chkQuadroVidro.Text = "Quadro de Vidro";
            this.chkQuadroVidro.UseVisualStyleBackColor = true;
            // 
            // chkQuadroBranco
            // 
            this.chkQuadroBranco.AutoSize = true;
            this.chkQuadroBranco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkQuadroBranco.Location = new System.Drawing.Point(578, 55);
            this.chkQuadroBranco.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.chkQuadroBranco.Name = "chkQuadroBranco";
            this.chkQuadroBranco.Size = new System.Drawing.Size(133, 22);
            this.chkQuadroBranco.TabIndex = 13;
            this.chkQuadroBranco.Text = "Quadro branco";
            this.chkQuadroBranco.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label6, 2);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(428, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "O local possui:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView2, 2);
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(10, 110);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(704, 252);
            this.dataGridView2.TabIndex = 1;
            // 
            // frmInfraEstrutura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "frmInfraEstrutura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Infra Estrutura de salas e laboratórios";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbDisciplina.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumComputador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox gbDisciplina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNomeDisciplina;
        private System.Windows.Forms.NumericUpDown nudCapacidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbTipoEspaco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudNumComputador;
        private System.Windows.Forms.CheckBox chkInternet;
        private System.Windows.Forms.CheckBox chkProjetor;
        private System.Windows.Forms.CheckBox chkQuadroVidro;
        private System.Windows.Forms.CheckBox chkQuadroBranco;
        private System.Windows.Forms.Label label6;
    }
}