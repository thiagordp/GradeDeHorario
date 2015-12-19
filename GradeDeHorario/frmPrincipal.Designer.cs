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
            this.btnProfessor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnInfraEstrutura = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.btnSemestre = new System.Windows.Forms.ToolStripButton();
            this.tsBarraMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsBarraMenu
            // 
            this.tsBarraMenu.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.tsBarraMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsBarraMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.tsBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDisciplina,
            this.btnFase,
            this.btnSemestre,
            this.btnProfessor,
            this.toolStripButton1,
            this.btnInfraEstrutura,
            this.btnSair});
            this.tsBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.tsBarraMenu.Name = "tsBarraMenu";
            this.tsBarraMenu.Padding = new System.Windows.Forms.Padding(5);
            this.tsBarraMenu.Size = new System.Drawing.Size(788, 77);
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
            this.btnFase.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnFase.Size = new System.Drawing.Size(64, 57);
            this.btnFase.Text = "Fases";
            this.btnFase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFase.Click += new System.EventHandler(this.btnFase_Click);
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
            // btnSair
            // 
            this.btnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSair.Image = global::GradeDeHorario.Properties.Resources.ic_logout;
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Margin = new System.Windows.Forms.Padding(5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(44, 57);
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.ToolTipText = "Sair e escolher outro curso";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Location = new System.Drawing.Point(0, 412);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(788, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundImage = global::GradeDeHorario.Properties.Resources.img_background;
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 77);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(788, 335);
            this.pnlBackground.TabIndex = 3;
            // 
            // btnSemestre
            // 
            this.btnSemestre.Image = ((System.Drawing.Image)(resources.GetObject("btnSemestre.Image")));
            this.btnSemestre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSemestre.Margin = new System.Windows.Forms.Padding(5);
            this.btnSemestre.Name = "btnSemestre";
            this.btnSemestre.Size = new System.Drawing.Size(62, 57);
            this.btnSemestre.Text = "Semestres";
            this.btnSemestre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 437);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tsBarraMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(804, 476);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade de Horários";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tsBarraMenu.ResumeLayout(false);
            this.tsBarraMenu.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnSemestre;
    }
}

