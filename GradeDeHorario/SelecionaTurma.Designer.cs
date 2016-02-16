namespace GradeDeHorario
{
    partial class frmSelecionaTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelecionaTurma));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnLimpar = new System.Windows.Forms.ToolStripButton();
            this.dtgSelecionaTurma = new System.Windows.Forms.DataGridView();
            this.SELECIONA_TURMA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CODIGO_TURMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSelecionaTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalvar,
            this.btnLimpar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStrip1.Size = new System.Drawing.Size(234, 72);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::GradeDeHorario.Properties.Resources.ic_button;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(44, 59);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::GradeDeHorario.Properties.Resources.ic_clean;
            this.btnLimpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(48, 62);
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dtgSelecionaTurma
            // 
            this.dtgSelecionaTurma.AllowUserToAddRows = false;
            this.dtgSelecionaTurma.AllowUserToDeleteRows = false;
            this.dtgSelecionaTurma.AllowUserToResizeColumns = false;
            this.dtgSelecionaTurma.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgSelecionaTurma.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgSelecionaTurma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgSelecionaTurma.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgSelecionaTurma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgSelecionaTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSelecionaTurma.ColumnHeadersVisible = false;
            this.dtgSelecionaTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SELECIONA_TURMA,
            this.CODIGO_TURMA});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgSelecionaTurma.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgSelecionaTurma.Location = new System.Drawing.Point(12, 82);
            this.dtgSelecionaTurma.Name = "dtgSelecionaTurma";
            this.dtgSelecionaTurma.RowHeadersVisible = false;
            this.dtgSelecionaTurma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSelecionaTurma.Size = new System.Drawing.Size(210, 126);
            this.dtgSelecionaTurma.TabIndex = 2;
            // 
            // SELECIONA_TURMA
            // 
            this.SELECIONA_TURMA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SELECIONA_TURMA.HeaderText = "";
            this.SELECIONA_TURMA.Name = "SELECIONA_TURMA";
            this.SELECIONA_TURMA.Width = 5;
            // 
            // CODIGO_TURMA
            // 
            this.CODIGO_TURMA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA.HeaderText = "Código";
            this.CODIGO_TURMA.Name = "CODIGO_TURMA";
            this.CODIGO_TURMA.ReadOnly = true;
            this.CODIGO_TURMA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // frmSelecionaTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 220);
            this.Controls.Add(this.dtgSelecionaTurma);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 259);
            this.Name = "frmSelecionaTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção de turma(s)";
            this.Load += new System.EventHandler(this.frmSelecionaTurma_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSelecionaTurma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnLimpar;
        private System.Windows.Forms.DataGridView dtgSelecionaTurma;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECIONA_TURMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA;
    }
}