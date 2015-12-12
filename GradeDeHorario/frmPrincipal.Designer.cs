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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDisciplina = new System.Windows.Forms.ToolStripButton();
            this.btnFase = new System.Windows.Forms.ToolStripButton();
            this.btnProfessor = new System.Windows.Forms.ToolStripButton();
            this.btnGradeHorario = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
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
            this.btnProfessor,
            this.btnGradeHorario,
            this.btnSair});
            this.tsBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.tsBarraMenu.Name = "tsBarraMenu";
            this.tsBarraMenu.Padding = new System.Windows.Forms.Padding(5);
            this.tsBarraMenu.Size = new System.Drawing.Size(788, 77);
            this.tsBarraMenu.TabIndex = 0;
            this.tsBarraMenu.Text = "BarraDeMenu";
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
            // panel1
            // 
            this.panel1.BackgroundImage = global::GradeDeHorario.Properties.Resources.img_background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 335);
            this.panel1.TabIndex = 3;
            // 
            // btnDisciplina
            // 
            this.btnDisciplina.Image = global::GradeDeHorario.Properties.Resources.ic_board;
            this.btnDisciplina.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDisciplina.Name = "btnDisciplina";
            this.btnDisciplina.Size = new System.Drawing.Size(66, 64);
            this.btnDisciplina.Text = "Disciplinas";
            this.btnDisciplina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDisciplina.Click += new System.EventHandler(this.btnDisciplina_Click);
            // 
            // btnFase
            // 
            this.btnFase.Image = ((System.Drawing.Image)(resources.GetObject("btnFase.Image")));
            this.btnFase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFase.Name = "btnFase";
            this.btnFase.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnFase.Size = new System.Drawing.Size(64, 64);
            this.btnFase.Text = "Fases";
            this.btnFase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFase.Click += new System.EventHandler(this.btnFase_Click);
            // 
            // btnProfessor
            // 
            this.btnProfessor.Image = ((System.Drawing.Image)(resources.GetObject("btnProfessor.Image")));
            this.btnProfessor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(70, 64);
            this.btnProfessor.Text = "Professores";
            this.btnProfessor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click);
            // 
            // btnGradeHorario
            // 
            this.btnGradeHorario.Image = global::GradeDeHorario.Properties.Resources.logo;
            this.btnGradeHorario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGradeHorario.Margin = new System.Windows.Forms.Padding(7, 1, 0, 2);
            this.btnGradeHorario.Name = "btnGradeHorario";
            this.btnGradeHorario.Size = new System.Drawing.Size(44, 64);
            this.btnGradeHorario.Text = "Grade";
            this.btnGradeHorario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGradeHorario.ToolTipText = "Grade de Horários";
            this.btnGradeHorario.Click += new System.EventHandler(this.btnGradeHorario_Click);
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
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 437);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tsBarraMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
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
        private System.Windows.Forms.ToolStripButton btnGradeHorario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton btnSair;
    }
}

