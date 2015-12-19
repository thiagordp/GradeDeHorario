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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbbSelectFase = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cbbSelectSemestre = new System.Windows.Forms.ToolStripComboBox();
            this.tblGrade = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnCarregaGrade = new System.Windows.Forms.ToolStripButton();
            this.btnGerarRelatorio = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.tblGrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(751, 69);
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
            // cbbSelectFase
            // 
            this.cbbSelectFase.AutoToolTip = true;
            this.cbbSelectFase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbbSelectFase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbbSelectSemestre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cbbSelectSemestre.Name = "cbbSelectSemestre";
            this.cbbSelectSemestre.Size = new System.Drawing.Size(121, 69);
            // 
            // tblGrade
            // 
            this.tblGrade.ColumnCount = 2;
            this.tblGrade.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblGrade.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblGrade.Controls.Add(this.dataGridView2, 1, 0);
            this.tblGrade.Controls.Add(this.dataGridView1, 0, 0);
            this.tblGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblGrade.Location = new System.Drawing.Point(0, 69);
            this.tblGrade.Name = "tblGrade";
            this.tblGrade.RowCount = 1;
            this.tblGrade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblGrade.Size = new System.Drawing.Size(751, 296);
            this.tblGrade.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(603, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(145, 290);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 59);
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
            // frmGradeHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 365);
            this.Controls.Add(this.tblGrade);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmGradeHorario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade de Horários";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tblGrade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TableLayoutPanel tblGrade;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}