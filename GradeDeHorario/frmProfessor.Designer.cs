namespace GradeDeHorario
{
    partial class frmProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfessor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovoProfessor = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelarEdicao = new System.Windows.Forms.ToolStripButton();
            this.btnSalvarEdicao = new System.Windows.Forms.ToolStripButton();
            this.gbDisciplina = new System.Windows.Forms.GroupBox();
            this.nudCredito = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.gbDisciplina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCredito)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovoProfessor,
            this.btnSalvar,
            this.btnCancelarEdicao,
            this.btnSalvarEdicao});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(639, 69);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNovoProfessor
            // 
            this.btnNovoProfessor.Image = global::GradeDeHorario.Properties.Resources.ic_new;
            this.btnNovoProfessor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovoProfessor.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnNovoProfessor.Name = "btnNovoProfessor";
            this.btnNovoProfessor.Size = new System.Drawing.Size(44, 59);
            this.btnNovoProfessor.Text = "Novo";
            this.btnNovoProfessor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::GradeDeHorario.Properties.Resources.ic_save_all;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(70, 59);
            this.btnSalvar.Text = "Salvar tudo";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnCancelarEdicao
            // 
            this.btnCancelarEdicao.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCancelarEdicao.Image = global::GradeDeHorario.Properties.Resources.ic_menu_close;
            this.btnCancelarEdicao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelarEdicao.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.btnCancelarEdicao.Name = "btnCancelarEdicao";
            this.btnCancelarEdicao.Size = new System.Drawing.Size(57, 59);
            this.btnCancelarEdicao.Text = "Cancelar";
            this.btnCancelarEdicao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelarEdicao.ToolTipText = "Cancelar cadastro do novo professor";
            // 
            // btnSalvarEdicao
            // 
            this.btnSalvarEdicao.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalvarEdicao.Image = global::GradeDeHorario.Properties.Resources.ic_button;
            this.btnSalvarEdicao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvarEdicao.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalvarEdicao.Name = "btnSalvarEdicao";
            this.btnSalvarEdicao.Size = new System.Drawing.Size(44, 59);
            this.btnSalvarEdicao.Text = "Salvar";
            this.btnSalvarEdicao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvarEdicao.ToolTipText = "Salvar o cadastro do novo professor";
            // 
            // gbDisciplina
            // 
            this.gbDisciplina.Controls.Add(this.nudCredito);
            this.gbDisciplina.Controls.Add(this.label3);
            this.gbDisciplina.Controls.Add(this.label2);
            this.gbDisciplina.Controls.Add(this.label1);
            this.gbDisciplina.Controls.Add(this.txtNome);
            this.gbDisciplina.Controls.Add(this.txtCodigo);
            this.gbDisciplina.Location = new System.Drawing.Point(12, 72);
            this.gbDisciplina.Name = "gbDisciplina";
            this.gbDisciplina.Size = new System.Drawing.Size(615, 129);
            this.gbDisciplina.TabIndex = 3;
            this.gbDisciplina.TabStop = false;
            this.gbDisciplina.Text = "Cadastro de disciplina";
            // 
            // nudCredito
            // 
            this.nudCredito.Location = new System.Drawing.Point(66, 85);
            this.nudCredito.Name = "nudCredito";
            this.nudCredito.Size = new System.Drawing.Size(41, 22);
            this.nudCredito.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Créditos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(66, 54);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(407, 22);
            this.txtNome.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(66, 23);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 468);
            this.Controls.Add(this.gbDisciplina);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Professor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Professor";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbDisciplina.ResumeLayout(false);
            this.gbDisciplina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCredito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovoProfessor;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnCancelarEdicao;
        private System.Windows.Forms.ToolStripButton btnSalvarEdicao;
        private System.Windows.Forms.GroupBox gbDisciplina;
        private System.Windows.Forms.NumericUpDown nudCredito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}