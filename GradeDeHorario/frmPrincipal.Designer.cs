namespace GradeDeHorario
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tsBarraMenu = new System.Windows.Forms.ToolStrip();
            this.btnDisciplina = new System.Windows.Forms.ToolStripButton();
            this.btnFase = new System.Windows.Forms.ToolStripButton();
            this.btnSemestre = new System.Windows.Forms.ToolStripButton();
            this.btnTurma = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProfessor = new System.Windows.Forms.ToolStripButton();
            this.btnInfraEstrutura = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.tsBarraMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsBarraMenu
            // 
            this.tsBarraMenu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tsBarraMenu.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.tsBarraMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsBarraMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.tsBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDisciplina,
            this.btnSemestre,
            this.btnProfessor,
            this.btnInfraEstrutura,
            this.toolStripSeparator1,
            this.btnFase,
            this.btnTurma,
            this.toolStripSeparator3,
            this.toolStripButton1});
            this.tsBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.tsBarraMenu.Name = "tsBarraMenu";
            this.tsBarraMenu.Padding = new System.Windows.Forms.Padding(5);
            this.tsBarraMenu.Size = new System.Drawing.Size(614, 77);
            this.tsBarraMenu.TabIndex = 0;
            this.tsBarraMenu.Text = "BarraDeMenu";
            // 
            // btnDisciplina
            // 
            this.btnDisciplina.Image = global::GradeDeHorario.Properties.Resources.ic_board;
            this.btnDisciplina.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDisciplina.Margin = new System.Windows.Forms.Padding(5);
            this.btnDisciplina.Name = "btnDisciplina";
            this.btnDisciplina.Size = new System.Drawing.Size(66, 57);
            this.btnDisciplina.Text = "Disciplinas";
            this.btnDisciplina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDisciplina.Click += new System.EventHandler(this.btnDisciplina_Click);
            // 
            // btnFase
            // 
            this.btnFase.Image = ((System.Drawing.Image)(resources.GetObject("btnFase.Image")));
            this.btnFase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFase.Margin = new System.Windows.Forms.Padding(5);
            this.btnFase.Name = "btnFase";
            this.btnFase.Size = new System.Drawing.Size(44, 57);
            this.btnFase.Text = "Fases";
            this.btnFase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFase.Click += new System.EventHandler(this.btnFase_Click);
            // 
            // btnSemestre
            // 
            this.btnSemestre.Image = global::GradeDeHorario.Properties.Resources.ic_semestre;
            this.btnSemestre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSemestre.Margin = new System.Windows.Forms.Padding(5);
            this.btnSemestre.Name = "btnSemestre";
            this.btnSemestre.Size = new System.Drawing.Size(62, 57);
            this.btnSemestre.Text = "Semestres";
            this.btnSemestre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSemestre.Click += new System.EventHandler(this.btnSemestre_Click);
            // 
            // btnTurma
            // 
            this.btnTurma.Image = global::GradeDeHorario.Properties.Resources.ic_turma;
            this.btnTurma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTurma.Margin = new System.Windows.Forms.Padding(5);
            this.btnTurma.Name = "btnTurma";
            this.btnTurma.Size = new System.Drawing.Size(47, 57);
            this.btnTurma.Text = "Turmas";
            this.btnTurma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTurma.Click += new System.EventHandler(this.btnTurma_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // btnProfessor
            // 
            this.btnProfessor.Image = ((System.Drawing.Image)(resources.GetObject("btnProfessor.Image")));
            this.btnProfessor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProfessor.Margin = new System.Windows.Forms.Padding(5);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(70, 57);
            this.btnProfessor.Text = "Professores";
            this.btnProfessor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click);
            // 
            // btnInfraEstrutura
            // 
            this.btnInfraEstrutura.Image = global::GradeDeHorario.Properties.Resources.ic_infraestrutura;
            this.btnInfraEstrutura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInfraEstrutura.Margin = new System.Windows.Forms.Padding(5);
            this.btnInfraEstrutura.Name = "btnInfraEstrutura";
            this.btnInfraEstrutura.Size = new System.Drawing.Size(82, 57);
            this.btnInfraEstrutura.Text = "Infraestrutura";
            this.btnInfraEstrutura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInfraEstrutura.ToolTipText = "Infraestrutura de salas e laboratórios";
            this.btnInfraEstrutura.Click += new System.EventHandler(this.btnInfraEstrutura_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::GradeDeHorario.Properties.Resources.logo;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(104, 57);
            this.toolStripButton1.Text = "Grade de horários";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.ToolTipText = "Grade de Horários";
            this.toolStripButton1.Click += new System.EventHandler(this.btnGradeHorario_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 412);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(614, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBackground.BackgroundImage = global::GradeDeHorario.Properties.Resources.ic_backgroud2;
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 77);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(614, 335);
            this.pnlBackground.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 437);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tsBarraMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(630, 476);
            this.Name = "frmPrincipal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade de Horários";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tsBarraMenu.ResumeLayout(false);
            this.tsBarraMenu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBarraMenu;
        private System.Windows.Forms.ToolStripButton btnFase;
        private System.Windows.Forms.ToolStripButton btnDisciplina;
        private System.Windows.Forms.ToolStripButton btnProfessor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnInfraEstrutura;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnSemestre;
        private System.Windows.Forms.ToolStripButton btnTurma;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

