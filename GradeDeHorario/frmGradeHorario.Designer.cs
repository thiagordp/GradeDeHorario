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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGradeHorario));
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
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gbDisciplina = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPesquisaDisciplina = new System.Windows.Forms.TextBox();
            this.dtgPesquisaDisciplina = new System.Windows.Forms.DataGridView();
            this.SELECT_DISCIPLINA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.COD_DISC_PESQUISA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_DISC_PESQUISA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbProfessor = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgPesquisaProfessor = new System.Windows.Forms.DataGridView();
            this.SELECT_PROFESSOR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.COD_PROF_PESQUISA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_PROF_PESQUISA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisaProfessor = new System.Windows.Forms.TextBox();
            this.gbSala = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgPesquisaEspaco = new System.Windows.Forms.DataGridView();
            this.SELECT_ESPACO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.COD_ESP_PESQUISA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_ESP_PESQUISA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisaEspaco = new System.Windows.Forms.TextBox();
            this.tblGrade = new System.Windows.Forms.TableLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.grade12 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuContexto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itmInserir = new System.Windows.Forms.ToolStripMenuItem();
            this.itmEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.itmExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.itmDetalhes = new System.Windows.Forms.ToolStripMenuItem();
            this.grade13 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade14 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade15 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade16 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade17 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade18 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade19 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade110 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_110 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_110 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_110 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_110 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_110 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_110 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_110 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_110 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade111 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_111 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_111 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_111 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_111 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_111 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_111 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_111 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_111 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade112 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_112 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_112 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_112 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_112 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_112 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_112 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_112 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_112 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade113 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_113 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_113 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_113 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_113 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_113 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_113 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_113 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_113 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade114 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_114 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_114 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_114 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_114 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_114 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_114 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_114 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_114 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade21 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade22 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade23 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade24 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade25 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade26 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade27 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade28 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade29 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade210 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_210 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_210 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_210 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_210 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_210 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_210 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_210 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_210 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade211 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_211 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_211 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_211 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_211 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_211 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_211 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_211 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_211 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade212 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_212 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_212 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_212 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_212 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_212 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_212 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_212 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_212 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade213 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_213 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_213 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_213 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_213 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_213 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_213 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_213 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_213 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade214 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_214 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_214 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_214 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_214 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_214 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_214 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_214 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_214 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade31 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade32 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade33 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade34 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade35 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade36 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade37 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade38 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade39 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade310 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_310 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_310 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_310 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_310 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_310 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_310 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_310 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_310 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade311 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_311 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_311 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_311 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_311 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_311 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_311 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_311 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_311 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade312 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_312 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_312 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_312 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_312 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_312 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_312 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_312 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_312 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade313 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_313 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_313 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_313 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_313 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_313 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_313 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_313 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_313 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade314 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_314 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_314 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_314 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_314 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_314 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_314 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_314 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_314 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade41 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade42 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade43 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade44 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade45 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade46 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade47 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade48 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade49 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade410 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_410 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_410 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_410 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_410 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_410 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_410 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_410 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_410 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade411 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_411 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_411 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_411 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_411 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_411 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_411 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_411 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_411 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade412 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_412 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_412 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_412 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_412 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_412 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_412 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_412 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_412 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade413 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_413 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_413 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_413 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_413 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_413 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_413 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_413 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_413 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade414 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_414 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_414 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_414 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_414 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_414 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_414 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_414 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_414 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade51 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade52 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade53 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade54 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade55 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade56 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade57 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade58 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade59 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade510 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_510 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_510 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_510 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_510 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_510 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_510 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_510 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_510 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade511 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_511 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_511 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_511 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_511 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_511 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_511 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_511 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_511 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade512 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_512 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_512 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_512 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_512 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_512 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_512 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_512 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_512 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade513 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_513 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_513 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_513 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_513 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_513 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_513 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_513 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_513 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade514 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_514 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_514 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_514 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_514 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_514 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_514 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_514 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_514 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade61 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade62 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade63 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade64 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade65 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade66 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade67 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_67 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_67 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_67 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_67 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_67 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_67 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_67 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_67 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade68 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_68 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_68 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_68 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_68 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_68 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_68 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_68 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_68 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade69 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_69 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_69 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_69 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_69 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_69 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_69 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_69 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_69 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade610 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_610 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_610 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_610 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_610 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_610 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_610 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_610 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_610 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade611 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_611 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_611 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_611 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_611 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_611 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_611 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_611 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_611 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade612 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_612 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_612 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_612 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_612 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_612 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_612 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_612 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_612 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade613 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_613 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_613 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_613 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_613 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_613 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_613 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_613 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_613 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade614 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_614 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_614 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_614 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_614 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_614 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_614 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_614 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_614 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade11 = new System.Windows.Forms.DataGridView();
            this.HORARIO_GRADE_11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA_GRADE_11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_DISCIPLINA_11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_TURMA_11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_ESPACO_11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR1_11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR2_11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROFESSOR3_11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbDisciplina.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaDisciplina)).BeginInit();
            this.gbProfessor.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaProfessor)).BeginInit();
            this.gbSala.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaEspaco)).BeginInit();
            this.tblGrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grade12)).BeginInit();
            this.menuContexto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grade13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade110)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade111)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade112)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade113)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade114)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade210)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade211)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade212)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade213)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade214)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade310)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade311)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade312)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade313)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade314)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade410)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade411)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade412)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade413)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade414)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade510)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade511)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade512)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade513)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade514)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade67)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade68)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade69)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade610)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade611)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade612)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade613)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade614)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade11)).BeginInit();
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
            this.btnGerarRelatorio,
            this.btnEditar,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(884, 69);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Test";
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
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = global::GradeDeHorario.Properties.Resources.ic_menu_close;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 59);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = global::GradeDeHorario.Properties.Resources.ic_button;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(44, 59);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbbSelectFase
            // 
            this.cbbSelectFase.AutoToolTip = true;
            this.cbbSelectFase.BackColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.cbbSelectFase.Size = new System.Drawing.Size(75, 69);
            this.cbbSelectFase.ToolTipText = "Selecione a fase";
            this.cbbSelectFase.Click += new System.EventHandler(this.cbbSelectFase_Click);
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
            this.cbbSelectSemestre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbbSelectSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSelectSemestre.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbbSelectSemestre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cbbSelectSemestre.Name = "cbbSelectSemestre";
            this.cbbSelectSemestre.Size = new System.Drawing.Size(75, 69);
            this.cbbSelectSemestre.Click += new System.EventHandler(this.cbbSelectSemestre_Click);
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
            this.btnCarregaGrade.Click += new System.EventHandler(this.btnCarregaGrade_Click);
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
            this.btnGerarRelatorio.Enabled = false;
            this.btnGerarRelatorio.Image = global::GradeDeHorario.Properties.Resources.ic_relatorio;
            this.btnGerarRelatorio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGerarRelatorio.Margin = new System.Windows.Forms.Padding(5);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(58, 59);
            this.btnGerarRelatorio.Text = "Relatório";
            this.btnGerarRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGerarRelatorio.ToolTipText = "Gerar relatório com os horários estabelecidos";
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::GradeDeHorario.Properties.Resources.ic_edit;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(44, 59);
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 59);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.875F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tblGrade, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 524);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.gbDisciplina, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gbProfessor, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.gbSala, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(687, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(192, 514);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // gbDisciplina
            // 
            this.gbDisciplina.Controls.Add(this.tableLayoutPanel3);
            this.gbDisciplina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDisciplina.Enabled = false;
            this.gbDisciplina.Location = new System.Drawing.Point(3, 3);
            this.gbDisciplina.Name = "gbDisciplina";
            this.gbDisciplina.Padding = new System.Windows.Forms.Padding(5);
            this.gbDisciplina.Size = new System.Drawing.Size(186, 165);
            this.gbDisciplina.TabIndex = 0;
            this.gbDisciplina.TabStop = false;
            this.gbDisciplina.Text = "Disciplinas";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.txtPesquisaDisciplina, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dtgPesquisaDisciplina, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 18);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(176, 142);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // txtPesquisaDisciplina
            // 
            this.txtPesquisaDisciplina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisaDisciplina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPesquisaDisciplina.Location = new System.Drawing.Point(3, 3);
            this.txtPesquisaDisciplina.Name = "txtPesquisaDisciplina";
            this.txtPesquisaDisciplina.Size = new System.Drawing.Size(170, 20);
            this.txtPesquisaDisciplina.TabIndex = 0;
            this.txtPesquisaDisciplina.WordWrap = false;
            this.txtPesquisaDisciplina.TextChanged += new System.EventHandler(this.txtPesquisaDisciplina_TextChanged);
            // 
            // dtgPesquisaDisciplina
            // 
            this.dtgPesquisaDisciplina.AllowUserToAddRows = false;
            this.dtgPesquisaDisciplina.AllowUserToDeleteRows = false;
            this.dtgPesquisaDisciplina.AllowUserToResizeColumns = false;
            this.dtgPesquisaDisciplina.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgPesquisaDisciplina.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPesquisaDisciplina.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgPesquisaDisciplina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgPesquisaDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPesquisaDisciplina.ColumnHeadersVisible = false;
            this.dtgPesquisaDisciplina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SELECT_DISCIPLINA,
            this.COD_DISC_PESQUISA,
            this.NOME_DISC_PESQUISA,
            this.CODIGO_TURMA});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPesquisaDisciplina.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPesquisaDisciplina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPesquisaDisciplina.Location = new System.Drawing.Point(3, 28);
            this.dtgPesquisaDisciplina.MultiSelect = false;
            this.dtgPesquisaDisciplina.Name = "dtgPesquisaDisciplina";
            this.dtgPesquisaDisciplina.RowHeadersVisible = false;
            this.dtgPesquisaDisciplina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPesquisaDisciplina.Size = new System.Drawing.Size(170, 111);
            this.dtgPesquisaDisciplina.TabIndex = 1;
            // 
            // SELECT_DISCIPLINA
            // 
            this.SELECT_DISCIPLINA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.SELECT_DISCIPLINA.HeaderText = "";
            this.SELECT_DISCIPLINA.Name = "SELECT_DISCIPLINA";
            this.SELECT_DISCIPLINA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SELECT_DISCIPLINA.Width = 5;
            // 
            // COD_DISC_PESQUISA
            // 
            this.COD_DISC_PESQUISA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COD_DISC_PESQUISA.DataPropertyName = "CODIGO_DISCIPLINA";
            this.COD_DISC_PESQUISA.HeaderText = "Código";
            this.COD_DISC_PESQUISA.MinimumWidth = 50;
            this.COD_DISC_PESQUISA.Name = "COD_DISC_PESQUISA";
            this.COD_DISC_PESQUISA.ReadOnly = true;
            this.COD_DISC_PESQUISA.Width = 50;
            // 
            // NOME_DISC_PESQUISA
            // 
            this.NOME_DISC_PESQUISA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOME_DISC_PESQUISA.DataPropertyName = "NOME_DISCIPLINA";
            this.NOME_DISC_PESQUISA.HeaderText = "Nome";
            this.NOME_DISC_PESQUISA.Name = "NOME_DISC_PESQUISA";
            this.NOME_DISC_PESQUISA.ReadOnly = true;
            // 
            // CODIGO_TURMA
            // 
            this.CODIGO_TURMA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_TURMA.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA.HeaderText = "Turma";
            this.CODIGO_TURMA.Name = "CODIGO_TURMA";
            this.CODIGO_TURMA.ReadOnly = true;
            this.CODIGO_TURMA.Width = 5;
            // 
            // gbProfessor
            // 
            this.gbProfessor.Controls.Add(this.tableLayoutPanel4);
            this.gbProfessor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProfessor.Enabled = false;
            this.gbProfessor.Location = new System.Drawing.Point(3, 174);
            this.gbProfessor.Name = "gbProfessor";
            this.gbProfessor.Size = new System.Drawing.Size(186, 165);
            this.gbProfessor.TabIndex = 1;
            this.gbProfessor.TabStop = false;
            this.gbProfessor.Text = "Professores";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.dtgPesquisaProfessor, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtPesquisaProfessor, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(180, 146);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // dtgPesquisaProfessor
            // 
            this.dtgPesquisaProfessor.AllowUserToAddRows = false;
            this.dtgPesquisaProfessor.AllowUserToDeleteRows = false;
            this.dtgPesquisaProfessor.AllowUserToResizeColumns = false;
            this.dtgPesquisaProfessor.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgPesquisaProfessor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgPesquisaProfessor.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgPesquisaProfessor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgPesquisaProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPesquisaProfessor.ColumnHeadersVisible = false;
            this.dtgPesquisaProfessor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SELECT_PROFESSOR,
            this.COD_PROF_PESQUISA,
            this.NOME_PROF_PESQUISA});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPesquisaProfessor.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgPesquisaProfessor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPesquisaProfessor.Location = new System.Drawing.Point(3, 28);
            this.dtgPesquisaProfessor.MultiSelect = false;
            this.dtgPesquisaProfessor.Name = "dtgPesquisaProfessor";
            this.dtgPesquisaProfessor.RowHeadersVisible = false;
            this.dtgPesquisaProfessor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPesquisaProfessor.Size = new System.Drawing.Size(174, 115);
            this.dtgPesquisaProfessor.TabIndex = 2;
            // 
            // SELECT_PROFESSOR
            // 
            this.SELECT_PROFESSOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.SELECT_PROFESSOR.HeaderText = "";
            this.SELECT_PROFESSOR.Name = "SELECT_PROFESSOR";
            this.SELECT_PROFESSOR.Width = 5;
            // 
            // COD_PROF_PESQUISA
            // 
            this.COD_PROF_PESQUISA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COD_PROF_PESQUISA.DataPropertyName = "CODIGO_PROFESSOR";
            this.COD_PROF_PESQUISA.HeaderText = "Código";
            this.COD_PROF_PESQUISA.MinimumWidth = 30;
            this.COD_PROF_PESQUISA.Name = "COD_PROF_PESQUISA";
            this.COD_PROF_PESQUISA.ReadOnly = true;
            this.COD_PROF_PESQUISA.Width = 30;
            // 
            // NOME_PROF_PESQUISA
            // 
            this.NOME_PROF_PESQUISA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOME_PROF_PESQUISA.DataPropertyName = "NOME_PROFESSOR";
            this.NOME_PROF_PESQUISA.HeaderText = "Nome";
            this.NOME_PROF_PESQUISA.Name = "NOME_PROF_PESQUISA";
            this.NOME_PROF_PESQUISA.ReadOnly = true;
            // 
            // txtPesquisaProfessor
            // 
            this.txtPesquisaProfessor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisaProfessor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPesquisaProfessor.Location = new System.Drawing.Point(3, 3);
            this.txtPesquisaProfessor.Name = "txtPesquisaProfessor";
            this.txtPesquisaProfessor.Size = new System.Drawing.Size(174, 20);
            this.txtPesquisaProfessor.TabIndex = 0;
            this.txtPesquisaProfessor.WordWrap = false;
            this.txtPesquisaProfessor.TextChanged += new System.EventHandler(this.txtPesquisaProfessor_TextChanged);
            // 
            // gbSala
            // 
            this.gbSala.Controls.Add(this.tableLayoutPanel5);
            this.gbSala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSala.Enabled = false;
            this.gbSala.Location = new System.Drawing.Point(3, 345);
            this.gbSala.Name = "gbSala";
            this.gbSala.Size = new System.Drawing.Size(186, 166);
            this.gbSala.TabIndex = 2;
            this.gbSala.TabStop = false;
            this.gbSala.Text = "Salas e laboratórios";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.dtgPesquisaEspaco, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtPesquisaEspaco, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(180, 147);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // dtgPesquisaEspaco
            // 
            this.dtgPesquisaEspaco.AllowUserToAddRows = false;
            this.dtgPesquisaEspaco.AllowUserToDeleteRows = false;
            this.dtgPesquisaEspaco.AllowUserToResizeColumns = false;
            this.dtgPesquisaEspaco.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgPesquisaEspaco.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgPesquisaEspaco.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgPesquisaEspaco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgPesquisaEspaco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPesquisaEspaco.ColumnHeadersVisible = false;
            this.dtgPesquisaEspaco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SELECT_ESPACO,
            this.COD_ESP_PESQUISA,
            this.TIPO_ESP_PESQUISA});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPesquisaEspaco.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgPesquisaEspaco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPesquisaEspaco.Location = new System.Drawing.Point(3, 28);
            this.dtgPesquisaEspaco.MultiSelect = false;
            this.dtgPesquisaEspaco.Name = "dtgPesquisaEspaco";
            this.dtgPesquisaEspaco.RowHeadersVisible = false;
            this.dtgPesquisaEspaco.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgPesquisaEspaco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPesquisaEspaco.Size = new System.Drawing.Size(174, 116);
            this.dtgPesquisaEspaco.TabIndex = 2;
            // 
            // SELECT_ESPACO
            // 
            this.SELECT_ESPACO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.SELECT_ESPACO.HeaderText = "";
            this.SELECT_ESPACO.Name = "SELECT_ESPACO";
            this.SELECT_ESPACO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SELECT_ESPACO.Width = 5;
            // 
            // COD_ESP_PESQUISA
            // 
            this.COD_ESP_PESQUISA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COD_ESP_PESQUISA.DataPropertyName = "CODIGO_ESPACO";
            this.COD_ESP_PESQUISA.HeaderText = "Código";
            this.COD_ESP_PESQUISA.MinimumWidth = 50;
            this.COD_ESP_PESQUISA.Name = "COD_ESP_PESQUISA";
            // 
            // TIPO_ESP_PESQUISA
            // 
            this.TIPO_ESP_PESQUISA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TIPO_ESP_PESQUISA.DataPropertyName = "TIPO_ESPACO";
            this.TIPO_ESP_PESQUISA.HeaderText = "Tipo";
            this.TIPO_ESP_PESQUISA.Name = "TIPO_ESP_PESQUISA";
            // 
            // txtPesquisaEspaco
            // 
            this.txtPesquisaEspaco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisaEspaco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPesquisaEspaco.Location = new System.Drawing.Point(3, 3);
            this.txtPesquisaEspaco.Name = "txtPesquisaEspaco";
            this.txtPesquisaEspaco.Size = new System.Drawing.Size(174, 20);
            this.txtPesquisaEspaco.TabIndex = 0;
            this.txtPesquisaEspaco.WordWrap = false;
            this.txtPesquisaEspaco.TextChanged += new System.EventHandler(this.txtPesquisaEspaco_TextChanged);
            // 
            // tblGrade
            // 
            this.tblGrade.BackColor = System.Drawing.SystemColors.Control;
            this.tblGrade.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblGrade.ColumnCount = 7;
            this.tblGrade.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblGrade.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66694F));
            this.tblGrade.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66694F));
            this.tblGrade.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66694F));
            this.tblGrade.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66694F));
            this.tblGrade.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66694F));
            this.tblGrade.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66528F));
            this.tblGrade.Controls.Add(this.label18, 0, 10);
            this.tblGrade.Controls.Add(this.label17, 0, 9);
            this.tblGrade.Controls.Add(this.label16, 0, 8);
            this.tblGrade.Controls.Add(this.label15, 0, 7);
            this.tblGrade.Controls.Add(this.label14, 0, 6);
            this.tblGrade.Controls.Add(this.label12, 0, 5);
            this.tblGrade.Controls.Add(this.label11, 0, 4);
            this.tblGrade.Controls.Add(this.label10, 0, 3);
            this.tblGrade.Controls.Add(this.label9, 0, 2);
            this.tblGrade.Controls.Add(this.label8, 0, 1);
            this.tblGrade.Controls.Add(this.label6, 6, 0);
            this.tblGrade.Controls.Add(this.label5, 5, 0);
            this.tblGrade.Controls.Add(this.label4, 4, 0);
            this.tblGrade.Controls.Add(this.label3, 3, 0);
            this.tblGrade.Controls.Add(this.label2, 2, 0);
            this.tblGrade.Controls.Add(this.label1, 1, 0);
            this.tblGrade.Controls.Add(this.label7, 0, 0);
            this.tblGrade.Controls.Add(this.label20, 0, 11);
            this.tblGrade.Controls.Add(this.label21, 0, 12);
            this.tblGrade.Controls.Add(this.label23, 0, 14);
            this.tblGrade.Controls.Add(this.label13, 0, 13);
            this.tblGrade.Controls.Add(this.grade12, 1, 2);
            this.tblGrade.Controls.Add(this.grade13, 1, 3);
            this.tblGrade.Controls.Add(this.grade14, 1, 4);
            this.tblGrade.Controls.Add(this.grade15, 1, 5);
            this.tblGrade.Controls.Add(this.grade16, 1, 6);
            this.tblGrade.Controls.Add(this.grade17, 1, 7);
            this.tblGrade.Controls.Add(this.grade18, 1, 8);
            this.tblGrade.Controls.Add(this.grade19, 1, 9);
            this.tblGrade.Controls.Add(this.grade110, 1, 10);
            this.tblGrade.Controls.Add(this.grade111, 1, 11);
            this.tblGrade.Controls.Add(this.grade112, 1, 12);
            this.tblGrade.Controls.Add(this.grade113, 1, 13);
            this.tblGrade.Controls.Add(this.grade114, 1, 14);
            this.tblGrade.Controls.Add(this.grade21, 2, 1);
            this.tblGrade.Controls.Add(this.grade22, 2, 2);
            this.tblGrade.Controls.Add(this.grade23, 2, 3);
            this.tblGrade.Controls.Add(this.grade24, 2, 4);
            this.tblGrade.Controls.Add(this.grade25, 2, 5);
            this.tblGrade.Controls.Add(this.grade26, 2, 6);
            this.tblGrade.Controls.Add(this.grade27, 2, 7);
            this.tblGrade.Controls.Add(this.grade28, 2, 8);
            this.tblGrade.Controls.Add(this.grade29, 2, 9);
            this.tblGrade.Controls.Add(this.grade210, 2, 10);
            this.tblGrade.Controls.Add(this.grade211, 2, 11);
            this.tblGrade.Controls.Add(this.grade212, 2, 12);
            this.tblGrade.Controls.Add(this.grade213, 2, 13);
            this.tblGrade.Controls.Add(this.grade214, 2, 14);
            this.tblGrade.Controls.Add(this.grade31, 3, 1);
            this.tblGrade.Controls.Add(this.grade32, 3, 2);
            this.tblGrade.Controls.Add(this.grade33, 3, 3);
            this.tblGrade.Controls.Add(this.grade34, 3, 4);
            this.tblGrade.Controls.Add(this.grade35, 3, 5);
            this.tblGrade.Controls.Add(this.grade36, 3, 6);
            this.tblGrade.Controls.Add(this.grade37, 3, 7);
            this.tblGrade.Controls.Add(this.grade38, 3, 8);
            this.tblGrade.Controls.Add(this.grade39, 3, 9);
            this.tblGrade.Controls.Add(this.grade310, 3, 10);
            this.tblGrade.Controls.Add(this.grade311, 3, 11);
            this.tblGrade.Controls.Add(this.grade312, 3, 12);
            this.tblGrade.Controls.Add(this.grade313, 3, 13);
            this.tblGrade.Controls.Add(this.grade314, 3, 14);
            this.tblGrade.Controls.Add(this.grade41, 4, 1);
            this.tblGrade.Controls.Add(this.grade42, 4, 2);
            this.tblGrade.Controls.Add(this.grade43, 4, 3);
            this.tblGrade.Controls.Add(this.grade44, 4, 4);
            this.tblGrade.Controls.Add(this.grade45, 4, 5);
            this.tblGrade.Controls.Add(this.grade46, 4, 6);
            this.tblGrade.Controls.Add(this.grade47, 4, 7);
            this.tblGrade.Controls.Add(this.grade48, 4, 8);
            this.tblGrade.Controls.Add(this.grade49, 4, 9);
            this.tblGrade.Controls.Add(this.grade410, 4, 10);
            this.tblGrade.Controls.Add(this.grade411, 4, 11);
            this.tblGrade.Controls.Add(this.grade412, 4, 12);
            this.tblGrade.Controls.Add(this.grade413, 4, 13);
            this.tblGrade.Controls.Add(this.grade414, 4, 14);
            this.tblGrade.Controls.Add(this.grade51, 5, 1);
            this.tblGrade.Controls.Add(this.grade52, 5, 2);
            this.tblGrade.Controls.Add(this.grade53, 5, 3);
            this.tblGrade.Controls.Add(this.grade54, 5, 4);
            this.tblGrade.Controls.Add(this.grade55, 5, 5);
            this.tblGrade.Controls.Add(this.grade56, 5, 6);
            this.tblGrade.Controls.Add(this.grade57, 5, 7);
            this.tblGrade.Controls.Add(this.grade58, 5, 8);
            this.tblGrade.Controls.Add(this.grade59, 5, 9);
            this.tblGrade.Controls.Add(this.grade510, 5, 10);
            this.tblGrade.Controls.Add(this.grade511, 5, 11);
            this.tblGrade.Controls.Add(this.grade512, 5, 12);
            this.tblGrade.Controls.Add(this.grade513, 5, 13);
            this.tblGrade.Controls.Add(this.grade514, 5, 14);
            this.tblGrade.Controls.Add(this.grade61, 6, 1);
            this.tblGrade.Controls.Add(this.grade62, 6, 2);
            this.tblGrade.Controls.Add(this.grade63, 6, 3);
            this.tblGrade.Controls.Add(this.grade64, 6, 4);
            this.tblGrade.Controls.Add(this.grade65, 6, 5);
            this.tblGrade.Controls.Add(this.grade66, 6, 6);
            this.tblGrade.Controls.Add(this.grade67, 6, 7);
            this.tblGrade.Controls.Add(this.grade68, 6, 8);
            this.tblGrade.Controls.Add(this.grade69, 6, 9);
            this.tblGrade.Controls.Add(this.grade610, 6, 10);
            this.tblGrade.Controls.Add(this.grade611, 6, 11);
            this.tblGrade.Controls.Add(this.grade612, 6, 12);
            this.tblGrade.Controls.Add(this.grade613, 6, 13);
            this.tblGrade.Controls.Add(this.grade614, 6, 14);
            this.tblGrade.Controls.Add(this.grade11, 1, 1);
            this.tblGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblGrade.Enabled = false;
            this.tblGrade.Location = new System.Drawing.Point(10, 10);
            this.tblGrade.Margin = new System.Windows.Forms.Padding(5);
            this.tblGrade.Name = "tblGrade";
            this.tblGrade.RowCount = 15;
            this.tblGrade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblGrade.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblGrade.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblGrade.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblGrade.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblGrade.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblGrade.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblGrade.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblGrade.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblGrade.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblGrade.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblGrade.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblGrade.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblGrade.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblGrade.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblGrade.Size = new System.Drawing.Size(672, 504);
            this.tblGrade.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.SeaGreen;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(4, 334);
            this.label18.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 31);
            this.label18.TabIndex = 116;
            this.label18.Text = "17:10 - 18:00";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.SeaGreen;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(4, 300);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 31);
            this.label17.TabIndex = 115;
            this.label17.Text = "16:20 - 17:10";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.SeaGreen;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(4, 266);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 31);
            this.label16.TabIndex = 114;
            this.label16.Text = "15:10 - 16:00";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.SeaGreen;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(4, 232);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 31);
            this.label15.TabIndex = 113;
            this.label15.Text = "14:20 - 15:10";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.SeaGreen;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(4, 198);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 31);
            this.label14.TabIndex = 112;
            this.label14.Text = "13:30 - 14:20";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkKhaki;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(4, 164);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 31);
            this.label12.TabIndex = 110;
            this.label12.Text = "11:00 - 11:50";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkKhaki;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(4, 130);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 31);
            this.label11.TabIndex = 109;
            this.label11.Text = "10:10 - 11:00";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkKhaki;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(4, 96);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 31);
            this.label10.TabIndex = 108;
            this.label10.Text = "09:10 - 10:00";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkKhaki;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(4, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 31);
            this.label9.TabIndex = 107;
            this.label9.Text = "08:20 - 09:10";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkKhaki;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(4, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 31);
            this.label8.TabIndex = 106;
            this.label8.Text = "07:30 - 08:20";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(572, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "SÁBADO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(476, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "SEXTA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(380, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "QUINTA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(284, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "QUARTA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(188, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "TERÇA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(92, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEGUNDA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(4, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 120;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.SteelBlue;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(4, 368);
            this.label20.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 31);
            this.label20.TabIndex = 121;
            this.label20.Text = "18:30 - 19:20";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.SteelBlue;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(4, 402);
            this.label21.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 31);
            this.label21.TabIndex = 122;
            this.label21.Text = "19:20 - 20:10";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.SteelBlue;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(4, 470);
            this.label23.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 32);
            this.label23.TabIndex = 124;
            this.label23.Text = "21:10 - 22:00";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.SteelBlue;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(4, 436);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 31);
            this.label13.TabIndex = 149;
            this.label13.Text = "20:20 - 21:10";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grade12
            // 
            this.grade12.AllowUserToAddRows = false;
            this.grade12.AllowUserToDeleteRows = false;
            this.grade12.AllowUserToResizeColumns = false;
            this.grade12.AllowUserToResizeRows = false;
            this.grade12.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade12.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade12.ColumnHeadersVisible = false;
            this.grade12.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_12,
            this.DIA_SEMANA_GRADE_12,
            this.CODIGO_DISCIPLINA_12,
            this.CODIGO_TURMA_12,
            this.CODIGO_ESPACO_12,
            this.CODIGO_PROFESSOR1_12,
            this.CODIGO_PROFESSOR2_12,
            this.CODIGO_PROFESSOR3_12});
            this.grade12.ContextMenuStrip = this.menuContexto;
            this.grade12.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade12.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade12.Location = new System.Drawing.Point(94, 64);
            this.grade12.MultiSelect = false;
            this.grade12.Name = "grade12";
            this.grade12.ReadOnly = true;
            this.grade12.RowHeadersVisible = false;
            this.grade12.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade12.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade12.Size = new System.Drawing.Size(89, 27);
            this.grade12.TabIndex = 150;
            this.grade12.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade12.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_12
            // 
            this.HORARIO_GRADE_12.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_12.HeaderText = "HORARIO_GRADE_12";
            this.HORARIO_GRADE_12.Name = "HORARIO_GRADE_12";
            this.HORARIO_GRADE_12.ReadOnly = true;
            this.HORARIO_GRADE_12.Visible = false;
            // 
            // DIA_SEMANA_GRADE_12
            // 
            this.DIA_SEMANA_GRADE_12.HeaderText = "DIA_SEMANA_GRADE_12";
            this.DIA_SEMANA_GRADE_12.Name = "DIA_SEMANA_GRADE_12";
            this.DIA_SEMANA_GRADE_12.ReadOnly = true;
            this.DIA_SEMANA_GRADE_12.Visible = false;
            // 
            // CODIGO_DISCIPLINA_12
            // 
            this.CODIGO_DISCIPLINA_12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_12.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_12.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_12.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_12.Name = "CODIGO_DISCIPLINA_12";
            this.CODIGO_DISCIPLINA_12.ReadOnly = true;
            this.CODIGO_DISCIPLINA_12.Width = 20;
            // 
            // CODIGO_TURMA_12
            // 
            this.CODIGO_TURMA_12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_12.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_12.HeaderText = "Turma";
            this.CODIGO_TURMA_12.MinimumWidth = 20;
            this.CODIGO_TURMA_12.Name = "CODIGO_TURMA_12";
            this.CODIGO_TURMA_12.ReadOnly = true;
            // 
            // CODIGO_ESPACO_12
            // 
            this.CODIGO_ESPACO_12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_12.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_12.HeaderText = "Sala";
            this.CODIGO_ESPACO_12.MinimumWidth = 20;
            this.CODIGO_ESPACO_12.Name = "CODIGO_ESPACO_12";
            this.CODIGO_ESPACO_12.ReadOnly = true;
            this.CODIGO_ESPACO_12.Width = 20;
            // 
            // CODIGO_PROFESSOR1_12
            // 
            this.CODIGO_PROFESSOR1_12.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_12.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_12.Name = "CODIGO_PROFESSOR1_12";
            this.CODIGO_PROFESSOR1_12.ReadOnly = true;
            this.CODIGO_PROFESSOR1_12.Visible = false;
            // 
            // CODIGO_PROFESSOR2_12
            // 
            this.CODIGO_PROFESSOR2_12.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_12.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_12.Name = "CODIGO_PROFESSOR2_12";
            this.CODIGO_PROFESSOR2_12.ReadOnly = true;
            this.CODIGO_PROFESSOR2_12.Visible = false;
            // 
            // CODIGO_PROFESSOR3_12
            // 
            this.CODIGO_PROFESSOR3_12.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_12.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_12.Name = "CODIGO_PROFESSOR3_12";
            this.CODIGO_PROFESSOR3_12.ReadOnly = true;
            this.CODIGO_PROFESSOR3_12.Visible = false;
            // 
            // menuContexto
            // 
            this.menuContexto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmInserir,
            this.itmEditar,
            this.itmExcluir,
            this.itmDetalhes});
            this.menuContexto.Name = "menuContexto";
            this.menuContexto.Size = new System.Drawing.Size(120, 92);
            // 
            // itmInserir
            // 
            this.itmInserir.Image = global::GradeDeHorario.Properties.Resources.ic_save_all;
            this.itmInserir.Name = "itmInserir";
            this.itmInserir.Size = new System.Drawing.Size(119, 22);
            this.itmInserir.Text = "Inserir";
            this.itmInserir.Click += new System.EventHandler(this.itmInserir_Click);
            // 
            // itmEditar
            // 
            this.itmEditar.Image = global::GradeDeHorario.Properties.Resources.ic_edit;
            this.itmEditar.Name = "itmEditar";
            this.itmEditar.Size = new System.Drawing.Size(119, 22);
            this.itmEditar.Text = "Editar";
            this.itmEditar.Click += new System.EventHandler(this.itmEditar_Click);
            // 
            // itmExcluir
            // 
            this.itmExcluir.Image = global::GradeDeHorario.Properties.Resources.ic_delete;
            this.itmExcluir.Name = "itmExcluir";
            this.itmExcluir.Size = new System.Drawing.Size(119, 22);
            this.itmExcluir.Text = "Excluir";
            this.itmExcluir.Click += new System.EventHandler(this.itmExcluir_Click);
            // 
            // itmDetalhes
            // 
            this.itmDetalhes.Image = global::GradeDeHorario.Properties.Resources.ic_info;
            this.itmDetalhes.Name = "itmDetalhes";
            this.itmDetalhes.Size = new System.Drawing.Size(119, 22);
            this.itmDetalhes.Text = "Detalhes";
            this.itmDetalhes.Click += new System.EventHandler(this.itmDetalhes_Click);
            // 
            // grade13
            // 
            this.grade13.AllowUserToAddRows = false;
            this.grade13.AllowUserToDeleteRows = false;
            this.grade13.AllowUserToResizeColumns = false;
            this.grade13.AllowUserToResizeRows = false;
            this.grade13.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade13.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade13.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade13.ColumnHeadersVisible = false;
            this.grade13.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_13,
            this.DIA_SEMANA_GRADE_13,
            this.CODIGO_DISCIPLINA_13,
            this.CODIGO_TURMA_13,
            this.CODIGO_ESPACO_13,
            this.CODIGO_PROFESSOR1_13,
            this.CODIGO_PROFESSOR2_13,
            this.CODIGO_PROFESSOR3_13});
            this.grade13.ContextMenuStrip = this.menuContexto;
            this.grade13.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade13.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade13.Location = new System.Drawing.Point(94, 98);
            this.grade13.MultiSelect = false;
            this.grade13.Name = "grade13";
            this.grade13.ReadOnly = true;
            this.grade13.RowHeadersVisible = false;
            this.grade13.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade13.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade13.Size = new System.Drawing.Size(89, 27);
            this.grade13.TabIndex = 150;
            this.grade13.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade13.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade13.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_13
            // 
            this.HORARIO_GRADE_13.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_13.HeaderText = "HORARIO_GRADE_13";
            this.HORARIO_GRADE_13.Name = "HORARIO_GRADE_13";
            this.HORARIO_GRADE_13.ReadOnly = true;
            this.HORARIO_GRADE_13.Visible = false;
            // 
            // DIA_SEMANA_GRADE_13
            // 
            this.DIA_SEMANA_GRADE_13.HeaderText = "DIA_SEMANA_GRADE_13";
            this.DIA_SEMANA_GRADE_13.Name = "DIA_SEMANA_GRADE_13";
            this.DIA_SEMANA_GRADE_13.ReadOnly = true;
            this.DIA_SEMANA_GRADE_13.Visible = false;
            // 
            // CODIGO_DISCIPLINA_13
            // 
            this.CODIGO_DISCIPLINA_13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_13.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_13.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_13.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_13.Name = "CODIGO_DISCIPLINA_13";
            this.CODIGO_DISCIPLINA_13.ReadOnly = true;
            this.CODIGO_DISCIPLINA_13.Width = 20;
            // 
            // CODIGO_TURMA_13
            // 
            this.CODIGO_TURMA_13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_13.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_13.HeaderText = "Turma";
            this.CODIGO_TURMA_13.MinimumWidth = 20;
            this.CODIGO_TURMA_13.Name = "CODIGO_TURMA_13";
            this.CODIGO_TURMA_13.ReadOnly = true;
            // 
            // CODIGO_ESPACO_13
            // 
            this.CODIGO_ESPACO_13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_13.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_13.HeaderText = "Sala";
            this.CODIGO_ESPACO_13.MinimumWidth = 20;
            this.CODIGO_ESPACO_13.Name = "CODIGO_ESPACO_13";
            this.CODIGO_ESPACO_13.ReadOnly = true;
            this.CODIGO_ESPACO_13.Width = 20;
            // 
            // CODIGO_PROFESSOR1_13
            // 
            this.CODIGO_PROFESSOR1_13.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_13.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_13.Name = "CODIGO_PROFESSOR1_13";
            this.CODIGO_PROFESSOR1_13.ReadOnly = true;
            this.CODIGO_PROFESSOR1_13.Visible = false;
            // 
            // CODIGO_PROFESSOR2_13
            // 
            this.CODIGO_PROFESSOR2_13.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_13.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_13.Name = "CODIGO_PROFESSOR2_13";
            this.CODIGO_PROFESSOR2_13.ReadOnly = true;
            this.CODIGO_PROFESSOR2_13.Visible = false;
            // 
            // CODIGO_PROFESSOR3_13
            // 
            this.CODIGO_PROFESSOR3_13.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_13.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_13.Name = "CODIGO_PROFESSOR3_13";
            this.CODIGO_PROFESSOR3_13.ReadOnly = true;
            this.CODIGO_PROFESSOR3_13.Visible = false;
            // 
            // grade14
            // 
            this.grade14.AllowUserToAddRows = false;
            this.grade14.AllowUserToDeleteRows = false;
            this.grade14.AllowUserToResizeColumns = false;
            this.grade14.AllowUserToResizeRows = false;
            this.grade14.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade14.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade14.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade14.ColumnHeadersVisible = false;
            this.grade14.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_14,
            this.DIA_SEMANA_GRADE_14,
            this.CODIGO_DISCIPLINA_14,
            this.CODIGO_TURMA_14,
            this.CODIGO_ESPACO_14,
            this.CODIGO_PROFESSOR1_14,
            this.CODIGO_PROFESSOR2_14,
            this.CODIGO_PROFESSOR3_14});
            this.grade14.ContextMenuStrip = this.menuContexto;
            this.grade14.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade14.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade14.Location = new System.Drawing.Point(94, 132);
            this.grade14.MultiSelect = false;
            this.grade14.Name = "grade14";
            this.grade14.ReadOnly = true;
            this.grade14.RowHeadersVisible = false;
            this.grade14.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade14.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade14.Size = new System.Drawing.Size(89, 27);
            this.grade14.TabIndex = 150;
            this.grade14.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade14.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade14.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_14
            // 
            this.HORARIO_GRADE_14.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_14.HeaderText = "HORARIO_GRADE_14";
            this.HORARIO_GRADE_14.Name = "HORARIO_GRADE_14";
            this.HORARIO_GRADE_14.ReadOnly = true;
            this.HORARIO_GRADE_14.Visible = false;
            // 
            // DIA_SEMANA_GRADE_14
            // 
            this.DIA_SEMANA_GRADE_14.HeaderText = "DIA_SEMANA_GRADE_14";
            this.DIA_SEMANA_GRADE_14.Name = "DIA_SEMANA_GRADE_14";
            this.DIA_SEMANA_GRADE_14.ReadOnly = true;
            this.DIA_SEMANA_GRADE_14.Visible = false;
            // 
            // CODIGO_DISCIPLINA_14
            // 
            this.CODIGO_DISCIPLINA_14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_14.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_14.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_14.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_14.Name = "CODIGO_DISCIPLINA_14";
            this.CODIGO_DISCIPLINA_14.ReadOnly = true;
            this.CODIGO_DISCIPLINA_14.Width = 20;
            // 
            // CODIGO_TURMA_14
            // 
            this.CODIGO_TURMA_14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_14.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_14.HeaderText = "Turma";
            this.CODIGO_TURMA_14.MinimumWidth = 20;
            this.CODIGO_TURMA_14.Name = "CODIGO_TURMA_14";
            this.CODIGO_TURMA_14.ReadOnly = true;
            // 
            // CODIGO_ESPACO_14
            // 
            this.CODIGO_ESPACO_14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_14.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_14.HeaderText = "Sala";
            this.CODIGO_ESPACO_14.MinimumWidth = 20;
            this.CODIGO_ESPACO_14.Name = "CODIGO_ESPACO_14";
            this.CODIGO_ESPACO_14.ReadOnly = true;
            this.CODIGO_ESPACO_14.Width = 20;
            // 
            // CODIGO_PROFESSOR1_14
            // 
            this.CODIGO_PROFESSOR1_14.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_14.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_14.Name = "CODIGO_PROFESSOR1_14";
            this.CODIGO_PROFESSOR1_14.ReadOnly = true;
            this.CODIGO_PROFESSOR1_14.Visible = false;
            // 
            // CODIGO_PROFESSOR2_14
            // 
            this.CODIGO_PROFESSOR2_14.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_14.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_14.Name = "CODIGO_PROFESSOR2_14";
            this.CODIGO_PROFESSOR2_14.ReadOnly = true;
            this.CODIGO_PROFESSOR2_14.Visible = false;
            // 
            // CODIGO_PROFESSOR3_14
            // 
            this.CODIGO_PROFESSOR3_14.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_14.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_14.Name = "CODIGO_PROFESSOR3_14";
            this.CODIGO_PROFESSOR3_14.ReadOnly = true;
            this.CODIGO_PROFESSOR3_14.Visible = false;
            // 
            // grade15
            // 
            this.grade15.AllowUserToAddRows = false;
            this.grade15.AllowUserToDeleteRows = false;
            this.grade15.AllowUserToResizeColumns = false;
            this.grade15.AllowUserToResizeRows = false;
            this.grade15.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade15.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade15.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade15.ColumnHeadersVisible = false;
            this.grade15.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_15,
            this.DIA_SEMANA_GRADE_15,
            this.CODIGO_DISCIPLINA_15,
            this.CODIGO_TURMA_15,
            this.CODIGO_ESPACO_15,
            this.CODIGO_PROFESSOR1_15,
            this.CODIGO_PROFESSOR2_15,
            this.CODIGO_PROFESSOR3_15});
            this.grade15.ContextMenuStrip = this.menuContexto;
            this.grade15.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade15.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade15.Location = new System.Drawing.Point(94, 166);
            this.grade15.MultiSelect = false;
            this.grade15.Name = "grade15";
            this.grade15.ReadOnly = true;
            this.grade15.RowHeadersVisible = false;
            this.grade15.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade15.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade15.Size = new System.Drawing.Size(89, 27);
            this.grade15.TabIndex = 150;
            this.grade15.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade15.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade15.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_15
            // 
            this.HORARIO_GRADE_15.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_15.HeaderText = "HORARIO_GRADE_15";
            this.HORARIO_GRADE_15.Name = "HORARIO_GRADE_15";
            this.HORARIO_GRADE_15.ReadOnly = true;
            this.HORARIO_GRADE_15.Visible = false;
            // 
            // DIA_SEMANA_GRADE_15
            // 
            this.DIA_SEMANA_GRADE_15.HeaderText = "DIA_SEMANA_GRADE_15";
            this.DIA_SEMANA_GRADE_15.Name = "DIA_SEMANA_GRADE_15";
            this.DIA_SEMANA_GRADE_15.ReadOnly = true;
            this.DIA_SEMANA_GRADE_15.Visible = false;
            // 
            // CODIGO_DISCIPLINA_15
            // 
            this.CODIGO_DISCIPLINA_15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_15.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_15.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_15.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_15.Name = "CODIGO_DISCIPLINA_15";
            this.CODIGO_DISCIPLINA_15.ReadOnly = true;
            this.CODIGO_DISCIPLINA_15.Width = 20;
            // 
            // CODIGO_TURMA_15
            // 
            this.CODIGO_TURMA_15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_15.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_15.HeaderText = "Turma";
            this.CODIGO_TURMA_15.MinimumWidth = 20;
            this.CODIGO_TURMA_15.Name = "CODIGO_TURMA_15";
            this.CODIGO_TURMA_15.ReadOnly = true;
            // 
            // CODIGO_ESPACO_15
            // 
            this.CODIGO_ESPACO_15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_15.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_15.HeaderText = "Sala";
            this.CODIGO_ESPACO_15.MinimumWidth = 20;
            this.CODIGO_ESPACO_15.Name = "CODIGO_ESPACO_15";
            this.CODIGO_ESPACO_15.ReadOnly = true;
            this.CODIGO_ESPACO_15.Width = 20;
            // 
            // CODIGO_PROFESSOR1_15
            // 
            this.CODIGO_PROFESSOR1_15.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_15.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_15.Name = "CODIGO_PROFESSOR1_15";
            this.CODIGO_PROFESSOR1_15.ReadOnly = true;
            this.CODIGO_PROFESSOR1_15.Visible = false;
            // 
            // CODIGO_PROFESSOR2_15
            // 
            this.CODIGO_PROFESSOR2_15.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_15.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_15.Name = "CODIGO_PROFESSOR2_15";
            this.CODIGO_PROFESSOR2_15.ReadOnly = true;
            this.CODIGO_PROFESSOR2_15.Visible = false;
            // 
            // CODIGO_PROFESSOR3_15
            // 
            this.CODIGO_PROFESSOR3_15.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_15.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_15.Name = "CODIGO_PROFESSOR3_15";
            this.CODIGO_PROFESSOR3_15.ReadOnly = true;
            this.CODIGO_PROFESSOR3_15.Visible = false;
            // 
            // grade16
            // 
            this.grade16.AllowUserToAddRows = false;
            this.grade16.AllowUserToDeleteRows = false;
            this.grade16.AllowUserToResizeColumns = false;
            this.grade16.AllowUserToResizeRows = false;
            this.grade16.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade16.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade16.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade16.ColumnHeadersVisible = false;
            this.grade16.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_16,
            this.DIA_SEMANA_GRADE_16,
            this.CODIGO_DISCIPLINA_16,
            this.CODIGO_TURMA_16,
            this.CODIGO_ESPACO_16,
            this.CODIGO_PROFESSOR1_16,
            this.CODIGO_PROFESSOR2_16,
            this.CODIGO_PROFESSOR3_16});
            this.grade16.ContextMenuStrip = this.menuContexto;
            this.grade16.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade16.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade16.Location = new System.Drawing.Point(94, 200);
            this.grade16.MultiSelect = false;
            this.grade16.Name = "grade16";
            this.grade16.ReadOnly = true;
            this.grade16.RowHeadersVisible = false;
            this.grade16.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade16.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade16.Size = new System.Drawing.Size(89, 27);
            this.grade16.TabIndex = 150;
            this.grade16.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade16.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade16.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_16
            // 
            this.HORARIO_GRADE_16.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_16.HeaderText = "HORARIO_GRADE_16";
            this.HORARIO_GRADE_16.Name = "HORARIO_GRADE_16";
            this.HORARIO_GRADE_16.ReadOnly = true;
            this.HORARIO_GRADE_16.Visible = false;
            // 
            // DIA_SEMANA_GRADE_16
            // 
            this.DIA_SEMANA_GRADE_16.HeaderText = "DIA_SEMANA_GRADE_16";
            this.DIA_SEMANA_GRADE_16.Name = "DIA_SEMANA_GRADE_16";
            this.DIA_SEMANA_GRADE_16.ReadOnly = true;
            this.DIA_SEMANA_GRADE_16.Visible = false;
            // 
            // CODIGO_DISCIPLINA_16
            // 
            this.CODIGO_DISCIPLINA_16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_16.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_16.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_16.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_16.Name = "CODIGO_DISCIPLINA_16";
            this.CODIGO_DISCIPLINA_16.ReadOnly = true;
            this.CODIGO_DISCIPLINA_16.Width = 20;
            // 
            // CODIGO_TURMA_16
            // 
            this.CODIGO_TURMA_16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_16.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_16.HeaderText = "Turma";
            this.CODIGO_TURMA_16.MinimumWidth = 20;
            this.CODIGO_TURMA_16.Name = "CODIGO_TURMA_16";
            this.CODIGO_TURMA_16.ReadOnly = true;
            // 
            // CODIGO_ESPACO_16
            // 
            this.CODIGO_ESPACO_16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_16.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_16.HeaderText = "Sala";
            this.CODIGO_ESPACO_16.MinimumWidth = 20;
            this.CODIGO_ESPACO_16.Name = "CODIGO_ESPACO_16";
            this.CODIGO_ESPACO_16.ReadOnly = true;
            this.CODIGO_ESPACO_16.Width = 20;
            // 
            // CODIGO_PROFESSOR1_16
            // 
            this.CODIGO_PROFESSOR1_16.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_16.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_16.Name = "CODIGO_PROFESSOR1_16";
            this.CODIGO_PROFESSOR1_16.ReadOnly = true;
            this.CODIGO_PROFESSOR1_16.Visible = false;
            // 
            // CODIGO_PROFESSOR2_16
            // 
            this.CODIGO_PROFESSOR2_16.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_16.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_16.Name = "CODIGO_PROFESSOR2_16";
            this.CODIGO_PROFESSOR2_16.ReadOnly = true;
            this.CODIGO_PROFESSOR2_16.Visible = false;
            // 
            // CODIGO_PROFESSOR3_16
            // 
            this.CODIGO_PROFESSOR3_16.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_16.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_16.Name = "CODIGO_PROFESSOR3_16";
            this.CODIGO_PROFESSOR3_16.ReadOnly = true;
            this.CODIGO_PROFESSOR3_16.Visible = false;
            // 
            // grade17
            // 
            this.grade17.AllowUserToAddRows = false;
            this.grade17.AllowUserToDeleteRows = false;
            this.grade17.AllowUserToResizeColumns = false;
            this.grade17.AllowUserToResizeRows = false;
            this.grade17.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade17.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade17.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade17.ColumnHeadersVisible = false;
            this.grade17.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_17,
            this.DIA_SEMANA_GRADE_17,
            this.CODIGO_DISCIPLINA_17,
            this.CODIGO_TURMA_17,
            this.CODIGO_ESPACO_17,
            this.CODIGO_PROFESSOR1_17,
            this.CODIGO_PROFESSOR2_17,
            this.CODIGO_PROFESSOR3_17});
            this.grade17.ContextMenuStrip = this.menuContexto;
            this.grade17.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade17.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade17.Location = new System.Drawing.Point(94, 234);
            this.grade17.MultiSelect = false;
            this.grade17.Name = "grade17";
            this.grade17.ReadOnly = true;
            this.grade17.RowHeadersVisible = false;
            this.grade17.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade17.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade17.Size = new System.Drawing.Size(89, 27);
            this.grade17.TabIndex = 150;
            this.grade17.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade17.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade17.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_17
            // 
            this.HORARIO_GRADE_17.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_17.HeaderText = "HORARIO_GRADE_17";
            this.HORARIO_GRADE_17.Name = "HORARIO_GRADE_17";
            this.HORARIO_GRADE_17.ReadOnly = true;
            this.HORARIO_GRADE_17.Visible = false;
            // 
            // DIA_SEMANA_GRADE_17
            // 
            this.DIA_SEMANA_GRADE_17.HeaderText = "DIA_SEMANA_GRADE_17";
            this.DIA_SEMANA_GRADE_17.Name = "DIA_SEMANA_GRADE_17";
            this.DIA_SEMANA_GRADE_17.ReadOnly = true;
            this.DIA_SEMANA_GRADE_17.Visible = false;
            // 
            // CODIGO_DISCIPLINA_17
            // 
            this.CODIGO_DISCIPLINA_17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_17.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_17.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_17.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_17.Name = "CODIGO_DISCIPLINA_17";
            this.CODIGO_DISCIPLINA_17.ReadOnly = true;
            this.CODIGO_DISCIPLINA_17.Width = 20;
            // 
            // CODIGO_TURMA_17
            // 
            this.CODIGO_TURMA_17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_17.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_17.HeaderText = "Turma";
            this.CODIGO_TURMA_17.MinimumWidth = 20;
            this.CODIGO_TURMA_17.Name = "CODIGO_TURMA_17";
            this.CODIGO_TURMA_17.ReadOnly = true;
            // 
            // CODIGO_ESPACO_17
            // 
            this.CODIGO_ESPACO_17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_17.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_17.HeaderText = "Sala";
            this.CODIGO_ESPACO_17.MinimumWidth = 20;
            this.CODIGO_ESPACO_17.Name = "CODIGO_ESPACO_17";
            this.CODIGO_ESPACO_17.ReadOnly = true;
            this.CODIGO_ESPACO_17.Width = 20;
            // 
            // CODIGO_PROFESSOR1_17
            // 
            this.CODIGO_PROFESSOR1_17.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_17.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_17.Name = "CODIGO_PROFESSOR1_17";
            this.CODIGO_PROFESSOR1_17.ReadOnly = true;
            this.CODIGO_PROFESSOR1_17.Visible = false;
            // 
            // CODIGO_PROFESSOR2_17
            // 
            this.CODIGO_PROFESSOR2_17.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_17.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_17.Name = "CODIGO_PROFESSOR2_17";
            this.CODIGO_PROFESSOR2_17.ReadOnly = true;
            this.CODIGO_PROFESSOR2_17.Visible = false;
            // 
            // CODIGO_PROFESSOR3_17
            // 
            this.CODIGO_PROFESSOR3_17.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_17.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_17.Name = "CODIGO_PROFESSOR3_17";
            this.CODIGO_PROFESSOR3_17.ReadOnly = true;
            this.CODIGO_PROFESSOR3_17.Visible = false;
            // 
            // grade18
            // 
            this.grade18.AllowUserToAddRows = false;
            this.grade18.AllowUserToDeleteRows = false;
            this.grade18.AllowUserToResizeColumns = false;
            this.grade18.AllowUserToResizeRows = false;
            this.grade18.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade18.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade18.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade18.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade18.ColumnHeadersVisible = false;
            this.grade18.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_18,
            this.DIA_SEMANA_GRADE_18,
            this.CODIGO_DISCIPLINA_18,
            this.CODIGO_TURMA_18,
            this.CODIGO_ESPACO_18,
            this.CODIGO_PROFESSOR1_18,
            this.CODIGO_PROFESSOR2_18,
            this.CODIGO_PROFESSOR3_18});
            this.grade18.ContextMenuStrip = this.menuContexto;
            this.grade18.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade18.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade18.Location = new System.Drawing.Point(94, 268);
            this.grade18.MultiSelect = false;
            this.grade18.Name = "grade18";
            this.grade18.ReadOnly = true;
            this.grade18.RowHeadersVisible = false;
            this.grade18.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade18.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade18.Size = new System.Drawing.Size(89, 27);
            this.grade18.TabIndex = 150;
            this.grade18.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade18.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade18.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_18
            // 
            this.HORARIO_GRADE_18.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_18.HeaderText = "HORARIO_GRADE_18";
            this.HORARIO_GRADE_18.Name = "HORARIO_GRADE_18";
            this.HORARIO_GRADE_18.ReadOnly = true;
            this.HORARIO_GRADE_18.Visible = false;
            // 
            // DIA_SEMANA_GRADE_18
            // 
            this.DIA_SEMANA_GRADE_18.HeaderText = "DIA_SEMANA_GRADE_18";
            this.DIA_SEMANA_GRADE_18.Name = "DIA_SEMANA_GRADE_18";
            this.DIA_SEMANA_GRADE_18.ReadOnly = true;
            this.DIA_SEMANA_GRADE_18.Visible = false;
            // 
            // CODIGO_DISCIPLINA_18
            // 
            this.CODIGO_DISCIPLINA_18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_18.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_18.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_18.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_18.Name = "CODIGO_DISCIPLINA_18";
            this.CODIGO_DISCIPLINA_18.ReadOnly = true;
            this.CODIGO_DISCIPLINA_18.Width = 20;
            // 
            // CODIGO_TURMA_18
            // 
            this.CODIGO_TURMA_18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_18.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_18.HeaderText = "Turma";
            this.CODIGO_TURMA_18.MinimumWidth = 20;
            this.CODIGO_TURMA_18.Name = "CODIGO_TURMA_18";
            this.CODIGO_TURMA_18.ReadOnly = true;
            // 
            // CODIGO_ESPACO_18
            // 
            this.CODIGO_ESPACO_18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_18.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_18.HeaderText = "Sala";
            this.CODIGO_ESPACO_18.MinimumWidth = 20;
            this.CODIGO_ESPACO_18.Name = "CODIGO_ESPACO_18";
            this.CODIGO_ESPACO_18.ReadOnly = true;
            this.CODIGO_ESPACO_18.Width = 20;
            // 
            // CODIGO_PROFESSOR1_18
            // 
            this.CODIGO_PROFESSOR1_18.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_18.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_18.Name = "CODIGO_PROFESSOR1_18";
            this.CODIGO_PROFESSOR1_18.ReadOnly = true;
            this.CODIGO_PROFESSOR1_18.Visible = false;
            // 
            // CODIGO_PROFESSOR2_18
            // 
            this.CODIGO_PROFESSOR2_18.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_18.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_18.Name = "CODIGO_PROFESSOR2_18";
            this.CODIGO_PROFESSOR2_18.ReadOnly = true;
            this.CODIGO_PROFESSOR2_18.Visible = false;
            // 
            // CODIGO_PROFESSOR3_18
            // 
            this.CODIGO_PROFESSOR3_18.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_18.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_18.Name = "CODIGO_PROFESSOR3_18";
            this.CODIGO_PROFESSOR3_18.ReadOnly = true;
            this.CODIGO_PROFESSOR3_18.Visible = false;
            // 
            // grade19
            // 
            this.grade19.AllowUserToAddRows = false;
            this.grade19.AllowUserToDeleteRows = false;
            this.grade19.AllowUserToResizeColumns = false;
            this.grade19.AllowUserToResizeRows = false;
            this.grade19.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade19.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade19.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade19.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade19.ColumnHeadersVisible = false;
            this.grade19.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_19,
            this.DIA_SEMANA_GRADE_19,
            this.CODIGO_DISCIPLINA_19,
            this.CODIGO_TURMA_19,
            this.CODIGO_ESPACO_19,
            this.CODIGO_PROFESSOR1_19,
            this.CODIGO_PROFESSOR2_19,
            this.CODIGO_PROFESSOR3_19});
            this.grade19.ContextMenuStrip = this.menuContexto;
            this.grade19.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade19.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade19.Location = new System.Drawing.Point(94, 302);
            this.grade19.MultiSelect = false;
            this.grade19.Name = "grade19";
            this.grade19.ReadOnly = true;
            this.grade19.RowHeadersVisible = false;
            this.grade19.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade19.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade19.Size = new System.Drawing.Size(89, 27);
            this.grade19.TabIndex = 150;
            this.grade19.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade19.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade19.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_19
            // 
            this.HORARIO_GRADE_19.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_19.HeaderText = "HORARIO_GRADE_19";
            this.HORARIO_GRADE_19.Name = "HORARIO_GRADE_19";
            this.HORARIO_GRADE_19.ReadOnly = true;
            this.HORARIO_GRADE_19.Visible = false;
            // 
            // DIA_SEMANA_GRADE_19
            // 
            this.DIA_SEMANA_GRADE_19.HeaderText = "DIA_SEMANA_GRADE_19";
            this.DIA_SEMANA_GRADE_19.Name = "DIA_SEMANA_GRADE_19";
            this.DIA_SEMANA_GRADE_19.ReadOnly = true;
            this.DIA_SEMANA_GRADE_19.Visible = false;
            // 
            // CODIGO_DISCIPLINA_19
            // 
            this.CODIGO_DISCIPLINA_19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_19.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_19.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_19.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_19.Name = "CODIGO_DISCIPLINA_19";
            this.CODIGO_DISCIPLINA_19.ReadOnly = true;
            this.CODIGO_DISCIPLINA_19.Width = 20;
            // 
            // CODIGO_TURMA_19
            // 
            this.CODIGO_TURMA_19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_19.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_19.HeaderText = "Turma";
            this.CODIGO_TURMA_19.MinimumWidth = 20;
            this.CODIGO_TURMA_19.Name = "CODIGO_TURMA_19";
            this.CODIGO_TURMA_19.ReadOnly = true;
            // 
            // CODIGO_ESPACO_19
            // 
            this.CODIGO_ESPACO_19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_19.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_19.HeaderText = "Sala";
            this.CODIGO_ESPACO_19.MinimumWidth = 20;
            this.CODIGO_ESPACO_19.Name = "CODIGO_ESPACO_19";
            this.CODIGO_ESPACO_19.ReadOnly = true;
            this.CODIGO_ESPACO_19.Width = 20;
            // 
            // CODIGO_PROFESSOR1_19
            // 
            this.CODIGO_PROFESSOR1_19.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_19.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_19.Name = "CODIGO_PROFESSOR1_19";
            this.CODIGO_PROFESSOR1_19.ReadOnly = true;
            this.CODIGO_PROFESSOR1_19.Visible = false;
            // 
            // CODIGO_PROFESSOR2_19
            // 
            this.CODIGO_PROFESSOR2_19.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_19.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_19.Name = "CODIGO_PROFESSOR2_19";
            this.CODIGO_PROFESSOR2_19.ReadOnly = true;
            this.CODIGO_PROFESSOR2_19.Visible = false;
            // 
            // CODIGO_PROFESSOR3_19
            // 
            this.CODIGO_PROFESSOR3_19.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_19.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_19.Name = "CODIGO_PROFESSOR3_19";
            this.CODIGO_PROFESSOR3_19.ReadOnly = true;
            this.CODIGO_PROFESSOR3_19.Visible = false;
            // 
            // grade110
            // 
            this.grade110.AllowUserToAddRows = false;
            this.grade110.AllowUserToDeleteRows = false;
            this.grade110.AllowUserToResizeColumns = false;
            this.grade110.AllowUserToResizeRows = false;
            this.grade110.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade110.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade110.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade110.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade110.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade110.ColumnHeadersVisible = false;
            this.grade110.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_110,
            this.DIA_SEMANA_GRADE_110,
            this.CODIGO_DISCIPLINA_110,
            this.CODIGO_TURMA_110,
            this.CODIGO_ESPACO_110,
            this.CODIGO_PROFESSOR1_110,
            this.CODIGO_PROFESSOR2_110,
            this.CODIGO_PROFESSOR3_110});
            this.grade110.ContextMenuStrip = this.menuContexto;
            this.grade110.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade110.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade110.Location = new System.Drawing.Point(94, 336);
            this.grade110.MultiSelect = false;
            this.grade110.Name = "grade110";
            this.grade110.ReadOnly = true;
            this.grade110.RowHeadersVisible = false;
            this.grade110.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade110.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade110.Size = new System.Drawing.Size(89, 27);
            this.grade110.TabIndex = 150;
            this.grade110.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade110.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade110.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_110
            // 
            this.HORARIO_GRADE_110.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_110.HeaderText = "HORARIO_GRADE_110";
            this.HORARIO_GRADE_110.Name = "HORARIO_GRADE_110";
            this.HORARIO_GRADE_110.ReadOnly = true;
            this.HORARIO_GRADE_110.Visible = false;
            // 
            // DIA_SEMANA_GRADE_110
            // 
            this.DIA_SEMANA_GRADE_110.HeaderText = "DIA_SEMANA_GRADE_110";
            this.DIA_SEMANA_GRADE_110.Name = "DIA_SEMANA_GRADE_110";
            this.DIA_SEMANA_GRADE_110.ReadOnly = true;
            this.DIA_SEMANA_GRADE_110.Visible = false;
            // 
            // CODIGO_DISCIPLINA_110
            // 
            this.CODIGO_DISCIPLINA_110.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_110.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_110.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_110.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_110.Name = "CODIGO_DISCIPLINA_110";
            this.CODIGO_DISCIPLINA_110.ReadOnly = true;
            this.CODIGO_DISCIPLINA_110.Width = 20;
            // 
            // CODIGO_TURMA_110
            // 
            this.CODIGO_TURMA_110.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_110.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_110.HeaderText = "Turma";
            this.CODIGO_TURMA_110.MinimumWidth = 20;
            this.CODIGO_TURMA_110.Name = "CODIGO_TURMA_110";
            this.CODIGO_TURMA_110.ReadOnly = true;
            // 
            // CODIGO_ESPACO_110
            // 
            this.CODIGO_ESPACO_110.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_110.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_110.HeaderText = "Sala";
            this.CODIGO_ESPACO_110.MinimumWidth = 20;
            this.CODIGO_ESPACO_110.Name = "CODIGO_ESPACO_110";
            this.CODIGO_ESPACO_110.ReadOnly = true;
            this.CODIGO_ESPACO_110.Width = 20;
            // 
            // CODIGO_PROFESSOR1_110
            // 
            this.CODIGO_PROFESSOR1_110.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_110.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_110.Name = "CODIGO_PROFESSOR1_110";
            this.CODIGO_PROFESSOR1_110.ReadOnly = true;
            this.CODIGO_PROFESSOR1_110.Visible = false;
            // 
            // CODIGO_PROFESSOR2_110
            // 
            this.CODIGO_PROFESSOR2_110.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_110.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_110.Name = "CODIGO_PROFESSOR2_110";
            this.CODIGO_PROFESSOR2_110.ReadOnly = true;
            this.CODIGO_PROFESSOR2_110.Visible = false;
            // 
            // CODIGO_PROFESSOR3_110
            // 
            this.CODIGO_PROFESSOR3_110.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_110.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_110.Name = "CODIGO_PROFESSOR3_110";
            this.CODIGO_PROFESSOR3_110.ReadOnly = true;
            this.CODIGO_PROFESSOR3_110.Visible = false;
            // 
            // grade111
            // 
            this.grade111.AllowUserToAddRows = false;
            this.grade111.AllowUserToDeleteRows = false;
            this.grade111.AllowUserToResizeColumns = false;
            this.grade111.AllowUserToResizeRows = false;
            this.grade111.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade111.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade111.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade111.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade111.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade111.ColumnHeadersVisible = false;
            this.grade111.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_111,
            this.DIA_SEMANA_GRADE_111,
            this.CODIGO_DISCIPLINA_111,
            this.CODIGO_TURMA_111,
            this.CODIGO_ESPACO_111,
            this.CODIGO_PROFESSOR1_111,
            this.CODIGO_PROFESSOR2_111,
            this.CODIGO_PROFESSOR3_111});
            this.grade111.ContextMenuStrip = this.menuContexto;
            this.grade111.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade111.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade111.Location = new System.Drawing.Point(94, 370);
            this.grade111.MultiSelect = false;
            this.grade111.Name = "grade111";
            this.grade111.ReadOnly = true;
            this.grade111.RowHeadersVisible = false;
            this.grade111.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade111.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade111.Size = new System.Drawing.Size(89, 27);
            this.grade111.TabIndex = 150;
            this.grade111.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade111.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade111.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_111
            // 
            this.HORARIO_GRADE_111.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_111.HeaderText = "HORARIO_GRADE_111";
            this.HORARIO_GRADE_111.Name = "HORARIO_GRADE_111";
            this.HORARIO_GRADE_111.ReadOnly = true;
            this.HORARIO_GRADE_111.Visible = false;
            // 
            // DIA_SEMANA_GRADE_111
            // 
            this.DIA_SEMANA_GRADE_111.HeaderText = "DIA_SEMANA_GRADE_111";
            this.DIA_SEMANA_GRADE_111.Name = "DIA_SEMANA_GRADE_111";
            this.DIA_SEMANA_GRADE_111.ReadOnly = true;
            this.DIA_SEMANA_GRADE_111.Visible = false;
            // 
            // CODIGO_DISCIPLINA_111
            // 
            this.CODIGO_DISCIPLINA_111.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_111.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_111.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_111.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_111.Name = "CODIGO_DISCIPLINA_111";
            this.CODIGO_DISCIPLINA_111.ReadOnly = true;
            this.CODIGO_DISCIPLINA_111.Width = 20;
            // 
            // CODIGO_TURMA_111
            // 
            this.CODIGO_TURMA_111.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_111.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_111.HeaderText = "Turma";
            this.CODIGO_TURMA_111.MinimumWidth = 20;
            this.CODIGO_TURMA_111.Name = "CODIGO_TURMA_111";
            this.CODIGO_TURMA_111.ReadOnly = true;
            // 
            // CODIGO_ESPACO_111
            // 
            this.CODIGO_ESPACO_111.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_111.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_111.HeaderText = "Sala";
            this.CODIGO_ESPACO_111.MinimumWidth = 20;
            this.CODIGO_ESPACO_111.Name = "CODIGO_ESPACO_111";
            this.CODIGO_ESPACO_111.ReadOnly = true;
            this.CODIGO_ESPACO_111.Width = 20;
            // 
            // CODIGO_PROFESSOR1_111
            // 
            this.CODIGO_PROFESSOR1_111.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_111.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_111.Name = "CODIGO_PROFESSOR1_111";
            this.CODIGO_PROFESSOR1_111.ReadOnly = true;
            this.CODIGO_PROFESSOR1_111.Visible = false;
            // 
            // CODIGO_PROFESSOR2_111
            // 
            this.CODIGO_PROFESSOR2_111.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_111.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_111.Name = "CODIGO_PROFESSOR2_111";
            this.CODIGO_PROFESSOR2_111.ReadOnly = true;
            this.CODIGO_PROFESSOR2_111.Visible = false;
            // 
            // CODIGO_PROFESSOR3_111
            // 
            this.CODIGO_PROFESSOR3_111.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_111.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_111.Name = "CODIGO_PROFESSOR3_111";
            this.CODIGO_PROFESSOR3_111.ReadOnly = true;
            this.CODIGO_PROFESSOR3_111.Visible = false;
            // 
            // grade112
            // 
            this.grade112.AllowUserToAddRows = false;
            this.grade112.AllowUserToDeleteRows = false;
            this.grade112.AllowUserToResizeColumns = false;
            this.grade112.AllowUserToResizeRows = false;
            this.grade112.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade112.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade112.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade112.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade112.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade112.ColumnHeadersVisible = false;
            this.grade112.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_112,
            this.DIA_SEMANA_GRADE_112,
            this.CODIGO_DISCIPLINA_112,
            this.CODIGO_TURMA_112,
            this.CODIGO_ESPACO_112,
            this.CODIGO_PROFESSOR1_112,
            this.CODIGO_PROFESSOR2_112,
            this.CODIGO_PROFESSOR3_112});
            this.grade112.ContextMenuStrip = this.menuContexto;
            this.grade112.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade112.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade112.Location = new System.Drawing.Point(94, 404);
            this.grade112.MultiSelect = false;
            this.grade112.Name = "grade112";
            this.grade112.ReadOnly = true;
            this.grade112.RowHeadersVisible = false;
            this.grade112.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade112.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade112.Size = new System.Drawing.Size(89, 27);
            this.grade112.TabIndex = 150;
            this.grade112.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade112.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade112.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_112
            // 
            this.HORARIO_GRADE_112.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_112.HeaderText = "HORARIO_GRADE_112";
            this.HORARIO_GRADE_112.Name = "HORARIO_GRADE_112";
            this.HORARIO_GRADE_112.ReadOnly = true;
            this.HORARIO_GRADE_112.Visible = false;
            // 
            // DIA_SEMANA_GRADE_112
            // 
            this.DIA_SEMANA_GRADE_112.HeaderText = "DIA_SEMANA_GRADE_112";
            this.DIA_SEMANA_GRADE_112.Name = "DIA_SEMANA_GRADE_112";
            this.DIA_SEMANA_GRADE_112.ReadOnly = true;
            this.DIA_SEMANA_GRADE_112.Visible = false;
            // 
            // CODIGO_DISCIPLINA_112
            // 
            this.CODIGO_DISCIPLINA_112.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_112.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_112.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_112.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_112.Name = "CODIGO_DISCIPLINA_112";
            this.CODIGO_DISCIPLINA_112.ReadOnly = true;
            this.CODIGO_DISCIPLINA_112.Width = 20;
            // 
            // CODIGO_TURMA_112
            // 
            this.CODIGO_TURMA_112.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_112.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_112.HeaderText = "Turma";
            this.CODIGO_TURMA_112.MinimumWidth = 20;
            this.CODIGO_TURMA_112.Name = "CODIGO_TURMA_112";
            this.CODIGO_TURMA_112.ReadOnly = true;
            // 
            // CODIGO_ESPACO_112
            // 
            this.CODIGO_ESPACO_112.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_112.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_112.HeaderText = "Sala";
            this.CODIGO_ESPACO_112.MinimumWidth = 20;
            this.CODIGO_ESPACO_112.Name = "CODIGO_ESPACO_112";
            this.CODIGO_ESPACO_112.ReadOnly = true;
            this.CODIGO_ESPACO_112.Width = 20;
            // 
            // CODIGO_PROFESSOR1_112
            // 
            this.CODIGO_PROFESSOR1_112.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_112.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_112.Name = "CODIGO_PROFESSOR1_112";
            this.CODIGO_PROFESSOR1_112.ReadOnly = true;
            this.CODIGO_PROFESSOR1_112.Visible = false;
            // 
            // CODIGO_PROFESSOR2_112
            // 
            this.CODIGO_PROFESSOR2_112.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_112.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_112.Name = "CODIGO_PROFESSOR2_112";
            this.CODIGO_PROFESSOR2_112.ReadOnly = true;
            this.CODIGO_PROFESSOR2_112.Visible = false;
            // 
            // CODIGO_PROFESSOR3_112
            // 
            this.CODIGO_PROFESSOR3_112.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_112.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_112.Name = "CODIGO_PROFESSOR3_112";
            this.CODIGO_PROFESSOR3_112.ReadOnly = true;
            this.CODIGO_PROFESSOR3_112.Visible = false;
            // 
            // grade113
            // 
            this.grade113.AllowUserToAddRows = false;
            this.grade113.AllowUserToDeleteRows = false;
            this.grade113.AllowUserToResizeColumns = false;
            this.grade113.AllowUserToResizeRows = false;
            this.grade113.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade113.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade113.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade113.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade113.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade113.ColumnHeadersVisible = false;
            this.grade113.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_113,
            this.DIA_SEMANA_GRADE_113,
            this.CODIGO_DISCIPLINA_113,
            this.CODIGO_TURMA_113,
            this.CODIGO_ESPACO_113,
            this.CODIGO_PROFESSOR1_113,
            this.CODIGO_PROFESSOR2_113,
            this.CODIGO_PROFESSOR3_113});
            this.grade113.ContextMenuStrip = this.menuContexto;
            this.grade113.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade113.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade113.Location = new System.Drawing.Point(94, 438);
            this.grade113.MultiSelect = false;
            this.grade113.Name = "grade113";
            this.grade113.ReadOnly = true;
            this.grade113.RowHeadersVisible = false;
            this.grade113.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade113.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade113.Size = new System.Drawing.Size(89, 27);
            this.grade113.TabIndex = 150;
            this.grade113.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade113.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade113.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_113
            // 
            this.HORARIO_GRADE_113.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_113.HeaderText = "HORARIO_GRADE_113";
            this.HORARIO_GRADE_113.Name = "HORARIO_GRADE_113";
            this.HORARIO_GRADE_113.ReadOnly = true;
            this.HORARIO_GRADE_113.Visible = false;
            // 
            // DIA_SEMANA_GRADE_113
            // 
            this.DIA_SEMANA_GRADE_113.HeaderText = "DIA_SEMANA_GRADE_113";
            this.DIA_SEMANA_GRADE_113.Name = "DIA_SEMANA_GRADE_113";
            this.DIA_SEMANA_GRADE_113.ReadOnly = true;
            this.DIA_SEMANA_GRADE_113.Visible = false;
            // 
            // CODIGO_DISCIPLINA_113
            // 
            this.CODIGO_DISCIPLINA_113.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_113.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_113.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_113.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_113.Name = "CODIGO_DISCIPLINA_113";
            this.CODIGO_DISCIPLINA_113.ReadOnly = true;
            this.CODIGO_DISCIPLINA_113.Width = 20;
            // 
            // CODIGO_TURMA_113
            // 
            this.CODIGO_TURMA_113.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_113.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_113.HeaderText = "Turma";
            this.CODIGO_TURMA_113.MinimumWidth = 20;
            this.CODIGO_TURMA_113.Name = "CODIGO_TURMA_113";
            this.CODIGO_TURMA_113.ReadOnly = true;
            // 
            // CODIGO_ESPACO_113
            // 
            this.CODIGO_ESPACO_113.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_113.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_113.HeaderText = "Sala";
            this.CODIGO_ESPACO_113.MinimumWidth = 20;
            this.CODIGO_ESPACO_113.Name = "CODIGO_ESPACO_113";
            this.CODIGO_ESPACO_113.ReadOnly = true;
            this.CODIGO_ESPACO_113.Width = 20;
            // 
            // CODIGO_PROFESSOR1_113
            // 
            this.CODIGO_PROFESSOR1_113.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_113.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_113.Name = "CODIGO_PROFESSOR1_113";
            this.CODIGO_PROFESSOR1_113.ReadOnly = true;
            this.CODIGO_PROFESSOR1_113.Visible = false;
            // 
            // CODIGO_PROFESSOR2_113
            // 
            this.CODIGO_PROFESSOR2_113.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_113.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_113.Name = "CODIGO_PROFESSOR2_113";
            this.CODIGO_PROFESSOR2_113.ReadOnly = true;
            this.CODIGO_PROFESSOR2_113.Visible = false;
            // 
            // CODIGO_PROFESSOR3_113
            // 
            this.CODIGO_PROFESSOR3_113.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_113.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_113.Name = "CODIGO_PROFESSOR3_113";
            this.CODIGO_PROFESSOR3_113.ReadOnly = true;
            this.CODIGO_PROFESSOR3_113.Visible = false;
            // 
            // grade114
            // 
            this.grade114.AllowUserToAddRows = false;
            this.grade114.AllowUserToDeleteRows = false;
            this.grade114.AllowUserToResizeColumns = false;
            this.grade114.AllowUserToResizeRows = false;
            this.grade114.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade114.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade114.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade114.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade114.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade114.ColumnHeadersVisible = false;
            this.grade114.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_114,
            this.DIA_SEMANA_GRADE_114,
            this.CODIGO_DISCIPLINA_114,
            this.CODIGO_TURMA_114,
            this.CODIGO_ESPACO_114,
            this.CODIGO_PROFESSOR1_114,
            this.CODIGO_PROFESSOR2_114,
            this.CODIGO_PROFESSOR3_114});
            this.grade114.ContextMenuStrip = this.menuContexto;
            this.grade114.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade114.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade114.Location = new System.Drawing.Point(94, 472);
            this.grade114.MultiSelect = false;
            this.grade114.Name = "grade114";
            this.grade114.ReadOnly = true;
            this.grade114.RowHeadersVisible = false;
            this.grade114.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade114.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade114.Size = new System.Drawing.Size(89, 28);
            this.grade114.TabIndex = 150;
            this.grade114.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade114.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade114.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_114
            // 
            this.HORARIO_GRADE_114.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_114.HeaderText = "HORARIO_GRADE_114";
            this.HORARIO_GRADE_114.Name = "HORARIO_GRADE_114";
            this.HORARIO_GRADE_114.ReadOnly = true;
            this.HORARIO_GRADE_114.Visible = false;
            // 
            // DIA_SEMANA_GRADE_114
            // 
            this.DIA_SEMANA_GRADE_114.HeaderText = "DIA_SEMANA_GRADE_114";
            this.DIA_SEMANA_GRADE_114.Name = "DIA_SEMANA_GRADE_114";
            this.DIA_SEMANA_GRADE_114.ReadOnly = true;
            this.DIA_SEMANA_GRADE_114.Visible = false;
            // 
            // CODIGO_DISCIPLINA_114
            // 
            this.CODIGO_DISCIPLINA_114.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_114.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_114.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_114.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_114.Name = "CODIGO_DISCIPLINA_114";
            this.CODIGO_DISCIPLINA_114.ReadOnly = true;
            this.CODIGO_DISCIPLINA_114.Width = 20;
            // 
            // CODIGO_TURMA_114
            // 
            this.CODIGO_TURMA_114.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_114.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_114.HeaderText = "Turma";
            this.CODIGO_TURMA_114.MinimumWidth = 20;
            this.CODIGO_TURMA_114.Name = "CODIGO_TURMA_114";
            this.CODIGO_TURMA_114.ReadOnly = true;
            // 
            // CODIGO_ESPACO_114
            // 
            this.CODIGO_ESPACO_114.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_114.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_114.HeaderText = "Sala";
            this.CODIGO_ESPACO_114.MinimumWidth = 20;
            this.CODIGO_ESPACO_114.Name = "CODIGO_ESPACO_114";
            this.CODIGO_ESPACO_114.ReadOnly = true;
            this.CODIGO_ESPACO_114.Width = 20;
            // 
            // CODIGO_PROFESSOR1_114
            // 
            this.CODIGO_PROFESSOR1_114.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_114.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_114.Name = "CODIGO_PROFESSOR1_114";
            this.CODIGO_PROFESSOR1_114.ReadOnly = true;
            this.CODIGO_PROFESSOR1_114.Visible = false;
            // 
            // CODIGO_PROFESSOR2_114
            // 
            this.CODIGO_PROFESSOR2_114.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_114.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_114.Name = "CODIGO_PROFESSOR2_114";
            this.CODIGO_PROFESSOR2_114.ReadOnly = true;
            this.CODIGO_PROFESSOR2_114.Visible = false;
            // 
            // CODIGO_PROFESSOR3_114
            // 
            this.CODIGO_PROFESSOR3_114.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_114.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_114.Name = "CODIGO_PROFESSOR3_114";
            this.CODIGO_PROFESSOR3_114.ReadOnly = true;
            this.CODIGO_PROFESSOR3_114.Visible = false;
            // 
            // grade21
            // 
            this.grade21.AllowUserToAddRows = false;
            this.grade21.AllowUserToDeleteRows = false;
            this.grade21.AllowUserToResizeColumns = false;
            this.grade21.AllowUserToResizeRows = false;
            this.grade21.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade21.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade21.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade21.ColumnHeadersVisible = false;
            this.grade21.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_21,
            this.DIA_SEMANA_GRADE_21,
            this.CODIGO_DISCIPLINA_21,
            this.CODIGO_TURMA_21,
            this.CODIGO_ESPACO_21,
            this.CODIGO_PROFESSOR1_21,
            this.CODIGO_PROFESSOR2_21,
            this.CODIGO_PROFESSOR3_21});
            this.grade21.ContextMenuStrip = this.menuContexto;
            this.grade21.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade21.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade21.Location = new System.Drawing.Point(190, 30);
            this.grade21.MultiSelect = false;
            this.grade21.Name = "grade21";
            this.grade21.ReadOnly = true;
            this.grade21.RowHeadersVisible = false;
            this.grade21.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade21.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade21.Size = new System.Drawing.Size(89, 27);
            this.grade21.TabIndex = 150;
            this.grade21.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade21.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade21.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_21
            // 
            this.HORARIO_GRADE_21.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_21.HeaderText = "HORARIO_GRADE_21";
            this.HORARIO_GRADE_21.Name = "HORARIO_GRADE_21";
            this.HORARIO_GRADE_21.ReadOnly = true;
            this.HORARIO_GRADE_21.Visible = false;
            // 
            // DIA_SEMANA_GRADE_21
            // 
            this.DIA_SEMANA_GRADE_21.HeaderText = "DIA_SEMANA_GRADE_21";
            this.DIA_SEMANA_GRADE_21.Name = "DIA_SEMANA_GRADE_21";
            this.DIA_SEMANA_GRADE_21.ReadOnly = true;
            this.DIA_SEMANA_GRADE_21.Visible = false;
            // 
            // CODIGO_DISCIPLINA_21
            // 
            this.CODIGO_DISCIPLINA_21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_21.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_21.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_21.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_21.Name = "CODIGO_DISCIPLINA_21";
            this.CODIGO_DISCIPLINA_21.ReadOnly = true;
            this.CODIGO_DISCIPLINA_21.Width = 20;
            // 
            // CODIGO_TURMA_21
            // 
            this.CODIGO_TURMA_21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_21.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_21.HeaderText = "Turma";
            this.CODIGO_TURMA_21.MinimumWidth = 20;
            this.CODIGO_TURMA_21.Name = "CODIGO_TURMA_21";
            this.CODIGO_TURMA_21.ReadOnly = true;
            // 
            // CODIGO_ESPACO_21
            // 
            this.CODIGO_ESPACO_21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_21.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_21.HeaderText = "Sala";
            this.CODIGO_ESPACO_21.MinimumWidth = 20;
            this.CODIGO_ESPACO_21.Name = "CODIGO_ESPACO_21";
            this.CODIGO_ESPACO_21.ReadOnly = true;
            this.CODIGO_ESPACO_21.Width = 20;
            // 
            // CODIGO_PROFESSOR1_21
            // 
            this.CODIGO_PROFESSOR1_21.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_21.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_21.Name = "CODIGO_PROFESSOR1_21";
            this.CODIGO_PROFESSOR1_21.ReadOnly = true;
            this.CODIGO_PROFESSOR1_21.Visible = false;
            // 
            // CODIGO_PROFESSOR2_21
            // 
            this.CODIGO_PROFESSOR2_21.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_21.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_21.Name = "CODIGO_PROFESSOR2_21";
            this.CODIGO_PROFESSOR2_21.ReadOnly = true;
            this.CODIGO_PROFESSOR2_21.Visible = false;
            // 
            // CODIGO_PROFESSOR3_21
            // 
            this.CODIGO_PROFESSOR3_21.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_21.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_21.Name = "CODIGO_PROFESSOR3_21";
            this.CODIGO_PROFESSOR3_21.ReadOnly = true;
            this.CODIGO_PROFESSOR3_21.Visible = false;
            // 
            // grade22
            // 
            this.grade22.AllowUserToAddRows = false;
            this.grade22.AllowUserToDeleteRows = false;
            this.grade22.AllowUserToResizeColumns = false;
            this.grade22.AllowUserToResizeRows = false;
            this.grade22.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade22.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade22.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade22.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade22.ColumnHeadersVisible = false;
            this.grade22.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_22,
            this.DIA_SEMANA_GRADE_22,
            this.CODIGO_DISCIPLINA_22,
            this.CODIGO_TURMA_22,
            this.CODIGO_ESPACO_22,
            this.CODIGO_PROFESSOR1_22,
            this.CODIGO_PROFESSOR2_22,
            this.CODIGO_PROFESSOR3_22});
            this.grade22.ContextMenuStrip = this.menuContexto;
            this.grade22.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade22.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade22.Location = new System.Drawing.Point(190, 64);
            this.grade22.MultiSelect = false;
            this.grade22.Name = "grade22";
            this.grade22.ReadOnly = true;
            this.grade22.RowHeadersVisible = false;
            this.grade22.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade22.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade22.Size = new System.Drawing.Size(89, 27);
            this.grade22.TabIndex = 150;
            this.grade22.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade22.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade22.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_22
            // 
            this.HORARIO_GRADE_22.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_22.HeaderText = "HORARIO_GRADE_22";
            this.HORARIO_GRADE_22.Name = "HORARIO_GRADE_22";
            this.HORARIO_GRADE_22.ReadOnly = true;
            this.HORARIO_GRADE_22.Visible = false;
            // 
            // DIA_SEMANA_GRADE_22
            // 
            this.DIA_SEMANA_GRADE_22.HeaderText = "DIA_SEMANA_GRADE_22";
            this.DIA_SEMANA_GRADE_22.Name = "DIA_SEMANA_GRADE_22";
            this.DIA_SEMANA_GRADE_22.ReadOnly = true;
            this.DIA_SEMANA_GRADE_22.Visible = false;
            // 
            // CODIGO_DISCIPLINA_22
            // 
            this.CODIGO_DISCIPLINA_22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_22.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_22.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_22.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_22.Name = "CODIGO_DISCIPLINA_22";
            this.CODIGO_DISCIPLINA_22.ReadOnly = true;
            this.CODIGO_DISCIPLINA_22.Width = 20;
            // 
            // CODIGO_TURMA_22
            // 
            this.CODIGO_TURMA_22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_22.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_22.HeaderText = "Turma";
            this.CODIGO_TURMA_22.MinimumWidth = 20;
            this.CODIGO_TURMA_22.Name = "CODIGO_TURMA_22";
            this.CODIGO_TURMA_22.ReadOnly = true;
            // 
            // CODIGO_ESPACO_22
            // 
            this.CODIGO_ESPACO_22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_22.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_22.HeaderText = "Sala";
            this.CODIGO_ESPACO_22.MinimumWidth = 20;
            this.CODIGO_ESPACO_22.Name = "CODIGO_ESPACO_22";
            this.CODIGO_ESPACO_22.ReadOnly = true;
            this.CODIGO_ESPACO_22.Width = 20;
            // 
            // CODIGO_PROFESSOR1_22
            // 
            this.CODIGO_PROFESSOR1_22.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_22.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_22.Name = "CODIGO_PROFESSOR1_22";
            this.CODIGO_PROFESSOR1_22.ReadOnly = true;
            this.CODIGO_PROFESSOR1_22.Visible = false;
            // 
            // CODIGO_PROFESSOR2_22
            // 
            this.CODIGO_PROFESSOR2_22.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_22.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_22.Name = "CODIGO_PROFESSOR2_22";
            this.CODIGO_PROFESSOR2_22.ReadOnly = true;
            this.CODIGO_PROFESSOR2_22.Visible = false;
            // 
            // CODIGO_PROFESSOR3_22
            // 
            this.CODIGO_PROFESSOR3_22.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_22.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_22.Name = "CODIGO_PROFESSOR3_22";
            this.CODIGO_PROFESSOR3_22.ReadOnly = true;
            this.CODIGO_PROFESSOR3_22.Visible = false;
            // 
            // grade23
            // 
            this.grade23.AllowUserToAddRows = false;
            this.grade23.AllowUserToDeleteRows = false;
            this.grade23.AllowUserToResizeColumns = false;
            this.grade23.AllowUserToResizeRows = false;
            this.grade23.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade23.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade23.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade23.ColumnHeadersVisible = false;
            this.grade23.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_23,
            this.DIA_SEMANA_GRADE_23,
            this.CODIGO_DISCIPLINA_23,
            this.CODIGO_TURMA_23,
            this.CODIGO_ESPACO_23,
            this.CODIGO_PROFESSOR1_23,
            this.CODIGO_PROFESSOR2_23,
            this.CODIGO_PROFESSOR3_23});
            this.grade23.ContextMenuStrip = this.menuContexto;
            this.grade23.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade23.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade23.Location = new System.Drawing.Point(190, 98);
            this.grade23.MultiSelect = false;
            this.grade23.Name = "grade23";
            this.grade23.ReadOnly = true;
            this.grade23.RowHeadersVisible = false;
            this.grade23.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade23.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade23.Size = new System.Drawing.Size(89, 27);
            this.grade23.TabIndex = 150;
            this.grade23.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade23.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade23.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_23
            // 
            this.HORARIO_GRADE_23.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_23.HeaderText = "HORARIO_GRADE_23";
            this.HORARIO_GRADE_23.Name = "HORARIO_GRADE_23";
            this.HORARIO_GRADE_23.ReadOnly = true;
            this.HORARIO_GRADE_23.Visible = false;
            // 
            // DIA_SEMANA_GRADE_23
            // 
            this.DIA_SEMANA_GRADE_23.HeaderText = "DIA_SEMANA_GRADE_23";
            this.DIA_SEMANA_GRADE_23.Name = "DIA_SEMANA_GRADE_23";
            this.DIA_SEMANA_GRADE_23.ReadOnly = true;
            this.DIA_SEMANA_GRADE_23.Visible = false;
            // 
            // CODIGO_DISCIPLINA_23
            // 
            this.CODIGO_DISCIPLINA_23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_23.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_23.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_23.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_23.Name = "CODIGO_DISCIPLINA_23";
            this.CODIGO_DISCIPLINA_23.ReadOnly = true;
            this.CODIGO_DISCIPLINA_23.Width = 20;
            // 
            // CODIGO_TURMA_23
            // 
            this.CODIGO_TURMA_23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_23.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_23.HeaderText = "Turma";
            this.CODIGO_TURMA_23.MinimumWidth = 20;
            this.CODIGO_TURMA_23.Name = "CODIGO_TURMA_23";
            this.CODIGO_TURMA_23.ReadOnly = true;
            // 
            // CODIGO_ESPACO_23
            // 
            this.CODIGO_ESPACO_23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_23.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_23.HeaderText = "Sala";
            this.CODIGO_ESPACO_23.MinimumWidth = 20;
            this.CODIGO_ESPACO_23.Name = "CODIGO_ESPACO_23";
            this.CODIGO_ESPACO_23.ReadOnly = true;
            this.CODIGO_ESPACO_23.Width = 20;
            // 
            // CODIGO_PROFESSOR1_23
            // 
            this.CODIGO_PROFESSOR1_23.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_23.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_23.Name = "CODIGO_PROFESSOR1_23";
            this.CODIGO_PROFESSOR1_23.ReadOnly = true;
            this.CODIGO_PROFESSOR1_23.Visible = false;
            // 
            // CODIGO_PROFESSOR2_23
            // 
            this.CODIGO_PROFESSOR2_23.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_23.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_23.Name = "CODIGO_PROFESSOR2_23";
            this.CODIGO_PROFESSOR2_23.ReadOnly = true;
            this.CODIGO_PROFESSOR2_23.Visible = false;
            // 
            // CODIGO_PROFESSOR3_23
            // 
            this.CODIGO_PROFESSOR3_23.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_23.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_23.Name = "CODIGO_PROFESSOR3_23";
            this.CODIGO_PROFESSOR3_23.ReadOnly = true;
            this.CODIGO_PROFESSOR3_23.Visible = false;
            // 
            // grade24
            // 
            this.grade24.AllowUserToAddRows = false;
            this.grade24.AllowUserToDeleteRows = false;
            this.grade24.AllowUserToResizeColumns = false;
            this.grade24.AllowUserToResizeRows = false;
            this.grade24.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade24.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade24.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade24.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade24.ColumnHeadersVisible = false;
            this.grade24.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_24,
            this.DIA_SEMANA_GRADE_24,
            this.CODIGO_DISCIPLINA_24,
            this.CODIGO_TURMA_24,
            this.CODIGO_ESPACO_24,
            this.CODIGO_PROFESSOR1_24,
            this.CODIGO_PROFESSOR2_24,
            this.CODIGO_PROFESSOR3_24});
            this.grade24.ContextMenuStrip = this.menuContexto;
            this.grade24.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade24.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade24.Location = new System.Drawing.Point(190, 132);
            this.grade24.MultiSelect = false;
            this.grade24.Name = "grade24";
            this.grade24.ReadOnly = true;
            this.grade24.RowHeadersVisible = false;
            this.grade24.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade24.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade24.Size = new System.Drawing.Size(89, 27);
            this.grade24.TabIndex = 150;
            this.grade24.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade24.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade24.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_24
            // 
            this.HORARIO_GRADE_24.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_24.HeaderText = "HORARIO_GRADE_24";
            this.HORARIO_GRADE_24.Name = "HORARIO_GRADE_24";
            this.HORARIO_GRADE_24.ReadOnly = true;
            this.HORARIO_GRADE_24.Visible = false;
            // 
            // DIA_SEMANA_GRADE_24
            // 
            this.DIA_SEMANA_GRADE_24.HeaderText = "DIA_SEMANA_GRADE_24";
            this.DIA_SEMANA_GRADE_24.Name = "DIA_SEMANA_GRADE_24";
            this.DIA_SEMANA_GRADE_24.ReadOnly = true;
            this.DIA_SEMANA_GRADE_24.Visible = false;
            // 
            // CODIGO_DISCIPLINA_24
            // 
            this.CODIGO_DISCIPLINA_24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_24.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_24.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_24.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_24.Name = "CODIGO_DISCIPLINA_24";
            this.CODIGO_DISCIPLINA_24.ReadOnly = true;
            this.CODIGO_DISCIPLINA_24.Width = 20;
            // 
            // CODIGO_TURMA_24
            // 
            this.CODIGO_TURMA_24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_24.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_24.HeaderText = "Turma";
            this.CODIGO_TURMA_24.MinimumWidth = 20;
            this.CODIGO_TURMA_24.Name = "CODIGO_TURMA_24";
            this.CODIGO_TURMA_24.ReadOnly = true;
            // 
            // CODIGO_ESPACO_24
            // 
            this.CODIGO_ESPACO_24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_24.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_24.HeaderText = "Sala";
            this.CODIGO_ESPACO_24.MinimumWidth = 20;
            this.CODIGO_ESPACO_24.Name = "CODIGO_ESPACO_24";
            this.CODIGO_ESPACO_24.ReadOnly = true;
            this.CODIGO_ESPACO_24.Width = 20;
            // 
            // CODIGO_PROFESSOR1_24
            // 
            this.CODIGO_PROFESSOR1_24.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_24.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_24.Name = "CODIGO_PROFESSOR1_24";
            this.CODIGO_PROFESSOR1_24.ReadOnly = true;
            this.CODIGO_PROFESSOR1_24.Visible = false;
            // 
            // CODIGO_PROFESSOR2_24
            // 
            this.CODIGO_PROFESSOR2_24.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_24.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_24.Name = "CODIGO_PROFESSOR2_24";
            this.CODIGO_PROFESSOR2_24.ReadOnly = true;
            this.CODIGO_PROFESSOR2_24.Visible = false;
            // 
            // CODIGO_PROFESSOR3_24
            // 
            this.CODIGO_PROFESSOR3_24.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_24.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_24.Name = "CODIGO_PROFESSOR3_24";
            this.CODIGO_PROFESSOR3_24.ReadOnly = true;
            this.CODIGO_PROFESSOR3_24.Visible = false;
            // 
            // grade25
            // 
            this.grade25.AllowUserToAddRows = false;
            this.grade25.AllowUserToDeleteRows = false;
            this.grade25.AllowUserToResizeColumns = false;
            this.grade25.AllowUserToResizeRows = false;
            this.grade25.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade25.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade25.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade25.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade25.ColumnHeadersVisible = false;
            this.grade25.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_25,
            this.DIA_SEMANA_GRADE_25,
            this.CODIGO_DISCIPLINA_25,
            this.CODIGO_TURMA_25,
            this.CODIGO_ESPACO_25,
            this.CODIGO_PROFESSOR1_25,
            this.CODIGO_PROFESSOR2_25,
            this.CODIGO_PROFESSOR3_25});
            this.grade25.ContextMenuStrip = this.menuContexto;
            this.grade25.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade25.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade25.Location = new System.Drawing.Point(190, 166);
            this.grade25.MultiSelect = false;
            this.grade25.Name = "grade25";
            this.grade25.ReadOnly = true;
            this.grade25.RowHeadersVisible = false;
            this.grade25.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade25.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade25.Size = new System.Drawing.Size(89, 27);
            this.grade25.TabIndex = 150;
            this.grade25.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade25.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade25.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_25
            // 
            this.HORARIO_GRADE_25.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_25.HeaderText = "HORARIO_GRADE_25";
            this.HORARIO_GRADE_25.Name = "HORARIO_GRADE_25";
            this.HORARIO_GRADE_25.ReadOnly = true;
            this.HORARIO_GRADE_25.Visible = false;
            // 
            // DIA_SEMANA_GRADE_25
            // 
            this.DIA_SEMANA_GRADE_25.HeaderText = "DIA_SEMANA_GRADE_25";
            this.DIA_SEMANA_GRADE_25.Name = "DIA_SEMANA_GRADE_25";
            this.DIA_SEMANA_GRADE_25.ReadOnly = true;
            this.DIA_SEMANA_GRADE_25.Visible = false;
            // 
            // CODIGO_DISCIPLINA_25
            // 
            this.CODIGO_DISCIPLINA_25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_25.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_25.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_25.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_25.Name = "CODIGO_DISCIPLINA_25";
            this.CODIGO_DISCIPLINA_25.ReadOnly = true;
            this.CODIGO_DISCIPLINA_25.Width = 20;
            // 
            // CODIGO_TURMA_25
            // 
            this.CODIGO_TURMA_25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_25.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_25.HeaderText = "Turma";
            this.CODIGO_TURMA_25.MinimumWidth = 20;
            this.CODIGO_TURMA_25.Name = "CODIGO_TURMA_25";
            this.CODIGO_TURMA_25.ReadOnly = true;
            // 
            // CODIGO_ESPACO_25
            // 
            this.CODIGO_ESPACO_25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_25.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_25.HeaderText = "Sala";
            this.CODIGO_ESPACO_25.MinimumWidth = 20;
            this.CODIGO_ESPACO_25.Name = "CODIGO_ESPACO_25";
            this.CODIGO_ESPACO_25.ReadOnly = true;
            this.CODIGO_ESPACO_25.Width = 20;
            // 
            // CODIGO_PROFESSOR1_25
            // 
            this.CODIGO_PROFESSOR1_25.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_25.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_25.Name = "CODIGO_PROFESSOR1_25";
            this.CODIGO_PROFESSOR1_25.ReadOnly = true;
            this.CODIGO_PROFESSOR1_25.Visible = false;
            // 
            // CODIGO_PROFESSOR2_25
            // 
            this.CODIGO_PROFESSOR2_25.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_25.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_25.Name = "CODIGO_PROFESSOR2_25";
            this.CODIGO_PROFESSOR2_25.ReadOnly = true;
            this.CODIGO_PROFESSOR2_25.Visible = false;
            // 
            // CODIGO_PROFESSOR3_25
            // 
            this.CODIGO_PROFESSOR3_25.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_25.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_25.Name = "CODIGO_PROFESSOR3_25";
            this.CODIGO_PROFESSOR3_25.ReadOnly = true;
            this.CODIGO_PROFESSOR3_25.Visible = false;
            // 
            // grade26
            // 
            this.grade26.AllowUserToAddRows = false;
            this.grade26.AllowUserToDeleteRows = false;
            this.grade26.AllowUserToResizeColumns = false;
            this.grade26.AllowUserToResizeRows = false;
            this.grade26.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade26.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade26.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade26.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade26.ColumnHeadersVisible = false;
            this.grade26.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_26,
            this.DIA_SEMANA_GRADE_26,
            this.CODIGO_DISCIPLINA_26,
            this.CODIGO_TURMA_26,
            this.CODIGO_ESPACO_26,
            this.CODIGO_PROFESSOR1_26,
            this.CODIGO_PROFESSOR2_26,
            this.CODIGO_PROFESSOR3_26});
            this.grade26.ContextMenuStrip = this.menuContexto;
            this.grade26.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade26.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade26.Location = new System.Drawing.Point(190, 200);
            this.grade26.MultiSelect = false;
            this.grade26.Name = "grade26";
            this.grade26.ReadOnly = true;
            this.grade26.RowHeadersVisible = false;
            this.grade26.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade26.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade26.Size = new System.Drawing.Size(89, 27);
            this.grade26.TabIndex = 150;
            this.grade26.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade26.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade26.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_26
            // 
            this.HORARIO_GRADE_26.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_26.HeaderText = "HORARIO_GRADE_26";
            this.HORARIO_GRADE_26.Name = "HORARIO_GRADE_26";
            this.HORARIO_GRADE_26.ReadOnly = true;
            this.HORARIO_GRADE_26.Visible = false;
            // 
            // DIA_SEMANA_GRADE_26
            // 
            this.DIA_SEMANA_GRADE_26.HeaderText = "DIA_SEMANA_GRADE_26";
            this.DIA_SEMANA_GRADE_26.Name = "DIA_SEMANA_GRADE_26";
            this.DIA_SEMANA_GRADE_26.ReadOnly = true;
            this.DIA_SEMANA_GRADE_26.Visible = false;
            // 
            // CODIGO_DISCIPLINA_26
            // 
            this.CODIGO_DISCIPLINA_26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_26.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_26.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_26.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_26.Name = "CODIGO_DISCIPLINA_26";
            this.CODIGO_DISCIPLINA_26.ReadOnly = true;
            this.CODIGO_DISCIPLINA_26.Width = 20;
            // 
            // CODIGO_TURMA_26
            // 
            this.CODIGO_TURMA_26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_26.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_26.HeaderText = "Turma";
            this.CODIGO_TURMA_26.MinimumWidth = 20;
            this.CODIGO_TURMA_26.Name = "CODIGO_TURMA_26";
            this.CODIGO_TURMA_26.ReadOnly = true;
            // 
            // CODIGO_ESPACO_26
            // 
            this.CODIGO_ESPACO_26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_26.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_26.HeaderText = "Sala";
            this.CODIGO_ESPACO_26.MinimumWidth = 20;
            this.CODIGO_ESPACO_26.Name = "CODIGO_ESPACO_26";
            this.CODIGO_ESPACO_26.ReadOnly = true;
            this.CODIGO_ESPACO_26.Width = 20;
            // 
            // CODIGO_PROFESSOR1_26
            // 
            this.CODIGO_PROFESSOR1_26.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_26.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_26.Name = "CODIGO_PROFESSOR1_26";
            this.CODIGO_PROFESSOR1_26.ReadOnly = true;
            this.CODIGO_PROFESSOR1_26.Visible = false;
            // 
            // CODIGO_PROFESSOR2_26
            // 
            this.CODIGO_PROFESSOR2_26.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_26.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_26.Name = "CODIGO_PROFESSOR2_26";
            this.CODIGO_PROFESSOR2_26.ReadOnly = true;
            this.CODIGO_PROFESSOR2_26.Visible = false;
            // 
            // CODIGO_PROFESSOR3_26
            // 
            this.CODIGO_PROFESSOR3_26.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_26.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_26.Name = "CODIGO_PROFESSOR3_26";
            this.CODIGO_PROFESSOR3_26.ReadOnly = true;
            this.CODIGO_PROFESSOR3_26.Visible = false;
            // 
            // grade27
            // 
            this.grade27.AllowUserToAddRows = false;
            this.grade27.AllowUserToDeleteRows = false;
            this.grade27.AllowUserToResizeColumns = false;
            this.grade27.AllowUserToResizeRows = false;
            this.grade27.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade27.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade27.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade27.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade27.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade27.ColumnHeadersVisible = false;
            this.grade27.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_27,
            this.DIA_SEMANA_GRADE_27,
            this.CODIGO_DISCIPLINA_27,
            this.CODIGO_TURMA_27,
            this.CODIGO_ESPACO_27,
            this.CODIGO_PROFESSOR1_27,
            this.CODIGO_PROFESSOR2_27,
            this.CODIGO_PROFESSOR3_27});
            this.grade27.ContextMenuStrip = this.menuContexto;
            this.grade27.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade27.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade27.Location = new System.Drawing.Point(190, 234);
            this.grade27.MultiSelect = false;
            this.grade27.Name = "grade27";
            this.grade27.ReadOnly = true;
            this.grade27.RowHeadersVisible = false;
            this.grade27.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade27.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade27.Size = new System.Drawing.Size(89, 27);
            this.grade27.TabIndex = 150;
            this.grade27.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade27.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade27.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_27
            // 
            this.HORARIO_GRADE_27.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_27.HeaderText = "HORARIO_GRADE_27";
            this.HORARIO_GRADE_27.Name = "HORARIO_GRADE_27";
            this.HORARIO_GRADE_27.ReadOnly = true;
            this.HORARIO_GRADE_27.Visible = false;
            // 
            // DIA_SEMANA_GRADE_27
            // 
            this.DIA_SEMANA_GRADE_27.HeaderText = "DIA_SEMANA_GRADE_27";
            this.DIA_SEMANA_GRADE_27.Name = "DIA_SEMANA_GRADE_27";
            this.DIA_SEMANA_GRADE_27.ReadOnly = true;
            this.DIA_SEMANA_GRADE_27.Visible = false;
            // 
            // CODIGO_DISCIPLINA_27
            // 
            this.CODIGO_DISCIPLINA_27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_27.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_27.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_27.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_27.Name = "CODIGO_DISCIPLINA_27";
            this.CODIGO_DISCIPLINA_27.ReadOnly = true;
            this.CODIGO_DISCIPLINA_27.Width = 20;
            // 
            // CODIGO_TURMA_27
            // 
            this.CODIGO_TURMA_27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_27.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_27.HeaderText = "Turma";
            this.CODIGO_TURMA_27.MinimumWidth = 20;
            this.CODIGO_TURMA_27.Name = "CODIGO_TURMA_27";
            this.CODIGO_TURMA_27.ReadOnly = true;
            // 
            // CODIGO_ESPACO_27
            // 
            this.CODIGO_ESPACO_27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_27.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_27.HeaderText = "Sala";
            this.CODIGO_ESPACO_27.MinimumWidth = 20;
            this.CODIGO_ESPACO_27.Name = "CODIGO_ESPACO_27";
            this.CODIGO_ESPACO_27.ReadOnly = true;
            this.CODIGO_ESPACO_27.Width = 20;
            // 
            // CODIGO_PROFESSOR1_27
            // 
            this.CODIGO_PROFESSOR1_27.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_27.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_27.Name = "CODIGO_PROFESSOR1_27";
            this.CODIGO_PROFESSOR1_27.ReadOnly = true;
            this.CODIGO_PROFESSOR1_27.Visible = false;
            // 
            // CODIGO_PROFESSOR2_27
            // 
            this.CODIGO_PROFESSOR2_27.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_27.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_27.Name = "CODIGO_PROFESSOR2_27";
            this.CODIGO_PROFESSOR2_27.ReadOnly = true;
            this.CODIGO_PROFESSOR2_27.Visible = false;
            // 
            // CODIGO_PROFESSOR3_27
            // 
            this.CODIGO_PROFESSOR3_27.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_27.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_27.Name = "CODIGO_PROFESSOR3_27";
            this.CODIGO_PROFESSOR3_27.ReadOnly = true;
            this.CODIGO_PROFESSOR3_27.Visible = false;
            // 
            // grade28
            // 
            this.grade28.AllowUserToAddRows = false;
            this.grade28.AllowUserToDeleteRows = false;
            this.grade28.AllowUserToResizeColumns = false;
            this.grade28.AllowUserToResizeRows = false;
            this.grade28.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade28.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade28.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade28.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade28.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade28.ColumnHeadersVisible = false;
            this.grade28.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_28,
            this.DIA_SEMANA_GRADE_28,
            this.CODIGO_DISCIPLINA_28,
            this.CODIGO_TURMA_28,
            this.CODIGO_ESPACO_28,
            this.CODIGO_PROFESSOR1_28,
            this.CODIGO_PROFESSOR2_28,
            this.CODIGO_PROFESSOR3_28});
            this.grade28.ContextMenuStrip = this.menuContexto;
            this.grade28.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade28.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade28.Location = new System.Drawing.Point(190, 268);
            this.grade28.MultiSelect = false;
            this.grade28.Name = "grade28";
            this.grade28.ReadOnly = true;
            this.grade28.RowHeadersVisible = false;
            this.grade28.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade28.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade28.Size = new System.Drawing.Size(89, 27);
            this.grade28.TabIndex = 150;
            this.grade28.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade28.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade28.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_28
            // 
            this.HORARIO_GRADE_28.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_28.HeaderText = "HORARIO_GRADE_28";
            this.HORARIO_GRADE_28.Name = "HORARIO_GRADE_28";
            this.HORARIO_GRADE_28.ReadOnly = true;
            this.HORARIO_GRADE_28.Visible = false;
            // 
            // DIA_SEMANA_GRADE_28
            // 
            this.DIA_SEMANA_GRADE_28.HeaderText = "DIA_SEMANA_GRADE_28";
            this.DIA_SEMANA_GRADE_28.Name = "DIA_SEMANA_GRADE_28";
            this.DIA_SEMANA_GRADE_28.ReadOnly = true;
            this.DIA_SEMANA_GRADE_28.Visible = false;
            // 
            // CODIGO_DISCIPLINA_28
            // 
            this.CODIGO_DISCIPLINA_28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_28.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_28.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_28.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_28.Name = "CODIGO_DISCIPLINA_28";
            this.CODIGO_DISCIPLINA_28.ReadOnly = true;
            this.CODIGO_DISCIPLINA_28.Width = 20;
            // 
            // CODIGO_TURMA_28
            // 
            this.CODIGO_TURMA_28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_28.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_28.HeaderText = "Turma";
            this.CODIGO_TURMA_28.MinimumWidth = 20;
            this.CODIGO_TURMA_28.Name = "CODIGO_TURMA_28";
            this.CODIGO_TURMA_28.ReadOnly = true;
            // 
            // CODIGO_ESPACO_28
            // 
            this.CODIGO_ESPACO_28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_28.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_28.HeaderText = "Sala";
            this.CODIGO_ESPACO_28.MinimumWidth = 20;
            this.CODIGO_ESPACO_28.Name = "CODIGO_ESPACO_28";
            this.CODIGO_ESPACO_28.ReadOnly = true;
            this.CODIGO_ESPACO_28.Width = 20;
            // 
            // CODIGO_PROFESSOR1_28
            // 
            this.CODIGO_PROFESSOR1_28.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_28.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_28.Name = "CODIGO_PROFESSOR1_28";
            this.CODIGO_PROFESSOR1_28.ReadOnly = true;
            this.CODIGO_PROFESSOR1_28.Visible = false;
            // 
            // CODIGO_PROFESSOR2_28
            // 
            this.CODIGO_PROFESSOR2_28.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_28.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_28.Name = "CODIGO_PROFESSOR2_28";
            this.CODIGO_PROFESSOR2_28.ReadOnly = true;
            this.CODIGO_PROFESSOR2_28.Visible = false;
            // 
            // CODIGO_PROFESSOR3_28
            // 
            this.CODIGO_PROFESSOR3_28.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_28.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_28.Name = "CODIGO_PROFESSOR3_28";
            this.CODIGO_PROFESSOR3_28.ReadOnly = true;
            this.CODIGO_PROFESSOR3_28.Visible = false;
            // 
            // grade29
            // 
            this.grade29.AllowUserToAddRows = false;
            this.grade29.AllowUserToDeleteRows = false;
            this.grade29.AllowUserToResizeColumns = false;
            this.grade29.AllowUserToResizeRows = false;
            this.grade29.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade29.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade29.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade29.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade29.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade29.ColumnHeadersVisible = false;
            this.grade29.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_29,
            this.DIA_SEMANA_GRADE_29,
            this.CODIGO_DISCIPLINA_29,
            this.CODIGO_TURMA_29,
            this.CODIGO_ESPACO_29,
            this.CODIGO_PROFESSOR1_29,
            this.CODIGO_PROFESSOR2_29,
            this.CODIGO_PROFESSOR3_29});
            this.grade29.ContextMenuStrip = this.menuContexto;
            this.grade29.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade29.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade29.Location = new System.Drawing.Point(190, 302);
            this.grade29.MultiSelect = false;
            this.grade29.Name = "grade29";
            this.grade29.ReadOnly = true;
            this.grade29.RowHeadersVisible = false;
            this.grade29.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade29.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade29.Size = new System.Drawing.Size(89, 27);
            this.grade29.TabIndex = 150;
            this.grade29.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade29.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade29.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_29
            // 
            this.HORARIO_GRADE_29.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_29.HeaderText = "HORARIO_GRADE_29";
            this.HORARIO_GRADE_29.Name = "HORARIO_GRADE_29";
            this.HORARIO_GRADE_29.ReadOnly = true;
            this.HORARIO_GRADE_29.Visible = false;
            // 
            // DIA_SEMANA_GRADE_29
            // 
            this.DIA_SEMANA_GRADE_29.HeaderText = "DIA_SEMANA_GRADE_29";
            this.DIA_SEMANA_GRADE_29.Name = "DIA_SEMANA_GRADE_29";
            this.DIA_SEMANA_GRADE_29.ReadOnly = true;
            this.DIA_SEMANA_GRADE_29.Visible = false;
            // 
            // CODIGO_DISCIPLINA_29
            // 
            this.CODIGO_DISCIPLINA_29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_29.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_29.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_29.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_29.Name = "CODIGO_DISCIPLINA_29";
            this.CODIGO_DISCIPLINA_29.ReadOnly = true;
            this.CODIGO_DISCIPLINA_29.Width = 20;
            // 
            // CODIGO_TURMA_29
            // 
            this.CODIGO_TURMA_29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_29.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_29.HeaderText = "Turma";
            this.CODIGO_TURMA_29.MinimumWidth = 20;
            this.CODIGO_TURMA_29.Name = "CODIGO_TURMA_29";
            this.CODIGO_TURMA_29.ReadOnly = true;
            // 
            // CODIGO_ESPACO_29
            // 
            this.CODIGO_ESPACO_29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_29.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_29.HeaderText = "Sala";
            this.CODIGO_ESPACO_29.MinimumWidth = 20;
            this.CODIGO_ESPACO_29.Name = "CODIGO_ESPACO_29";
            this.CODIGO_ESPACO_29.ReadOnly = true;
            this.CODIGO_ESPACO_29.Width = 20;
            // 
            // CODIGO_PROFESSOR1_29
            // 
            this.CODIGO_PROFESSOR1_29.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_29.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_29.Name = "CODIGO_PROFESSOR1_29";
            this.CODIGO_PROFESSOR1_29.ReadOnly = true;
            this.CODIGO_PROFESSOR1_29.Visible = false;
            // 
            // CODIGO_PROFESSOR2_29
            // 
            this.CODIGO_PROFESSOR2_29.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_29.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_29.Name = "CODIGO_PROFESSOR2_29";
            this.CODIGO_PROFESSOR2_29.ReadOnly = true;
            this.CODIGO_PROFESSOR2_29.Visible = false;
            // 
            // CODIGO_PROFESSOR3_29
            // 
            this.CODIGO_PROFESSOR3_29.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_29.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_29.Name = "CODIGO_PROFESSOR3_29";
            this.CODIGO_PROFESSOR3_29.ReadOnly = true;
            this.CODIGO_PROFESSOR3_29.Visible = false;
            // 
            // grade210
            // 
            this.grade210.AllowUserToAddRows = false;
            this.grade210.AllowUserToDeleteRows = false;
            this.grade210.AllowUserToResizeColumns = false;
            this.grade210.AllowUserToResizeRows = false;
            this.grade210.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade210.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade210.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade210.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade210.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade210.ColumnHeadersVisible = false;
            this.grade210.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_210,
            this.DIA_SEMANA_GRADE_210,
            this.CODIGO_DISCIPLINA_210,
            this.CODIGO_TURMA_210,
            this.CODIGO_ESPACO_210,
            this.CODIGO_PROFESSOR1_210,
            this.CODIGO_PROFESSOR2_210,
            this.CODIGO_PROFESSOR3_210});
            this.grade210.ContextMenuStrip = this.menuContexto;
            this.grade210.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade210.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade210.Location = new System.Drawing.Point(190, 336);
            this.grade210.MultiSelect = false;
            this.grade210.Name = "grade210";
            this.grade210.ReadOnly = true;
            this.grade210.RowHeadersVisible = false;
            this.grade210.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade210.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade210.Size = new System.Drawing.Size(89, 27);
            this.grade210.TabIndex = 150;
            this.grade210.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade210.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade210.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_210
            // 
            this.HORARIO_GRADE_210.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_210.HeaderText = "HORARIO_GRADE_210";
            this.HORARIO_GRADE_210.Name = "HORARIO_GRADE_210";
            this.HORARIO_GRADE_210.ReadOnly = true;
            this.HORARIO_GRADE_210.Visible = false;
            // 
            // DIA_SEMANA_GRADE_210
            // 
            this.DIA_SEMANA_GRADE_210.HeaderText = "DIA_SEMANA_GRADE_210";
            this.DIA_SEMANA_GRADE_210.Name = "DIA_SEMANA_GRADE_210";
            this.DIA_SEMANA_GRADE_210.ReadOnly = true;
            this.DIA_SEMANA_GRADE_210.Visible = false;
            // 
            // CODIGO_DISCIPLINA_210
            // 
            this.CODIGO_DISCIPLINA_210.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_210.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_210.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_210.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_210.Name = "CODIGO_DISCIPLINA_210";
            this.CODIGO_DISCIPLINA_210.ReadOnly = true;
            this.CODIGO_DISCIPLINA_210.Width = 20;
            // 
            // CODIGO_TURMA_210
            // 
            this.CODIGO_TURMA_210.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_210.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_210.HeaderText = "Turma";
            this.CODIGO_TURMA_210.MinimumWidth = 20;
            this.CODIGO_TURMA_210.Name = "CODIGO_TURMA_210";
            this.CODIGO_TURMA_210.ReadOnly = true;
            // 
            // CODIGO_ESPACO_210
            // 
            this.CODIGO_ESPACO_210.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_210.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_210.HeaderText = "Sala";
            this.CODIGO_ESPACO_210.MinimumWidth = 20;
            this.CODIGO_ESPACO_210.Name = "CODIGO_ESPACO_210";
            this.CODIGO_ESPACO_210.ReadOnly = true;
            this.CODIGO_ESPACO_210.Width = 20;
            // 
            // CODIGO_PROFESSOR1_210
            // 
            this.CODIGO_PROFESSOR1_210.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_210.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_210.Name = "CODIGO_PROFESSOR1_210";
            this.CODIGO_PROFESSOR1_210.ReadOnly = true;
            this.CODIGO_PROFESSOR1_210.Visible = false;
            // 
            // CODIGO_PROFESSOR2_210
            // 
            this.CODIGO_PROFESSOR2_210.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_210.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_210.Name = "CODIGO_PROFESSOR2_210";
            this.CODIGO_PROFESSOR2_210.ReadOnly = true;
            this.CODIGO_PROFESSOR2_210.Visible = false;
            // 
            // CODIGO_PROFESSOR3_210
            // 
            this.CODIGO_PROFESSOR3_210.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_210.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_210.Name = "CODIGO_PROFESSOR3_210";
            this.CODIGO_PROFESSOR3_210.ReadOnly = true;
            this.CODIGO_PROFESSOR3_210.Visible = false;
            // 
            // grade211
            // 
            this.grade211.AllowUserToAddRows = false;
            this.grade211.AllowUserToDeleteRows = false;
            this.grade211.AllowUserToResizeColumns = false;
            this.grade211.AllowUserToResizeRows = false;
            this.grade211.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade211.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade211.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade211.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade211.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade211.ColumnHeadersVisible = false;
            this.grade211.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_211,
            this.DIA_SEMANA_GRADE_211,
            this.CODIGO_DISCIPLINA_211,
            this.CODIGO_TURMA_211,
            this.CODIGO_ESPACO_211,
            this.CODIGO_PROFESSOR1_211,
            this.CODIGO_PROFESSOR2_211,
            this.CODIGO_PROFESSOR3_211});
            this.grade211.ContextMenuStrip = this.menuContexto;
            this.grade211.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade211.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade211.Location = new System.Drawing.Point(190, 370);
            this.grade211.MultiSelect = false;
            this.grade211.Name = "grade211";
            this.grade211.ReadOnly = true;
            this.grade211.RowHeadersVisible = false;
            this.grade211.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade211.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade211.Size = new System.Drawing.Size(89, 27);
            this.grade211.TabIndex = 150;
            this.grade211.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade211.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade211.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_211
            // 
            this.HORARIO_GRADE_211.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_211.HeaderText = "HORARIO_GRADE_211";
            this.HORARIO_GRADE_211.Name = "HORARIO_GRADE_211";
            this.HORARIO_GRADE_211.ReadOnly = true;
            this.HORARIO_GRADE_211.Visible = false;
            // 
            // DIA_SEMANA_GRADE_211
            // 
            this.DIA_SEMANA_GRADE_211.HeaderText = "DIA_SEMANA_GRADE_211";
            this.DIA_SEMANA_GRADE_211.Name = "DIA_SEMANA_GRADE_211";
            this.DIA_SEMANA_GRADE_211.ReadOnly = true;
            this.DIA_SEMANA_GRADE_211.Visible = false;
            // 
            // CODIGO_DISCIPLINA_211
            // 
            this.CODIGO_DISCIPLINA_211.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_211.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_211.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_211.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_211.Name = "CODIGO_DISCIPLINA_211";
            this.CODIGO_DISCIPLINA_211.ReadOnly = true;
            this.CODIGO_DISCIPLINA_211.Width = 20;
            // 
            // CODIGO_TURMA_211
            // 
            this.CODIGO_TURMA_211.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_211.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_211.HeaderText = "Turma";
            this.CODIGO_TURMA_211.MinimumWidth = 20;
            this.CODIGO_TURMA_211.Name = "CODIGO_TURMA_211";
            this.CODIGO_TURMA_211.ReadOnly = true;
            // 
            // CODIGO_ESPACO_211
            // 
            this.CODIGO_ESPACO_211.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_211.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_211.HeaderText = "Sala";
            this.CODIGO_ESPACO_211.MinimumWidth = 20;
            this.CODIGO_ESPACO_211.Name = "CODIGO_ESPACO_211";
            this.CODIGO_ESPACO_211.ReadOnly = true;
            this.CODIGO_ESPACO_211.Width = 20;
            // 
            // CODIGO_PROFESSOR1_211
            // 
            this.CODIGO_PROFESSOR1_211.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_211.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_211.Name = "CODIGO_PROFESSOR1_211";
            this.CODIGO_PROFESSOR1_211.ReadOnly = true;
            this.CODIGO_PROFESSOR1_211.Visible = false;
            // 
            // CODIGO_PROFESSOR2_211
            // 
            this.CODIGO_PROFESSOR2_211.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_211.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_211.Name = "CODIGO_PROFESSOR2_211";
            this.CODIGO_PROFESSOR2_211.ReadOnly = true;
            this.CODIGO_PROFESSOR2_211.Visible = false;
            // 
            // CODIGO_PROFESSOR3_211
            // 
            this.CODIGO_PROFESSOR3_211.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_211.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_211.Name = "CODIGO_PROFESSOR3_211";
            this.CODIGO_PROFESSOR3_211.ReadOnly = true;
            this.CODIGO_PROFESSOR3_211.Visible = false;
            // 
            // grade212
            // 
            this.grade212.AllowUserToAddRows = false;
            this.grade212.AllowUserToDeleteRows = false;
            this.grade212.AllowUserToResizeColumns = false;
            this.grade212.AllowUserToResizeRows = false;
            this.grade212.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade212.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade212.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade212.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade212.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade212.ColumnHeadersVisible = false;
            this.grade212.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_212,
            this.DIA_SEMANA_GRADE_212,
            this.CODIGO_DISCIPLINA_212,
            this.CODIGO_TURMA_212,
            this.CODIGO_ESPACO_212,
            this.CODIGO_PROFESSOR1_212,
            this.CODIGO_PROFESSOR2_212,
            this.CODIGO_PROFESSOR3_212});
            this.grade212.ContextMenuStrip = this.menuContexto;
            this.grade212.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade212.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade212.Location = new System.Drawing.Point(190, 404);
            this.grade212.MultiSelect = false;
            this.grade212.Name = "grade212";
            this.grade212.ReadOnly = true;
            this.grade212.RowHeadersVisible = false;
            this.grade212.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade212.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade212.Size = new System.Drawing.Size(89, 27);
            this.grade212.TabIndex = 150;
            this.grade212.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade212.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade212.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_212
            // 
            this.HORARIO_GRADE_212.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_212.HeaderText = "HORARIO_GRADE_212";
            this.HORARIO_GRADE_212.Name = "HORARIO_GRADE_212";
            this.HORARIO_GRADE_212.ReadOnly = true;
            this.HORARIO_GRADE_212.Visible = false;
            // 
            // DIA_SEMANA_GRADE_212
            // 
            this.DIA_SEMANA_GRADE_212.HeaderText = "DIA_SEMANA_GRADE_212";
            this.DIA_SEMANA_GRADE_212.Name = "DIA_SEMANA_GRADE_212";
            this.DIA_SEMANA_GRADE_212.ReadOnly = true;
            this.DIA_SEMANA_GRADE_212.Visible = false;
            // 
            // CODIGO_DISCIPLINA_212
            // 
            this.CODIGO_DISCIPLINA_212.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_212.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_212.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_212.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_212.Name = "CODIGO_DISCIPLINA_212";
            this.CODIGO_DISCIPLINA_212.ReadOnly = true;
            this.CODIGO_DISCIPLINA_212.Width = 20;
            // 
            // CODIGO_TURMA_212
            // 
            this.CODIGO_TURMA_212.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_212.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_212.HeaderText = "Turma";
            this.CODIGO_TURMA_212.MinimumWidth = 20;
            this.CODIGO_TURMA_212.Name = "CODIGO_TURMA_212";
            this.CODIGO_TURMA_212.ReadOnly = true;
            // 
            // CODIGO_ESPACO_212
            // 
            this.CODIGO_ESPACO_212.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_212.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_212.HeaderText = "Sala";
            this.CODIGO_ESPACO_212.MinimumWidth = 20;
            this.CODIGO_ESPACO_212.Name = "CODIGO_ESPACO_212";
            this.CODIGO_ESPACO_212.ReadOnly = true;
            this.CODIGO_ESPACO_212.Width = 20;
            // 
            // CODIGO_PROFESSOR1_212
            // 
            this.CODIGO_PROFESSOR1_212.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_212.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_212.Name = "CODIGO_PROFESSOR1_212";
            this.CODIGO_PROFESSOR1_212.ReadOnly = true;
            this.CODIGO_PROFESSOR1_212.Visible = false;
            // 
            // CODIGO_PROFESSOR2_212
            // 
            this.CODIGO_PROFESSOR2_212.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_212.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_212.Name = "CODIGO_PROFESSOR2_212";
            this.CODIGO_PROFESSOR2_212.ReadOnly = true;
            this.CODIGO_PROFESSOR2_212.Visible = false;
            // 
            // CODIGO_PROFESSOR3_212
            // 
            this.CODIGO_PROFESSOR3_212.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_212.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_212.Name = "CODIGO_PROFESSOR3_212";
            this.CODIGO_PROFESSOR3_212.ReadOnly = true;
            this.CODIGO_PROFESSOR3_212.Visible = false;
            // 
            // grade213
            // 
            this.grade213.AllowUserToAddRows = false;
            this.grade213.AllowUserToDeleteRows = false;
            this.grade213.AllowUserToResizeColumns = false;
            this.grade213.AllowUserToResizeRows = false;
            this.grade213.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade213.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade213.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade213.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade213.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade213.ColumnHeadersVisible = false;
            this.grade213.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_213,
            this.DIA_SEMANA_GRADE_213,
            this.CODIGO_DISCIPLINA_213,
            this.CODIGO_TURMA_213,
            this.CODIGO_ESPACO_213,
            this.CODIGO_PROFESSOR1_213,
            this.CODIGO_PROFESSOR2_213,
            this.CODIGO_PROFESSOR3_213});
            this.grade213.ContextMenuStrip = this.menuContexto;
            this.grade213.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade213.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade213.Location = new System.Drawing.Point(190, 438);
            this.grade213.MultiSelect = false;
            this.grade213.Name = "grade213";
            this.grade213.ReadOnly = true;
            this.grade213.RowHeadersVisible = false;
            this.grade213.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade213.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade213.Size = new System.Drawing.Size(89, 27);
            this.grade213.TabIndex = 150;
            this.grade213.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade213.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade213.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_213
            // 
            this.HORARIO_GRADE_213.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_213.HeaderText = "HORARIO_GRADE_213";
            this.HORARIO_GRADE_213.Name = "HORARIO_GRADE_213";
            this.HORARIO_GRADE_213.ReadOnly = true;
            this.HORARIO_GRADE_213.Visible = false;
            // 
            // DIA_SEMANA_GRADE_213
            // 
            this.DIA_SEMANA_GRADE_213.HeaderText = "DIA_SEMANA_GRADE_213";
            this.DIA_SEMANA_GRADE_213.Name = "DIA_SEMANA_GRADE_213";
            this.DIA_SEMANA_GRADE_213.ReadOnly = true;
            this.DIA_SEMANA_GRADE_213.Visible = false;
            // 
            // CODIGO_DISCIPLINA_213
            // 
            this.CODIGO_DISCIPLINA_213.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_213.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_213.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_213.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_213.Name = "CODIGO_DISCIPLINA_213";
            this.CODIGO_DISCIPLINA_213.ReadOnly = true;
            this.CODIGO_DISCIPLINA_213.Width = 20;
            // 
            // CODIGO_TURMA_213
            // 
            this.CODIGO_TURMA_213.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_213.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_213.HeaderText = "Turma";
            this.CODIGO_TURMA_213.MinimumWidth = 20;
            this.CODIGO_TURMA_213.Name = "CODIGO_TURMA_213";
            this.CODIGO_TURMA_213.ReadOnly = true;
            // 
            // CODIGO_ESPACO_213
            // 
            this.CODIGO_ESPACO_213.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_213.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_213.HeaderText = "Sala";
            this.CODIGO_ESPACO_213.MinimumWidth = 20;
            this.CODIGO_ESPACO_213.Name = "CODIGO_ESPACO_213";
            this.CODIGO_ESPACO_213.ReadOnly = true;
            this.CODIGO_ESPACO_213.Width = 20;
            // 
            // CODIGO_PROFESSOR1_213
            // 
            this.CODIGO_PROFESSOR1_213.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_213.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_213.Name = "CODIGO_PROFESSOR1_213";
            this.CODIGO_PROFESSOR1_213.ReadOnly = true;
            this.CODIGO_PROFESSOR1_213.Visible = false;
            // 
            // CODIGO_PROFESSOR2_213
            // 
            this.CODIGO_PROFESSOR2_213.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_213.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_213.Name = "CODIGO_PROFESSOR2_213";
            this.CODIGO_PROFESSOR2_213.ReadOnly = true;
            this.CODIGO_PROFESSOR2_213.Visible = false;
            // 
            // CODIGO_PROFESSOR3_213
            // 
            this.CODIGO_PROFESSOR3_213.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_213.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_213.Name = "CODIGO_PROFESSOR3_213";
            this.CODIGO_PROFESSOR3_213.ReadOnly = true;
            this.CODIGO_PROFESSOR3_213.Visible = false;
            // 
            // grade214
            // 
            this.grade214.AllowUserToAddRows = false;
            this.grade214.AllowUserToDeleteRows = false;
            this.grade214.AllowUserToResizeColumns = false;
            this.grade214.AllowUserToResizeRows = false;
            this.grade214.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade214.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade214.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade214.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade214.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade214.ColumnHeadersVisible = false;
            this.grade214.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_214,
            this.DIA_SEMANA_GRADE_214,
            this.CODIGO_DISCIPLINA_214,
            this.CODIGO_TURMA_214,
            this.CODIGO_ESPACO_214,
            this.CODIGO_PROFESSOR1_214,
            this.CODIGO_PROFESSOR2_214,
            this.CODIGO_PROFESSOR3_214});
            this.grade214.ContextMenuStrip = this.menuContexto;
            this.grade214.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade214.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade214.Location = new System.Drawing.Point(190, 472);
            this.grade214.MultiSelect = false;
            this.grade214.Name = "grade214";
            this.grade214.ReadOnly = true;
            this.grade214.RowHeadersVisible = false;
            this.grade214.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade214.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade214.Size = new System.Drawing.Size(89, 28);
            this.grade214.TabIndex = 150;
            this.grade214.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade214.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade214.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_214
            // 
            this.HORARIO_GRADE_214.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_214.HeaderText = "HORARIO_GRADE_214";
            this.HORARIO_GRADE_214.Name = "HORARIO_GRADE_214";
            this.HORARIO_GRADE_214.ReadOnly = true;
            this.HORARIO_GRADE_214.Visible = false;
            // 
            // DIA_SEMANA_GRADE_214
            // 
            this.DIA_SEMANA_GRADE_214.HeaderText = "DIA_SEMANA_GRADE_214";
            this.DIA_SEMANA_GRADE_214.Name = "DIA_SEMANA_GRADE_214";
            this.DIA_SEMANA_GRADE_214.ReadOnly = true;
            this.DIA_SEMANA_GRADE_214.Visible = false;
            // 
            // CODIGO_DISCIPLINA_214
            // 
            this.CODIGO_DISCIPLINA_214.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_214.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_214.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_214.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_214.Name = "CODIGO_DISCIPLINA_214";
            this.CODIGO_DISCIPLINA_214.ReadOnly = true;
            this.CODIGO_DISCIPLINA_214.Width = 20;
            // 
            // CODIGO_TURMA_214
            // 
            this.CODIGO_TURMA_214.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_214.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_214.HeaderText = "Turma";
            this.CODIGO_TURMA_214.MinimumWidth = 20;
            this.CODIGO_TURMA_214.Name = "CODIGO_TURMA_214";
            this.CODIGO_TURMA_214.ReadOnly = true;
            // 
            // CODIGO_ESPACO_214
            // 
            this.CODIGO_ESPACO_214.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_214.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_214.HeaderText = "Sala";
            this.CODIGO_ESPACO_214.MinimumWidth = 20;
            this.CODIGO_ESPACO_214.Name = "CODIGO_ESPACO_214";
            this.CODIGO_ESPACO_214.ReadOnly = true;
            this.CODIGO_ESPACO_214.Width = 20;
            // 
            // CODIGO_PROFESSOR1_214
            // 
            this.CODIGO_PROFESSOR1_214.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_214.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_214.Name = "CODIGO_PROFESSOR1_214";
            this.CODIGO_PROFESSOR1_214.ReadOnly = true;
            this.CODIGO_PROFESSOR1_214.Visible = false;
            // 
            // CODIGO_PROFESSOR2_214
            // 
            this.CODIGO_PROFESSOR2_214.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_214.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_214.Name = "CODIGO_PROFESSOR2_214";
            this.CODIGO_PROFESSOR2_214.ReadOnly = true;
            this.CODIGO_PROFESSOR2_214.Visible = false;
            // 
            // CODIGO_PROFESSOR3_214
            // 
            this.CODIGO_PROFESSOR3_214.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_214.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_214.Name = "CODIGO_PROFESSOR3_214";
            this.CODIGO_PROFESSOR3_214.ReadOnly = true;
            this.CODIGO_PROFESSOR3_214.Visible = false;
            // 
            // grade31
            // 
            this.grade31.AllowUserToAddRows = false;
            this.grade31.AllowUserToDeleteRows = false;
            this.grade31.AllowUserToResizeColumns = false;
            this.grade31.AllowUserToResizeRows = false;
            this.grade31.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade31.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade31.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade31.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade31.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade31.ColumnHeadersVisible = false;
            this.grade31.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_31,
            this.DIA_SEMANA_GRADE_31,
            this.CODIGO_DISCIPLINA_31,
            this.CODIGO_TURMA_31,
            this.CODIGO_ESPACO_31,
            this.CODIGO_PROFESSOR1_31,
            this.CODIGO_PROFESSOR2_31,
            this.CODIGO_PROFESSOR3_31});
            this.grade31.ContextMenuStrip = this.menuContexto;
            this.grade31.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade31.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade31.Location = new System.Drawing.Point(286, 30);
            this.grade31.MultiSelect = false;
            this.grade31.Name = "grade31";
            this.grade31.ReadOnly = true;
            this.grade31.RowHeadersVisible = false;
            this.grade31.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade31.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade31.Size = new System.Drawing.Size(89, 27);
            this.grade31.TabIndex = 150;
            this.grade31.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade31.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade31.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_31
            // 
            this.HORARIO_GRADE_31.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_31.HeaderText = "HORARIO_GRADE_31";
            this.HORARIO_GRADE_31.Name = "HORARIO_GRADE_31";
            this.HORARIO_GRADE_31.ReadOnly = true;
            this.HORARIO_GRADE_31.Visible = false;
            // 
            // DIA_SEMANA_GRADE_31
            // 
            this.DIA_SEMANA_GRADE_31.HeaderText = "DIA_SEMANA_GRADE_31";
            this.DIA_SEMANA_GRADE_31.Name = "DIA_SEMANA_GRADE_31";
            this.DIA_SEMANA_GRADE_31.ReadOnly = true;
            this.DIA_SEMANA_GRADE_31.Visible = false;
            // 
            // CODIGO_DISCIPLINA_31
            // 
            this.CODIGO_DISCIPLINA_31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_31.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_31.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_31.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_31.Name = "CODIGO_DISCIPLINA_31";
            this.CODIGO_DISCIPLINA_31.ReadOnly = true;
            this.CODIGO_DISCIPLINA_31.Width = 20;
            // 
            // CODIGO_TURMA_31
            // 
            this.CODIGO_TURMA_31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_31.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_31.HeaderText = "Turma";
            this.CODIGO_TURMA_31.MinimumWidth = 20;
            this.CODIGO_TURMA_31.Name = "CODIGO_TURMA_31";
            this.CODIGO_TURMA_31.ReadOnly = true;
            // 
            // CODIGO_ESPACO_31
            // 
            this.CODIGO_ESPACO_31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_31.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_31.HeaderText = "Sala";
            this.CODIGO_ESPACO_31.MinimumWidth = 20;
            this.CODIGO_ESPACO_31.Name = "CODIGO_ESPACO_31";
            this.CODIGO_ESPACO_31.ReadOnly = true;
            this.CODIGO_ESPACO_31.Width = 20;
            // 
            // CODIGO_PROFESSOR1_31
            // 
            this.CODIGO_PROFESSOR1_31.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_31.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_31.Name = "CODIGO_PROFESSOR1_31";
            this.CODIGO_PROFESSOR1_31.ReadOnly = true;
            this.CODIGO_PROFESSOR1_31.Visible = false;
            // 
            // CODIGO_PROFESSOR2_31
            // 
            this.CODIGO_PROFESSOR2_31.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_31.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_31.Name = "CODIGO_PROFESSOR2_31";
            this.CODIGO_PROFESSOR2_31.ReadOnly = true;
            this.CODIGO_PROFESSOR2_31.Visible = false;
            // 
            // CODIGO_PROFESSOR3_31
            // 
            this.CODIGO_PROFESSOR3_31.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_31.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_31.Name = "CODIGO_PROFESSOR3_31";
            this.CODIGO_PROFESSOR3_31.ReadOnly = true;
            this.CODIGO_PROFESSOR3_31.Visible = false;
            // 
            // grade32
            // 
            this.grade32.AllowUserToAddRows = false;
            this.grade32.AllowUserToDeleteRows = false;
            this.grade32.AllowUserToResizeColumns = false;
            this.grade32.AllowUserToResizeRows = false;
            this.grade32.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade32.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade32.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade32.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade32.ColumnHeadersVisible = false;
            this.grade32.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_32,
            this.DIA_SEMANA_GRADE_32,
            this.CODIGO_DISCIPLINA_32,
            this.CODIGO_TURMA_32,
            this.CODIGO_ESPACO_32,
            this.CODIGO_PROFESSOR1_32,
            this.CODIGO_PROFESSOR2_32,
            this.CODIGO_PROFESSOR3_32});
            this.grade32.ContextMenuStrip = this.menuContexto;
            this.grade32.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade32.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade32.Location = new System.Drawing.Point(286, 64);
            this.grade32.MultiSelect = false;
            this.grade32.Name = "grade32";
            this.grade32.ReadOnly = true;
            this.grade32.RowHeadersVisible = false;
            this.grade32.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade32.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade32.Size = new System.Drawing.Size(89, 27);
            this.grade32.TabIndex = 150;
            this.grade32.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade32.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade32.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_32
            // 
            this.HORARIO_GRADE_32.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_32.HeaderText = "HORARIO_GRADE_32";
            this.HORARIO_GRADE_32.Name = "HORARIO_GRADE_32";
            this.HORARIO_GRADE_32.ReadOnly = true;
            this.HORARIO_GRADE_32.Visible = false;
            // 
            // DIA_SEMANA_GRADE_32
            // 
            this.DIA_SEMANA_GRADE_32.HeaderText = "DIA_SEMANA_GRADE_32";
            this.DIA_SEMANA_GRADE_32.Name = "DIA_SEMANA_GRADE_32";
            this.DIA_SEMANA_GRADE_32.ReadOnly = true;
            this.DIA_SEMANA_GRADE_32.Visible = false;
            // 
            // CODIGO_DISCIPLINA_32
            // 
            this.CODIGO_DISCIPLINA_32.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_32.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_32.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_32.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_32.Name = "CODIGO_DISCIPLINA_32";
            this.CODIGO_DISCIPLINA_32.ReadOnly = true;
            this.CODIGO_DISCIPLINA_32.Width = 20;
            // 
            // CODIGO_TURMA_32
            // 
            this.CODIGO_TURMA_32.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_32.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_32.HeaderText = "Turma";
            this.CODIGO_TURMA_32.MinimumWidth = 20;
            this.CODIGO_TURMA_32.Name = "CODIGO_TURMA_32";
            this.CODIGO_TURMA_32.ReadOnly = true;
            // 
            // CODIGO_ESPACO_32
            // 
            this.CODIGO_ESPACO_32.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_32.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_32.HeaderText = "Sala";
            this.CODIGO_ESPACO_32.MinimumWidth = 20;
            this.CODIGO_ESPACO_32.Name = "CODIGO_ESPACO_32";
            this.CODIGO_ESPACO_32.ReadOnly = true;
            this.CODIGO_ESPACO_32.Width = 20;
            // 
            // CODIGO_PROFESSOR1_32
            // 
            this.CODIGO_PROFESSOR1_32.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_32.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_32.Name = "CODIGO_PROFESSOR1_32";
            this.CODIGO_PROFESSOR1_32.ReadOnly = true;
            this.CODIGO_PROFESSOR1_32.Visible = false;
            // 
            // CODIGO_PROFESSOR2_32
            // 
            this.CODIGO_PROFESSOR2_32.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_32.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_32.Name = "CODIGO_PROFESSOR2_32";
            this.CODIGO_PROFESSOR2_32.ReadOnly = true;
            this.CODIGO_PROFESSOR2_32.Visible = false;
            // 
            // CODIGO_PROFESSOR3_32
            // 
            this.CODIGO_PROFESSOR3_32.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_32.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_32.Name = "CODIGO_PROFESSOR3_32";
            this.CODIGO_PROFESSOR3_32.ReadOnly = true;
            this.CODIGO_PROFESSOR3_32.Visible = false;
            // 
            // grade33
            // 
            this.grade33.AllowUserToAddRows = false;
            this.grade33.AllowUserToDeleteRows = false;
            this.grade33.AllowUserToResizeColumns = false;
            this.grade33.AllowUserToResizeRows = false;
            this.grade33.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade33.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade33.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade33.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade33.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade33.ColumnHeadersVisible = false;
            this.grade33.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_33,
            this.DIA_SEMANA_GRADE_33,
            this.CODIGO_DISCIPLINA_33,
            this.CODIGO_TURMA_33,
            this.CODIGO_ESPACO_33,
            this.CODIGO_PROFESSOR1_33,
            this.CODIGO_PROFESSOR2_33,
            this.CODIGO_PROFESSOR3_33});
            this.grade33.ContextMenuStrip = this.menuContexto;
            this.grade33.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade33.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade33.Location = new System.Drawing.Point(286, 98);
            this.grade33.MultiSelect = false;
            this.grade33.Name = "grade33";
            this.grade33.ReadOnly = true;
            this.grade33.RowHeadersVisible = false;
            this.grade33.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade33.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade33.Size = new System.Drawing.Size(89, 27);
            this.grade33.TabIndex = 150;
            this.grade33.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade33.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade33.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_33
            // 
            this.HORARIO_GRADE_33.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_33.HeaderText = "HORARIO_GRADE_33";
            this.HORARIO_GRADE_33.Name = "HORARIO_GRADE_33";
            this.HORARIO_GRADE_33.ReadOnly = true;
            this.HORARIO_GRADE_33.Visible = false;
            // 
            // DIA_SEMANA_GRADE_33
            // 
            this.DIA_SEMANA_GRADE_33.HeaderText = "DIA_SEMANA_GRADE_33";
            this.DIA_SEMANA_GRADE_33.Name = "DIA_SEMANA_GRADE_33";
            this.DIA_SEMANA_GRADE_33.ReadOnly = true;
            this.DIA_SEMANA_GRADE_33.Visible = false;
            // 
            // CODIGO_DISCIPLINA_33
            // 
            this.CODIGO_DISCIPLINA_33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_33.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_33.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_33.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_33.Name = "CODIGO_DISCIPLINA_33";
            this.CODIGO_DISCIPLINA_33.ReadOnly = true;
            this.CODIGO_DISCIPLINA_33.Width = 20;
            // 
            // CODIGO_TURMA_33
            // 
            this.CODIGO_TURMA_33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_33.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_33.HeaderText = "Turma";
            this.CODIGO_TURMA_33.MinimumWidth = 20;
            this.CODIGO_TURMA_33.Name = "CODIGO_TURMA_33";
            this.CODIGO_TURMA_33.ReadOnly = true;
            // 
            // CODIGO_ESPACO_33
            // 
            this.CODIGO_ESPACO_33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_33.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_33.HeaderText = "Sala";
            this.CODIGO_ESPACO_33.MinimumWidth = 20;
            this.CODIGO_ESPACO_33.Name = "CODIGO_ESPACO_33";
            this.CODIGO_ESPACO_33.ReadOnly = true;
            this.CODIGO_ESPACO_33.Width = 20;
            // 
            // CODIGO_PROFESSOR1_33
            // 
            this.CODIGO_PROFESSOR1_33.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_33.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_33.Name = "CODIGO_PROFESSOR1_33";
            this.CODIGO_PROFESSOR1_33.ReadOnly = true;
            this.CODIGO_PROFESSOR1_33.Visible = false;
            // 
            // CODIGO_PROFESSOR2_33
            // 
            this.CODIGO_PROFESSOR2_33.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_33.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_33.Name = "CODIGO_PROFESSOR2_33";
            this.CODIGO_PROFESSOR2_33.ReadOnly = true;
            this.CODIGO_PROFESSOR2_33.Visible = false;
            // 
            // CODIGO_PROFESSOR3_33
            // 
            this.CODIGO_PROFESSOR3_33.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_33.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_33.Name = "CODIGO_PROFESSOR3_33";
            this.CODIGO_PROFESSOR3_33.ReadOnly = true;
            this.CODIGO_PROFESSOR3_33.Visible = false;
            // 
            // grade34
            // 
            this.grade34.AllowUserToAddRows = false;
            this.grade34.AllowUserToDeleteRows = false;
            this.grade34.AllowUserToResizeColumns = false;
            this.grade34.AllowUserToResizeRows = false;
            this.grade34.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade34.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade34.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade34.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade34.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade34.ColumnHeadersVisible = false;
            this.grade34.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_34,
            this.DIA_SEMANA_GRADE_34,
            this.CODIGO_DISCIPLINA_34,
            this.CODIGO_TURMA_34,
            this.CODIGO_ESPACO_34,
            this.CODIGO_PROFESSOR1_34,
            this.CODIGO_PROFESSOR2_34,
            this.CODIGO_PROFESSOR3_34});
            this.grade34.ContextMenuStrip = this.menuContexto;
            this.grade34.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade34.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade34.Location = new System.Drawing.Point(286, 132);
            this.grade34.MultiSelect = false;
            this.grade34.Name = "grade34";
            this.grade34.ReadOnly = true;
            this.grade34.RowHeadersVisible = false;
            this.grade34.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade34.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade34.Size = new System.Drawing.Size(89, 27);
            this.grade34.TabIndex = 150;
            this.grade34.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade34.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade34.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_34
            // 
            this.HORARIO_GRADE_34.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_34.HeaderText = "HORARIO_GRADE_34";
            this.HORARIO_GRADE_34.Name = "HORARIO_GRADE_34";
            this.HORARIO_GRADE_34.ReadOnly = true;
            this.HORARIO_GRADE_34.Visible = false;
            // 
            // DIA_SEMANA_GRADE_34
            // 
            this.DIA_SEMANA_GRADE_34.HeaderText = "DIA_SEMANA_GRADE_34";
            this.DIA_SEMANA_GRADE_34.Name = "DIA_SEMANA_GRADE_34";
            this.DIA_SEMANA_GRADE_34.ReadOnly = true;
            this.DIA_SEMANA_GRADE_34.Visible = false;
            // 
            // CODIGO_DISCIPLINA_34
            // 
            this.CODIGO_DISCIPLINA_34.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_34.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_34.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_34.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_34.Name = "CODIGO_DISCIPLINA_34";
            this.CODIGO_DISCIPLINA_34.ReadOnly = true;
            this.CODIGO_DISCIPLINA_34.Width = 20;
            // 
            // CODIGO_TURMA_34
            // 
            this.CODIGO_TURMA_34.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_34.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_34.HeaderText = "Turma";
            this.CODIGO_TURMA_34.MinimumWidth = 20;
            this.CODIGO_TURMA_34.Name = "CODIGO_TURMA_34";
            this.CODIGO_TURMA_34.ReadOnly = true;
            // 
            // CODIGO_ESPACO_34
            // 
            this.CODIGO_ESPACO_34.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_34.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_34.HeaderText = "Sala";
            this.CODIGO_ESPACO_34.MinimumWidth = 20;
            this.CODIGO_ESPACO_34.Name = "CODIGO_ESPACO_34";
            this.CODIGO_ESPACO_34.ReadOnly = true;
            this.CODIGO_ESPACO_34.Width = 20;
            // 
            // CODIGO_PROFESSOR1_34
            // 
            this.CODIGO_PROFESSOR1_34.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_34.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_34.Name = "CODIGO_PROFESSOR1_34";
            this.CODIGO_PROFESSOR1_34.ReadOnly = true;
            this.CODIGO_PROFESSOR1_34.Visible = false;
            // 
            // CODIGO_PROFESSOR2_34
            // 
            this.CODIGO_PROFESSOR2_34.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_34.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_34.Name = "CODIGO_PROFESSOR2_34";
            this.CODIGO_PROFESSOR2_34.ReadOnly = true;
            this.CODIGO_PROFESSOR2_34.Visible = false;
            // 
            // CODIGO_PROFESSOR3_34
            // 
            this.CODIGO_PROFESSOR3_34.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_34.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_34.Name = "CODIGO_PROFESSOR3_34";
            this.CODIGO_PROFESSOR3_34.ReadOnly = true;
            this.CODIGO_PROFESSOR3_34.Visible = false;
            // 
            // grade35
            // 
            this.grade35.AllowUserToAddRows = false;
            this.grade35.AllowUserToDeleteRows = false;
            this.grade35.AllowUserToResizeColumns = false;
            this.grade35.AllowUserToResizeRows = false;
            this.grade35.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade35.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade35.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade35.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade35.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade35.ColumnHeadersVisible = false;
            this.grade35.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_35,
            this.DIA_SEMANA_GRADE_35,
            this.CODIGO_DISCIPLINA_35,
            this.CODIGO_TURMA_35,
            this.CODIGO_ESPACO_35,
            this.CODIGO_PROFESSOR1_35,
            this.CODIGO_PROFESSOR2_35,
            this.CODIGO_PROFESSOR3_35});
            this.grade35.ContextMenuStrip = this.menuContexto;
            this.grade35.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade35.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade35.Location = new System.Drawing.Point(286, 166);
            this.grade35.MultiSelect = false;
            this.grade35.Name = "grade35";
            this.grade35.ReadOnly = true;
            this.grade35.RowHeadersVisible = false;
            this.grade35.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade35.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade35.Size = new System.Drawing.Size(89, 27);
            this.grade35.TabIndex = 150;
            this.grade35.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade35.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade35.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_35
            // 
            this.HORARIO_GRADE_35.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_35.HeaderText = "HORARIO_GRADE_35";
            this.HORARIO_GRADE_35.Name = "HORARIO_GRADE_35";
            this.HORARIO_GRADE_35.ReadOnly = true;
            this.HORARIO_GRADE_35.Visible = false;
            // 
            // DIA_SEMANA_GRADE_35
            // 
            this.DIA_SEMANA_GRADE_35.HeaderText = "DIA_SEMANA_GRADE_35";
            this.DIA_SEMANA_GRADE_35.Name = "DIA_SEMANA_GRADE_35";
            this.DIA_SEMANA_GRADE_35.ReadOnly = true;
            this.DIA_SEMANA_GRADE_35.Visible = false;
            // 
            // CODIGO_DISCIPLINA_35
            // 
            this.CODIGO_DISCIPLINA_35.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_35.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_35.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_35.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_35.Name = "CODIGO_DISCIPLINA_35";
            this.CODIGO_DISCIPLINA_35.ReadOnly = true;
            this.CODIGO_DISCIPLINA_35.Width = 20;
            // 
            // CODIGO_TURMA_35
            // 
            this.CODIGO_TURMA_35.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_35.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_35.HeaderText = "Turma";
            this.CODIGO_TURMA_35.MinimumWidth = 20;
            this.CODIGO_TURMA_35.Name = "CODIGO_TURMA_35";
            this.CODIGO_TURMA_35.ReadOnly = true;
            // 
            // CODIGO_ESPACO_35
            // 
            this.CODIGO_ESPACO_35.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_35.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_35.HeaderText = "Sala";
            this.CODIGO_ESPACO_35.MinimumWidth = 20;
            this.CODIGO_ESPACO_35.Name = "CODIGO_ESPACO_35";
            this.CODIGO_ESPACO_35.ReadOnly = true;
            this.CODIGO_ESPACO_35.Width = 20;
            // 
            // CODIGO_PROFESSOR1_35
            // 
            this.CODIGO_PROFESSOR1_35.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_35.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_35.Name = "CODIGO_PROFESSOR1_35";
            this.CODIGO_PROFESSOR1_35.ReadOnly = true;
            this.CODIGO_PROFESSOR1_35.Visible = false;
            // 
            // CODIGO_PROFESSOR2_35
            // 
            this.CODIGO_PROFESSOR2_35.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_35.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_35.Name = "CODIGO_PROFESSOR2_35";
            this.CODIGO_PROFESSOR2_35.ReadOnly = true;
            this.CODIGO_PROFESSOR2_35.Visible = false;
            // 
            // CODIGO_PROFESSOR3_35
            // 
            this.CODIGO_PROFESSOR3_35.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_35.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_35.Name = "CODIGO_PROFESSOR3_35";
            this.CODIGO_PROFESSOR3_35.ReadOnly = true;
            this.CODIGO_PROFESSOR3_35.Visible = false;
            // 
            // grade36
            // 
            this.grade36.AllowUserToAddRows = false;
            this.grade36.AllowUserToDeleteRows = false;
            this.grade36.AllowUserToResizeColumns = false;
            this.grade36.AllowUserToResizeRows = false;
            this.grade36.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade36.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade36.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade36.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade36.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade36.ColumnHeadersVisible = false;
            this.grade36.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_36,
            this.DIA_SEMANA_GRADE_36,
            this.CODIGO_DISCIPLINA_36,
            this.CODIGO_TURMA_36,
            this.CODIGO_ESPACO_36,
            this.CODIGO_PROFESSOR1_36,
            this.CODIGO_PROFESSOR2_36,
            this.CODIGO_PROFESSOR3_36});
            this.grade36.ContextMenuStrip = this.menuContexto;
            this.grade36.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade36.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade36.Location = new System.Drawing.Point(286, 200);
            this.grade36.MultiSelect = false;
            this.grade36.Name = "grade36";
            this.grade36.ReadOnly = true;
            this.grade36.RowHeadersVisible = false;
            this.grade36.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade36.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade36.Size = new System.Drawing.Size(89, 27);
            this.grade36.TabIndex = 150;
            this.grade36.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade36.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade36.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_36
            // 
            this.HORARIO_GRADE_36.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_36.HeaderText = "HORARIO_GRADE_36";
            this.HORARIO_GRADE_36.Name = "HORARIO_GRADE_36";
            this.HORARIO_GRADE_36.ReadOnly = true;
            this.HORARIO_GRADE_36.Visible = false;
            // 
            // DIA_SEMANA_GRADE_36
            // 
            this.DIA_SEMANA_GRADE_36.HeaderText = "DIA_SEMANA_GRADE_36";
            this.DIA_SEMANA_GRADE_36.Name = "DIA_SEMANA_GRADE_36";
            this.DIA_SEMANA_GRADE_36.ReadOnly = true;
            this.DIA_SEMANA_GRADE_36.Visible = false;
            // 
            // CODIGO_DISCIPLINA_36
            // 
            this.CODIGO_DISCIPLINA_36.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_36.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_36.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_36.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_36.Name = "CODIGO_DISCIPLINA_36";
            this.CODIGO_DISCIPLINA_36.ReadOnly = true;
            this.CODIGO_DISCIPLINA_36.Width = 20;
            // 
            // CODIGO_TURMA_36
            // 
            this.CODIGO_TURMA_36.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_36.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_36.HeaderText = "Turma";
            this.CODIGO_TURMA_36.MinimumWidth = 20;
            this.CODIGO_TURMA_36.Name = "CODIGO_TURMA_36";
            this.CODIGO_TURMA_36.ReadOnly = true;
            // 
            // CODIGO_ESPACO_36
            // 
            this.CODIGO_ESPACO_36.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_36.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_36.HeaderText = "Sala";
            this.CODIGO_ESPACO_36.MinimumWidth = 20;
            this.CODIGO_ESPACO_36.Name = "CODIGO_ESPACO_36";
            this.CODIGO_ESPACO_36.ReadOnly = true;
            this.CODIGO_ESPACO_36.Width = 20;
            // 
            // CODIGO_PROFESSOR1_36
            // 
            this.CODIGO_PROFESSOR1_36.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_36.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_36.Name = "CODIGO_PROFESSOR1_36";
            this.CODIGO_PROFESSOR1_36.ReadOnly = true;
            this.CODIGO_PROFESSOR1_36.Visible = false;
            // 
            // CODIGO_PROFESSOR2_36
            // 
            this.CODIGO_PROFESSOR2_36.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_36.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_36.Name = "CODIGO_PROFESSOR2_36";
            this.CODIGO_PROFESSOR2_36.ReadOnly = true;
            this.CODIGO_PROFESSOR2_36.Visible = false;
            // 
            // CODIGO_PROFESSOR3_36
            // 
            this.CODIGO_PROFESSOR3_36.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_36.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_36.Name = "CODIGO_PROFESSOR3_36";
            this.CODIGO_PROFESSOR3_36.ReadOnly = true;
            this.CODIGO_PROFESSOR3_36.Visible = false;
            // 
            // grade37
            // 
            this.grade37.AllowUserToAddRows = false;
            this.grade37.AllowUserToDeleteRows = false;
            this.grade37.AllowUserToResizeColumns = false;
            this.grade37.AllowUserToResizeRows = false;
            this.grade37.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade37.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade37.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade37.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade37.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade37.ColumnHeadersVisible = false;
            this.grade37.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_37,
            this.DIA_SEMANA_GRADE_37,
            this.CODIGO_DISCIPLINA_37,
            this.CODIGO_TURMA_37,
            this.CODIGO_ESPACO_37,
            this.CODIGO_PROFESSOR1_37,
            this.CODIGO_PROFESSOR2_37,
            this.CODIGO_PROFESSOR3_37});
            this.grade37.ContextMenuStrip = this.menuContexto;
            this.grade37.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade37.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade37.Location = new System.Drawing.Point(286, 234);
            this.grade37.MultiSelect = false;
            this.grade37.Name = "grade37";
            this.grade37.ReadOnly = true;
            this.grade37.RowHeadersVisible = false;
            this.grade37.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade37.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade37.Size = new System.Drawing.Size(89, 27);
            this.grade37.TabIndex = 150;
            this.grade37.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade37.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade37.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_37
            // 
            this.HORARIO_GRADE_37.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_37.HeaderText = "HORARIO_GRADE_37";
            this.HORARIO_GRADE_37.Name = "HORARIO_GRADE_37";
            this.HORARIO_GRADE_37.ReadOnly = true;
            this.HORARIO_GRADE_37.Visible = false;
            // 
            // DIA_SEMANA_GRADE_37
            // 
            this.DIA_SEMANA_GRADE_37.HeaderText = "DIA_SEMANA_GRADE_37";
            this.DIA_SEMANA_GRADE_37.Name = "DIA_SEMANA_GRADE_37";
            this.DIA_SEMANA_GRADE_37.ReadOnly = true;
            this.DIA_SEMANA_GRADE_37.Visible = false;
            // 
            // CODIGO_DISCIPLINA_37
            // 
            this.CODIGO_DISCIPLINA_37.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_37.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_37.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_37.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_37.Name = "CODIGO_DISCIPLINA_37";
            this.CODIGO_DISCIPLINA_37.ReadOnly = true;
            this.CODIGO_DISCIPLINA_37.Width = 20;
            // 
            // CODIGO_TURMA_37
            // 
            this.CODIGO_TURMA_37.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_37.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_37.HeaderText = "Turma";
            this.CODIGO_TURMA_37.MinimumWidth = 20;
            this.CODIGO_TURMA_37.Name = "CODIGO_TURMA_37";
            this.CODIGO_TURMA_37.ReadOnly = true;
            // 
            // CODIGO_ESPACO_37
            // 
            this.CODIGO_ESPACO_37.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_37.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_37.HeaderText = "Sala";
            this.CODIGO_ESPACO_37.MinimumWidth = 20;
            this.CODIGO_ESPACO_37.Name = "CODIGO_ESPACO_37";
            this.CODIGO_ESPACO_37.ReadOnly = true;
            this.CODIGO_ESPACO_37.Width = 20;
            // 
            // CODIGO_PROFESSOR1_37
            // 
            this.CODIGO_PROFESSOR1_37.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_37.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_37.Name = "CODIGO_PROFESSOR1_37";
            this.CODIGO_PROFESSOR1_37.ReadOnly = true;
            this.CODIGO_PROFESSOR1_37.Visible = false;
            // 
            // CODIGO_PROFESSOR2_37
            // 
            this.CODIGO_PROFESSOR2_37.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_37.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_37.Name = "CODIGO_PROFESSOR2_37";
            this.CODIGO_PROFESSOR2_37.ReadOnly = true;
            this.CODIGO_PROFESSOR2_37.Visible = false;
            // 
            // CODIGO_PROFESSOR3_37
            // 
            this.CODIGO_PROFESSOR3_37.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_37.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_37.Name = "CODIGO_PROFESSOR3_37";
            this.CODIGO_PROFESSOR3_37.ReadOnly = true;
            this.CODIGO_PROFESSOR3_37.Visible = false;
            // 
            // grade38
            // 
            this.grade38.AllowUserToAddRows = false;
            this.grade38.AllowUserToDeleteRows = false;
            this.grade38.AllowUserToResizeColumns = false;
            this.grade38.AllowUserToResizeRows = false;
            this.grade38.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade38.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade38.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade38.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade38.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade38.ColumnHeadersVisible = false;
            this.grade38.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_38,
            this.DIA_SEMANA_GRADE_38,
            this.CODIGO_DISCIPLINA_38,
            this.CODIGO_TURMA_38,
            this.CODIGO_ESPACO_38,
            this.CODIGO_PROFESSOR1_38,
            this.CODIGO_PROFESSOR2_38,
            this.CODIGO_PROFESSOR3_38});
            this.grade38.ContextMenuStrip = this.menuContexto;
            this.grade38.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade38.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade38.Location = new System.Drawing.Point(286, 268);
            this.grade38.MultiSelect = false;
            this.grade38.Name = "grade38";
            this.grade38.ReadOnly = true;
            this.grade38.RowHeadersVisible = false;
            this.grade38.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade38.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade38.Size = new System.Drawing.Size(89, 27);
            this.grade38.TabIndex = 150;
            this.grade38.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade38.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade38.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_38
            // 
            this.HORARIO_GRADE_38.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_38.HeaderText = "HORARIO_GRADE_38";
            this.HORARIO_GRADE_38.Name = "HORARIO_GRADE_38";
            this.HORARIO_GRADE_38.ReadOnly = true;
            this.HORARIO_GRADE_38.Visible = false;
            // 
            // DIA_SEMANA_GRADE_38
            // 
            this.DIA_SEMANA_GRADE_38.HeaderText = "DIA_SEMANA_GRADE_38";
            this.DIA_SEMANA_GRADE_38.Name = "DIA_SEMANA_GRADE_38";
            this.DIA_SEMANA_GRADE_38.ReadOnly = true;
            this.DIA_SEMANA_GRADE_38.Visible = false;
            // 
            // CODIGO_DISCIPLINA_38
            // 
            this.CODIGO_DISCIPLINA_38.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_38.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_38.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_38.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_38.Name = "CODIGO_DISCIPLINA_38";
            this.CODIGO_DISCIPLINA_38.ReadOnly = true;
            this.CODIGO_DISCIPLINA_38.Width = 20;
            // 
            // CODIGO_TURMA_38
            // 
            this.CODIGO_TURMA_38.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_38.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_38.HeaderText = "Turma";
            this.CODIGO_TURMA_38.MinimumWidth = 20;
            this.CODIGO_TURMA_38.Name = "CODIGO_TURMA_38";
            this.CODIGO_TURMA_38.ReadOnly = true;
            // 
            // CODIGO_ESPACO_38
            // 
            this.CODIGO_ESPACO_38.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_38.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_38.HeaderText = "Sala";
            this.CODIGO_ESPACO_38.MinimumWidth = 20;
            this.CODIGO_ESPACO_38.Name = "CODIGO_ESPACO_38";
            this.CODIGO_ESPACO_38.ReadOnly = true;
            this.CODIGO_ESPACO_38.Width = 20;
            // 
            // CODIGO_PROFESSOR1_38
            // 
            this.CODIGO_PROFESSOR1_38.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_38.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_38.Name = "CODIGO_PROFESSOR1_38";
            this.CODIGO_PROFESSOR1_38.ReadOnly = true;
            this.CODIGO_PROFESSOR1_38.Visible = false;
            // 
            // CODIGO_PROFESSOR2_38
            // 
            this.CODIGO_PROFESSOR2_38.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_38.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_38.Name = "CODIGO_PROFESSOR2_38";
            this.CODIGO_PROFESSOR2_38.ReadOnly = true;
            this.CODIGO_PROFESSOR2_38.Visible = false;
            // 
            // CODIGO_PROFESSOR3_38
            // 
            this.CODIGO_PROFESSOR3_38.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_38.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_38.Name = "CODIGO_PROFESSOR3_38";
            this.CODIGO_PROFESSOR3_38.ReadOnly = true;
            this.CODIGO_PROFESSOR3_38.Visible = false;
            // 
            // grade39
            // 
            this.grade39.AllowUserToAddRows = false;
            this.grade39.AllowUserToDeleteRows = false;
            this.grade39.AllowUserToResizeColumns = false;
            this.grade39.AllowUserToResizeRows = false;
            this.grade39.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade39.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade39.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade39.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade39.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade39.ColumnHeadersVisible = false;
            this.grade39.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_39,
            this.DIA_SEMANA_GRADE_39,
            this.CODIGO_DISCIPLINA_39,
            this.CODIGO_TURMA_39,
            this.CODIGO_ESPACO_39,
            this.CODIGO_PROFESSOR1_39,
            this.CODIGO_PROFESSOR2_39,
            this.CODIGO_PROFESSOR3_39});
            this.grade39.ContextMenuStrip = this.menuContexto;
            this.grade39.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade39.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade39.Location = new System.Drawing.Point(286, 302);
            this.grade39.MultiSelect = false;
            this.grade39.Name = "grade39";
            this.grade39.ReadOnly = true;
            this.grade39.RowHeadersVisible = false;
            this.grade39.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade39.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade39.Size = new System.Drawing.Size(89, 27);
            this.grade39.TabIndex = 150;
            this.grade39.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade39.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade39.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_39
            // 
            this.HORARIO_GRADE_39.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_39.HeaderText = "HORARIO_GRADE_39";
            this.HORARIO_GRADE_39.Name = "HORARIO_GRADE_39";
            this.HORARIO_GRADE_39.ReadOnly = true;
            this.HORARIO_GRADE_39.Visible = false;
            // 
            // DIA_SEMANA_GRADE_39
            // 
            this.DIA_SEMANA_GRADE_39.HeaderText = "DIA_SEMANA_GRADE_39";
            this.DIA_SEMANA_GRADE_39.Name = "DIA_SEMANA_GRADE_39";
            this.DIA_SEMANA_GRADE_39.ReadOnly = true;
            this.DIA_SEMANA_GRADE_39.Visible = false;
            // 
            // CODIGO_DISCIPLINA_39
            // 
            this.CODIGO_DISCIPLINA_39.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_39.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_39.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_39.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_39.Name = "CODIGO_DISCIPLINA_39";
            this.CODIGO_DISCIPLINA_39.ReadOnly = true;
            this.CODIGO_DISCIPLINA_39.Width = 20;
            // 
            // CODIGO_TURMA_39
            // 
            this.CODIGO_TURMA_39.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_39.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_39.HeaderText = "Turma";
            this.CODIGO_TURMA_39.MinimumWidth = 20;
            this.CODIGO_TURMA_39.Name = "CODIGO_TURMA_39";
            this.CODIGO_TURMA_39.ReadOnly = true;
            // 
            // CODIGO_ESPACO_39
            // 
            this.CODIGO_ESPACO_39.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_39.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_39.HeaderText = "Sala";
            this.CODIGO_ESPACO_39.MinimumWidth = 20;
            this.CODIGO_ESPACO_39.Name = "CODIGO_ESPACO_39";
            this.CODIGO_ESPACO_39.ReadOnly = true;
            this.CODIGO_ESPACO_39.Width = 20;
            // 
            // CODIGO_PROFESSOR1_39
            // 
            this.CODIGO_PROFESSOR1_39.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_39.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_39.Name = "CODIGO_PROFESSOR1_39";
            this.CODIGO_PROFESSOR1_39.ReadOnly = true;
            this.CODIGO_PROFESSOR1_39.Visible = false;
            // 
            // CODIGO_PROFESSOR2_39
            // 
            this.CODIGO_PROFESSOR2_39.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_39.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_39.Name = "CODIGO_PROFESSOR2_39";
            this.CODIGO_PROFESSOR2_39.ReadOnly = true;
            this.CODIGO_PROFESSOR2_39.Visible = false;
            // 
            // CODIGO_PROFESSOR3_39
            // 
            this.CODIGO_PROFESSOR3_39.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_39.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_39.Name = "CODIGO_PROFESSOR3_39";
            this.CODIGO_PROFESSOR3_39.ReadOnly = true;
            this.CODIGO_PROFESSOR3_39.Visible = false;
            // 
            // grade310
            // 
            this.grade310.AllowUserToAddRows = false;
            this.grade310.AllowUserToDeleteRows = false;
            this.grade310.AllowUserToResizeColumns = false;
            this.grade310.AllowUserToResizeRows = false;
            this.grade310.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade310.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade310.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade310.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade310.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade310.ColumnHeadersVisible = false;
            this.grade310.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_310,
            this.DIA_SEMANA_GRADE_310,
            this.CODIGO_DISCIPLINA_310,
            this.CODIGO_TURMA_310,
            this.CODIGO_ESPACO_310,
            this.CODIGO_PROFESSOR1_310,
            this.CODIGO_PROFESSOR2_310,
            this.CODIGO_PROFESSOR3_310});
            this.grade310.ContextMenuStrip = this.menuContexto;
            this.grade310.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade310.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade310.Location = new System.Drawing.Point(286, 336);
            this.grade310.MultiSelect = false;
            this.grade310.Name = "grade310";
            this.grade310.ReadOnly = true;
            this.grade310.RowHeadersVisible = false;
            this.grade310.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade310.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade310.Size = new System.Drawing.Size(89, 27);
            this.grade310.TabIndex = 150;
            this.grade310.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade310.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade310.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_310
            // 
            this.HORARIO_GRADE_310.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_310.HeaderText = "HORARIO_GRADE_310";
            this.HORARIO_GRADE_310.Name = "HORARIO_GRADE_310";
            this.HORARIO_GRADE_310.ReadOnly = true;
            this.HORARIO_GRADE_310.Visible = false;
            // 
            // DIA_SEMANA_GRADE_310
            // 
            this.DIA_SEMANA_GRADE_310.HeaderText = "DIA_SEMANA_GRADE_310";
            this.DIA_SEMANA_GRADE_310.Name = "DIA_SEMANA_GRADE_310";
            this.DIA_SEMANA_GRADE_310.ReadOnly = true;
            this.DIA_SEMANA_GRADE_310.Visible = false;
            // 
            // CODIGO_DISCIPLINA_310
            // 
            this.CODIGO_DISCIPLINA_310.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_310.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_310.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_310.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_310.Name = "CODIGO_DISCIPLINA_310";
            this.CODIGO_DISCIPLINA_310.ReadOnly = true;
            this.CODIGO_DISCIPLINA_310.Width = 20;
            // 
            // CODIGO_TURMA_310
            // 
            this.CODIGO_TURMA_310.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_310.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_310.HeaderText = "Turma";
            this.CODIGO_TURMA_310.MinimumWidth = 20;
            this.CODIGO_TURMA_310.Name = "CODIGO_TURMA_310";
            this.CODIGO_TURMA_310.ReadOnly = true;
            // 
            // CODIGO_ESPACO_310
            // 
            this.CODIGO_ESPACO_310.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_310.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_310.HeaderText = "Sala";
            this.CODIGO_ESPACO_310.MinimumWidth = 20;
            this.CODIGO_ESPACO_310.Name = "CODIGO_ESPACO_310";
            this.CODIGO_ESPACO_310.ReadOnly = true;
            this.CODIGO_ESPACO_310.Width = 20;
            // 
            // CODIGO_PROFESSOR1_310
            // 
            this.CODIGO_PROFESSOR1_310.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_310.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_310.Name = "CODIGO_PROFESSOR1_310";
            this.CODIGO_PROFESSOR1_310.ReadOnly = true;
            this.CODIGO_PROFESSOR1_310.Visible = false;
            // 
            // CODIGO_PROFESSOR2_310
            // 
            this.CODIGO_PROFESSOR2_310.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_310.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_310.Name = "CODIGO_PROFESSOR2_310";
            this.CODIGO_PROFESSOR2_310.ReadOnly = true;
            this.CODIGO_PROFESSOR2_310.Visible = false;
            // 
            // CODIGO_PROFESSOR3_310
            // 
            this.CODIGO_PROFESSOR3_310.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_310.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_310.Name = "CODIGO_PROFESSOR3_310";
            this.CODIGO_PROFESSOR3_310.ReadOnly = true;
            this.CODIGO_PROFESSOR3_310.Visible = false;
            // 
            // grade311
            // 
            this.grade311.AllowUserToAddRows = false;
            this.grade311.AllowUserToDeleteRows = false;
            this.grade311.AllowUserToResizeColumns = false;
            this.grade311.AllowUserToResizeRows = false;
            this.grade311.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade311.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade311.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade311.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade311.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade311.ColumnHeadersVisible = false;
            this.grade311.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_311,
            this.DIA_SEMANA_GRADE_311,
            this.CODIGO_DISCIPLINA_311,
            this.CODIGO_TURMA_311,
            this.CODIGO_ESPACO_311,
            this.CODIGO_PROFESSOR1_311,
            this.CODIGO_PROFESSOR2_311,
            this.CODIGO_PROFESSOR3_311});
            this.grade311.ContextMenuStrip = this.menuContexto;
            this.grade311.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade311.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade311.Location = new System.Drawing.Point(286, 370);
            this.grade311.MultiSelect = false;
            this.grade311.Name = "grade311";
            this.grade311.ReadOnly = true;
            this.grade311.RowHeadersVisible = false;
            this.grade311.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade311.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade311.Size = new System.Drawing.Size(89, 27);
            this.grade311.TabIndex = 150;
            this.grade311.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade311.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade311.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_311
            // 
            this.HORARIO_GRADE_311.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_311.HeaderText = "HORARIO_GRADE_311";
            this.HORARIO_GRADE_311.Name = "HORARIO_GRADE_311";
            this.HORARIO_GRADE_311.ReadOnly = true;
            this.HORARIO_GRADE_311.Visible = false;
            // 
            // DIA_SEMANA_GRADE_311
            // 
            this.DIA_SEMANA_GRADE_311.HeaderText = "DIA_SEMANA_GRADE_311";
            this.DIA_SEMANA_GRADE_311.Name = "DIA_SEMANA_GRADE_311";
            this.DIA_SEMANA_GRADE_311.ReadOnly = true;
            this.DIA_SEMANA_GRADE_311.Visible = false;
            // 
            // CODIGO_DISCIPLINA_311
            // 
            this.CODIGO_DISCIPLINA_311.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_311.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_311.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_311.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_311.Name = "CODIGO_DISCIPLINA_311";
            this.CODIGO_DISCIPLINA_311.ReadOnly = true;
            this.CODIGO_DISCIPLINA_311.Width = 20;
            // 
            // CODIGO_TURMA_311
            // 
            this.CODIGO_TURMA_311.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_311.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_311.HeaderText = "Turma";
            this.CODIGO_TURMA_311.MinimumWidth = 20;
            this.CODIGO_TURMA_311.Name = "CODIGO_TURMA_311";
            this.CODIGO_TURMA_311.ReadOnly = true;
            // 
            // CODIGO_ESPACO_311
            // 
            this.CODIGO_ESPACO_311.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_311.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_311.HeaderText = "Sala";
            this.CODIGO_ESPACO_311.MinimumWidth = 20;
            this.CODIGO_ESPACO_311.Name = "CODIGO_ESPACO_311";
            this.CODIGO_ESPACO_311.ReadOnly = true;
            this.CODIGO_ESPACO_311.Width = 20;
            // 
            // CODIGO_PROFESSOR1_311
            // 
            this.CODIGO_PROFESSOR1_311.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_311.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_311.Name = "CODIGO_PROFESSOR1_311";
            this.CODIGO_PROFESSOR1_311.ReadOnly = true;
            this.CODIGO_PROFESSOR1_311.Visible = false;
            // 
            // CODIGO_PROFESSOR2_311
            // 
            this.CODIGO_PROFESSOR2_311.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_311.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_311.Name = "CODIGO_PROFESSOR2_311";
            this.CODIGO_PROFESSOR2_311.ReadOnly = true;
            this.CODIGO_PROFESSOR2_311.Visible = false;
            // 
            // CODIGO_PROFESSOR3_311
            // 
            this.CODIGO_PROFESSOR3_311.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_311.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_311.Name = "CODIGO_PROFESSOR3_311";
            this.CODIGO_PROFESSOR3_311.ReadOnly = true;
            this.CODIGO_PROFESSOR3_311.Visible = false;
            // 
            // grade312
            // 
            this.grade312.AllowUserToAddRows = false;
            this.grade312.AllowUserToDeleteRows = false;
            this.grade312.AllowUserToResizeColumns = false;
            this.grade312.AllowUserToResizeRows = false;
            this.grade312.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade312.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade312.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade312.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade312.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade312.ColumnHeadersVisible = false;
            this.grade312.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_312,
            this.DIA_SEMANA_GRADE_312,
            this.CODIGO_DISCIPLINA_312,
            this.CODIGO_TURMA_312,
            this.CODIGO_ESPACO_312,
            this.CODIGO_PROFESSOR1_312,
            this.CODIGO_PROFESSOR2_312,
            this.CODIGO_PROFESSOR3_312});
            this.grade312.ContextMenuStrip = this.menuContexto;
            this.grade312.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade312.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade312.Location = new System.Drawing.Point(286, 404);
            this.grade312.MultiSelect = false;
            this.grade312.Name = "grade312";
            this.grade312.ReadOnly = true;
            this.grade312.RowHeadersVisible = false;
            this.grade312.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade312.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade312.Size = new System.Drawing.Size(89, 27);
            this.grade312.TabIndex = 150;
            this.grade312.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade312.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade312.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_312
            // 
            this.HORARIO_GRADE_312.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_312.HeaderText = "HORARIO_GRADE_312";
            this.HORARIO_GRADE_312.Name = "HORARIO_GRADE_312";
            this.HORARIO_GRADE_312.ReadOnly = true;
            this.HORARIO_GRADE_312.Visible = false;
            // 
            // DIA_SEMANA_GRADE_312
            // 
            this.DIA_SEMANA_GRADE_312.HeaderText = "DIA_SEMANA_GRADE_312";
            this.DIA_SEMANA_GRADE_312.Name = "DIA_SEMANA_GRADE_312";
            this.DIA_SEMANA_GRADE_312.ReadOnly = true;
            this.DIA_SEMANA_GRADE_312.Visible = false;
            // 
            // CODIGO_DISCIPLINA_312
            // 
            this.CODIGO_DISCIPLINA_312.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_312.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_312.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_312.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_312.Name = "CODIGO_DISCIPLINA_312";
            this.CODIGO_DISCIPLINA_312.ReadOnly = true;
            this.CODIGO_DISCIPLINA_312.Width = 20;
            // 
            // CODIGO_TURMA_312
            // 
            this.CODIGO_TURMA_312.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_312.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_312.HeaderText = "Turma";
            this.CODIGO_TURMA_312.MinimumWidth = 20;
            this.CODIGO_TURMA_312.Name = "CODIGO_TURMA_312";
            this.CODIGO_TURMA_312.ReadOnly = true;
            // 
            // CODIGO_ESPACO_312
            // 
            this.CODIGO_ESPACO_312.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_312.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_312.HeaderText = "Sala";
            this.CODIGO_ESPACO_312.MinimumWidth = 20;
            this.CODIGO_ESPACO_312.Name = "CODIGO_ESPACO_312";
            this.CODIGO_ESPACO_312.ReadOnly = true;
            this.CODIGO_ESPACO_312.Width = 20;
            // 
            // CODIGO_PROFESSOR1_312
            // 
            this.CODIGO_PROFESSOR1_312.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_312.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_312.Name = "CODIGO_PROFESSOR1_312";
            this.CODIGO_PROFESSOR1_312.ReadOnly = true;
            this.CODIGO_PROFESSOR1_312.Visible = false;
            // 
            // CODIGO_PROFESSOR2_312
            // 
            this.CODIGO_PROFESSOR2_312.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_312.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_312.Name = "CODIGO_PROFESSOR2_312";
            this.CODIGO_PROFESSOR2_312.ReadOnly = true;
            this.CODIGO_PROFESSOR2_312.Visible = false;
            // 
            // CODIGO_PROFESSOR3_312
            // 
            this.CODIGO_PROFESSOR3_312.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_312.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_312.Name = "CODIGO_PROFESSOR3_312";
            this.CODIGO_PROFESSOR3_312.ReadOnly = true;
            this.CODIGO_PROFESSOR3_312.Visible = false;
            // 
            // grade313
            // 
            this.grade313.AllowUserToAddRows = false;
            this.grade313.AllowUserToDeleteRows = false;
            this.grade313.AllowUserToResizeColumns = false;
            this.grade313.AllowUserToResizeRows = false;
            this.grade313.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade313.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade313.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade313.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade313.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade313.ColumnHeadersVisible = false;
            this.grade313.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_313,
            this.DIA_SEMANA_GRADE_313,
            this.CODIGO_DISCIPLINA_313,
            this.CODIGO_TURMA_313,
            this.CODIGO_ESPACO_313,
            this.CODIGO_PROFESSOR1_313,
            this.CODIGO_PROFESSOR2_313,
            this.CODIGO_PROFESSOR3_313});
            this.grade313.ContextMenuStrip = this.menuContexto;
            this.grade313.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade313.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade313.Location = new System.Drawing.Point(286, 438);
            this.grade313.MultiSelect = false;
            this.grade313.Name = "grade313";
            this.grade313.ReadOnly = true;
            this.grade313.RowHeadersVisible = false;
            this.grade313.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade313.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade313.Size = new System.Drawing.Size(89, 27);
            this.grade313.TabIndex = 150;
            this.grade313.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade313.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade313.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_313
            // 
            this.HORARIO_GRADE_313.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_313.HeaderText = "HORARIO_GRADE_313";
            this.HORARIO_GRADE_313.Name = "HORARIO_GRADE_313";
            this.HORARIO_GRADE_313.ReadOnly = true;
            this.HORARIO_GRADE_313.Visible = false;
            // 
            // DIA_SEMANA_GRADE_313
            // 
            this.DIA_SEMANA_GRADE_313.HeaderText = "DIA_SEMANA_GRADE_313";
            this.DIA_SEMANA_GRADE_313.Name = "DIA_SEMANA_GRADE_313";
            this.DIA_SEMANA_GRADE_313.ReadOnly = true;
            this.DIA_SEMANA_GRADE_313.Visible = false;
            // 
            // CODIGO_DISCIPLINA_313
            // 
            this.CODIGO_DISCIPLINA_313.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_313.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_313.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_313.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_313.Name = "CODIGO_DISCIPLINA_313";
            this.CODIGO_DISCIPLINA_313.ReadOnly = true;
            this.CODIGO_DISCIPLINA_313.Width = 20;
            // 
            // CODIGO_TURMA_313
            // 
            this.CODIGO_TURMA_313.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_313.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_313.HeaderText = "Turma";
            this.CODIGO_TURMA_313.MinimumWidth = 20;
            this.CODIGO_TURMA_313.Name = "CODIGO_TURMA_313";
            this.CODIGO_TURMA_313.ReadOnly = true;
            // 
            // CODIGO_ESPACO_313
            // 
            this.CODIGO_ESPACO_313.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_313.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_313.HeaderText = "Sala";
            this.CODIGO_ESPACO_313.MinimumWidth = 20;
            this.CODIGO_ESPACO_313.Name = "CODIGO_ESPACO_313";
            this.CODIGO_ESPACO_313.ReadOnly = true;
            this.CODIGO_ESPACO_313.Width = 20;
            // 
            // CODIGO_PROFESSOR1_313
            // 
            this.CODIGO_PROFESSOR1_313.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_313.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_313.Name = "CODIGO_PROFESSOR1_313";
            this.CODIGO_PROFESSOR1_313.ReadOnly = true;
            this.CODIGO_PROFESSOR1_313.Visible = false;
            // 
            // CODIGO_PROFESSOR2_313
            // 
            this.CODIGO_PROFESSOR2_313.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_313.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_313.Name = "CODIGO_PROFESSOR2_313";
            this.CODIGO_PROFESSOR2_313.ReadOnly = true;
            this.CODIGO_PROFESSOR2_313.Visible = false;
            // 
            // CODIGO_PROFESSOR3_313
            // 
            this.CODIGO_PROFESSOR3_313.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_313.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_313.Name = "CODIGO_PROFESSOR3_313";
            this.CODIGO_PROFESSOR3_313.ReadOnly = true;
            this.CODIGO_PROFESSOR3_313.Visible = false;
            // 
            // grade314
            // 
            this.grade314.AllowUserToAddRows = false;
            this.grade314.AllowUserToDeleteRows = false;
            this.grade314.AllowUserToResizeColumns = false;
            this.grade314.AllowUserToResizeRows = false;
            this.grade314.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade314.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade314.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade314.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade314.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade314.ColumnHeadersVisible = false;
            this.grade314.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_314,
            this.DIA_SEMANA_GRADE_314,
            this.CODIGO_DISCIPLINA_314,
            this.CODIGO_TURMA_314,
            this.CODIGO_ESPACO_314,
            this.CODIGO_PROFESSOR1_314,
            this.CODIGO_PROFESSOR2_314,
            this.CODIGO_PROFESSOR3_314});
            this.grade314.ContextMenuStrip = this.menuContexto;
            this.grade314.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade314.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade314.Location = new System.Drawing.Point(286, 472);
            this.grade314.MultiSelect = false;
            this.grade314.Name = "grade314";
            this.grade314.ReadOnly = true;
            this.grade314.RowHeadersVisible = false;
            this.grade314.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade314.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade314.Size = new System.Drawing.Size(89, 28);
            this.grade314.TabIndex = 150;
            this.grade314.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade314.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade314.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_314
            // 
            this.HORARIO_GRADE_314.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_314.HeaderText = "HORARIO_GRADE_314";
            this.HORARIO_GRADE_314.Name = "HORARIO_GRADE_314";
            this.HORARIO_GRADE_314.ReadOnly = true;
            this.HORARIO_GRADE_314.Visible = false;
            // 
            // DIA_SEMANA_GRADE_314
            // 
            this.DIA_SEMANA_GRADE_314.HeaderText = "DIA_SEMANA_GRADE_314";
            this.DIA_SEMANA_GRADE_314.Name = "DIA_SEMANA_GRADE_314";
            this.DIA_SEMANA_GRADE_314.ReadOnly = true;
            this.DIA_SEMANA_GRADE_314.Visible = false;
            // 
            // CODIGO_DISCIPLINA_314
            // 
            this.CODIGO_DISCIPLINA_314.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_314.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_314.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_314.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_314.Name = "CODIGO_DISCIPLINA_314";
            this.CODIGO_DISCIPLINA_314.ReadOnly = true;
            this.CODIGO_DISCIPLINA_314.Width = 20;
            // 
            // CODIGO_TURMA_314
            // 
            this.CODIGO_TURMA_314.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_314.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_314.HeaderText = "Turma";
            this.CODIGO_TURMA_314.MinimumWidth = 20;
            this.CODIGO_TURMA_314.Name = "CODIGO_TURMA_314";
            this.CODIGO_TURMA_314.ReadOnly = true;
            // 
            // CODIGO_ESPACO_314
            // 
            this.CODIGO_ESPACO_314.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_314.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_314.HeaderText = "Sala";
            this.CODIGO_ESPACO_314.MinimumWidth = 20;
            this.CODIGO_ESPACO_314.Name = "CODIGO_ESPACO_314";
            this.CODIGO_ESPACO_314.ReadOnly = true;
            this.CODIGO_ESPACO_314.Width = 20;
            // 
            // CODIGO_PROFESSOR1_314
            // 
            this.CODIGO_PROFESSOR1_314.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_314.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_314.Name = "CODIGO_PROFESSOR1_314";
            this.CODIGO_PROFESSOR1_314.ReadOnly = true;
            this.CODIGO_PROFESSOR1_314.Visible = false;
            // 
            // CODIGO_PROFESSOR2_314
            // 
            this.CODIGO_PROFESSOR2_314.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_314.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_314.Name = "CODIGO_PROFESSOR2_314";
            this.CODIGO_PROFESSOR2_314.ReadOnly = true;
            this.CODIGO_PROFESSOR2_314.Visible = false;
            // 
            // CODIGO_PROFESSOR3_314
            // 
            this.CODIGO_PROFESSOR3_314.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_314.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_314.Name = "CODIGO_PROFESSOR3_314";
            this.CODIGO_PROFESSOR3_314.ReadOnly = true;
            this.CODIGO_PROFESSOR3_314.Visible = false;
            // 
            // grade41
            // 
            this.grade41.AllowUserToAddRows = false;
            this.grade41.AllowUserToDeleteRows = false;
            this.grade41.AllowUserToResizeColumns = false;
            this.grade41.AllowUserToResizeRows = false;
            this.grade41.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade41.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade41.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade41.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade41.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade41.ColumnHeadersVisible = false;
            this.grade41.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_41,
            this.DIA_SEMANA_GRADE_41,
            this.CODIGO_DISCIPLINA_41,
            this.CODIGO_TURMA_41,
            this.CODIGO_ESPACO_41,
            this.CODIGO_PROFESSOR1_41,
            this.CODIGO_PROFESSOR2_41,
            this.CODIGO_PROFESSOR3_41});
            this.grade41.ContextMenuStrip = this.menuContexto;
            this.grade41.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade41.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade41.Location = new System.Drawing.Point(382, 30);
            this.grade41.MultiSelect = false;
            this.grade41.Name = "grade41";
            this.grade41.ReadOnly = true;
            this.grade41.RowHeadersVisible = false;
            this.grade41.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade41.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade41.Size = new System.Drawing.Size(89, 27);
            this.grade41.TabIndex = 150;
            this.grade41.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade41.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade41.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_41
            // 
            this.HORARIO_GRADE_41.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_41.HeaderText = "HORARIO_GRADE_41";
            this.HORARIO_GRADE_41.Name = "HORARIO_GRADE_41";
            this.HORARIO_GRADE_41.ReadOnly = true;
            this.HORARIO_GRADE_41.Visible = false;
            // 
            // DIA_SEMANA_GRADE_41
            // 
            this.DIA_SEMANA_GRADE_41.HeaderText = "DIA_SEMANA_GRADE_41";
            this.DIA_SEMANA_GRADE_41.Name = "DIA_SEMANA_GRADE_41";
            this.DIA_SEMANA_GRADE_41.ReadOnly = true;
            this.DIA_SEMANA_GRADE_41.Visible = false;
            // 
            // CODIGO_DISCIPLINA_41
            // 
            this.CODIGO_DISCIPLINA_41.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_41.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_41.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_41.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_41.Name = "CODIGO_DISCIPLINA_41";
            this.CODIGO_DISCIPLINA_41.ReadOnly = true;
            this.CODIGO_DISCIPLINA_41.Width = 20;
            // 
            // CODIGO_TURMA_41
            // 
            this.CODIGO_TURMA_41.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_41.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_41.HeaderText = "Turma";
            this.CODIGO_TURMA_41.MinimumWidth = 20;
            this.CODIGO_TURMA_41.Name = "CODIGO_TURMA_41";
            this.CODIGO_TURMA_41.ReadOnly = true;
            // 
            // CODIGO_ESPACO_41
            // 
            this.CODIGO_ESPACO_41.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_41.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_41.HeaderText = "Sala";
            this.CODIGO_ESPACO_41.MinimumWidth = 20;
            this.CODIGO_ESPACO_41.Name = "CODIGO_ESPACO_41";
            this.CODIGO_ESPACO_41.ReadOnly = true;
            this.CODIGO_ESPACO_41.Width = 20;
            // 
            // CODIGO_PROFESSOR1_41
            // 
            this.CODIGO_PROFESSOR1_41.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_41.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_41.Name = "CODIGO_PROFESSOR1_41";
            this.CODIGO_PROFESSOR1_41.ReadOnly = true;
            this.CODIGO_PROFESSOR1_41.Visible = false;
            // 
            // CODIGO_PROFESSOR2_41
            // 
            this.CODIGO_PROFESSOR2_41.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_41.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_41.Name = "CODIGO_PROFESSOR2_41";
            this.CODIGO_PROFESSOR2_41.ReadOnly = true;
            this.CODIGO_PROFESSOR2_41.Visible = false;
            // 
            // CODIGO_PROFESSOR3_41
            // 
            this.CODIGO_PROFESSOR3_41.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_41.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_41.Name = "CODIGO_PROFESSOR3_41";
            this.CODIGO_PROFESSOR3_41.ReadOnly = true;
            this.CODIGO_PROFESSOR3_41.Visible = false;
            // 
            // grade42
            // 
            this.grade42.AllowUserToAddRows = false;
            this.grade42.AllowUserToDeleteRows = false;
            this.grade42.AllowUserToResizeColumns = false;
            this.grade42.AllowUserToResizeRows = false;
            this.grade42.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade42.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade42.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade42.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade42.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade42.ColumnHeadersVisible = false;
            this.grade42.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_42,
            this.DIA_SEMANA_GRADE_42,
            this.CODIGO_DISCIPLINA_42,
            this.CODIGO_TURMA_42,
            this.CODIGO_ESPACO_42,
            this.CODIGO_PROFESSOR1_42,
            this.CODIGO_PROFESSOR2_42,
            this.CODIGO_PROFESSOR3_42});
            this.grade42.ContextMenuStrip = this.menuContexto;
            this.grade42.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade42.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade42.Location = new System.Drawing.Point(382, 64);
            this.grade42.MultiSelect = false;
            this.grade42.Name = "grade42";
            this.grade42.ReadOnly = true;
            this.grade42.RowHeadersVisible = false;
            this.grade42.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade42.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade42.Size = new System.Drawing.Size(89, 27);
            this.grade42.TabIndex = 150;
            this.grade42.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade42.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade42.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_42
            // 
            this.HORARIO_GRADE_42.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_42.HeaderText = "HORARIO_GRADE_42";
            this.HORARIO_GRADE_42.Name = "HORARIO_GRADE_42";
            this.HORARIO_GRADE_42.ReadOnly = true;
            this.HORARIO_GRADE_42.Visible = false;
            // 
            // DIA_SEMANA_GRADE_42
            // 
            this.DIA_SEMANA_GRADE_42.HeaderText = "DIA_SEMANA_GRADE_42";
            this.DIA_SEMANA_GRADE_42.Name = "DIA_SEMANA_GRADE_42";
            this.DIA_SEMANA_GRADE_42.ReadOnly = true;
            this.DIA_SEMANA_GRADE_42.Visible = false;
            // 
            // CODIGO_DISCIPLINA_42
            // 
            this.CODIGO_DISCIPLINA_42.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_42.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_42.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_42.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_42.Name = "CODIGO_DISCIPLINA_42";
            this.CODIGO_DISCIPLINA_42.ReadOnly = true;
            this.CODIGO_DISCIPLINA_42.Width = 20;
            // 
            // CODIGO_TURMA_42
            // 
            this.CODIGO_TURMA_42.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_42.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_42.HeaderText = "Turma";
            this.CODIGO_TURMA_42.MinimumWidth = 20;
            this.CODIGO_TURMA_42.Name = "CODIGO_TURMA_42";
            this.CODIGO_TURMA_42.ReadOnly = true;
            // 
            // CODIGO_ESPACO_42
            // 
            this.CODIGO_ESPACO_42.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_42.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_42.HeaderText = "Sala";
            this.CODIGO_ESPACO_42.MinimumWidth = 20;
            this.CODIGO_ESPACO_42.Name = "CODIGO_ESPACO_42";
            this.CODIGO_ESPACO_42.ReadOnly = true;
            this.CODIGO_ESPACO_42.Width = 20;
            // 
            // CODIGO_PROFESSOR1_42
            // 
            this.CODIGO_PROFESSOR1_42.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_42.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_42.Name = "CODIGO_PROFESSOR1_42";
            this.CODIGO_PROFESSOR1_42.ReadOnly = true;
            this.CODIGO_PROFESSOR1_42.Visible = false;
            // 
            // CODIGO_PROFESSOR2_42
            // 
            this.CODIGO_PROFESSOR2_42.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_42.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_42.Name = "CODIGO_PROFESSOR2_42";
            this.CODIGO_PROFESSOR2_42.ReadOnly = true;
            this.CODIGO_PROFESSOR2_42.Visible = false;
            // 
            // CODIGO_PROFESSOR3_42
            // 
            this.CODIGO_PROFESSOR3_42.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_42.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_42.Name = "CODIGO_PROFESSOR3_42";
            this.CODIGO_PROFESSOR3_42.ReadOnly = true;
            this.CODIGO_PROFESSOR3_42.Visible = false;
            // 
            // grade43
            // 
            this.grade43.AllowUserToAddRows = false;
            this.grade43.AllowUserToDeleteRows = false;
            this.grade43.AllowUserToResizeColumns = false;
            this.grade43.AllowUserToResizeRows = false;
            this.grade43.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade43.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade43.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade43.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade43.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade43.ColumnHeadersVisible = false;
            this.grade43.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_43,
            this.DIA_SEMANA_GRADE_43,
            this.CODIGO_DISCIPLINA_43,
            this.CODIGO_TURMA_43,
            this.CODIGO_ESPACO_43,
            this.CODIGO_PROFESSOR1_43,
            this.CODIGO_PROFESSOR2_43,
            this.CODIGO_PROFESSOR3_43});
            this.grade43.ContextMenuStrip = this.menuContexto;
            this.grade43.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade43.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade43.Location = new System.Drawing.Point(382, 98);
            this.grade43.MultiSelect = false;
            this.grade43.Name = "grade43";
            this.grade43.ReadOnly = true;
            this.grade43.RowHeadersVisible = false;
            this.grade43.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade43.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade43.Size = new System.Drawing.Size(89, 27);
            this.grade43.TabIndex = 150;
            this.grade43.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade43.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade43.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_43
            // 
            this.HORARIO_GRADE_43.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_43.HeaderText = "HORARIO_GRADE_43";
            this.HORARIO_GRADE_43.Name = "HORARIO_GRADE_43";
            this.HORARIO_GRADE_43.ReadOnly = true;
            this.HORARIO_GRADE_43.Visible = false;
            // 
            // DIA_SEMANA_GRADE_43
            // 
            this.DIA_SEMANA_GRADE_43.HeaderText = "DIA_SEMANA_GRADE_43";
            this.DIA_SEMANA_GRADE_43.Name = "DIA_SEMANA_GRADE_43";
            this.DIA_SEMANA_GRADE_43.ReadOnly = true;
            this.DIA_SEMANA_GRADE_43.Visible = false;
            // 
            // CODIGO_DISCIPLINA_43
            // 
            this.CODIGO_DISCIPLINA_43.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_43.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_43.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_43.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_43.Name = "CODIGO_DISCIPLINA_43";
            this.CODIGO_DISCIPLINA_43.ReadOnly = true;
            this.CODIGO_DISCIPLINA_43.Width = 20;
            // 
            // CODIGO_TURMA_43
            // 
            this.CODIGO_TURMA_43.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_43.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_43.HeaderText = "Turma";
            this.CODIGO_TURMA_43.MinimumWidth = 20;
            this.CODIGO_TURMA_43.Name = "CODIGO_TURMA_43";
            this.CODIGO_TURMA_43.ReadOnly = true;
            // 
            // CODIGO_ESPACO_43
            // 
            this.CODIGO_ESPACO_43.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_43.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_43.HeaderText = "Sala";
            this.CODIGO_ESPACO_43.MinimumWidth = 20;
            this.CODIGO_ESPACO_43.Name = "CODIGO_ESPACO_43";
            this.CODIGO_ESPACO_43.ReadOnly = true;
            this.CODIGO_ESPACO_43.Width = 20;
            // 
            // CODIGO_PROFESSOR1_43
            // 
            this.CODIGO_PROFESSOR1_43.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_43.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_43.Name = "CODIGO_PROFESSOR1_43";
            this.CODIGO_PROFESSOR1_43.ReadOnly = true;
            this.CODIGO_PROFESSOR1_43.Visible = false;
            // 
            // CODIGO_PROFESSOR2_43
            // 
            this.CODIGO_PROFESSOR2_43.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_43.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_43.Name = "CODIGO_PROFESSOR2_43";
            this.CODIGO_PROFESSOR2_43.ReadOnly = true;
            this.CODIGO_PROFESSOR2_43.Visible = false;
            // 
            // CODIGO_PROFESSOR3_43
            // 
            this.CODIGO_PROFESSOR3_43.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_43.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_43.Name = "CODIGO_PROFESSOR3_43";
            this.CODIGO_PROFESSOR3_43.ReadOnly = true;
            this.CODIGO_PROFESSOR3_43.Visible = false;
            // 
            // grade44
            // 
            this.grade44.AllowUserToAddRows = false;
            this.grade44.AllowUserToDeleteRows = false;
            this.grade44.AllowUserToResizeColumns = false;
            this.grade44.AllowUserToResizeRows = false;
            this.grade44.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade44.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade44.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade44.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade44.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade44.ColumnHeadersVisible = false;
            this.grade44.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_44,
            this.DIA_SEMANA_GRADE_44,
            this.CODIGO_DISCIPLINA_44,
            this.CODIGO_TURMA_44,
            this.CODIGO_ESPACO_44,
            this.CODIGO_PROFESSOR1_44,
            this.CODIGO_PROFESSOR2_44,
            this.CODIGO_PROFESSOR3_44});
            this.grade44.ContextMenuStrip = this.menuContexto;
            this.grade44.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade44.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade44.Location = new System.Drawing.Point(382, 132);
            this.grade44.MultiSelect = false;
            this.grade44.Name = "grade44";
            this.grade44.ReadOnly = true;
            this.grade44.RowHeadersVisible = false;
            this.grade44.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade44.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade44.Size = new System.Drawing.Size(89, 27);
            this.grade44.TabIndex = 150;
            this.grade44.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade44.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade44.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_44
            // 
            this.HORARIO_GRADE_44.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_44.HeaderText = "HORARIO_GRADE_44";
            this.HORARIO_GRADE_44.Name = "HORARIO_GRADE_44";
            this.HORARIO_GRADE_44.ReadOnly = true;
            this.HORARIO_GRADE_44.Visible = false;
            // 
            // DIA_SEMANA_GRADE_44
            // 
            this.DIA_SEMANA_GRADE_44.HeaderText = "DIA_SEMANA_GRADE_44";
            this.DIA_SEMANA_GRADE_44.Name = "DIA_SEMANA_GRADE_44";
            this.DIA_SEMANA_GRADE_44.ReadOnly = true;
            this.DIA_SEMANA_GRADE_44.Visible = false;
            // 
            // CODIGO_DISCIPLINA_44
            // 
            this.CODIGO_DISCIPLINA_44.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_44.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_44.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_44.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_44.Name = "CODIGO_DISCIPLINA_44";
            this.CODIGO_DISCIPLINA_44.ReadOnly = true;
            this.CODIGO_DISCIPLINA_44.Width = 20;
            // 
            // CODIGO_TURMA_44
            // 
            this.CODIGO_TURMA_44.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_44.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_44.HeaderText = "Turma";
            this.CODIGO_TURMA_44.MinimumWidth = 20;
            this.CODIGO_TURMA_44.Name = "CODIGO_TURMA_44";
            this.CODIGO_TURMA_44.ReadOnly = true;
            // 
            // CODIGO_ESPACO_44
            // 
            this.CODIGO_ESPACO_44.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_44.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_44.HeaderText = "Sala";
            this.CODIGO_ESPACO_44.MinimumWidth = 20;
            this.CODIGO_ESPACO_44.Name = "CODIGO_ESPACO_44";
            this.CODIGO_ESPACO_44.ReadOnly = true;
            this.CODIGO_ESPACO_44.Width = 20;
            // 
            // CODIGO_PROFESSOR1_44
            // 
            this.CODIGO_PROFESSOR1_44.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_44.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_44.Name = "CODIGO_PROFESSOR1_44";
            this.CODIGO_PROFESSOR1_44.ReadOnly = true;
            this.CODIGO_PROFESSOR1_44.Visible = false;
            // 
            // CODIGO_PROFESSOR2_44
            // 
            this.CODIGO_PROFESSOR2_44.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_44.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_44.Name = "CODIGO_PROFESSOR2_44";
            this.CODIGO_PROFESSOR2_44.ReadOnly = true;
            this.CODIGO_PROFESSOR2_44.Visible = false;
            // 
            // CODIGO_PROFESSOR3_44
            // 
            this.CODIGO_PROFESSOR3_44.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_44.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_44.Name = "CODIGO_PROFESSOR3_44";
            this.CODIGO_PROFESSOR3_44.ReadOnly = true;
            this.CODIGO_PROFESSOR3_44.Visible = false;
            // 
            // grade45
            // 
            this.grade45.AllowUserToAddRows = false;
            this.grade45.AllowUserToDeleteRows = false;
            this.grade45.AllowUserToResizeColumns = false;
            this.grade45.AllowUserToResizeRows = false;
            this.grade45.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade45.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade45.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade45.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade45.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade45.ColumnHeadersVisible = false;
            this.grade45.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_45,
            this.DIA_SEMANA_GRADE_45,
            this.CODIGO_DISCIPLINA_45,
            this.CODIGO_TURMA_45,
            this.CODIGO_ESPACO_45,
            this.CODIGO_PROFESSOR1_45,
            this.CODIGO_PROFESSOR2_45,
            this.CODIGO_PROFESSOR3_45});
            this.grade45.ContextMenuStrip = this.menuContexto;
            this.grade45.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade45.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade45.Location = new System.Drawing.Point(382, 166);
            this.grade45.MultiSelect = false;
            this.grade45.Name = "grade45";
            this.grade45.ReadOnly = true;
            this.grade45.RowHeadersVisible = false;
            this.grade45.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade45.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade45.Size = new System.Drawing.Size(89, 27);
            this.grade45.TabIndex = 150;
            this.grade45.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade45.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade45.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_45
            // 
            this.HORARIO_GRADE_45.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_45.HeaderText = "HORARIO_GRADE_45";
            this.HORARIO_GRADE_45.Name = "HORARIO_GRADE_45";
            this.HORARIO_GRADE_45.ReadOnly = true;
            this.HORARIO_GRADE_45.Visible = false;
            // 
            // DIA_SEMANA_GRADE_45
            // 
            this.DIA_SEMANA_GRADE_45.HeaderText = "DIA_SEMANA_GRADE_45";
            this.DIA_SEMANA_GRADE_45.Name = "DIA_SEMANA_GRADE_45";
            this.DIA_SEMANA_GRADE_45.ReadOnly = true;
            this.DIA_SEMANA_GRADE_45.Visible = false;
            // 
            // CODIGO_DISCIPLINA_45
            // 
            this.CODIGO_DISCIPLINA_45.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_45.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_45.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_45.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_45.Name = "CODIGO_DISCIPLINA_45";
            this.CODIGO_DISCIPLINA_45.ReadOnly = true;
            this.CODIGO_DISCIPLINA_45.Width = 20;
            // 
            // CODIGO_TURMA_45
            // 
            this.CODIGO_TURMA_45.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_45.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_45.HeaderText = "Turma";
            this.CODIGO_TURMA_45.MinimumWidth = 20;
            this.CODIGO_TURMA_45.Name = "CODIGO_TURMA_45";
            this.CODIGO_TURMA_45.ReadOnly = true;
            // 
            // CODIGO_ESPACO_45
            // 
            this.CODIGO_ESPACO_45.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_45.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_45.HeaderText = "Sala";
            this.CODIGO_ESPACO_45.MinimumWidth = 20;
            this.CODIGO_ESPACO_45.Name = "CODIGO_ESPACO_45";
            this.CODIGO_ESPACO_45.ReadOnly = true;
            this.CODIGO_ESPACO_45.Width = 20;
            // 
            // CODIGO_PROFESSOR1_45
            // 
            this.CODIGO_PROFESSOR1_45.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_45.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_45.Name = "CODIGO_PROFESSOR1_45";
            this.CODIGO_PROFESSOR1_45.ReadOnly = true;
            this.CODIGO_PROFESSOR1_45.Visible = false;
            // 
            // CODIGO_PROFESSOR2_45
            // 
            this.CODIGO_PROFESSOR2_45.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_45.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_45.Name = "CODIGO_PROFESSOR2_45";
            this.CODIGO_PROFESSOR2_45.ReadOnly = true;
            this.CODIGO_PROFESSOR2_45.Visible = false;
            // 
            // CODIGO_PROFESSOR3_45
            // 
            this.CODIGO_PROFESSOR3_45.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_45.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_45.Name = "CODIGO_PROFESSOR3_45";
            this.CODIGO_PROFESSOR3_45.ReadOnly = true;
            this.CODIGO_PROFESSOR3_45.Visible = false;
            // 
            // grade46
            // 
            this.grade46.AllowUserToAddRows = false;
            this.grade46.AllowUserToDeleteRows = false;
            this.grade46.AllowUserToResizeColumns = false;
            this.grade46.AllowUserToResizeRows = false;
            this.grade46.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade46.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade46.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade46.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade46.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade46.ColumnHeadersVisible = false;
            this.grade46.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_46,
            this.DIA_SEMANA_GRADE_46,
            this.CODIGO_DISCIPLINA_46,
            this.CODIGO_TURMA_46,
            this.CODIGO_ESPACO_46,
            this.CODIGO_PROFESSOR1_46,
            this.CODIGO_PROFESSOR2_46,
            this.CODIGO_PROFESSOR3_46});
            this.grade46.ContextMenuStrip = this.menuContexto;
            this.grade46.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade46.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade46.Location = new System.Drawing.Point(382, 200);
            this.grade46.MultiSelect = false;
            this.grade46.Name = "grade46";
            this.grade46.ReadOnly = true;
            this.grade46.RowHeadersVisible = false;
            this.grade46.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade46.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade46.Size = new System.Drawing.Size(89, 27);
            this.grade46.TabIndex = 150;
            this.grade46.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade46.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade46.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_46
            // 
            this.HORARIO_GRADE_46.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_46.HeaderText = "HORARIO_GRADE_46";
            this.HORARIO_GRADE_46.Name = "HORARIO_GRADE_46";
            this.HORARIO_GRADE_46.ReadOnly = true;
            this.HORARIO_GRADE_46.Visible = false;
            // 
            // DIA_SEMANA_GRADE_46
            // 
            this.DIA_SEMANA_GRADE_46.HeaderText = "DIA_SEMANA_GRADE_46";
            this.DIA_SEMANA_GRADE_46.Name = "DIA_SEMANA_GRADE_46";
            this.DIA_SEMANA_GRADE_46.ReadOnly = true;
            this.DIA_SEMANA_GRADE_46.Visible = false;
            // 
            // CODIGO_DISCIPLINA_46
            // 
            this.CODIGO_DISCIPLINA_46.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_46.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_46.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_46.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_46.Name = "CODIGO_DISCIPLINA_46";
            this.CODIGO_DISCIPLINA_46.ReadOnly = true;
            this.CODIGO_DISCIPLINA_46.Width = 20;
            // 
            // CODIGO_TURMA_46
            // 
            this.CODIGO_TURMA_46.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_46.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_46.HeaderText = "Turma";
            this.CODIGO_TURMA_46.MinimumWidth = 20;
            this.CODIGO_TURMA_46.Name = "CODIGO_TURMA_46";
            this.CODIGO_TURMA_46.ReadOnly = true;
            // 
            // CODIGO_ESPACO_46
            // 
            this.CODIGO_ESPACO_46.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_46.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_46.HeaderText = "Sala";
            this.CODIGO_ESPACO_46.MinimumWidth = 20;
            this.CODIGO_ESPACO_46.Name = "CODIGO_ESPACO_46";
            this.CODIGO_ESPACO_46.ReadOnly = true;
            this.CODIGO_ESPACO_46.Width = 20;
            // 
            // CODIGO_PROFESSOR1_46
            // 
            this.CODIGO_PROFESSOR1_46.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_46.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_46.Name = "CODIGO_PROFESSOR1_46";
            this.CODIGO_PROFESSOR1_46.ReadOnly = true;
            this.CODIGO_PROFESSOR1_46.Visible = false;
            // 
            // CODIGO_PROFESSOR2_46
            // 
            this.CODIGO_PROFESSOR2_46.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_46.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_46.Name = "CODIGO_PROFESSOR2_46";
            this.CODIGO_PROFESSOR2_46.ReadOnly = true;
            this.CODIGO_PROFESSOR2_46.Visible = false;
            // 
            // CODIGO_PROFESSOR3_46
            // 
            this.CODIGO_PROFESSOR3_46.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_46.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_46.Name = "CODIGO_PROFESSOR3_46";
            this.CODIGO_PROFESSOR3_46.ReadOnly = true;
            this.CODIGO_PROFESSOR3_46.Visible = false;
            // 
            // grade47
            // 
            this.grade47.AllowUserToAddRows = false;
            this.grade47.AllowUserToDeleteRows = false;
            this.grade47.AllowUserToResizeColumns = false;
            this.grade47.AllowUserToResizeRows = false;
            this.grade47.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade47.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade47.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade47.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade47.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade47.ColumnHeadersVisible = false;
            this.grade47.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_47,
            this.DIA_SEMANA_GRADE_47,
            this.CODIGO_DISCIPLINA_47,
            this.CODIGO_TURMA_47,
            this.CODIGO_ESPACO_47,
            this.CODIGO_PROFESSOR1_47,
            this.CODIGO_PROFESSOR2_47,
            this.CODIGO_PROFESSOR3_47});
            this.grade47.ContextMenuStrip = this.menuContexto;
            this.grade47.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade47.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade47.Location = new System.Drawing.Point(382, 234);
            this.grade47.MultiSelect = false;
            this.grade47.Name = "grade47";
            this.grade47.ReadOnly = true;
            this.grade47.RowHeadersVisible = false;
            this.grade47.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade47.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade47.Size = new System.Drawing.Size(89, 27);
            this.grade47.TabIndex = 150;
            this.grade47.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade47.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade47.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_47
            // 
            this.HORARIO_GRADE_47.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_47.HeaderText = "HORARIO_GRADE_47";
            this.HORARIO_GRADE_47.Name = "HORARIO_GRADE_47";
            this.HORARIO_GRADE_47.ReadOnly = true;
            this.HORARIO_GRADE_47.Visible = false;
            // 
            // DIA_SEMANA_GRADE_47
            // 
            this.DIA_SEMANA_GRADE_47.HeaderText = "DIA_SEMANA_GRADE_47";
            this.DIA_SEMANA_GRADE_47.Name = "DIA_SEMANA_GRADE_47";
            this.DIA_SEMANA_GRADE_47.ReadOnly = true;
            this.DIA_SEMANA_GRADE_47.Visible = false;
            // 
            // CODIGO_DISCIPLINA_47
            // 
            this.CODIGO_DISCIPLINA_47.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_47.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_47.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_47.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_47.Name = "CODIGO_DISCIPLINA_47";
            this.CODIGO_DISCIPLINA_47.ReadOnly = true;
            this.CODIGO_DISCIPLINA_47.Width = 20;
            // 
            // CODIGO_TURMA_47
            // 
            this.CODIGO_TURMA_47.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_47.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_47.HeaderText = "Turma";
            this.CODIGO_TURMA_47.MinimumWidth = 20;
            this.CODIGO_TURMA_47.Name = "CODIGO_TURMA_47";
            this.CODIGO_TURMA_47.ReadOnly = true;
            // 
            // CODIGO_ESPACO_47
            // 
            this.CODIGO_ESPACO_47.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_47.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_47.HeaderText = "Sala";
            this.CODIGO_ESPACO_47.MinimumWidth = 20;
            this.CODIGO_ESPACO_47.Name = "CODIGO_ESPACO_47";
            this.CODIGO_ESPACO_47.ReadOnly = true;
            this.CODIGO_ESPACO_47.Width = 20;
            // 
            // CODIGO_PROFESSOR1_47
            // 
            this.CODIGO_PROFESSOR1_47.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_47.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_47.Name = "CODIGO_PROFESSOR1_47";
            this.CODIGO_PROFESSOR1_47.ReadOnly = true;
            this.CODIGO_PROFESSOR1_47.Visible = false;
            // 
            // CODIGO_PROFESSOR2_47
            // 
            this.CODIGO_PROFESSOR2_47.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_47.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_47.Name = "CODIGO_PROFESSOR2_47";
            this.CODIGO_PROFESSOR2_47.ReadOnly = true;
            this.CODIGO_PROFESSOR2_47.Visible = false;
            // 
            // CODIGO_PROFESSOR3_47
            // 
            this.CODIGO_PROFESSOR3_47.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_47.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_47.Name = "CODIGO_PROFESSOR3_47";
            this.CODIGO_PROFESSOR3_47.ReadOnly = true;
            this.CODIGO_PROFESSOR3_47.Visible = false;
            // 
            // grade48
            // 
            this.grade48.AllowUserToAddRows = false;
            this.grade48.AllowUserToDeleteRows = false;
            this.grade48.AllowUserToResizeColumns = false;
            this.grade48.AllowUserToResizeRows = false;
            this.grade48.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade48.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade48.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade48.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade48.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade48.ColumnHeadersVisible = false;
            this.grade48.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_48,
            this.DIA_SEMANA_GRADE_48,
            this.CODIGO_DISCIPLINA_48,
            this.CODIGO_TURMA_48,
            this.CODIGO_ESPACO_48,
            this.CODIGO_PROFESSOR1_48,
            this.CODIGO_PROFESSOR2_48,
            this.CODIGO_PROFESSOR3_48});
            this.grade48.ContextMenuStrip = this.menuContexto;
            this.grade48.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade48.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade48.Location = new System.Drawing.Point(382, 268);
            this.grade48.MultiSelect = false;
            this.grade48.Name = "grade48";
            this.grade48.ReadOnly = true;
            this.grade48.RowHeadersVisible = false;
            this.grade48.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade48.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade48.Size = new System.Drawing.Size(89, 27);
            this.grade48.TabIndex = 150;
            this.grade48.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade48.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade48.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_48
            // 
            this.HORARIO_GRADE_48.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_48.HeaderText = "HORARIO_GRADE_48";
            this.HORARIO_GRADE_48.Name = "HORARIO_GRADE_48";
            this.HORARIO_GRADE_48.ReadOnly = true;
            this.HORARIO_GRADE_48.Visible = false;
            // 
            // DIA_SEMANA_GRADE_48
            // 
            this.DIA_SEMANA_GRADE_48.HeaderText = "DIA_SEMANA_GRADE_48";
            this.DIA_SEMANA_GRADE_48.Name = "DIA_SEMANA_GRADE_48";
            this.DIA_SEMANA_GRADE_48.ReadOnly = true;
            this.DIA_SEMANA_GRADE_48.Visible = false;
            // 
            // CODIGO_DISCIPLINA_48
            // 
            this.CODIGO_DISCIPLINA_48.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_48.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_48.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_48.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_48.Name = "CODIGO_DISCIPLINA_48";
            this.CODIGO_DISCIPLINA_48.ReadOnly = true;
            this.CODIGO_DISCIPLINA_48.Width = 20;
            // 
            // CODIGO_TURMA_48
            // 
            this.CODIGO_TURMA_48.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_48.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_48.HeaderText = "Turma";
            this.CODIGO_TURMA_48.MinimumWidth = 20;
            this.CODIGO_TURMA_48.Name = "CODIGO_TURMA_48";
            this.CODIGO_TURMA_48.ReadOnly = true;
            // 
            // CODIGO_ESPACO_48
            // 
            this.CODIGO_ESPACO_48.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_48.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_48.HeaderText = "Sala";
            this.CODIGO_ESPACO_48.MinimumWidth = 20;
            this.CODIGO_ESPACO_48.Name = "CODIGO_ESPACO_48";
            this.CODIGO_ESPACO_48.ReadOnly = true;
            this.CODIGO_ESPACO_48.Width = 20;
            // 
            // CODIGO_PROFESSOR1_48
            // 
            this.CODIGO_PROFESSOR1_48.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_48.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_48.Name = "CODIGO_PROFESSOR1_48";
            this.CODIGO_PROFESSOR1_48.ReadOnly = true;
            this.CODIGO_PROFESSOR1_48.Visible = false;
            // 
            // CODIGO_PROFESSOR2_48
            // 
            this.CODIGO_PROFESSOR2_48.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_48.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_48.Name = "CODIGO_PROFESSOR2_48";
            this.CODIGO_PROFESSOR2_48.ReadOnly = true;
            this.CODIGO_PROFESSOR2_48.Visible = false;
            // 
            // CODIGO_PROFESSOR3_48
            // 
            this.CODIGO_PROFESSOR3_48.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_48.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_48.Name = "CODIGO_PROFESSOR3_48";
            this.CODIGO_PROFESSOR3_48.ReadOnly = true;
            this.CODIGO_PROFESSOR3_48.Visible = false;
            // 
            // grade49
            // 
            this.grade49.AllowUserToAddRows = false;
            this.grade49.AllowUserToDeleteRows = false;
            this.grade49.AllowUserToResizeColumns = false;
            this.grade49.AllowUserToResizeRows = false;
            this.grade49.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade49.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade49.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade49.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade49.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade49.ColumnHeadersVisible = false;
            this.grade49.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_49,
            this.DIA_SEMANA_GRADE_49,
            this.CODIGO_DISCIPLINA_49,
            this.CODIGO_TURMA_49,
            this.CODIGO_ESPACO_49,
            this.CODIGO_PROFESSOR1_49,
            this.CODIGO_PROFESSOR2_49,
            this.CODIGO_PROFESSOR3_49});
            this.grade49.ContextMenuStrip = this.menuContexto;
            this.grade49.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade49.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade49.Location = new System.Drawing.Point(382, 302);
            this.grade49.MultiSelect = false;
            this.grade49.Name = "grade49";
            this.grade49.ReadOnly = true;
            this.grade49.RowHeadersVisible = false;
            this.grade49.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade49.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade49.Size = new System.Drawing.Size(89, 27);
            this.grade49.TabIndex = 150;
            this.grade49.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade49.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade49.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_49
            // 
            this.HORARIO_GRADE_49.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_49.HeaderText = "HORARIO_GRADE_49";
            this.HORARIO_GRADE_49.Name = "HORARIO_GRADE_49";
            this.HORARIO_GRADE_49.ReadOnly = true;
            this.HORARIO_GRADE_49.Visible = false;
            // 
            // DIA_SEMANA_GRADE_49
            // 
            this.DIA_SEMANA_GRADE_49.HeaderText = "DIA_SEMANA_GRADE_49";
            this.DIA_SEMANA_GRADE_49.Name = "DIA_SEMANA_GRADE_49";
            this.DIA_SEMANA_GRADE_49.ReadOnly = true;
            this.DIA_SEMANA_GRADE_49.Visible = false;
            // 
            // CODIGO_DISCIPLINA_49
            // 
            this.CODIGO_DISCIPLINA_49.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_49.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_49.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_49.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_49.Name = "CODIGO_DISCIPLINA_49";
            this.CODIGO_DISCIPLINA_49.ReadOnly = true;
            this.CODIGO_DISCIPLINA_49.Width = 20;
            // 
            // CODIGO_TURMA_49
            // 
            this.CODIGO_TURMA_49.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_49.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_49.HeaderText = "Turma";
            this.CODIGO_TURMA_49.MinimumWidth = 20;
            this.CODIGO_TURMA_49.Name = "CODIGO_TURMA_49";
            this.CODIGO_TURMA_49.ReadOnly = true;
            // 
            // CODIGO_ESPACO_49
            // 
            this.CODIGO_ESPACO_49.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_49.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_49.HeaderText = "Sala";
            this.CODIGO_ESPACO_49.MinimumWidth = 20;
            this.CODIGO_ESPACO_49.Name = "CODIGO_ESPACO_49";
            this.CODIGO_ESPACO_49.ReadOnly = true;
            this.CODIGO_ESPACO_49.Width = 20;
            // 
            // CODIGO_PROFESSOR1_49
            // 
            this.CODIGO_PROFESSOR1_49.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_49.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_49.Name = "CODIGO_PROFESSOR1_49";
            this.CODIGO_PROFESSOR1_49.ReadOnly = true;
            this.CODIGO_PROFESSOR1_49.Visible = false;
            // 
            // CODIGO_PROFESSOR2_49
            // 
            this.CODIGO_PROFESSOR2_49.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_49.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_49.Name = "CODIGO_PROFESSOR2_49";
            this.CODIGO_PROFESSOR2_49.ReadOnly = true;
            this.CODIGO_PROFESSOR2_49.Visible = false;
            // 
            // CODIGO_PROFESSOR3_49
            // 
            this.CODIGO_PROFESSOR3_49.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_49.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_49.Name = "CODIGO_PROFESSOR3_49";
            this.CODIGO_PROFESSOR3_49.ReadOnly = true;
            this.CODIGO_PROFESSOR3_49.Visible = false;
            // 
            // grade410
            // 
            this.grade410.AllowUserToAddRows = false;
            this.grade410.AllowUserToDeleteRows = false;
            this.grade410.AllowUserToResizeColumns = false;
            this.grade410.AllowUserToResizeRows = false;
            this.grade410.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade410.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade410.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade410.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade410.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade410.ColumnHeadersVisible = false;
            this.grade410.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_410,
            this.DIA_SEMANA_GRADE_410,
            this.CODIGO_DISCIPLINA_410,
            this.CODIGO_TURMA_410,
            this.CODIGO_ESPACO_410,
            this.CODIGO_PROFESSOR1_410,
            this.CODIGO_PROFESSOR2_410,
            this.CODIGO_PROFESSOR3_410});
            this.grade410.ContextMenuStrip = this.menuContexto;
            this.grade410.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade410.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade410.Location = new System.Drawing.Point(382, 336);
            this.grade410.MultiSelect = false;
            this.grade410.Name = "grade410";
            this.grade410.ReadOnly = true;
            this.grade410.RowHeadersVisible = false;
            this.grade410.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade410.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade410.Size = new System.Drawing.Size(89, 27);
            this.grade410.TabIndex = 150;
            this.grade410.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade410.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade410.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_410
            // 
            this.HORARIO_GRADE_410.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_410.HeaderText = "HORARIO_GRADE_410";
            this.HORARIO_GRADE_410.Name = "HORARIO_GRADE_410";
            this.HORARIO_GRADE_410.ReadOnly = true;
            this.HORARIO_GRADE_410.Visible = false;
            // 
            // DIA_SEMANA_GRADE_410
            // 
            this.DIA_SEMANA_GRADE_410.HeaderText = "DIA_SEMANA_GRADE_410";
            this.DIA_SEMANA_GRADE_410.Name = "DIA_SEMANA_GRADE_410";
            this.DIA_SEMANA_GRADE_410.ReadOnly = true;
            this.DIA_SEMANA_GRADE_410.Visible = false;
            // 
            // CODIGO_DISCIPLINA_410
            // 
            this.CODIGO_DISCIPLINA_410.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_410.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_410.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_410.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_410.Name = "CODIGO_DISCIPLINA_410";
            this.CODIGO_DISCIPLINA_410.ReadOnly = true;
            this.CODIGO_DISCIPLINA_410.Width = 20;
            // 
            // CODIGO_TURMA_410
            // 
            this.CODIGO_TURMA_410.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_410.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_410.HeaderText = "Turma";
            this.CODIGO_TURMA_410.MinimumWidth = 20;
            this.CODIGO_TURMA_410.Name = "CODIGO_TURMA_410";
            this.CODIGO_TURMA_410.ReadOnly = true;
            // 
            // CODIGO_ESPACO_410
            // 
            this.CODIGO_ESPACO_410.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_410.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_410.HeaderText = "Sala";
            this.CODIGO_ESPACO_410.MinimumWidth = 20;
            this.CODIGO_ESPACO_410.Name = "CODIGO_ESPACO_410";
            this.CODIGO_ESPACO_410.ReadOnly = true;
            this.CODIGO_ESPACO_410.Width = 20;
            // 
            // CODIGO_PROFESSOR1_410
            // 
            this.CODIGO_PROFESSOR1_410.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_410.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_410.Name = "CODIGO_PROFESSOR1_410";
            this.CODIGO_PROFESSOR1_410.ReadOnly = true;
            this.CODIGO_PROFESSOR1_410.Visible = false;
            // 
            // CODIGO_PROFESSOR2_410
            // 
            this.CODIGO_PROFESSOR2_410.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_410.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_410.Name = "CODIGO_PROFESSOR2_410";
            this.CODIGO_PROFESSOR2_410.ReadOnly = true;
            this.CODIGO_PROFESSOR2_410.Visible = false;
            // 
            // CODIGO_PROFESSOR3_410
            // 
            this.CODIGO_PROFESSOR3_410.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_410.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_410.Name = "CODIGO_PROFESSOR3_410";
            this.CODIGO_PROFESSOR3_410.ReadOnly = true;
            this.CODIGO_PROFESSOR3_410.Visible = false;
            // 
            // grade411
            // 
            this.grade411.AllowUserToAddRows = false;
            this.grade411.AllowUserToDeleteRows = false;
            this.grade411.AllowUserToResizeColumns = false;
            this.grade411.AllowUserToResizeRows = false;
            this.grade411.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade411.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade411.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade411.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade411.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade411.ColumnHeadersVisible = false;
            this.grade411.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_411,
            this.DIA_SEMANA_GRADE_411,
            this.CODIGO_DISCIPLINA_411,
            this.CODIGO_TURMA_411,
            this.CODIGO_ESPACO_411,
            this.CODIGO_PROFESSOR1_411,
            this.CODIGO_PROFESSOR2_411,
            this.CODIGO_PROFESSOR3_411});
            this.grade411.ContextMenuStrip = this.menuContexto;
            this.grade411.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade411.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade411.Location = new System.Drawing.Point(382, 370);
            this.grade411.MultiSelect = false;
            this.grade411.Name = "grade411";
            this.grade411.ReadOnly = true;
            this.grade411.RowHeadersVisible = false;
            this.grade411.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade411.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade411.Size = new System.Drawing.Size(89, 27);
            this.grade411.TabIndex = 150;
            this.grade411.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade411.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade411.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_411
            // 
            this.HORARIO_GRADE_411.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_411.HeaderText = "HORARIO_GRADE_411";
            this.HORARIO_GRADE_411.Name = "HORARIO_GRADE_411";
            this.HORARIO_GRADE_411.ReadOnly = true;
            this.HORARIO_GRADE_411.Visible = false;
            // 
            // DIA_SEMANA_GRADE_411
            // 
            this.DIA_SEMANA_GRADE_411.HeaderText = "DIA_SEMANA_GRADE_411";
            this.DIA_SEMANA_GRADE_411.Name = "DIA_SEMANA_GRADE_411";
            this.DIA_SEMANA_GRADE_411.ReadOnly = true;
            this.DIA_SEMANA_GRADE_411.Visible = false;
            // 
            // CODIGO_DISCIPLINA_411
            // 
            this.CODIGO_DISCIPLINA_411.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_411.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_411.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_411.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_411.Name = "CODIGO_DISCIPLINA_411";
            this.CODIGO_DISCIPLINA_411.ReadOnly = true;
            this.CODIGO_DISCIPLINA_411.Width = 20;
            // 
            // CODIGO_TURMA_411
            // 
            this.CODIGO_TURMA_411.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_411.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_411.HeaderText = "Turma";
            this.CODIGO_TURMA_411.MinimumWidth = 20;
            this.CODIGO_TURMA_411.Name = "CODIGO_TURMA_411";
            this.CODIGO_TURMA_411.ReadOnly = true;
            // 
            // CODIGO_ESPACO_411
            // 
            this.CODIGO_ESPACO_411.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_411.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_411.HeaderText = "Sala";
            this.CODIGO_ESPACO_411.MinimumWidth = 20;
            this.CODIGO_ESPACO_411.Name = "CODIGO_ESPACO_411";
            this.CODIGO_ESPACO_411.ReadOnly = true;
            this.CODIGO_ESPACO_411.Width = 20;
            // 
            // CODIGO_PROFESSOR1_411
            // 
            this.CODIGO_PROFESSOR1_411.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_411.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_411.Name = "CODIGO_PROFESSOR1_411";
            this.CODIGO_PROFESSOR1_411.ReadOnly = true;
            this.CODIGO_PROFESSOR1_411.Visible = false;
            // 
            // CODIGO_PROFESSOR2_411
            // 
            this.CODIGO_PROFESSOR2_411.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_411.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_411.Name = "CODIGO_PROFESSOR2_411";
            this.CODIGO_PROFESSOR2_411.ReadOnly = true;
            this.CODIGO_PROFESSOR2_411.Visible = false;
            // 
            // CODIGO_PROFESSOR3_411
            // 
            this.CODIGO_PROFESSOR3_411.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_411.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_411.Name = "CODIGO_PROFESSOR3_411";
            this.CODIGO_PROFESSOR3_411.ReadOnly = true;
            this.CODIGO_PROFESSOR3_411.Visible = false;
            // 
            // grade412
            // 
            this.grade412.AllowUserToAddRows = false;
            this.grade412.AllowUserToDeleteRows = false;
            this.grade412.AllowUserToResizeColumns = false;
            this.grade412.AllowUserToResizeRows = false;
            this.grade412.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade412.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade412.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade412.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade412.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade412.ColumnHeadersVisible = false;
            this.grade412.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_412,
            this.DIA_SEMANA_GRADE_412,
            this.CODIGO_DISCIPLINA_412,
            this.CODIGO_TURMA_412,
            this.CODIGO_ESPACO_412,
            this.CODIGO_PROFESSOR1_412,
            this.CODIGO_PROFESSOR2_412,
            this.CODIGO_PROFESSOR3_412});
            this.grade412.ContextMenuStrip = this.menuContexto;
            this.grade412.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade412.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade412.Location = new System.Drawing.Point(382, 404);
            this.grade412.MultiSelect = false;
            this.grade412.Name = "grade412";
            this.grade412.ReadOnly = true;
            this.grade412.RowHeadersVisible = false;
            this.grade412.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade412.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade412.Size = new System.Drawing.Size(89, 27);
            this.grade412.TabIndex = 150;
            this.grade412.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade412.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade412.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_412
            // 
            this.HORARIO_GRADE_412.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_412.HeaderText = "HORARIO_GRADE_412";
            this.HORARIO_GRADE_412.Name = "HORARIO_GRADE_412";
            this.HORARIO_GRADE_412.ReadOnly = true;
            this.HORARIO_GRADE_412.Visible = false;
            // 
            // DIA_SEMANA_GRADE_412
            // 
            this.DIA_SEMANA_GRADE_412.HeaderText = "DIA_SEMANA_GRADE_412";
            this.DIA_SEMANA_GRADE_412.Name = "DIA_SEMANA_GRADE_412";
            this.DIA_SEMANA_GRADE_412.ReadOnly = true;
            this.DIA_SEMANA_GRADE_412.Visible = false;
            // 
            // CODIGO_DISCIPLINA_412
            // 
            this.CODIGO_DISCIPLINA_412.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_412.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_412.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_412.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_412.Name = "CODIGO_DISCIPLINA_412";
            this.CODIGO_DISCIPLINA_412.ReadOnly = true;
            this.CODIGO_DISCIPLINA_412.Width = 20;
            // 
            // CODIGO_TURMA_412
            // 
            this.CODIGO_TURMA_412.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_412.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_412.HeaderText = "Turma";
            this.CODIGO_TURMA_412.MinimumWidth = 20;
            this.CODIGO_TURMA_412.Name = "CODIGO_TURMA_412";
            this.CODIGO_TURMA_412.ReadOnly = true;
            // 
            // CODIGO_ESPACO_412
            // 
            this.CODIGO_ESPACO_412.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_412.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_412.HeaderText = "Sala";
            this.CODIGO_ESPACO_412.MinimumWidth = 20;
            this.CODIGO_ESPACO_412.Name = "CODIGO_ESPACO_412";
            this.CODIGO_ESPACO_412.ReadOnly = true;
            this.CODIGO_ESPACO_412.Width = 20;
            // 
            // CODIGO_PROFESSOR1_412
            // 
            this.CODIGO_PROFESSOR1_412.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_412.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_412.Name = "CODIGO_PROFESSOR1_412";
            this.CODIGO_PROFESSOR1_412.ReadOnly = true;
            this.CODIGO_PROFESSOR1_412.Visible = false;
            // 
            // CODIGO_PROFESSOR2_412
            // 
            this.CODIGO_PROFESSOR2_412.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_412.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_412.Name = "CODIGO_PROFESSOR2_412";
            this.CODIGO_PROFESSOR2_412.ReadOnly = true;
            this.CODIGO_PROFESSOR2_412.Visible = false;
            // 
            // CODIGO_PROFESSOR3_412
            // 
            this.CODIGO_PROFESSOR3_412.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_412.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_412.Name = "CODIGO_PROFESSOR3_412";
            this.CODIGO_PROFESSOR3_412.ReadOnly = true;
            this.CODIGO_PROFESSOR3_412.Visible = false;
            // 
            // grade413
            // 
            this.grade413.AllowUserToAddRows = false;
            this.grade413.AllowUserToDeleteRows = false;
            this.grade413.AllowUserToResizeColumns = false;
            this.grade413.AllowUserToResizeRows = false;
            this.grade413.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade413.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade413.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade413.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade413.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade413.ColumnHeadersVisible = false;
            this.grade413.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_413,
            this.DIA_SEMANA_GRADE_413,
            this.CODIGO_DISCIPLINA_413,
            this.CODIGO_TURMA_413,
            this.CODIGO_ESPACO_413,
            this.CODIGO_PROFESSOR1_413,
            this.CODIGO_PROFESSOR2_413,
            this.CODIGO_PROFESSOR3_413});
            this.grade413.ContextMenuStrip = this.menuContexto;
            this.grade413.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade413.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade413.Location = new System.Drawing.Point(382, 438);
            this.grade413.MultiSelect = false;
            this.grade413.Name = "grade413";
            this.grade413.ReadOnly = true;
            this.grade413.RowHeadersVisible = false;
            this.grade413.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade413.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade413.Size = new System.Drawing.Size(89, 27);
            this.grade413.TabIndex = 150;
            this.grade413.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade413.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade413.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_413
            // 
            this.HORARIO_GRADE_413.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_413.HeaderText = "HORARIO_GRADE_413";
            this.HORARIO_GRADE_413.Name = "HORARIO_GRADE_413";
            this.HORARIO_GRADE_413.ReadOnly = true;
            this.HORARIO_GRADE_413.Visible = false;
            // 
            // DIA_SEMANA_GRADE_413
            // 
            this.DIA_SEMANA_GRADE_413.HeaderText = "DIA_SEMANA_GRADE_413";
            this.DIA_SEMANA_GRADE_413.Name = "DIA_SEMANA_GRADE_413";
            this.DIA_SEMANA_GRADE_413.ReadOnly = true;
            this.DIA_SEMANA_GRADE_413.Visible = false;
            // 
            // CODIGO_DISCIPLINA_413
            // 
            this.CODIGO_DISCIPLINA_413.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_413.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_413.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_413.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_413.Name = "CODIGO_DISCIPLINA_413";
            this.CODIGO_DISCIPLINA_413.ReadOnly = true;
            this.CODIGO_DISCIPLINA_413.Width = 20;
            // 
            // CODIGO_TURMA_413
            // 
            this.CODIGO_TURMA_413.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_413.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_413.HeaderText = "Turma";
            this.CODIGO_TURMA_413.MinimumWidth = 20;
            this.CODIGO_TURMA_413.Name = "CODIGO_TURMA_413";
            this.CODIGO_TURMA_413.ReadOnly = true;
            // 
            // CODIGO_ESPACO_413
            // 
            this.CODIGO_ESPACO_413.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_413.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_413.HeaderText = "Sala";
            this.CODIGO_ESPACO_413.MinimumWidth = 20;
            this.CODIGO_ESPACO_413.Name = "CODIGO_ESPACO_413";
            this.CODIGO_ESPACO_413.ReadOnly = true;
            this.CODIGO_ESPACO_413.Width = 20;
            // 
            // CODIGO_PROFESSOR1_413
            // 
            this.CODIGO_PROFESSOR1_413.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_413.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_413.Name = "CODIGO_PROFESSOR1_413";
            this.CODIGO_PROFESSOR1_413.ReadOnly = true;
            this.CODIGO_PROFESSOR1_413.Visible = false;
            // 
            // CODIGO_PROFESSOR2_413
            // 
            this.CODIGO_PROFESSOR2_413.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_413.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_413.Name = "CODIGO_PROFESSOR2_413";
            this.CODIGO_PROFESSOR2_413.ReadOnly = true;
            this.CODIGO_PROFESSOR2_413.Visible = false;
            // 
            // CODIGO_PROFESSOR3_413
            // 
            this.CODIGO_PROFESSOR3_413.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_413.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_413.Name = "CODIGO_PROFESSOR3_413";
            this.CODIGO_PROFESSOR3_413.ReadOnly = true;
            this.CODIGO_PROFESSOR3_413.Visible = false;
            // 
            // grade414
            // 
            this.grade414.AllowUserToAddRows = false;
            this.grade414.AllowUserToDeleteRows = false;
            this.grade414.AllowUserToResizeColumns = false;
            this.grade414.AllowUserToResizeRows = false;
            this.grade414.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade414.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade414.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade414.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade414.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade414.ColumnHeadersVisible = false;
            this.grade414.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_414,
            this.DIA_SEMANA_GRADE_414,
            this.CODIGO_DISCIPLINA_414,
            this.CODIGO_TURMA_414,
            this.CODIGO_ESPACO_414,
            this.CODIGO_PROFESSOR1_414,
            this.CODIGO_PROFESSOR2_414,
            this.CODIGO_PROFESSOR3_414});
            this.grade414.ContextMenuStrip = this.menuContexto;
            this.grade414.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade414.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade414.Location = new System.Drawing.Point(382, 472);
            this.grade414.MultiSelect = false;
            this.grade414.Name = "grade414";
            this.grade414.ReadOnly = true;
            this.grade414.RowHeadersVisible = false;
            this.grade414.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade414.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade414.Size = new System.Drawing.Size(89, 28);
            this.grade414.TabIndex = 150;
            this.grade414.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade414.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade414.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_414
            // 
            this.HORARIO_GRADE_414.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_414.HeaderText = "HORARIO_GRADE_414";
            this.HORARIO_GRADE_414.Name = "HORARIO_GRADE_414";
            this.HORARIO_GRADE_414.ReadOnly = true;
            this.HORARIO_GRADE_414.Visible = false;
            // 
            // DIA_SEMANA_GRADE_414
            // 
            this.DIA_SEMANA_GRADE_414.HeaderText = "DIA_SEMANA_GRADE_414";
            this.DIA_SEMANA_GRADE_414.Name = "DIA_SEMANA_GRADE_414";
            this.DIA_SEMANA_GRADE_414.ReadOnly = true;
            this.DIA_SEMANA_GRADE_414.Visible = false;
            // 
            // CODIGO_DISCIPLINA_414
            // 
            this.CODIGO_DISCIPLINA_414.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_414.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_414.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_414.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_414.Name = "CODIGO_DISCIPLINA_414";
            this.CODIGO_DISCIPLINA_414.ReadOnly = true;
            this.CODIGO_DISCIPLINA_414.Width = 20;
            // 
            // CODIGO_TURMA_414
            // 
            this.CODIGO_TURMA_414.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_414.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_414.HeaderText = "Turma";
            this.CODIGO_TURMA_414.MinimumWidth = 20;
            this.CODIGO_TURMA_414.Name = "CODIGO_TURMA_414";
            this.CODIGO_TURMA_414.ReadOnly = true;
            // 
            // CODIGO_ESPACO_414
            // 
            this.CODIGO_ESPACO_414.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_414.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_414.HeaderText = "Sala";
            this.CODIGO_ESPACO_414.MinimumWidth = 20;
            this.CODIGO_ESPACO_414.Name = "CODIGO_ESPACO_414";
            this.CODIGO_ESPACO_414.ReadOnly = true;
            this.CODIGO_ESPACO_414.Width = 20;
            // 
            // CODIGO_PROFESSOR1_414
            // 
            this.CODIGO_PROFESSOR1_414.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_414.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_414.Name = "CODIGO_PROFESSOR1_414";
            this.CODIGO_PROFESSOR1_414.ReadOnly = true;
            this.CODIGO_PROFESSOR1_414.Visible = false;
            // 
            // CODIGO_PROFESSOR2_414
            // 
            this.CODIGO_PROFESSOR2_414.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_414.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_414.Name = "CODIGO_PROFESSOR2_414";
            this.CODIGO_PROFESSOR2_414.ReadOnly = true;
            this.CODIGO_PROFESSOR2_414.Visible = false;
            // 
            // CODIGO_PROFESSOR3_414
            // 
            this.CODIGO_PROFESSOR3_414.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_414.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_414.Name = "CODIGO_PROFESSOR3_414";
            this.CODIGO_PROFESSOR3_414.ReadOnly = true;
            this.CODIGO_PROFESSOR3_414.Visible = false;
            // 
            // grade51
            // 
            this.grade51.AllowUserToAddRows = false;
            this.grade51.AllowUserToDeleteRows = false;
            this.grade51.AllowUserToResizeColumns = false;
            this.grade51.AllowUserToResizeRows = false;
            this.grade51.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade51.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade51.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade51.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade51.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade51.ColumnHeadersVisible = false;
            this.grade51.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_51,
            this.DIA_SEMANA_GRADE_51,
            this.CODIGO_DISCIPLINA_51,
            this.CODIGO_TURMA_51,
            this.CODIGO_ESPACO_51,
            this.CODIGO_PROFESSOR1_51,
            this.CODIGO_PROFESSOR2_51,
            this.CODIGO_PROFESSOR3_51});
            this.grade51.ContextMenuStrip = this.menuContexto;
            this.grade51.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade51.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade51.Location = new System.Drawing.Point(478, 30);
            this.grade51.MultiSelect = false;
            this.grade51.Name = "grade51";
            this.grade51.ReadOnly = true;
            this.grade51.RowHeadersVisible = false;
            this.grade51.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade51.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade51.Size = new System.Drawing.Size(89, 27);
            this.grade51.TabIndex = 150;
            this.grade51.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade51.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade51.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_51
            // 
            this.HORARIO_GRADE_51.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_51.HeaderText = "HORARIO_GRADE_51";
            this.HORARIO_GRADE_51.Name = "HORARIO_GRADE_51";
            this.HORARIO_GRADE_51.ReadOnly = true;
            this.HORARIO_GRADE_51.Visible = false;
            // 
            // DIA_SEMANA_GRADE_51
            // 
            this.DIA_SEMANA_GRADE_51.HeaderText = "DIA_SEMANA_GRADE_51";
            this.DIA_SEMANA_GRADE_51.Name = "DIA_SEMANA_GRADE_51";
            this.DIA_SEMANA_GRADE_51.ReadOnly = true;
            this.DIA_SEMANA_GRADE_51.Visible = false;
            // 
            // CODIGO_DISCIPLINA_51
            // 
            this.CODIGO_DISCIPLINA_51.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_51.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_51.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_51.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_51.Name = "CODIGO_DISCIPLINA_51";
            this.CODIGO_DISCIPLINA_51.ReadOnly = true;
            this.CODIGO_DISCIPLINA_51.Width = 20;
            // 
            // CODIGO_TURMA_51
            // 
            this.CODIGO_TURMA_51.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_51.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_51.HeaderText = "Turma";
            this.CODIGO_TURMA_51.MinimumWidth = 20;
            this.CODIGO_TURMA_51.Name = "CODIGO_TURMA_51";
            this.CODIGO_TURMA_51.ReadOnly = true;
            // 
            // CODIGO_ESPACO_51
            // 
            this.CODIGO_ESPACO_51.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_51.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_51.HeaderText = "Sala";
            this.CODIGO_ESPACO_51.MinimumWidth = 20;
            this.CODIGO_ESPACO_51.Name = "CODIGO_ESPACO_51";
            this.CODIGO_ESPACO_51.ReadOnly = true;
            this.CODIGO_ESPACO_51.Width = 20;
            // 
            // CODIGO_PROFESSOR1_51
            // 
            this.CODIGO_PROFESSOR1_51.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_51.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_51.Name = "CODIGO_PROFESSOR1_51";
            this.CODIGO_PROFESSOR1_51.ReadOnly = true;
            this.CODIGO_PROFESSOR1_51.Visible = false;
            // 
            // CODIGO_PROFESSOR2_51
            // 
            this.CODIGO_PROFESSOR2_51.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_51.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_51.Name = "CODIGO_PROFESSOR2_51";
            this.CODIGO_PROFESSOR2_51.ReadOnly = true;
            this.CODIGO_PROFESSOR2_51.Visible = false;
            // 
            // CODIGO_PROFESSOR3_51
            // 
            this.CODIGO_PROFESSOR3_51.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_51.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_51.Name = "CODIGO_PROFESSOR3_51";
            this.CODIGO_PROFESSOR3_51.ReadOnly = true;
            this.CODIGO_PROFESSOR3_51.Visible = false;
            // 
            // grade52
            // 
            this.grade52.AllowUserToAddRows = false;
            this.grade52.AllowUserToDeleteRows = false;
            this.grade52.AllowUserToResizeColumns = false;
            this.grade52.AllowUserToResizeRows = false;
            this.grade52.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade52.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade52.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade52.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade52.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade52.ColumnHeadersVisible = false;
            this.grade52.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_52,
            this.DIA_SEMANA_GRADE_52,
            this.CODIGO_DISCIPLINA_52,
            this.CODIGO_TURMA_52,
            this.CODIGO_ESPACO_52,
            this.CODIGO_PROFESSOR1_52,
            this.CODIGO_PROFESSOR2_52,
            this.CODIGO_PROFESSOR3_52});
            this.grade52.ContextMenuStrip = this.menuContexto;
            this.grade52.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade52.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade52.Location = new System.Drawing.Point(478, 64);
            this.grade52.MultiSelect = false;
            this.grade52.Name = "grade52";
            this.grade52.ReadOnly = true;
            this.grade52.RowHeadersVisible = false;
            this.grade52.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade52.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade52.Size = new System.Drawing.Size(89, 27);
            this.grade52.TabIndex = 150;
            this.grade52.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade52.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade52.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_52
            // 
            this.HORARIO_GRADE_52.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_52.HeaderText = "HORARIO_GRADE_52";
            this.HORARIO_GRADE_52.Name = "HORARIO_GRADE_52";
            this.HORARIO_GRADE_52.ReadOnly = true;
            this.HORARIO_GRADE_52.Visible = false;
            // 
            // DIA_SEMANA_GRADE_52
            // 
            this.DIA_SEMANA_GRADE_52.HeaderText = "DIA_SEMANA_GRADE_52";
            this.DIA_SEMANA_GRADE_52.Name = "DIA_SEMANA_GRADE_52";
            this.DIA_SEMANA_GRADE_52.ReadOnly = true;
            this.DIA_SEMANA_GRADE_52.Visible = false;
            // 
            // CODIGO_DISCIPLINA_52
            // 
            this.CODIGO_DISCIPLINA_52.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_52.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_52.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_52.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_52.Name = "CODIGO_DISCIPLINA_52";
            this.CODIGO_DISCIPLINA_52.ReadOnly = true;
            this.CODIGO_DISCIPLINA_52.Width = 20;
            // 
            // CODIGO_TURMA_52
            // 
            this.CODIGO_TURMA_52.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_52.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_52.HeaderText = "Turma";
            this.CODIGO_TURMA_52.MinimumWidth = 20;
            this.CODIGO_TURMA_52.Name = "CODIGO_TURMA_52";
            this.CODIGO_TURMA_52.ReadOnly = true;
            // 
            // CODIGO_ESPACO_52
            // 
            this.CODIGO_ESPACO_52.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_52.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_52.HeaderText = "Sala";
            this.CODIGO_ESPACO_52.MinimumWidth = 20;
            this.CODIGO_ESPACO_52.Name = "CODIGO_ESPACO_52";
            this.CODIGO_ESPACO_52.ReadOnly = true;
            this.CODIGO_ESPACO_52.Width = 20;
            // 
            // CODIGO_PROFESSOR1_52
            // 
            this.CODIGO_PROFESSOR1_52.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_52.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_52.Name = "CODIGO_PROFESSOR1_52";
            this.CODIGO_PROFESSOR1_52.ReadOnly = true;
            this.CODIGO_PROFESSOR1_52.Visible = false;
            // 
            // CODIGO_PROFESSOR2_52
            // 
            this.CODIGO_PROFESSOR2_52.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_52.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_52.Name = "CODIGO_PROFESSOR2_52";
            this.CODIGO_PROFESSOR2_52.ReadOnly = true;
            this.CODIGO_PROFESSOR2_52.Visible = false;
            // 
            // CODIGO_PROFESSOR3_52
            // 
            this.CODIGO_PROFESSOR3_52.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_52.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_52.Name = "CODIGO_PROFESSOR3_52";
            this.CODIGO_PROFESSOR3_52.ReadOnly = true;
            this.CODIGO_PROFESSOR3_52.Visible = false;
            // 
            // grade53
            // 
            this.grade53.AllowUserToAddRows = false;
            this.grade53.AllowUserToDeleteRows = false;
            this.grade53.AllowUserToResizeColumns = false;
            this.grade53.AllowUserToResizeRows = false;
            this.grade53.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade53.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade53.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade53.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade53.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade53.ColumnHeadersVisible = false;
            this.grade53.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_53,
            this.DIA_SEMANA_GRADE_53,
            this.CODIGO_DISCIPLINA_53,
            this.CODIGO_TURMA_53,
            this.CODIGO_ESPACO_53,
            this.CODIGO_PROFESSOR1_53,
            this.CODIGO_PROFESSOR2_53,
            this.CODIGO_PROFESSOR3_53});
            this.grade53.ContextMenuStrip = this.menuContexto;
            this.grade53.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade53.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade53.Location = new System.Drawing.Point(478, 98);
            this.grade53.MultiSelect = false;
            this.grade53.Name = "grade53";
            this.grade53.ReadOnly = true;
            this.grade53.RowHeadersVisible = false;
            this.grade53.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade53.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade53.Size = new System.Drawing.Size(89, 27);
            this.grade53.TabIndex = 150;
            this.grade53.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade53.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade53.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_53
            // 
            this.HORARIO_GRADE_53.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_53.HeaderText = "HORARIO_GRADE_53";
            this.HORARIO_GRADE_53.Name = "HORARIO_GRADE_53";
            this.HORARIO_GRADE_53.ReadOnly = true;
            this.HORARIO_GRADE_53.Visible = false;
            // 
            // DIA_SEMANA_GRADE_53
            // 
            this.DIA_SEMANA_GRADE_53.HeaderText = "DIA_SEMANA_GRADE_53";
            this.DIA_SEMANA_GRADE_53.Name = "DIA_SEMANA_GRADE_53";
            this.DIA_SEMANA_GRADE_53.ReadOnly = true;
            this.DIA_SEMANA_GRADE_53.Visible = false;
            // 
            // CODIGO_DISCIPLINA_53
            // 
            this.CODIGO_DISCIPLINA_53.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_53.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_53.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_53.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_53.Name = "CODIGO_DISCIPLINA_53";
            this.CODIGO_DISCIPLINA_53.ReadOnly = true;
            this.CODIGO_DISCIPLINA_53.Width = 20;
            // 
            // CODIGO_TURMA_53
            // 
            this.CODIGO_TURMA_53.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_53.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_53.HeaderText = "Turma";
            this.CODIGO_TURMA_53.MinimumWidth = 20;
            this.CODIGO_TURMA_53.Name = "CODIGO_TURMA_53";
            this.CODIGO_TURMA_53.ReadOnly = true;
            // 
            // CODIGO_ESPACO_53
            // 
            this.CODIGO_ESPACO_53.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_53.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_53.HeaderText = "Sala";
            this.CODIGO_ESPACO_53.MinimumWidth = 20;
            this.CODIGO_ESPACO_53.Name = "CODIGO_ESPACO_53";
            this.CODIGO_ESPACO_53.ReadOnly = true;
            this.CODIGO_ESPACO_53.Width = 20;
            // 
            // CODIGO_PROFESSOR1_53
            // 
            this.CODIGO_PROFESSOR1_53.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_53.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_53.Name = "CODIGO_PROFESSOR1_53";
            this.CODIGO_PROFESSOR1_53.ReadOnly = true;
            this.CODIGO_PROFESSOR1_53.Visible = false;
            // 
            // CODIGO_PROFESSOR2_53
            // 
            this.CODIGO_PROFESSOR2_53.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_53.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_53.Name = "CODIGO_PROFESSOR2_53";
            this.CODIGO_PROFESSOR2_53.ReadOnly = true;
            this.CODIGO_PROFESSOR2_53.Visible = false;
            // 
            // CODIGO_PROFESSOR3_53
            // 
            this.CODIGO_PROFESSOR3_53.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_53.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_53.Name = "CODIGO_PROFESSOR3_53";
            this.CODIGO_PROFESSOR3_53.ReadOnly = true;
            this.CODIGO_PROFESSOR3_53.Visible = false;
            // 
            // grade54
            // 
            this.grade54.AllowUserToAddRows = false;
            this.grade54.AllowUserToDeleteRows = false;
            this.grade54.AllowUserToResizeColumns = false;
            this.grade54.AllowUserToResizeRows = false;
            this.grade54.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade54.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade54.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade54.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade54.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade54.ColumnHeadersVisible = false;
            this.grade54.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_54,
            this.DIA_SEMANA_GRADE_54,
            this.CODIGO_DISCIPLINA_54,
            this.CODIGO_TURMA_54,
            this.CODIGO_ESPACO_54,
            this.CODIGO_PROFESSOR1_54,
            this.CODIGO_PROFESSOR2_54,
            this.CODIGO_PROFESSOR3_54});
            this.grade54.ContextMenuStrip = this.menuContexto;
            this.grade54.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade54.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade54.Location = new System.Drawing.Point(478, 132);
            this.grade54.MultiSelect = false;
            this.grade54.Name = "grade54";
            this.grade54.ReadOnly = true;
            this.grade54.RowHeadersVisible = false;
            this.grade54.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade54.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade54.Size = new System.Drawing.Size(89, 27);
            this.grade54.TabIndex = 150;
            this.grade54.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade54.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade54.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_54
            // 
            this.HORARIO_GRADE_54.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_54.HeaderText = "HORARIO_GRADE_54";
            this.HORARIO_GRADE_54.Name = "HORARIO_GRADE_54";
            this.HORARIO_GRADE_54.ReadOnly = true;
            this.HORARIO_GRADE_54.Visible = false;
            // 
            // DIA_SEMANA_GRADE_54
            // 
            this.DIA_SEMANA_GRADE_54.HeaderText = "DIA_SEMANA_GRADE_54";
            this.DIA_SEMANA_GRADE_54.Name = "DIA_SEMANA_GRADE_54";
            this.DIA_SEMANA_GRADE_54.ReadOnly = true;
            this.DIA_SEMANA_GRADE_54.Visible = false;
            // 
            // CODIGO_DISCIPLINA_54
            // 
            this.CODIGO_DISCIPLINA_54.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_54.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_54.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_54.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_54.Name = "CODIGO_DISCIPLINA_54";
            this.CODIGO_DISCIPLINA_54.ReadOnly = true;
            this.CODIGO_DISCIPLINA_54.Width = 20;
            // 
            // CODIGO_TURMA_54
            // 
            this.CODIGO_TURMA_54.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_54.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_54.HeaderText = "Turma";
            this.CODIGO_TURMA_54.MinimumWidth = 20;
            this.CODIGO_TURMA_54.Name = "CODIGO_TURMA_54";
            this.CODIGO_TURMA_54.ReadOnly = true;
            // 
            // CODIGO_ESPACO_54
            // 
            this.CODIGO_ESPACO_54.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_54.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_54.HeaderText = "Sala";
            this.CODIGO_ESPACO_54.MinimumWidth = 20;
            this.CODIGO_ESPACO_54.Name = "CODIGO_ESPACO_54";
            this.CODIGO_ESPACO_54.ReadOnly = true;
            this.CODIGO_ESPACO_54.Width = 20;
            // 
            // CODIGO_PROFESSOR1_54
            // 
            this.CODIGO_PROFESSOR1_54.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_54.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_54.Name = "CODIGO_PROFESSOR1_54";
            this.CODIGO_PROFESSOR1_54.ReadOnly = true;
            this.CODIGO_PROFESSOR1_54.Visible = false;
            // 
            // CODIGO_PROFESSOR2_54
            // 
            this.CODIGO_PROFESSOR2_54.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_54.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_54.Name = "CODIGO_PROFESSOR2_54";
            this.CODIGO_PROFESSOR2_54.ReadOnly = true;
            this.CODIGO_PROFESSOR2_54.Visible = false;
            // 
            // CODIGO_PROFESSOR3_54
            // 
            this.CODIGO_PROFESSOR3_54.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_54.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_54.Name = "CODIGO_PROFESSOR3_54";
            this.CODIGO_PROFESSOR3_54.ReadOnly = true;
            this.CODIGO_PROFESSOR3_54.Visible = false;
            // 
            // grade55
            // 
            this.grade55.AllowUserToAddRows = false;
            this.grade55.AllowUserToDeleteRows = false;
            this.grade55.AllowUserToResizeColumns = false;
            this.grade55.AllowUserToResizeRows = false;
            this.grade55.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade55.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade55.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade55.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade55.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade55.ColumnHeadersVisible = false;
            this.grade55.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_55,
            this.DIA_SEMANA_GRADE_55,
            this.CODIGO_DISCIPLINA_55,
            this.CODIGO_TURMA_55,
            this.CODIGO_ESPACO_55,
            this.CODIGO_PROFESSOR1_55,
            this.CODIGO_PROFESSOR2_55,
            this.CODIGO_PROFESSOR3_55});
            this.grade55.ContextMenuStrip = this.menuContexto;
            this.grade55.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade55.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade55.Location = new System.Drawing.Point(478, 166);
            this.grade55.MultiSelect = false;
            this.grade55.Name = "grade55";
            this.grade55.ReadOnly = true;
            this.grade55.RowHeadersVisible = false;
            this.grade55.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade55.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade55.Size = new System.Drawing.Size(89, 27);
            this.grade55.TabIndex = 150;
            this.grade55.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade55.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade55.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_55
            // 
            this.HORARIO_GRADE_55.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_55.HeaderText = "HORARIO_GRADE_55";
            this.HORARIO_GRADE_55.Name = "HORARIO_GRADE_55";
            this.HORARIO_GRADE_55.ReadOnly = true;
            this.HORARIO_GRADE_55.Visible = false;
            // 
            // DIA_SEMANA_GRADE_55
            // 
            this.DIA_SEMANA_GRADE_55.HeaderText = "DIA_SEMANA_GRADE_55";
            this.DIA_SEMANA_GRADE_55.Name = "DIA_SEMANA_GRADE_55";
            this.DIA_SEMANA_GRADE_55.ReadOnly = true;
            this.DIA_SEMANA_GRADE_55.Visible = false;
            // 
            // CODIGO_DISCIPLINA_55
            // 
            this.CODIGO_DISCIPLINA_55.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_55.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_55.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_55.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_55.Name = "CODIGO_DISCIPLINA_55";
            this.CODIGO_DISCIPLINA_55.ReadOnly = true;
            this.CODIGO_DISCIPLINA_55.Width = 20;
            // 
            // CODIGO_TURMA_55
            // 
            this.CODIGO_TURMA_55.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_55.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_55.HeaderText = "Turma";
            this.CODIGO_TURMA_55.MinimumWidth = 20;
            this.CODIGO_TURMA_55.Name = "CODIGO_TURMA_55";
            this.CODIGO_TURMA_55.ReadOnly = true;
            // 
            // CODIGO_ESPACO_55
            // 
            this.CODIGO_ESPACO_55.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_55.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_55.HeaderText = "Sala";
            this.CODIGO_ESPACO_55.MinimumWidth = 20;
            this.CODIGO_ESPACO_55.Name = "CODIGO_ESPACO_55";
            this.CODIGO_ESPACO_55.ReadOnly = true;
            this.CODIGO_ESPACO_55.Width = 20;
            // 
            // CODIGO_PROFESSOR1_55
            // 
            this.CODIGO_PROFESSOR1_55.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_55.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_55.Name = "CODIGO_PROFESSOR1_55";
            this.CODIGO_PROFESSOR1_55.ReadOnly = true;
            this.CODIGO_PROFESSOR1_55.Visible = false;
            // 
            // CODIGO_PROFESSOR2_55
            // 
            this.CODIGO_PROFESSOR2_55.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_55.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_55.Name = "CODIGO_PROFESSOR2_55";
            this.CODIGO_PROFESSOR2_55.ReadOnly = true;
            this.CODIGO_PROFESSOR2_55.Visible = false;
            // 
            // CODIGO_PROFESSOR3_55
            // 
            this.CODIGO_PROFESSOR3_55.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_55.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_55.Name = "CODIGO_PROFESSOR3_55";
            this.CODIGO_PROFESSOR3_55.ReadOnly = true;
            this.CODIGO_PROFESSOR3_55.Visible = false;
            // 
            // grade56
            // 
            this.grade56.AllowUserToAddRows = false;
            this.grade56.AllowUserToDeleteRows = false;
            this.grade56.AllowUserToResizeColumns = false;
            this.grade56.AllowUserToResizeRows = false;
            this.grade56.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade56.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade56.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade56.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade56.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade56.ColumnHeadersVisible = false;
            this.grade56.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_56,
            this.DIA_SEMANA_GRADE_56,
            this.CODIGO_DISCIPLINA_56,
            this.CODIGO_TURMA_56,
            this.CODIGO_ESPACO_56,
            this.CODIGO_PROFESSOR1_56,
            this.CODIGO_PROFESSOR2_56,
            this.CODIGO_PROFESSOR3_56});
            this.grade56.ContextMenuStrip = this.menuContexto;
            this.grade56.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade56.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade56.Location = new System.Drawing.Point(478, 200);
            this.grade56.MultiSelect = false;
            this.grade56.Name = "grade56";
            this.grade56.ReadOnly = true;
            this.grade56.RowHeadersVisible = false;
            this.grade56.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade56.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade56.Size = new System.Drawing.Size(89, 27);
            this.grade56.TabIndex = 150;
            this.grade56.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade56.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade56.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_56
            // 
            this.HORARIO_GRADE_56.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_56.HeaderText = "HORARIO_GRADE_56";
            this.HORARIO_GRADE_56.Name = "HORARIO_GRADE_56";
            this.HORARIO_GRADE_56.ReadOnly = true;
            this.HORARIO_GRADE_56.Visible = false;
            // 
            // DIA_SEMANA_GRADE_56
            // 
            this.DIA_SEMANA_GRADE_56.HeaderText = "DIA_SEMANA_GRADE_56";
            this.DIA_SEMANA_GRADE_56.Name = "DIA_SEMANA_GRADE_56";
            this.DIA_SEMANA_GRADE_56.ReadOnly = true;
            this.DIA_SEMANA_GRADE_56.Visible = false;
            // 
            // CODIGO_DISCIPLINA_56
            // 
            this.CODIGO_DISCIPLINA_56.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_56.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_56.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_56.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_56.Name = "CODIGO_DISCIPLINA_56";
            this.CODIGO_DISCIPLINA_56.ReadOnly = true;
            this.CODIGO_DISCIPLINA_56.Width = 20;
            // 
            // CODIGO_TURMA_56
            // 
            this.CODIGO_TURMA_56.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_56.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_56.HeaderText = "Turma";
            this.CODIGO_TURMA_56.MinimumWidth = 20;
            this.CODIGO_TURMA_56.Name = "CODIGO_TURMA_56";
            this.CODIGO_TURMA_56.ReadOnly = true;
            // 
            // CODIGO_ESPACO_56
            // 
            this.CODIGO_ESPACO_56.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_56.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_56.HeaderText = "Sala";
            this.CODIGO_ESPACO_56.MinimumWidth = 20;
            this.CODIGO_ESPACO_56.Name = "CODIGO_ESPACO_56";
            this.CODIGO_ESPACO_56.ReadOnly = true;
            this.CODIGO_ESPACO_56.Width = 20;
            // 
            // CODIGO_PROFESSOR1_56
            // 
            this.CODIGO_PROFESSOR1_56.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_56.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_56.Name = "CODIGO_PROFESSOR1_56";
            this.CODIGO_PROFESSOR1_56.ReadOnly = true;
            this.CODIGO_PROFESSOR1_56.Visible = false;
            // 
            // CODIGO_PROFESSOR2_56
            // 
            this.CODIGO_PROFESSOR2_56.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_56.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_56.Name = "CODIGO_PROFESSOR2_56";
            this.CODIGO_PROFESSOR2_56.ReadOnly = true;
            this.CODIGO_PROFESSOR2_56.Visible = false;
            // 
            // CODIGO_PROFESSOR3_56
            // 
            this.CODIGO_PROFESSOR3_56.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_56.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_56.Name = "CODIGO_PROFESSOR3_56";
            this.CODIGO_PROFESSOR3_56.ReadOnly = true;
            this.CODIGO_PROFESSOR3_56.Visible = false;
            // 
            // grade57
            // 
            this.grade57.AllowUserToAddRows = false;
            this.grade57.AllowUserToDeleteRows = false;
            this.grade57.AllowUserToResizeColumns = false;
            this.grade57.AllowUserToResizeRows = false;
            this.grade57.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade57.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade57.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade57.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade57.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade57.ColumnHeadersVisible = false;
            this.grade57.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_57,
            this.DIA_SEMANA_GRADE_57,
            this.CODIGO_DISCIPLINA_57,
            this.CODIGO_TURMA_57,
            this.CODIGO_ESPACO_57,
            this.CODIGO_PROFESSOR1_57,
            this.CODIGO_PROFESSOR2_57,
            this.CODIGO_PROFESSOR3_57});
            this.grade57.ContextMenuStrip = this.menuContexto;
            this.grade57.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade57.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade57.Location = new System.Drawing.Point(478, 234);
            this.grade57.MultiSelect = false;
            this.grade57.Name = "grade57";
            this.grade57.ReadOnly = true;
            this.grade57.RowHeadersVisible = false;
            this.grade57.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade57.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade57.Size = new System.Drawing.Size(89, 27);
            this.grade57.TabIndex = 150;
            this.grade57.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade57.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade57.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_57
            // 
            this.HORARIO_GRADE_57.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_57.HeaderText = "HORARIO_GRADE_57";
            this.HORARIO_GRADE_57.Name = "HORARIO_GRADE_57";
            this.HORARIO_GRADE_57.ReadOnly = true;
            this.HORARIO_GRADE_57.Visible = false;
            // 
            // DIA_SEMANA_GRADE_57
            // 
            this.DIA_SEMANA_GRADE_57.HeaderText = "DIA_SEMANA_GRADE_57";
            this.DIA_SEMANA_GRADE_57.Name = "DIA_SEMANA_GRADE_57";
            this.DIA_SEMANA_GRADE_57.ReadOnly = true;
            this.DIA_SEMANA_GRADE_57.Visible = false;
            // 
            // CODIGO_DISCIPLINA_57
            // 
            this.CODIGO_DISCIPLINA_57.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_57.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_57.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_57.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_57.Name = "CODIGO_DISCIPLINA_57";
            this.CODIGO_DISCIPLINA_57.ReadOnly = true;
            this.CODIGO_DISCIPLINA_57.Width = 20;
            // 
            // CODIGO_TURMA_57
            // 
            this.CODIGO_TURMA_57.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_57.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_57.HeaderText = "Turma";
            this.CODIGO_TURMA_57.MinimumWidth = 20;
            this.CODIGO_TURMA_57.Name = "CODIGO_TURMA_57";
            this.CODIGO_TURMA_57.ReadOnly = true;
            // 
            // CODIGO_ESPACO_57
            // 
            this.CODIGO_ESPACO_57.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_57.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_57.HeaderText = "Sala";
            this.CODIGO_ESPACO_57.MinimumWidth = 20;
            this.CODIGO_ESPACO_57.Name = "CODIGO_ESPACO_57";
            this.CODIGO_ESPACO_57.ReadOnly = true;
            this.CODIGO_ESPACO_57.Width = 20;
            // 
            // CODIGO_PROFESSOR1_57
            // 
            this.CODIGO_PROFESSOR1_57.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_57.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_57.Name = "CODIGO_PROFESSOR1_57";
            this.CODIGO_PROFESSOR1_57.ReadOnly = true;
            this.CODIGO_PROFESSOR1_57.Visible = false;
            // 
            // CODIGO_PROFESSOR2_57
            // 
            this.CODIGO_PROFESSOR2_57.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_57.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_57.Name = "CODIGO_PROFESSOR2_57";
            this.CODIGO_PROFESSOR2_57.ReadOnly = true;
            this.CODIGO_PROFESSOR2_57.Visible = false;
            // 
            // CODIGO_PROFESSOR3_57
            // 
            this.CODIGO_PROFESSOR3_57.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_57.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_57.Name = "CODIGO_PROFESSOR3_57";
            this.CODIGO_PROFESSOR3_57.ReadOnly = true;
            this.CODIGO_PROFESSOR3_57.Visible = false;
            // 
            // grade58
            // 
            this.grade58.AllowUserToAddRows = false;
            this.grade58.AllowUserToDeleteRows = false;
            this.grade58.AllowUserToResizeColumns = false;
            this.grade58.AllowUserToResizeRows = false;
            this.grade58.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade58.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade58.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade58.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade58.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade58.ColumnHeadersVisible = false;
            this.grade58.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_58,
            this.DIA_SEMANA_GRADE_58,
            this.CODIGO_DISCIPLINA_58,
            this.CODIGO_TURMA_58,
            this.CODIGO_ESPACO_58,
            this.CODIGO_PROFESSOR1_58,
            this.CODIGO_PROFESSOR2_58,
            this.CODIGO_PROFESSOR3_58});
            this.grade58.ContextMenuStrip = this.menuContexto;
            this.grade58.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade58.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade58.Location = new System.Drawing.Point(478, 268);
            this.grade58.MultiSelect = false;
            this.grade58.Name = "grade58";
            this.grade58.ReadOnly = true;
            this.grade58.RowHeadersVisible = false;
            this.grade58.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade58.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade58.Size = new System.Drawing.Size(89, 27);
            this.grade58.TabIndex = 150;
            this.grade58.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade58.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade58.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_58
            // 
            this.HORARIO_GRADE_58.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_58.HeaderText = "HORARIO_GRADE_58";
            this.HORARIO_GRADE_58.Name = "HORARIO_GRADE_58";
            this.HORARIO_GRADE_58.ReadOnly = true;
            this.HORARIO_GRADE_58.Visible = false;
            // 
            // DIA_SEMANA_GRADE_58
            // 
            this.DIA_SEMANA_GRADE_58.HeaderText = "DIA_SEMANA_GRADE_58";
            this.DIA_SEMANA_GRADE_58.Name = "DIA_SEMANA_GRADE_58";
            this.DIA_SEMANA_GRADE_58.ReadOnly = true;
            this.DIA_SEMANA_GRADE_58.Visible = false;
            // 
            // CODIGO_DISCIPLINA_58
            // 
            this.CODIGO_DISCIPLINA_58.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_58.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_58.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_58.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_58.Name = "CODIGO_DISCIPLINA_58";
            this.CODIGO_DISCIPLINA_58.ReadOnly = true;
            this.CODIGO_DISCIPLINA_58.Width = 20;
            // 
            // CODIGO_TURMA_58
            // 
            this.CODIGO_TURMA_58.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_58.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_58.HeaderText = "Turma";
            this.CODIGO_TURMA_58.MinimumWidth = 20;
            this.CODIGO_TURMA_58.Name = "CODIGO_TURMA_58";
            this.CODIGO_TURMA_58.ReadOnly = true;
            // 
            // CODIGO_ESPACO_58
            // 
            this.CODIGO_ESPACO_58.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_58.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_58.HeaderText = "Sala";
            this.CODIGO_ESPACO_58.MinimumWidth = 20;
            this.CODIGO_ESPACO_58.Name = "CODIGO_ESPACO_58";
            this.CODIGO_ESPACO_58.ReadOnly = true;
            this.CODIGO_ESPACO_58.Width = 20;
            // 
            // CODIGO_PROFESSOR1_58
            // 
            this.CODIGO_PROFESSOR1_58.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_58.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_58.Name = "CODIGO_PROFESSOR1_58";
            this.CODIGO_PROFESSOR1_58.ReadOnly = true;
            this.CODIGO_PROFESSOR1_58.Visible = false;
            // 
            // CODIGO_PROFESSOR2_58
            // 
            this.CODIGO_PROFESSOR2_58.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_58.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_58.Name = "CODIGO_PROFESSOR2_58";
            this.CODIGO_PROFESSOR2_58.ReadOnly = true;
            this.CODIGO_PROFESSOR2_58.Visible = false;
            // 
            // CODIGO_PROFESSOR3_58
            // 
            this.CODIGO_PROFESSOR3_58.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_58.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_58.Name = "CODIGO_PROFESSOR3_58";
            this.CODIGO_PROFESSOR3_58.ReadOnly = true;
            this.CODIGO_PROFESSOR3_58.Visible = false;
            // 
            // grade59
            // 
            this.grade59.AllowUserToAddRows = false;
            this.grade59.AllowUserToDeleteRows = false;
            this.grade59.AllowUserToResizeColumns = false;
            this.grade59.AllowUserToResizeRows = false;
            this.grade59.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade59.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade59.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade59.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade59.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade59.ColumnHeadersVisible = false;
            this.grade59.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_59,
            this.DIA_SEMANA_GRADE_59,
            this.CODIGO_DISCIPLINA_59,
            this.CODIGO_TURMA_59,
            this.CODIGO_ESPACO_59,
            this.CODIGO_PROFESSOR1_59,
            this.CODIGO_PROFESSOR2_59,
            this.CODIGO_PROFESSOR3_59});
            this.grade59.ContextMenuStrip = this.menuContexto;
            this.grade59.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade59.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade59.Location = new System.Drawing.Point(478, 302);
            this.grade59.MultiSelect = false;
            this.grade59.Name = "grade59";
            this.grade59.ReadOnly = true;
            this.grade59.RowHeadersVisible = false;
            this.grade59.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade59.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade59.Size = new System.Drawing.Size(89, 27);
            this.grade59.TabIndex = 150;
            this.grade59.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade59.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade59.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_59
            // 
            this.HORARIO_GRADE_59.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_59.HeaderText = "HORARIO_GRADE_59";
            this.HORARIO_GRADE_59.Name = "HORARIO_GRADE_59";
            this.HORARIO_GRADE_59.ReadOnly = true;
            this.HORARIO_GRADE_59.Visible = false;
            // 
            // DIA_SEMANA_GRADE_59
            // 
            this.DIA_SEMANA_GRADE_59.HeaderText = "DIA_SEMANA_GRADE_59";
            this.DIA_SEMANA_GRADE_59.Name = "DIA_SEMANA_GRADE_59";
            this.DIA_SEMANA_GRADE_59.ReadOnly = true;
            this.DIA_SEMANA_GRADE_59.Visible = false;
            // 
            // CODIGO_DISCIPLINA_59
            // 
            this.CODIGO_DISCIPLINA_59.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_59.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_59.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_59.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_59.Name = "CODIGO_DISCIPLINA_59";
            this.CODIGO_DISCIPLINA_59.ReadOnly = true;
            this.CODIGO_DISCIPLINA_59.Width = 20;
            // 
            // CODIGO_TURMA_59
            // 
            this.CODIGO_TURMA_59.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_59.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_59.HeaderText = "Turma";
            this.CODIGO_TURMA_59.MinimumWidth = 20;
            this.CODIGO_TURMA_59.Name = "CODIGO_TURMA_59";
            this.CODIGO_TURMA_59.ReadOnly = true;
            // 
            // CODIGO_ESPACO_59
            // 
            this.CODIGO_ESPACO_59.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_59.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_59.HeaderText = "Sala";
            this.CODIGO_ESPACO_59.MinimumWidth = 20;
            this.CODIGO_ESPACO_59.Name = "CODIGO_ESPACO_59";
            this.CODIGO_ESPACO_59.ReadOnly = true;
            this.CODIGO_ESPACO_59.Width = 20;
            // 
            // CODIGO_PROFESSOR1_59
            // 
            this.CODIGO_PROFESSOR1_59.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_59.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_59.Name = "CODIGO_PROFESSOR1_59";
            this.CODIGO_PROFESSOR1_59.ReadOnly = true;
            this.CODIGO_PROFESSOR1_59.Visible = false;
            // 
            // CODIGO_PROFESSOR2_59
            // 
            this.CODIGO_PROFESSOR2_59.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_59.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_59.Name = "CODIGO_PROFESSOR2_59";
            this.CODIGO_PROFESSOR2_59.ReadOnly = true;
            this.CODIGO_PROFESSOR2_59.Visible = false;
            // 
            // CODIGO_PROFESSOR3_59
            // 
            this.CODIGO_PROFESSOR3_59.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_59.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_59.Name = "CODIGO_PROFESSOR3_59";
            this.CODIGO_PROFESSOR3_59.ReadOnly = true;
            this.CODIGO_PROFESSOR3_59.Visible = false;
            // 
            // grade510
            // 
            this.grade510.AllowUserToAddRows = false;
            this.grade510.AllowUserToDeleteRows = false;
            this.grade510.AllowUserToResizeColumns = false;
            this.grade510.AllowUserToResizeRows = false;
            this.grade510.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade510.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade510.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade510.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade510.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade510.ColumnHeadersVisible = false;
            this.grade510.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_510,
            this.DIA_SEMANA_GRADE_510,
            this.CODIGO_DISCIPLINA_510,
            this.CODIGO_TURMA_510,
            this.CODIGO_ESPACO_510,
            this.CODIGO_PROFESSOR1_510,
            this.CODIGO_PROFESSOR2_510,
            this.CODIGO_PROFESSOR3_510});
            this.grade510.ContextMenuStrip = this.menuContexto;
            this.grade510.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade510.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade510.Location = new System.Drawing.Point(478, 336);
            this.grade510.MultiSelect = false;
            this.grade510.Name = "grade510";
            this.grade510.ReadOnly = true;
            this.grade510.RowHeadersVisible = false;
            this.grade510.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade510.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade510.Size = new System.Drawing.Size(89, 27);
            this.grade510.TabIndex = 150;
            this.grade510.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade510.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade510.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_510
            // 
            this.HORARIO_GRADE_510.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_510.HeaderText = "HORARIO_GRADE_510";
            this.HORARIO_GRADE_510.Name = "HORARIO_GRADE_510";
            this.HORARIO_GRADE_510.ReadOnly = true;
            this.HORARIO_GRADE_510.Visible = false;
            // 
            // DIA_SEMANA_GRADE_510
            // 
            this.DIA_SEMANA_GRADE_510.HeaderText = "DIA_SEMANA_GRADE_510";
            this.DIA_SEMANA_GRADE_510.Name = "DIA_SEMANA_GRADE_510";
            this.DIA_SEMANA_GRADE_510.ReadOnly = true;
            this.DIA_SEMANA_GRADE_510.Visible = false;
            // 
            // CODIGO_DISCIPLINA_510
            // 
            this.CODIGO_DISCIPLINA_510.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_510.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_510.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_510.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_510.Name = "CODIGO_DISCIPLINA_510";
            this.CODIGO_DISCIPLINA_510.ReadOnly = true;
            this.CODIGO_DISCIPLINA_510.Width = 20;
            // 
            // CODIGO_TURMA_510
            // 
            this.CODIGO_TURMA_510.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_510.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_510.HeaderText = "Turma";
            this.CODIGO_TURMA_510.MinimumWidth = 20;
            this.CODIGO_TURMA_510.Name = "CODIGO_TURMA_510";
            this.CODIGO_TURMA_510.ReadOnly = true;
            // 
            // CODIGO_ESPACO_510
            // 
            this.CODIGO_ESPACO_510.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_510.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_510.HeaderText = "Sala";
            this.CODIGO_ESPACO_510.MinimumWidth = 20;
            this.CODIGO_ESPACO_510.Name = "CODIGO_ESPACO_510";
            this.CODIGO_ESPACO_510.ReadOnly = true;
            this.CODIGO_ESPACO_510.Width = 20;
            // 
            // CODIGO_PROFESSOR1_510
            // 
            this.CODIGO_PROFESSOR1_510.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_510.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_510.Name = "CODIGO_PROFESSOR1_510";
            this.CODIGO_PROFESSOR1_510.ReadOnly = true;
            this.CODIGO_PROFESSOR1_510.Visible = false;
            // 
            // CODIGO_PROFESSOR2_510
            // 
            this.CODIGO_PROFESSOR2_510.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_510.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_510.Name = "CODIGO_PROFESSOR2_510";
            this.CODIGO_PROFESSOR2_510.ReadOnly = true;
            this.CODIGO_PROFESSOR2_510.Visible = false;
            // 
            // CODIGO_PROFESSOR3_510
            // 
            this.CODIGO_PROFESSOR3_510.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_510.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_510.Name = "CODIGO_PROFESSOR3_510";
            this.CODIGO_PROFESSOR3_510.ReadOnly = true;
            this.CODIGO_PROFESSOR3_510.Visible = false;
            // 
            // grade511
            // 
            this.grade511.AllowUserToAddRows = false;
            this.grade511.AllowUserToDeleteRows = false;
            this.grade511.AllowUserToResizeColumns = false;
            this.grade511.AllowUserToResizeRows = false;
            this.grade511.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade511.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade511.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade511.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade511.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade511.ColumnHeadersVisible = false;
            this.grade511.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_511,
            this.DIA_SEMANA_GRADE_511,
            this.CODIGO_DISCIPLINA_511,
            this.CODIGO_TURMA_511,
            this.CODIGO_ESPACO_511,
            this.CODIGO_PROFESSOR1_511,
            this.CODIGO_PROFESSOR2_511,
            this.CODIGO_PROFESSOR3_511});
            this.grade511.ContextMenuStrip = this.menuContexto;
            this.grade511.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade511.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade511.Location = new System.Drawing.Point(478, 370);
            this.grade511.MultiSelect = false;
            this.grade511.Name = "grade511";
            this.grade511.ReadOnly = true;
            this.grade511.RowHeadersVisible = false;
            this.grade511.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade511.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade511.Size = new System.Drawing.Size(89, 27);
            this.grade511.TabIndex = 150;
            this.grade511.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade511.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade511.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_511
            // 
            this.HORARIO_GRADE_511.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_511.HeaderText = "HORARIO_GRADE_511";
            this.HORARIO_GRADE_511.Name = "HORARIO_GRADE_511";
            this.HORARIO_GRADE_511.ReadOnly = true;
            this.HORARIO_GRADE_511.Visible = false;
            // 
            // DIA_SEMANA_GRADE_511
            // 
            this.DIA_SEMANA_GRADE_511.HeaderText = "DIA_SEMANA_GRADE_511";
            this.DIA_SEMANA_GRADE_511.Name = "DIA_SEMANA_GRADE_511";
            this.DIA_SEMANA_GRADE_511.ReadOnly = true;
            this.DIA_SEMANA_GRADE_511.Visible = false;
            // 
            // CODIGO_DISCIPLINA_511
            // 
            this.CODIGO_DISCIPLINA_511.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_511.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_511.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_511.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_511.Name = "CODIGO_DISCIPLINA_511";
            this.CODIGO_DISCIPLINA_511.ReadOnly = true;
            this.CODIGO_DISCIPLINA_511.Width = 20;
            // 
            // CODIGO_TURMA_511
            // 
            this.CODIGO_TURMA_511.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_511.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_511.HeaderText = "Turma";
            this.CODIGO_TURMA_511.MinimumWidth = 20;
            this.CODIGO_TURMA_511.Name = "CODIGO_TURMA_511";
            this.CODIGO_TURMA_511.ReadOnly = true;
            // 
            // CODIGO_ESPACO_511
            // 
            this.CODIGO_ESPACO_511.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_511.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_511.HeaderText = "Sala";
            this.CODIGO_ESPACO_511.MinimumWidth = 20;
            this.CODIGO_ESPACO_511.Name = "CODIGO_ESPACO_511";
            this.CODIGO_ESPACO_511.ReadOnly = true;
            this.CODIGO_ESPACO_511.Width = 20;
            // 
            // CODIGO_PROFESSOR1_511
            // 
            this.CODIGO_PROFESSOR1_511.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_511.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_511.Name = "CODIGO_PROFESSOR1_511";
            this.CODIGO_PROFESSOR1_511.ReadOnly = true;
            this.CODIGO_PROFESSOR1_511.Visible = false;
            // 
            // CODIGO_PROFESSOR2_511
            // 
            this.CODIGO_PROFESSOR2_511.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_511.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_511.Name = "CODIGO_PROFESSOR2_511";
            this.CODIGO_PROFESSOR2_511.ReadOnly = true;
            this.CODIGO_PROFESSOR2_511.Visible = false;
            // 
            // CODIGO_PROFESSOR3_511
            // 
            this.CODIGO_PROFESSOR3_511.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_511.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_511.Name = "CODIGO_PROFESSOR3_511";
            this.CODIGO_PROFESSOR3_511.ReadOnly = true;
            this.CODIGO_PROFESSOR3_511.Visible = false;
            // 
            // grade512
            // 
            this.grade512.AllowUserToAddRows = false;
            this.grade512.AllowUserToDeleteRows = false;
            this.grade512.AllowUserToResizeColumns = false;
            this.grade512.AllowUserToResizeRows = false;
            this.grade512.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade512.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade512.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade512.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade512.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade512.ColumnHeadersVisible = false;
            this.grade512.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_512,
            this.DIA_SEMANA_GRADE_512,
            this.CODIGO_DISCIPLINA_512,
            this.CODIGO_TURMA_512,
            this.CODIGO_ESPACO_512,
            this.CODIGO_PROFESSOR1_512,
            this.CODIGO_PROFESSOR2_512,
            this.CODIGO_PROFESSOR3_512});
            this.grade512.ContextMenuStrip = this.menuContexto;
            this.grade512.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade512.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade512.Location = new System.Drawing.Point(478, 404);
            this.grade512.MultiSelect = false;
            this.grade512.Name = "grade512";
            this.grade512.ReadOnly = true;
            this.grade512.RowHeadersVisible = false;
            this.grade512.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade512.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade512.Size = new System.Drawing.Size(89, 27);
            this.grade512.TabIndex = 150;
            this.grade512.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade512.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade512.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_512
            // 
            this.HORARIO_GRADE_512.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_512.HeaderText = "HORARIO_GRADE_512";
            this.HORARIO_GRADE_512.Name = "HORARIO_GRADE_512";
            this.HORARIO_GRADE_512.ReadOnly = true;
            this.HORARIO_GRADE_512.Visible = false;
            // 
            // DIA_SEMANA_GRADE_512
            // 
            this.DIA_SEMANA_GRADE_512.HeaderText = "DIA_SEMANA_GRADE_512";
            this.DIA_SEMANA_GRADE_512.Name = "DIA_SEMANA_GRADE_512";
            this.DIA_SEMANA_GRADE_512.ReadOnly = true;
            this.DIA_SEMANA_GRADE_512.Visible = false;
            // 
            // CODIGO_DISCIPLINA_512
            // 
            this.CODIGO_DISCIPLINA_512.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_512.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_512.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_512.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_512.Name = "CODIGO_DISCIPLINA_512";
            this.CODIGO_DISCIPLINA_512.ReadOnly = true;
            this.CODIGO_DISCIPLINA_512.Width = 20;
            // 
            // CODIGO_TURMA_512
            // 
            this.CODIGO_TURMA_512.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_512.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_512.HeaderText = "Turma";
            this.CODIGO_TURMA_512.MinimumWidth = 20;
            this.CODIGO_TURMA_512.Name = "CODIGO_TURMA_512";
            this.CODIGO_TURMA_512.ReadOnly = true;
            // 
            // CODIGO_ESPACO_512
            // 
            this.CODIGO_ESPACO_512.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_512.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_512.HeaderText = "Sala";
            this.CODIGO_ESPACO_512.MinimumWidth = 20;
            this.CODIGO_ESPACO_512.Name = "CODIGO_ESPACO_512";
            this.CODIGO_ESPACO_512.ReadOnly = true;
            this.CODIGO_ESPACO_512.Width = 20;
            // 
            // CODIGO_PROFESSOR1_512
            // 
            this.CODIGO_PROFESSOR1_512.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_512.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_512.Name = "CODIGO_PROFESSOR1_512";
            this.CODIGO_PROFESSOR1_512.ReadOnly = true;
            this.CODIGO_PROFESSOR1_512.Visible = false;
            // 
            // CODIGO_PROFESSOR2_512
            // 
            this.CODIGO_PROFESSOR2_512.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_512.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_512.Name = "CODIGO_PROFESSOR2_512";
            this.CODIGO_PROFESSOR2_512.ReadOnly = true;
            this.CODIGO_PROFESSOR2_512.Visible = false;
            // 
            // CODIGO_PROFESSOR3_512
            // 
            this.CODIGO_PROFESSOR3_512.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_512.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_512.Name = "CODIGO_PROFESSOR3_512";
            this.CODIGO_PROFESSOR3_512.ReadOnly = true;
            this.CODIGO_PROFESSOR3_512.Visible = false;
            // 
            // grade513
            // 
            this.grade513.AllowUserToAddRows = false;
            this.grade513.AllowUserToDeleteRows = false;
            this.grade513.AllowUserToResizeColumns = false;
            this.grade513.AllowUserToResizeRows = false;
            this.grade513.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade513.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade513.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade513.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade513.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade513.ColumnHeadersVisible = false;
            this.grade513.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_513,
            this.DIA_SEMANA_GRADE_513,
            this.CODIGO_DISCIPLINA_513,
            this.CODIGO_TURMA_513,
            this.CODIGO_ESPACO_513,
            this.CODIGO_PROFESSOR1_513,
            this.CODIGO_PROFESSOR2_513,
            this.CODIGO_PROFESSOR3_513});
            this.grade513.ContextMenuStrip = this.menuContexto;
            this.grade513.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade513.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade513.Location = new System.Drawing.Point(478, 438);
            this.grade513.MultiSelect = false;
            this.grade513.Name = "grade513";
            this.grade513.ReadOnly = true;
            this.grade513.RowHeadersVisible = false;
            this.grade513.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade513.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade513.Size = new System.Drawing.Size(89, 27);
            this.grade513.TabIndex = 150;
            this.grade513.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade513.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade513.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_513
            // 
            this.HORARIO_GRADE_513.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_513.HeaderText = "HORARIO_GRADE_513";
            this.HORARIO_GRADE_513.Name = "HORARIO_GRADE_513";
            this.HORARIO_GRADE_513.ReadOnly = true;
            this.HORARIO_GRADE_513.Visible = false;
            // 
            // DIA_SEMANA_GRADE_513
            // 
            this.DIA_SEMANA_GRADE_513.HeaderText = "DIA_SEMANA_GRADE_513";
            this.DIA_SEMANA_GRADE_513.Name = "DIA_SEMANA_GRADE_513";
            this.DIA_SEMANA_GRADE_513.ReadOnly = true;
            this.DIA_SEMANA_GRADE_513.Visible = false;
            // 
            // CODIGO_DISCIPLINA_513
            // 
            this.CODIGO_DISCIPLINA_513.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_513.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_513.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_513.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_513.Name = "CODIGO_DISCIPLINA_513";
            this.CODIGO_DISCIPLINA_513.ReadOnly = true;
            this.CODIGO_DISCIPLINA_513.Width = 20;
            // 
            // CODIGO_TURMA_513
            // 
            this.CODIGO_TURMA_513.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_513.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_513.HeaderText = "Turma";
            this.CODIGO_TURMA_513.MinimumWidth = 20;
            this.CODIGO_TURMA_513.Name = "CODIGO_TURMA_513";
            this.CODIGO_TURMA_513.ReadOnly = true;
            // 
            // CODIGO_ESPACO_513
            // 
            this.CODIGO_ESPACO_513.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_513.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_513.HeaderText = "Sala";
            this.CODIGO_ESPACO_513.MinimumWidth = 20;
            this.CODIGO_ESPACO_513.Name = "CODIGO_ESPACO_513";
            this.CODIGO_ESPACO_513.ReadOnly = true;
            this.CODIGO_ESPACO_513.Width = 20;
            // 
            // CODIGO_PROFESSOR1_513
            // 
            this.CODIGO_PROFESSOR1_513.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_513.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_513.Name = "CODIGO_PROFESSOR1_513";
            this.CODIGO_PROFESSOR1_513.ReadOnly = true;
            this.CODIGO_PROFESSOR1_513.Visible = false;
            // 
            // CODIGO_PROFESSOR2_513
            // 
            this.CODIGO_PROFESSOR2_513.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_513.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_513.Name = "CODIGO_PROFESSOR2_513";
            this.CODIGO_PROFESSOR2_513.ReadOnly = true;
            this.CODIGO_PROFESSOR2_513.Visible = false;
            // 
            // CODIGO_PROFESSOR3_513
            // 
            this.CODIGO_PROFESSOR3_513.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_513.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_513.Name = "CODIGO_PROFESSOR3_513";
            this.CODIGO_PROFESSOR3_513.ReadOnly = true;
            this.CODIGO_PROFESSOR3_513.Visible = false;
            // 
            // grade514
            // 
            this.grade514.AllowUserToAddRows = false;
            this.grade514.AllowUserToDeleteRows = false;
            this.grade514.AllowUserToResizeColumns = false;
            this.grade514.AllowUserToResizeRows = false;
            this.grade514.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade514.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade514.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade514.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade514.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade514.ColumnHeadersVisible = false;
            this.grade514.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_514,
            this.DIA_SEMANA_GRADE_514,
            this.CODIGO_DISCIPLINA_514,
            this.CODIGO_TURMA_514,
            this.CODIGO_ESPACO_514,
            this.CODIGO_PROFESSOR1_514,
            this.CODIGO_PROFESSOR2_514,
            this.CODIGO_PROFESSOR3_514});
            this.grade514.ContextMenuStrip = this.menuContexto;
            this.grade514.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade514.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade514.Location = new System.Drawing.Point(478, 472);
            this.grade514.MultiSelect = false;
            this.grade514.Name = "grade514";
            this.grade514.ReadOnly = true;
            this.grade514.RowHeadersVisible = false;
            this.grade514.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade514.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade514.Size = new System.Drawing.Size(89, 28);
            this.grade514.TabIndex = 150;
            this.grade514.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade514.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade514.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_514
            // 
            this.HORARIO_GRADE_514.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_514.HeaderText = "HORARIO_GRADE_514";
            this.HORARIO_GRADE_514.Name = "HORARIO_GRADE_514";
            this.HORARIO_GRADE_514.ReadOnly = true;
            this.HORARIO_GRADE_514.Visible = false;
            // 
            // DIA_SEMANA_GRADE_514
            // 
            this.DIA_SEMANA_GRADE_514.HeaderText = "DIA_SEMANA_GRADE_514";
            this.DIA_SEMANA_GRADE_514.Name = "DIA_SEMANA_GRADE_514";
            this.DIA_SEMANA_GRADE_514.ReadOnly = true;
            this.DIA_SEMANA_GRADE_514.Visible = false;
            // 
            // CODIGO_DISCIPLINA_514
            // 
            this.CODIGO_DISCIPLINA_514.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_514.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_514.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_514.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_514.Name = "CODIGO_DISCIPLINA_514";
            this.CODIGO_DISCIPLINA_514.ReadOnly = true;
            this.CODIGO_DISCIPLINA_514.Width = 20;
            // 
            // CODIGO_TURMA_514
            // 
            this.CODIGO_TURMA_514.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_514.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_514.HeaderText = "Turma";
            this.CODIGO_TURMA_514.MinimumWidth = 20;
            this.CODIGO_TURMA_514.Name = "CODIGO_TURMA_514";
            this.CODIGO_TURMA_514.ReadOnly = true;
            // 
            // CODIGO_ESPACO_514
            // 
            this.CODIGO_ESPACO_514.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_514.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_514.HeaderText = "Sala";
            this.CODIGO_ESPACO_514.MinimumWidth = 20;
            this.CODIGO_ESPACO_514.Name = "CODIGO_ESPACO_514";
            this.CODIGO_ESPACO_514.ReadOnly = true;
            this.CODIGO_ESPACO_514.Width = 20;
            // 
            // CODIGO_PROFESSOR1_514
            // 
            this.CODIGO_PROFESSOR1_514.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_514.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_514.Name = "CODIGO_PROFESSOR1_514";
            this.CODIGO_PROFESSOR1_514.ReadOnly = true;
            this.CODIGO_PROFESSOR1_514.Visible = false;
            // 
            // CODIGO_PROFESSOR2_514
            // 
            this.CODIGO_PROFESSOR2_514.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_514.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_514.Name = "CODIGO_PROFESSOR2_514";
            this.CODIGO_PROFESSOR2_514.ReadOnly = true;
            this.CODIGO_PROFESSOR2_514.Visible = false;
            // 
            // CODIGO_PROFESSOR3_514
            // 
            this.CODIGO_PROFESSOR3_514.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_514.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_514.Name = "CODIGO_PROFESSOR3_514";
            this.CODIGO_PROFESSOR3_514.ReadOnly = true;
            this.CODIGO_PROFESSOR3_514.Visible = false;
            // 
            // grade61
            // 
            this.grade61.AllowUserToAddRows = false;
            this.grade61.AllowUserToDeleteRows = false;
            this.grade61.AllowUserToResizeColumns = false;
            this.grade61.AllowUserToResizeRows = false;
            this.grade61.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade61.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade61.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade61.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade61.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade61.ColumnHeadersVisible = false;
            this.grade61.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_61,
            this.DIA_SEMANA_GRADE_61,
            this.CODIGO_DISCIPLINA_61,
            this.CODIGO_TURMA_61,
            this.CODIGO_ESPACO_61,
            this.CODIGO_PROFESSOR1_61,
            this.CODIGO_PROFESSOR2_61,
            this.CODIGO_PROFESSOR3_61});
            this.grade61.ContextMenuStrip = this.menuContexto;
            this.grade61.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade61.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade61.Location = new System.Drawing.Point(574, 30);
            this.grade61.MultiSelect = false;
            this.grade61.Name = "grade61";
            this.grade61.ReadOnly = true;
            this.grade61.RowHeadersVisible = false;
            this.grade61.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade61.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade61.Size = new System.Drawing.Size(94, 27);
            this.grade61.TabIndex = 150;
            this.grade61.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade61.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade61.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_61
            // 
            this.HORARIO_GRADE_61.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_61.HeaderText = "HORARIO_GRADE_61";
            this.HORARIO_GRADE_61.Name = "HORARIO_GRADE_61";
            this.HORARIO_GRADE_61.ReadOnly = true;
            this.HORARIO_GRADE_61.Visible = false;
            // 
            // DIA_SEMANA_GRADE_61
            // 
            this.DIA_SEMANA_GRADE_61.HeaderText = "DIA_SEMANA_GRADE_61";
            this.DIA_SEMANA_GRADE_61.Name = "DIA_SEMANA_GRADE_61";
            this.DIA_SEMANA_GRADE_61.ReadOnly = true;
            this.DIA_SEMANA_GRADE_61.Visible = false;
            // 
            // CODIGO_DISCIPLINA_61
            // 
            this.CODIGO_DISCIPLINA_61.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_61.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_61.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_61.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_61.Name = "CODIGO_DISCIPLINA_61";
            this.CODIGO_DISCIPLINA_61.ReadOnly = true;
            this.CODIGO_DISCIPLINA_61.Width = 20;
            // 
            // CODIGO_TURMA_61
            // 
            this.CODIGO_TURMA_61.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_61.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_61.HeaderText = "Turma";
            this.CODIGO_TURMA_61.MinimumWidth = 20;
            this.CODIGO_TURMA_61.Name = "CODIGO_TURMA_61";
            this.CODIGO_TURMA_61.ReadOnly = true;
            // 
            // CODIGO_ESPACO_61
            // 
            this.CODIGO_ESPACO_61.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_61.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_61.HeaderText = "Sala";
            this.CODIGO_ESPACO_61.MinimumWidth = 20;
            this.CODIGO_ESPACO_61.Name = "CODIGO_ESPACO_61";
            this.CODIGO_ESPACO_61.ReadOnly = true;
            this.CODIGO_ESPACO_61.Width = 20;
            // 
            // CODIGO_PROFESSOR1_61
            // 
            this.CODIGO_PROFESSOR1_61.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_61.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_61.Name = "CODIGO_PROFESSOR1_61";
            this.CODIGO_PROFESSOR1_61.ReadOnly = true;
            this.CODIGO_PROFESSOR1_61.Visible = false;
            // 
            // CODIGO_PROFESSOR2_61
            // 
            this.CODIGO_PROFESSOR2_61.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_61.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_61.Name = "CODIGO_PROFESSOR2_61";
            this.CODIGO_PROFESSOR2_61.ReadOnly = true;
            this.CODIGO_PROFESSOR2_61.Visible = false;
            // 
            // CODIGO_PROFESSOR3_61
            // 
            this.CODIGO_PROFESSOR3_61.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_61.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_61.Name = "CODIGO_PROFESSOR3_61";
            this.CODIGO_PROFESSOR3_61.ReadOnly = true;
            this.CODIGO_PROFESSOR3_61.Visible = false;
            // 
            // grade62
            // 
            this.grade62.AllowUserToAddRows = false;
            this.grade62.AllowUserToDeleteRows = false;
            this.grade62.AllowUserToResizeColumns = false;
            this.grade62.AllowUserToResizeRows = false;
            this.grade62.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade62.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade62.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade62.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade62.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade62.ColumnHeadersVisible = false;
            this.grade62.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_62,
            this.DIA_SEMANA_GRADE_62,
            this.CODIGO_DISCIPLINA_62,
            this.CODIGO_TURMA_62,
            this.CODIGO_ESPACO_62,
            this.CODIGO_PROFESSOR1_62,
            this.CODIGO_PROFESSOR2_62,
            this.CODIGO_PROFESSOR3_62});
            this.grade62.ContextMenuStrip = this.menuContexto;
            this.grade62.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade62.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade62.Location = new System.Drawing.Point(574, 64);
            this.grade62.MultiSelect = false;
            this.grade62.Name = "grade62";
            this.grade62.ReadOnly = true;
            this.grade62.RowHeadersVisible = false;
            this.grade62.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade62.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade62.Size = new System.Drawing.Size(94, 27);
            this.grade62.TabIndex = 150;
            this.grade62.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade62.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade62.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_62
            // 
            this.HORARIO_GRADE_62.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_62.HeaderText = "HORARIO_GRADE_62";
            this.HORARIO_GRADE_62.Name = "HORARIO_GRADE_62";
            this.HORARIO_GRADE_62.ReadOnly = true;
            this.HORARIO_GRADE_62.Visible = false;
            // 
            // DIA_SEMANA_GRADE_62
            // 
            this.DIA_SEMANA_GRADE_62.HeaderText = "DIA_SEMANA_GRADE_62";
            this.DIA_SEMANA_GRADE_62.Name = "DIA_SEMANA_GRADE_62";
            this.DIA_SEMANA_GRADE_62.ReadOnly = true;
            this.DIA_SEMANA_GRADE_62.Visible = false;
            // 
            // CODIGO_DISCIPLINA_62
            // 
            this.CODIGO_DISCIPLINA_62.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_62.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_62.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_62.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_62.Name = "CODIGO_DISCIPLINA_62";
            this.CODIGO_DISCIPLINA_62.ReadOnly = true;
            this.CODIGO_DISCIPLINA_62.Width = 20;
            // 
            // CODIGO_TURMA_62
            // 
            this.CODIGO_TURMA_62.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_62.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_62.HeaderText = "Turma";
            this.CODIGO_TURMA_62.MinimumWidth = 20;
            this.CODIGO_TURMA_62.Name = "CODIGO_TURMA_62";
            this.CODIGO_TURMA_62.ReadOnly = true;
            // 
            // CODIGO_ESPACO_62
            // 
            this.CODIGO_ESPACO_62.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_62.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_62.HeaderText = "Sala";
            this.CODIGO_ESPACO_62.MinimumWidth = 20;
            this.CODIGO_ESPACO_62.Name = "CODIGO_ESPACO_62";
            this.CODIGO_ESPACO_62.ReadOnly = true;
            this.CODIGO_ESPACO_62.Width = 20;
            // 
            // CODIGO_PROFESSOR1_62
            // 
            this.CODIGO_PROFESSOR1_62.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_62.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_62.Name = "CODIGO_PROFESSOR1_62";
            this.CODIGO_PROFESSOR1_62.ReadOnly = true;
            this.CODIGO_PROFESSOR1_62.Visible = false;
            // 
            // CODIGO_PROFESSOR2_62
            // 
            this.CODIGO_PROFESSOR2_62.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_62.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_62.Name = "CODIGO_PROFESSOR2_62";
            this.CODIGO_PROFESSOR2_62.ReadOnly = true;
            this.CODIGO_PROFESSOR2_62.Visible = false;
            // 
            // CODIGO_PROFESSOR3_62
            // 
            this.CODIGO_PROFESSOR3_62.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_62.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_62.Name = "CODIGO_PROFESSOR3_62";
            this.CODIGO_PROFESSOR3_62.ReadOnly = true;
            this.CODIGO_PROFESSOR3_62.Visible = false;
            // 
            // grade63
            // 
            this.grade63.AllowUserToAddRows = false;
            this.grade63.AllowUserToDeleteRows = false;
            this.grade63.AllowUserToResizeColumns = false;
            this.grade63.AllowUserToResizeRows = false;
            this.grade63.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade63.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade63.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade63.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade63.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade63.ColumnHeadersVisible = false;
            this.grade63.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_63,
            this.DIA_SEMANA_GRADE_63,
            this.CODIGO_DISCIPLINA_63,
            this.CODIGO_TURMA_63,
            this.CODIGO_ESPACO_63,
            this.CODIGO_PROFESSOR1_63,
            this.CODIGO_PROFESSOR2_63,
            this.CODIGO_PROFESSOR3_63});
            this.grade63.ContextMenuStrip = this.menuContexto;
            this.grade63.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade63.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade63.Location = new System.Drawing.Point(574, 98);
            this.grade63.MultiSelect = false;
            this.grade63.Name = "grade63";
            this.grade63.ReadOnly = true;
            this.grade63.RowHeadersVisible = false;
            this.grade63.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade63.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade63.Size = new System.Drawing.Size(94, 27);
            this.grade63.TabIndex = 150;
            this.grade63.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade63.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade63.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_63
            // 
            this.HORARIO_GRADE_63.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_63.HeaderText = "HORARIO_GRADE_63";
            this.HORARIO_GRADE_63.Name = "HORARIO_GRADE_63";
            this.HORARIO_GRADE_63.ReadOnly = true;
            this.HORARIO_GRADE_63.Visible = false;
            // 
            // DIA_SEMANA_GRADE_63
            // 
            this.DIA_SEMANA_GRADE_63.HeaderText = "DIA_SEMANA_GRADE_63";
            this.DIA_SEMANA_GRADE_63.Name = "DIA_SEMANA_GRADE_63";
            this.DIA_SEMANA_GRADE_63.ReadOnly = true;
            this.DIA_SEMANA_GRADE_63.Visible = false;
            // 
            // CODIGO_DISCIPLINA_63
            // 
            this.CODIGO_DISCIPLINA_63.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_63.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_63.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_63.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_63.Name = "CODIGO_DISCIPLINA_63";
            this.CODIGO_DISCIPLINA_63.ReadOnly = true;
            this.CODIGO_DISCIPLINA_63.Width = 20;
            // 
            // CODIGO_TURMA_63
            // 
            this.CODIGO_TURMA_63.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_63.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_63.HeaderText = "Turma";
            this.CODIGO_TURMA_63.MinimumWidth = 20;
            this.CODIGO_TURMA_63.Name = "CODIGO_TURMA_63";
            this.CODIGO_TURMA_63.ReadOnly = true;
            // 
            // CODIGO_ESPACO_63
            // 
            this.CODIGO_ESPACO_63.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_63.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_63.HeaderText = "Sala";
            this.CODIGO_ESPACO_63.MinimumWidth = 20;
            this.CODIGO_ESPACO_63.Name = "CODIGO_ESPACO_63";
            this.CODIGO_ESPACO_63.ReadOnly = true;
            this.CODIGO_ESPACO_63.Width = 20;
            // 
            // CODIGO_PROFESSOR1_63
            // 
            this.CODIGO_PROFESSOR1_63.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_63.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_63.Name = "CODIGO_PROFESSOR1_63";
            this.CODIGO_PROFESSOR1_63.ReadOnly = true;
            this.CODIGO_PROFESSOR1_63.Visible = false;
            // 
            // CODIGO_PROFESSOR2_63
            // 
            this.CODIGO_PROFESSOR2_63.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_63.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_63.Name = "CODIGO_PROFESSOR2_63";
            this.CODIGO_PROFESSOR2_63.ReadOnly = true;
            this.CODIGO_PROFESSOR2_63.Visible = false;
            // 
            // CODIGO_PROFESSOR3_63
            // 
            this.CODIGO_PROFESSOR3_63.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_63.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_63.Name = "CODIGO_PROFESSOR3_63";
            this.CODIGO_PROFESSOR3_63.ReadOnly = true;
            this.CODIGO_PROFESSOR3_63.Visible = false;
            // 
            // grade64
            // 
            this.grade64.AllowUserToAddRows = false;
            this.grade64.AllowUserToDeleteRows = false;
            this.grade64.AllowUserToResizeColumns = false;
            this.grade64.AllowUserToResizeRows = false;
            this.grade64.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade64.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade64.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade64.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade64.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade64.ColumnHeadersVisible = false;
            this.grade64.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_64,
            this.DIA_SEMANA_GRADE_64,
            this.CODIGO_DISCIPLINA_64,
            this.CODIGO_TURMA_64,
            this.CODIGO_ESPACO_64,
            this.CODIGO_PROFESSOR1_64,
            this.CODIGO_PROFESSOR2_64,
            this.CODIGO_PROFESSOR3_64});
            this.grade64.ContextMenuStrip = this.menuContexto;
            this.grade64.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade64.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade64.Location = new System.Drawing.Point(574, 132);
            this.grade64.MultiSelect = false;
            this.grade64.Name = "grade64";
            this.grade64.ReadOnly = true;
            this.grade64.RowHeadersVisible = false;
            this.grade64.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade64.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade64.Size = new System.Drawing.Size(94, 27);
            this.grade64.TabIndex = 150;
            this.grade64.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade64.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade64.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_64
            // 
            this.HORARIO_GRADE_64.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_64.HeaderText = "HORARIO_GRADE_64";
            this.HORARIO_GRADE_64.Name = "HORARIO_GRADE_64";
            this.HORARIO_GRADE_64.ReadOnly = true;
            this.HORARIO_GRADE_64.Visible = false;
            // 
            // DIA_SEMANA_GRADE_64
            // 
            this.DIA_SEMANA_GRADE_64.HeaderText = "DIA_SEMANA_GRADE_64";
            this.DIA_SEMANA_GRADE_64.Name = "DIA_SEMANA_GRADE_64";
            this.DIA_SEMANA_GRADE_64.ReadOnly = true;
            this.DIA_SEMANA_GRADE_64.Visible = false;
            // 
            // CODIGO_DISCIPLINA_64
            // 
            this.CODIGO_DISCIPLINA_64.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_64.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_64.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_64.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_64.Name = "CODIGO_DISCIPLINA_64";
            this.CODIGO_DISCIPLINA_64.ReadOnly = true;
            this.CODIGO_DISCIPLINA_64.Width = 20;
            // 
            // CODIGO_TURMA_64
            // 
            this.CODIGO_TURMA_64.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_64.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_64.HeaderText = "Turma";
            this.CODIGO_TURMA_64.MinimumWidth = 20;
            this.CODIGO_TURMA_64.Name = "CODIGO_TURMA_64";
            this.CODIGO_TURMA_64.ReadOnly = true;
            // 
            // CODIGO_ESPACO_64
            // 
            this.CODIGO_ESPACO_64.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_64.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_64.HeaderText = "Sala";
            this.CODIGO_ESPACO_64.MinimumWidth = 20;
            this.CODIGO_ESPACO_64.Name = "CODIGO_ESPACO_64";
            this.CODIGO_ESPACO_64.ReadOnly = true;
            this.CODIGO_ESPACO_64.Width = 20;
            // 
            // CODIGO_PROFESSOR1_64
            // 
            this.CODIGO_PROFESSOR1_64.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_64.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_64.Name = "CODIGO_PROFESSOR1_64";
            this.CODIGO_PROFESSOR1_64.ReadOnly = true;
            this.CODIGO_PROFESSOR1_64.Visible = false;
            // 
            // CODIGO_PROFESSOR2_64
            // 
            this.CODIGO_PROFESSOR2_64.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_64.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_64.Name = "CODIGO_PROFESSOR2_64";
            this.CODIGO_PROFESSOR2_64.ReadOnly = true;
            this.CODIGO_PROFESSOR2_64.Visible = false;
            // 
            // CODIGO_PROFESSOR3_64
            // 
            this.CODIGO_PROFESSOR3_64.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_64.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_64.Name = "CODIGO_PROFESSOR3_64";
            this.CODIGO_PROFESSOR3_64.ReadOnly = true;
            this.CODIGO_PROFESSOR3_64.Visible = false;
            // 
            // grade65
            // 
            this.grade65.AllowUserToAddRows = false;
            this.grade65.AllowUserToDeleteRows = false;
            this.grade65.AllowUserToResizeColumns = false;
            this.grade65.AllowUserToResizeRows = false;
            this.grade65.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade65.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade65.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade65.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade65.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade65.ColumnHeadersVisible = false;
            this.grade65.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_65,
            this.DIA_SEMANA_GRADE_65,
            this.CODIGO_DISCIPLINA_65,
            this.CODIGO_TURMA_65,
            this.CODIGO_ESPACO_65,
            this.CODIGO_PROFESSOR1_65,
            this.CODIGO_PROFESSOR2_65,
            this.CODIGO_PROFESSOR3_65});
            this.grade65.ContextMenuStrip = this.menuContexto;
            this.grade65.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade65.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade65.Location = new System.Drawing.Point(574, 166);
            this.grade65.MultiSelect = false;
            this.grade65.Name = "grade65";
            this.grade65.ReadOnly = true;
            this.grade65.RowHeadersVisible = false;
            this.grade65.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade65.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade65.Size = new System.Drawing.Size(94, 27);
            this.grade65.TabIndex = 150;
            this.grade65.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade65.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade65.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_65
            // 
            this.HORARIO_GRADE_65.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_65.HeaderText = "HORARIO_GRADE_65";
            this.HORARIO_GRADE_65.Name = "HORARIO_GRADE_65";
            this.HORARIO_GRADE_65.ReadOnly = true;
            this.HORARIO_GRADE_65.Visible = false;
            // 
            // DIA_SEMANA_GRADE_65
            // 
            this.DIA_SEMANA_GRADE_65.HeaderText = "DIA_SEMANA_GRADE_65";
            this.DIA_SEMANA_GRADE_65.Name = "DIA_SEMANA_GRADE_65";
            this.DIA_SEMANA_GRADE_65.ReadOnly = true;
            this.DIA_SEMANA_GRADE_65.Visible = false;
            // 
            // CODIGO_DISCIPLINA_65
            // 
            this.CODIGO_DISCIPLINA_65.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_65.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_65.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_65.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_65.Name = "CODIGO_DISCIPLINA_65";
            this.CODIGO_DISCIPLINA_65.ReadOnly = true;
            this.CODIGO_DISCIPLINA_65.Width = 20;
            // 
            // CODIGO_TURMA_65
            // 
            this.CODIGO_TURMA_65.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_65.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_65.HeaderText = "Turma";
            this.CODIGO_TURMA_65.MinimumWidth = 20;
            this.CODIGO_TURMA_65.Name = "CODIGO_TURMA_65";
            this.CODIGO_TURMA_65.ReadOnly = true;
            // 
            // CODIGO_ESPACO_65
            // 
            this.CODIGO_ESPACO_65.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_65.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_65.HeaderText = "Sala";
            this.CODIGO_ESPACO_65.MinimumWidth = 20;
            this.CODIGO_ESPACO_65.Name = "CODIGO_ESPACO_65";
            this.CODIGO_ESPACO_65.ReadOnly = true;
            this.CODIGO_ESPACO_65.Width = 20;
            // 
            // CODIGO_PROFESSOR1_65
            // 
            this.CODIGO_PROFESSOR1_65.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_65.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_65.Name = "CODIGO_PROFESSOR1_65";
            this.CODIGO_PROFESSOR1_65.ReadOnly = true;
            this.CODIGO_PROFESSOR1_65.Visible = false;
            // 
            // CODIGO_PROFESSOR2_65
            // 
            this.CODIGO_PROFESSOR2_65.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_65.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_65.Name = "CODIGO_PROFESSOR2_65";
            this.CODIGO_PROFESSOR2_65.ReadOnly = true;
            this.CODIGO_PROFESSOR2_65.Visible = false;
            // 
            // CODIGO_PROFESSOR3_65
            // 
            this.CODIGO_PROFESSOR3_65.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_65.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_65.Name = "CODIGO_PROFESSOR3_65";
            this.CODIGO_PROFESSOR3_65.ReadOnly = true;
            this.CODIGO_PROFESSOR3_65.Visible = false;
            // 
            // grade66
            // 
            this.grade66.AllowUserToAddRows = false;
            this.grade66.AllowUserToDeleteRows = false;
            this.grade66.AllowUserToResizeColumns = false;
            this.grade66.AllowUserToResizeRows = false;
            this.grade66.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade66.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade66.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade66.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade66.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade66.ColumnHeadersVisible = false;
            this.grade66.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_66,
            this.DIA_SEMANA_GRADE_66,
            this.CODIGO_DISCIPLINA_66,
            this.CODIGO_TURMA_66,
            this.CODIGO_ESPACO_66,
            this.CODIGO_PROFESSOR1_66,
            this.CODIGO_PROFESSOR2_66,
            this.CODIGO_PROFESSOR3_66});
            this.grade66.ContextMenuStrip = this.menuContexto;
            this.grade66.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade66.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade66.Location = new System.Drawing.Point(574, 200);
            this.grade66.MultiSelect = false;
            this.grade66.Name = "grade66";
            this.grade66.ReadOnly = true;
            this.grade66.RowHeadersVisible = false;
            this.grade66.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade66.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade66.Size = new System.Drawing.Size(94, 27);
            this.grade66.TabIndex = 150;
            this.grade66.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade66.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade66.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_66
            // 
            this.HORARIO_GRADE_66.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_66.HeaderText = "HORARIO_GRADE_66";
            this.HORARIO_GRADE_66.Name = "HORARIO_GRADE_66";
            this.HORARIO_GRADE_66.ReadOnly = true;
            this.HORARIO_GRADE_66.Visible = false;
            // 
            // DIA_SEMANA_GRADE_66
            // 
            this.DIA_SEMANA_GRADE_66.HeaderText = "DIA_SEMANA_GRADE_66";
            this.DIA_SEMANA_GRADE_66.Name = "DIA_SEMANA_GRADE_66";
            this.DIA_SEMANA_GRADE_66.ReadOnly = true;
            this.DIA_SEMANA_GRADE_66.Visible = false;
            // 
            // CODIGO_DISCIPLINA_66
            // 
            this.CODIGO_DISCIPLINA_66.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_66.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_66.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_66.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_66.Name = "CODIGO_DISCIPLINA_66";
            this.CODIGO_DISCIPLINA_66.ReadOnly = true;
            this.CODIGO_DISCIPLINA_66.Width = 20;
            // 
            // CODIGO_TURMA_66
            // 
            this.CODIGO_TURMA_66.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_66.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_66.HeaderText = "Turma";
            this.CODIGO_TURMA_66.MinimumWidth = 20;
            this.CODIGO_TURMA_66.Name = "CODIGO_TURMA_66";
            this.CODIGO_TURMA_66.ReadOnly = true;
            // 
            // CODIGO_ESPACO_66
            // 
            this.CODIGO_ESPACO_66.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_66.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_66.HeaderText = "Sala";
            this.CODIGO_ESPACO_66.MinimumWidth = 20;
            this.CODIGO_ESPACO_66.Name = "CODIGO_ESPACO_66";
            this.CODIGO_ESPACO_66.ReadOnly = true;
            this.CODIGO_ESPACO_66.Width = 20;
            // 
            // CODIGO_PROFESSOR1_66
            // 
            this.CODIGO_PROFESSOR1_66.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_66.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_66.Name = "CODIGO_PROFESSOR1_66";
            this.CODIGO_PROFESSOR1_66.ReadOnly = true;
            this.CODIGO_PROFESSOR1_66.Visible = false;
            // 
            // CODIGO_PROFESSOR2_66
            // 
            this.CODIGO_PROFESSOR2_66.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_66.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_66.Name = "CODIGO_PROFESSOR2_66";
            this.CODIGO_PROFESSOR2_66.ReadOnly = true;
            this.CODIGO_PROFESSOR2_66.Visible = false;
            // 
            // CODIGO_PROFESSOR3_66
            // 
            this.CODIGO_PROFESSOR3_66.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_66.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_66.Name = "CODIGO_PROFESSOR3_66";
            this.CODIGO_PROFESSOR3_66.ReadOnly = true;
            this.CODIGO_PROFESSOR3_66.Visible = false;
            // 
            // grade67
            // 
            this.grade67.AllowUserToAddRows = false;
            this.grade67.AllowUserToDeleteRows = false;
            this.grade67.AllowUserToResizeColumns = false;
            this.grade67.AllowUserToResizeRows = false;
            this.grade67.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade67.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade67.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade67.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade67.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade67.ColumnHeadersVisible = false;
            this.grade67.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_67,
            this.DIA_SEMANA_GRADE_67,
            this.CODIGO_DISCIPLINA_67,
            this.CODIGO_TURMA_67,
            this.CODIGO_ESPACO_67,
            this.CODIGO_PROFESSOR1_67,
            this.CODIGO_PROFESSOR2_67,
            this.CODIGO_PROFESSOR3_67});
            this.grade67.ContextMenuStrip = this.menuContexto;
            this.grade67.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade67.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade67.Location = new System.Drawing.Point(574, 234);
            this.grade67.MultiSelect = false;
            this.grade67.Name = "grade67";
            this.grade67.ReadOnly = true;
            this.grade67.RowHeadersVisible = false;
            this.grade67.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade67.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade67.Size = new System.Drawing.Size(94, 27);
            this.grade67.TabIndex = 150;
            this.grade67.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade67.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade67.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_67
            // 
            this.HORARIO_GRADE_67.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_67.HeaderText = "HORARIO_GRADE_67";
            this.HORARIO_GRADE_67.Name = "HORARIO_GRADE_67";
            this.HORARIO_GRADE_67.ReadOnly = true;
            this.HORARIO_GRADE_67.Visible = false;
            // 
            // DIA_SEMANA_GRADE_67
            // 
            this.DIA_SEMANA_GRADE_67.HeaderText = "DIA_SEMANA_GRADE_67";
            this.DIA_SEMANA_GRADE_67.Name = "DIA_SEMANA_GRADE_67";
            this.DIA_SEMANA_GRADE_67.ReadOnly = true;
            this.DIA_SEMANA_GRADE_67.Visible = false;
            // 
            // CODIGO_DISCIPLINA_67
            // 
            this.CODIGO_DISCIPLINA_67.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_67.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_67.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_67.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_67.Name = "CODIGO_DISCIPLINA_67";
            this.CODIGO_DISCIPLINA_67.ReadOnly = true;
            this.CODIGO_DISCIPLINA_67.Width = 20;
            // 
            // CODIGO_TURMA_67
            // 
            this.CODIGO_TURMA_67.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_67.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_67.HeaderText = "Turma";
            this.CODIGO_TURMA_67.MinimumWidth = 20;
            this.CODIGO_TURMA_67.Name = "CODIGO_TURMA_67";
            this.CODIGO_TURMA_67.ReadOnly = true;
            // 
            // CODIGO_ESPACO_67
            // 
            this.CODIGO_ESPACO_67.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_67.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_67.HeaderText = "Sala";
            this.CODIGO_ESPACO_67.MinimumWidth = 20;
            this.CODIGO_ESPACO_67.Name = "CODIGO_ESPACO_67";
            this.CODIGO_ESPACO_67.ReadOnly = true;
            this.CODIGO_ESPACO_67.Width = 20;
            // 
            // CODIGO_PROFESSOR1_67
            // 
            this.CODIGO_PROFESSOR1_67.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_67.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_67.Name = "CODIGO_PROFESSOR1_67";
            this.CODIGO_PROFESSOR1_67.ReadOnly = true;
            this.CODIGO_PROFESSOR1_67.Visible = false;
            // 
            // CODIGO_PROFESSOR2_67
            // 
            this.CODIGO_PROFESSOR2_67.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_67.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_67.Name = "CODIGO_PROFESSOR2_67";
            this.CODIGO_PROFESSOR2_67.ReadOnly = true;
            this.CODIGO_PROFESSOR2_67.Visible = false;
            // 
            // CODIGO_PROFESSOR3_67
            // 
            this.CODIGO_PROFESSOR3_67.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_67.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_67.Name = "CODIGO_PROFESSOR3_67";
            this.CODIGO_PROFESSOR3_67.ReadOnly = true;
            this.CODIGO_PROFESSOR3_67.Visible = false;
            // 
            // grade68
            // 
            this.grade68.AllowUserToAddRows = false;
            this.grade68.AllowUserToDeleteRows = false;
            this.grade68.AllowUserToResizeColumns = false;
            this.grade68.AllowUserToResizeRows = false;
            this.grade68.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade68.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade68.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade68.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade68.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade68.ColumnHeadersVisible = false;
            this.grade68.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_68,
            this.DIA_SEMANA_GRADE_68,
            this.CODIGO_DISCIPLINA_68,
            this.CODIGO_TURMA_68,
            this.CODIGO_ESPACO_68,
            this.CODIGO_PROFESSOR1_68,
            this.CODIGO_PROFESSOR2_68,
            this.CODIGO_PROFESSOR3_68});
            this.grade68.ContextMenuStrip = this.menuContexto;
            this.grade68.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade68.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade68.Location = new System.Drawing.Point(574, 268);
            this.grade68.MultiSelect = false;
            this.grade68.Name = "grade68";
            this.grade68.ReadOnly = true;
            this.grade68.RowHeadersVisible = false;
            this.grade68.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade68.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade68.Size = new System.Drawing.Size(94, 27);
            this.grade68.TabIndex = 150;
            this.grade68.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade68.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade68.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_68
            // 
            this.HORARIO_GRADE_68.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_68.HeaderText = "HORARIO_GRADE_68";
            this.HORARIO_GRADE_68.Name = "HORARIO_GRADE_68";
            this.HORARIO_GRADE_68.ReadOnly = true;
            this.HORARIO_GRADE_68.Visible = false;
            // 
            // DIA_SEMANA_GRADE_68
            // 
            this.DIA_SEMANA_GRADE_68.HeaderText = "DIA_SEMANA_GRADE_68";
            this.DIA_SEMANA_GRADE_68.Name = "DIA_SEMANA_GRADE_68";
            this.DIA_SEMANA_GRADE_68.ReadOnly = true;
            this.DIA_SEMANA_GRADE_68.Visible = false;
            // 
            // CODIGO_DISCIPLINA_68
            // 
            this.CODIGO_DISCIPLINA_68.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_68.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_68.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_68.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_68.Name = "CODIGO_DISCIPLINA_68";
            this.CODIGO_DISCIPLINA_68.ReadOnly = true;
            this.CODIGO_DISCIPLINA_68.Width = 20;
            // 
            // CODIGO_TURMA_68
            // 
            this.CODIGO_TURMA_68.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_68.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_68.HeaderText = "Turma";
            this.CODIGO_TURMA_68.MinimumWidth = 20;
            this.CODIGO_TURMA_68.Name = "CODIGO_TURMA_68";
            this.CODIGO_TURMA_68.ReadOnly = true;
            // 
            // CODIGO_ESPACO_68
            // 
            this.CODIGO_ESPACO_68.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_68.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_68.HeaderText = "Sala";
            this.CODIGO_ESPACO_68.MinimumWidth = 20;
            this.CODIGO_ESPACO_68.Name = "CODIGO_ESPACO_68";
            this.CODIGO_ESPACO_68.ReadOnly = true;
            this.CODIGO_ESPACO_68.Width = 20;
            // 
            // CODIGO_PROFESSOR1_68
            // 
            this.CODIGO_PROFESSOR1_68.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_68.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_68.Name = "CODIGO_PROFESSOR1_68";
            this.CODIGO_PROFESSOR1_68.ReadOnly = true;
            this.CODIGO_PROFESSOR1_68.Visible = false;
            // 
            // CODIGO_PROFESSOR2_68
            // 
            this.CODIGO_PROFESSOR2_68.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_68.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_68.Name = "CODIGO_PROFESSOR2_68";
            this.CODIGO_PROFESSOR2_68.ReadOnly = true;
            this.CODIGO_PROFESSOR2_68.Visible = false;
            // 
            // CODIGO_PROFESSOR3_68
            // 
            this.CODIGO_PROFESSOR3_68.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_68.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_68.Name = "CODIGO_PROFESSOR3_68";
            this.CODIGO_PROFESSOR3_68.ReadOnly = true;
            this.CODIGO_PROFESSOR3_68.Visible = false;
            // 
            // grade69
            // 
            this.grade69.AllowUserToAddRows = false;
            this.grade69.AllowUserToDeleteRows = false;
            this.grade69.AllowUserToResizeColumns = false;
            this.grade69.AllowUserToResizeRows = false;
            this.grade69.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade69.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade69.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade69.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade69.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade69.ColumnHeadersVisible = false;
            this.grade69.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_69,
            this.DIA_SEMANA_GRADE_69,
            this.CODIGO_DISCIPLINA_69,
            this.CODIGO_TURMA_69,
            this.CODIGO_ESPACO_69,
            this.CODIGO_PROFESSOR1_69,
            this.CODIGO_PROFESSOR2_69,
            this.CODIGO_PROFESSOR3_69});
            this.grade69.ContextMenuStrip = this.menuContexto;
            this.grade69.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade69.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade69.Location = new System.Drawing.Point(574, 302);
            this.grade69.MultiSelect = false;
            this.grade69.Name = "grade69";
            this.grade69.ReadOnly = true;
            this.grade69.RowHeadersVisible = false;
            this.grade69.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade69.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade69.Size = new System.Drawing.Size(94, 27);
            this.grade69.TabIndex = 150;
            this.grade69.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade69.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade69.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_69
            // 
            this.HORARIO_GRADE_69.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_69.HeaderText = "HORARIO_GRADE_69";
            this.HORARIO_GRADE_69.Name = "HORARIO_GRADE_69";
            this.HORARIO_GRADE_69.ReadOnly = true;
            this.HORARIO_GRADE_69.Visible = false;
            // 
            // DIA_SEMANA_GRADE_69
            // 
            this.DIA_SEMANA_GRADE_69.HeaderText = "DIA_SEMANA_GRADE_69";
            this.DIA_SEMANA_GRADE_69.Name = "DIA_SEMANA_GRADE_69";
            this.DIA_SEMANA_GRADE_69.ReadOnly = true;
            this.DIA_SEMANA_GRADE_69.Visible = false;
            // 
            // CODIGO_DISCIPLINA_69
            // 
            this.CODIGO_DISCIPLINA_69.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_69.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_69.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_69.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_69.Name = "CODIGO_DISCIPLINA_69";
            this.CODIGO_DISCIPLINA_69.ReadOnly = true;
            this.CODIGO_DISCIPLINA_69.Width = 20;
            // 
            // CODIGO_TURMA_69
            // 
            this.CODIGO_TURMA_69.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_69.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_69.HeaderText = "Turma";
            this.CODIGO_TURMA_69.MinimumWidth = 20;
            this.CODIGO_TURMA_69.Name = "CODIGO_TURMA_69";
            this.CODIGO_TURMA_69.ReadOnly = true;
            // 
            // CODIGO_ESPACO_69
            // 
            this.CODIGO_ESPACO_69.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_69.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_69.HeaderText = "Sala";
            this.CODIGO_ESPACO_69.MinimumWidth = 20;
            this.CODIGO_ESPACO_69.Name = "CODIGO_ESPACO_69";
            this.CODIGO_ESPACO_69.ReadOnly = true;
            this.CODIGO_ESPACO_69.Width = 20;
            // 
            // CODIGO_PROFESSOR1_69
            // 
            this.CODIGO_PROFESSOR1_69.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_69.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_69.Name = "CODIGO_PROFESSOR1_69";
            this.CODIGO_PROFESSOR1_69.ReadOnly = true;
            this.CODIGO_PROFESSOR1_69.Visible = false;
            // 
            // CODIGO_PROFESSOR2_69
            // 
            this.CODIGO_PROFESSOR2_69.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_69.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_69.Name = "CODIGO_PROFESSOR2_69";
            this.CODIGO_PROFESSOR2_69.ReadOnly = true;
            this.CODIGO_PROFESSOR2_69.Visible = false;
            // 
            // CODIGO_PROFESSOR3_69
            // 
            this.CODIGO_PROFESSOR3_69.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_69.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_69.Name = "CODIGO_PROFESSOR3_69";
            this.CODIGO_PROFESSOR3_69.ReadOnly = true;
            this.CODIGO_PROFESSOR3_69.Visible = false;
            // 
            // grade610
            // 
            this.grade610.AllowUserToAddRows = false;
            this.grade610.AllowUserToDeleteRows = false;
            this.grade610.AllowUserToResizeColumns = false;
            this.grade610.AllowUserToResizeRows = false;
            this.grade610.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade610.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade610.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade610.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade610.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade610.ColumnHeadersVisible = false;
            this.grade610.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_610,
            this.DIA_SEMANA_GRADE_610,
            this.CODIGO_DISCIPLINA_610,
            this.CODIGO_TURMA_610,
            this.CODIGO_ESPACO_610,
            this.CODIGO_PROFESSOR1_610,
            this.CODIGO_PROFESSOR2_610,
            this.CODIGO_PROFESSOR3_610});
            this.grade610.ContextMenuStrip = this.menuContexto;
            this.grade610.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade610.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade610.Location = new System.Drawing.Point(574, 336);
            this.grade610.MultiSelect = false;
            this.grade610.Name = "grade610";
            this.grade610.ReadOnly = true;
            this.grade610.RowHeadersVisible = false;
            this.grade610.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade610.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade610.Size = new System.Drawing.Size(94, 27);
            this.grade610.TabIndex = 150;
            this.grade610.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade610.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade610.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_610
            // 
            this.HORARIO_GRADE_610.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_610.HeaderText = "HORARIO_GRADE_610";
            this.HORARIO_GRADE_610.Name = "HORARIO_GRADE_610";
            this.HORARIO_GRADE_610.ReadOnly = true;
            this.HORARIO_GRADE_610.Visible = false;
            // 
            // DIA_SEMANA_GRADE_610
            // 
            this.DIA_SEMANA_GRADE_610.HeaderText = "DIA_SEMANA_GRADE_610";
            this.DIA_SEMANA_GRADE_610.Name = "DIA_SEMANA_GRADE_610";
            this.DIA_SEMANA_GRADE_610.ReadOnly = true;
            this.DIA_SEMANA_GRADE_610.Visible = false;
            // 
            // CODIGO_DISCIPLINA_610
            // 
            this.CODIGO_DISCIPLINA_610.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_610.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_610.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_610.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_610.Name = "CODIGO_DISCIPLINA_610";
            this.CODIGO_DISCIPLINA_610.ReadOnly = true;
            this.CODIGO_DISCIPLINA_610.Width = 20;
            // 
            // CODIGO_TURMA_610
            // 
            this.CODIGO_TURMA_610.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_610.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_610.HeaderText = "Turma";
            this.CODIGO_TURMA_610.MinimumWidth = 20;
            this.CODIGO_TURMA_610.Name = "CODIGO_TURMA_610";
            this.CODIGO_TURMA_610.ReadOnly = true;
            // 
            // CODIGO_ESPACO_610
            // 
            this.CODIGO_ESPACO_610.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_610.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_610.HeaderText = "Sala";
            this.CODIGO_ESPACO_610.MinimumWidth = 20;
            this.CODIGO_ESPACO_610.Name = "CODIGO_ESPACO_610";
            this.CODIGO_ESPACO_610.ReadOnly = true;
            this.CODIGO_ESPACO_610.Width = 20;
            // 
            // CODIGO_PROFESSOR1_610
            // 
            this.CODIGO_PROFESSOR1_610.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_610.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_610.Name = "CODIGO_PROFESSOR1_610";
            this.CODIGO_PROFESSOR1_610.ReadOnly = true;
            this.CODIGO_PROFESSOR1_610.Visible = false;
            // 
            // CODIGO_PROFESSOR2_610
            // 
            this.CODIGO_PROFESSOR2_610.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_610.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_610.Name = "CODIGO_PROFESSOR2_610";
            this.CODIGO_PROFESSOR2_610.ReadOnly = true;
            this.CODIGO_PROFESSOR2_610.Visible = false;
            // 
            // CODIGO_PROFESSOR3_610
            // 
            this.CODIGO_PROFESSOR3_610.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_610.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_610.Name = "CODIGO_PROFESSOR3_610";
            this.CODIGO_PROFESSOR3_610.ReadOnly = true;
            this.CODIGO_PROFESSOR3_610.Visible = false;
            // 
            // grade611
            // 
            this.grade611.AllowUserToAddRows = false;
            this.grade611.AllowUserToDeleteRows = false;
            this.grade611.AllowUserToResizeColumns = false;
            this.grade611.AllowUserToResizeRows = false;
            this.grade611.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade611.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade611.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade611.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade611.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade611.ColumnHeadersVisible = false;
            this.grade611.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_611,
            this.DIA_SEMANA_GRADE_611,
            this.CODIGO_DISCIPLINA_611,
            this.CODIGO_TURMA_611,
            this.CODIGO_ESPACO_611,
            this.CODIGO_PROFESSOR1_611,
            this.CODIGO_PROFESSOR2_611,
            this.CODIGO_PROFESSOR3_611});
            this.grade611.ContextMenuStrip = this.menuContexto;
            this.grade611.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade611.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade611.Location = new System.Drawing.Point(574, 370);
            this.grade611.MultiSelect = false;
            this.grade611.Name = "grade611";
            this.grade611.ReadOnly = true;
            this.grade611.RowHeadersVisible = false;
            this.grade611.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade611.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade611.Size = new System.Drawing.Size(94, 27);
            this.grade611.TabIndex = 150;
            this.grade611.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade611.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade611.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_611
            // 
            this.HORARIO_GRADE_611.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_611.HeaderText = "HORARIO_GRADE_611";
            this.HORARIO_GRADE_611.Name = "HORARIO_GRADE_611";
            this.HORARIO_GRADE_611.ReadOnly = true;
            this.HORARIO_GRADE_611.Visible = false;
            // 
            // DIA_SEMANA_GRADE_611
            // 
            this.DIA_SEMANA_GRADE_611.HeaderText = "DIA_SEMANA_GRADE_611";
            this.DIA_SEMANA_GRADE_611.Name = "DIA_SEMANA_GRADE_611";
            this.DIA_SEMANA_GRADE_611.ReadOnly = true;
            this.DIA_SEMANA_GRADE_611.Visible = false;
            // 
            // CODIGO_DISCIPLINA_611
            // 
            this.CODIGO_DISCIPLINA_611.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_611.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_611.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_611.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_611.Name = "CODIGO_DISCIPLINA_611";
            this.CODIGO_DISCIPLINA_611.ReadOnly = true;
            this.CODIGO_DISCIPLINA_611.Width = 20;
            // 
            // CODIGO_TURMA_611
            // 
            this.CODIGO_TURMA_611.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_611.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_611.HeaderText = "Turma";
            this.CODIGO_TURMA_611.MinimumWidth = 20;
            this.CODIGO_TURMA_611.Name = "CODIGO_TURMA_611";
            this.CODIGO_TURMA_611.ReadOnly = true;
            // 
            // CODIGO_ESPACO_611
            // 
            this.CODIGO_ESPACO_611.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_611.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_611.HeaderText = "Sala";
            this.CODIGO_ESPACO_611.MinimumWidth = 20;
            this.CODIGO_ESPACO_611.Name = "CODIGO_ESPACO_611";
            this.CODIGO_ESPACO_611.ReadOnly = true;
            this.CODIGO_ESPACO_611.Width = 20;
            // 
            // CODIGO_PROFESSOR1_611
            // 
            this.CODIGO_PROFESSOR1_611.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_611.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_611.Name = "CODIGO_PROFESSOR1_611";
            this.CODIGO_PROFESSOR1_611.ReadOnly = true;
            this.CODIGO_PROFESSOR1_611.Visible = false;
            // 
            // CODIGO_PROFESSOR2_611
            // 
            this.CODIGO_PROFESSOR2_611.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_611.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_611.Name = "CODIGO_PROFESSOR2_611";
            this.CODIGO_PROFESSOR2_611.ReadOnly = true;
            this.CODIGO_PROFESSOR2_611.Visible = false;
            // 
            // CODIGO_PROFESSOR3_611
            // 
            this.CODIGO_PROFESSOR3_611.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_611.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_611.Name = "CODIGO_PROFESSOR3_611";
            this.CODIGO_PROFESSOR3_611.ReadOnly = true;
            this.CODIGO_PROFESSOR3_611.Visible = false;
            // 
            // grade612
            // 
            this.grade612.AllowUserToAddRows = false;
            this.grade612.AllowUserToDeleteRows = false;
            this.grade612.AllowUserToResizeColumns = false;
            this.grade612.AllowUserToResizeRows = false;
            this.grade612.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade612.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade612.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade612.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade612.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade612.ColumnHeadersVisible = false;
            this.grade612.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_612,
            this.DIA_SEMANA_GRADE_612,
            this.CODIGO_DISCIPLINA_612,
            this.CODIGO_TURMA_612,
            this.CODIGO_ESPACO_612,
            this.CODIGO_PROFESSOR1_612,
            this.CODIGO_PROFESSOR2_612,
            this.CODIGO_PROFESSOR3_612});
            this.grade612.ContextMenuStrip = this.menuContexto;
            this.grade612.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade612.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade612.Location = new System.Drawing.Point(574, 404);
            this.grade612.MultiSelect = false;
            this.grade612.Name = "grade612";
            this.grade612.ReadOnly = true;
            this.grade612.RowHeadersVisible = false;
            this.grade612.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade612.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade612.Size = new System.Drawing.Size(94, 27);
            this.grade612.TabIndex = 150;
            this.grade612.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade612.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade612.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_612
            // 
            this.HORARIO_GRADE_612.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_612.HeaderText = "HORARIO_GRADE_612";
            this.HORARIO_GRADE_612.Name = "HORARIO_GRADE_612";
            this.HORARIO_GRADE_612.ReadOnly = true;
            this.HORARIO_GRADE_612.Visible = false;
            // 
            // DIA_SEMANA_GRADE_612
            // 
            this.DIA_SEMANA_GRADE_612.HeaderText = "DIA_SEMANA_GRADE_612";
            this.DIA_SEMANA_GRADE_612.Name = "DIA_SEMANA_GRADE_612";
            this.DIA_SEMANA_GRADE_612.ReadOnly = true;
            this.DIA_SEMANA_GRADE_612.Visible = false;
            // 
            // CODIGO_DISCIPLINA_612
            // 
            this.CODIGO_DISCIPLINA_612.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_612.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_612.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_612.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_612.Name = "CODIGO_DISCIPLINA_612";
            this.CODIGO_DISCIPLINA_612.ReadOnly = true;
            this.CODIGO_DISCIPLINA_612.Width = 20;
            // 
            // CODIGO_TURMA_612
            // 
            this.CODIGO_TURMA_612.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_612.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_612.HeaderText = "Turma";
            this.CODIGO_TURMA_612.MinimumWidth = 20;
            this.CODIGO_TURMA_612.Name = "CODIGO_TURMA_612";
            this.CODIGO_TURMA_612.ReadOnly = true;
            // 
            // CODIGO_ESPACO_612
            // 
            this.CODIGO_ESPACO_612.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_612.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_612.HeaderText = "Sala";
            this.CODIGO_ESPACO_612.MinimumWidth = 20;
            this.CODIGO_ESPACO_612.Name = "CODIGO_ESPACO_612";
            this.CODIGO_ESPACO_612.ReadOnly = true;
            this.CODIGO_ESPACO_612.Width = 20;
            // 
            // CODIGO_PROFESSOR1_612
            // 
            this.CODIGO_PROFESSOR1_612.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_612.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_612.Name = "CODIGO_PROFESSOR1_612";
            this.CODIGO_PROFESSOR1_612.ReadOnly = true;
            this.CODIGO_PROFESSOR1_612.Visible = false;
            // 
            // CODIGO_PROFESSOR2_612
            // 
            this.CODIGO_PROFESSOR2_612.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_612.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_612.Name = "CODIGO_PROFESSOR2_612";
            this.CODIGO_PROFESSOR2_612.ReadOnly = true;
            this.CODIGO_PROFESSOR2_612.Visible = false;
            // 
            // CODIGO_PROFESSOR3_612
            // 
            this.CODIGO_PROFESSOR3_612.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_612.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_612.Name = "CODIGO_PROFESSOR3_612";
            this.CODIGO_PROFESSOR3_612.ReadOnly = true;
            this.CODIGO_PROFESSOR3_612.Visible = false;
            // 
            // grade613
            // 
            this.grade613.AllowUserToAddRows = false;
            this.grade613.AllowUserToDeleteRows = false;
            this.grade613.AllowUserToResizeColumns = false;
            this.grade613.AllowUserToResizeRows = false;
            this.grade613.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade613.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade613.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade613.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade613.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade613.ColumnHeadersVisible = false;
            this.grade613.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_613,
            this.DIA_SEMANA_GRADE_613,
            this.CODIGO_DISCIPLINA_613,
            this.CODIGO_TURMA_613,
            this.CODIGO_ESPACO_613,
            this.CODIGO_PROFESSOR1_613,
            this.CODIGO_PROFESSOR2_613,
            this.CODIGO_PROFESSOR3_613});
            this.grade613.ContextMenuStrip = this.menuContexto;
            this.grade613.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade613.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade613.Location = new System.Drawing.Point(574, 438);
            this.grade613.MultiSelect = false;
            this.grade613.Name = "grade613";
            this.grade613.ReadOnly = true;
            this.grade613.RowHeadersVisible = false;
            this.grade613.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade613.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade613.Size = new System.Drawing.Size(94, 27);
            this.grade613.TabIndex = 150;
            this.grade613.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade613.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade613.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_613
            // 
            this.HORARIO_GRADE_613.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_613.HeaderText = "HORARIO_GRADE_613";
            this.HORARIO_GRADE_613.Name = "HORARIO_GRADE_613";
            this.HORARIO_GRADE_613.ReadOnly = true;
            this.HORARIO_GRADE_613.Visible = false;
            // 
            // DIA_SEMANA_GRADE_613
            // 
            this.DIA_SEMANA_GRADE_613.HeaderText = "DIA_SEMANA_GRADE_613";
            this.DIA_SEMANA_GRADE_613.Name = "DIA_SEMANA_GRADE_613";
            this.DIA_SEMANA_GRADE_613.ReadOnly = true;
            this.DIA_SEMANA_GRADE_613.Visible = false;
            // 
            // CODIGO_DISCIPLINA_613
            // 
            this.CODIGO_DISCIPLINA_613.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_613.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_613.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_613.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_613.Name = "CODIGO_DISCIPLINA_613";
            this.CODIGO_DISCIPLINA_613.ReadOnly = true;
            this.CODIGO_DISCIPLINA_613.Width = 20;
            // 
            // CODIGO_TURMA_613
            // 
            this.CODIGO_TURMA_613.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_613.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_613.HeaderText = "Turma";
            this.CODIGO_TURMA_613.MinimumWidth = 20;
            this.CODIGO_TURMA_613.Name = "CODIGO_TURMA_613";
            this.CODIGO_TURMA_613.ReadOnly = true;
            // 
            // CODIGO_ESPACO_613
            // 
            this.CODIGO_ESPACO_613.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_613.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_613.HeaderText = "Sala";
            this.CODIGO_ESPACO_613.MinimumWidth = 20;
            this.CODIGO_ESPACO_613.Name = "CODIGO_ESPACO_613";
            this.CODIGO_ESPACO_613.ReadOnly = true;
            this.CODIGO_ESPACO_613.Width = 20;
            // 
            // CODIGO_PROFESSOR1_613
            // 
            this.CODIGO_PROFESSOR1_613.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_613.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_613.Name = "CODIGO_PROFESSOR1_613";
            this.CODIGO_PROFESSOR1_613.ReadOnly = true;
            this.CODIGO_PROFESSOR1_613.Visible = false;
            // 
            // CODIGO_PROFESSOR2_613
            // 
            this.CODIGO_PROFESSOR2_613.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_613.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_613.Name = "CODIGO_PROFESSOR2_613";
            this.CODIGO_PROFESSOR2_613.ReadOnly = true;
            this.CODIGO_PROFESSOR2_613.Visible = false;
            // 
            // CODIGO_PROFESSOR3_613
            // 
            this.CODIGO_PROFESSOR3_613.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_613.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_613.Name = "CODIGO_PROFESSOR3_613";
            this.CODIGO_PROFESSOR3_613.ReadOnly = true;
            this.CODIGO_PROFESSOR3_613.Visible = false;
            // 
            // grade614
            // 
            this.grade614.AllowUserToAddRows = false;
            this.grade614.AllowUserToDeleteRows = false;
            this.grade614.AllowUserToResizeColumns = false;
            this.grade614.AllowUserToResizeRows = false;
            this.grade614.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade614.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade614.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade614.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade614.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade614.ColumnHeadersVisible = false;
            this.grade614.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_614,
            this.DIA_SEMANA_GRADE_614,
            this.CODIGO_DISCIPLINA_614,
            this.CODIGO_TURMA_614,
            this.CODIGO_ESPACO_614,
            this.CODIGO_PROFESSOR1_614,
            this.CODIGO_PROFESSOR2_614,
            this.CODIGO_PROFESSOR3_614});
            this.grade614.ContextMenuStrip = this.menuContexto;
            this.grade614.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade614.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade614.Location = new System.Drawing.Point(574, 472);
            this.grade614.MultiSelect = false;
            this.grade614.Name = "grade614";
            this.grade614.ReadOnly = true;
            this.grade614.RowHeadersVisible = false;
            this.grade614.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade614.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade614.Size = new System.Drawing.Size(94, 28);
            this.grade614.TabIndex = 150;
            this.grade614.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade614.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade614.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_614
            // 
            this.HORARIO_GRADE_614.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_614.HeaderText = "HORARIO_GRADE_614";
            this.HORARIO_GRADE_614.Name = "HORARIO_GRADE_614";
            this.HORARIO_GRADE_614.ReadOnly = true;
            this.HORARIO_GRADE_614.Visible = false;
            // 
            // DIA_SEMANA_GRADE_614
            // 
            this.DIA_SEMANA_GRADE_614.HeaderText = "DIA_SEMANA_GRADE_614";
            this.DIA_SEMANA_GRADE_614.Name = "DIA_SEMANA_GRADE_614";
            this.DIA_SEMANA_GRADE_614.ReadOnly = true;
            this.DIA_SEMANA_GRADE_614.Visible = false;
            // 
            // CODIGO_DISCIPLINA_614
            // 
            this.CODIGO_DISCIPLINA_614.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_614.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_614.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_614.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_614.Name = "CODIGO_DISCIPLINA_614";
            this.CODIGO_DISCIPLINA_614.ReadOnly = true;
            this.CODIGO_DISCIPLINA_614.Width = 20;
            // 
            // CODIGO_TURMA_614
            // 
            this.CODIGO_TURMA_614.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_614.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_614.HeaderText = "Turma";
            this.CODIGO_TURMA_614.MinimumWidth = 20;
            this.CODIGO_TURMA_614.Name = "CODIGO_TURMA_614";
            this.CODIGO_TURMA_614.ReadOnly = true;
            // 
            // CODIGO_ESPACO_614
            // 
            this.CODIGO_ESPACO_614.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_614.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_614.HeaderText = "Sala";
            this.CODIGO_ESPACO_614.MinimumWidth = 20;
            this.CODIGO_ESPACO_614.Name = "CODIGO_ESPACO_614";
            this.CODIGO_ESPACO_614.ReadOnly = true;
            this.CODIGO_ESPACO_614.Width = 20;
            // 
            // CODIGO_PROFESSOR1_614
            // 
            this.CODIGO_PROFESSOR1_614.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_614.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_614.Name = "CODIGO_PROFESSOR1_614";
            this.CODIGO_PROFESSOR1_614.ReadOnly = true;
            this.CODIGO_PROFESSOR1_614.Visible = false;
            // 
            // CODIGO_PROFESSOR2_614
            // 
            this.CODIGO_PROFESSOR2_614.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_614.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_614.Name = "CODIGO_PROFESSOR2_614";
            this.CODIGO_PROFESSOR2_614.ReadOnly = true;
            this.CODIGO_PROFESSOR2_614.Visible = false;
            // 
            // CODIGO_PROFESSOR3_614
            // 
            this.CODIGO_PROFESSOR3_614.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_614.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_614.Name = "CODIGO_PROFESSOR3_614";
            this.CODIGO_PROFESSOR3_614.ReadOnly = true;
            this.CODIGO_PROFESSOR3_614.Visible = false;
            // 
            // grade11
            // 
            this.grade11.AllowUserToAddRows = false;
            this.grade11.AllowUserToDeleteRows = false;
            this.grade11.AllowUserToResizeColumns = false;
            this.grade11.AllowUserToResizeRows = false;
            this.grade11.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grade11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grade11.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grade11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade11.ColumnHeadersVisible = false;
            this.grade11.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIO_GRADE_11,
            this.DIA_SEMANA_GRADE_11,
            this.CODIGO_DISCIPLINA_11,
            this.CODIGO_TURMA_11,
            this.CODIGO_ESPACO_11,
            this.CODIGO_PROFESSOR1_11,
            this.CODIGO_PROFESSOR2_11,
            this.CODIGO_PROFESSOR3_11});
            this.grade11.ContextMenuStrip = this.menuContexto;
            this.grade11.DefaultCellStyle = dataGridViewCellStyle2;
            this.grade11.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grade11.Location = new System.Drawing.Point(94, 30);
            this.grade11.MultiSelect = false;
            this.grade11.Name = "grade11";
            this.grade11.ReadOnly = true;
            this.grade11.RowHeadersVisible = false;
            this.grade11.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grade11.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grade11.Size = new System.Drawing.Size(89, 27);
            this.grade11.TabIndex = 150;
            this.grade11.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradeXX_CellClick);
            this.grade11.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gradeXX_RowsAdded);
            this.grade11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradeXX_MouseMove);
            // 
            // HORARIO_GRADE_11
            // 
            this.HORARIO_GRADE_11.DataPropertyName = "HORARIO_GRADE";
            this.HORARIO_GRADE_11.HeaderText = "HORARIO_GRADE_11";
            this.HORARIO_GRADE_11.Name = "HORARIO_GRADE_11";
            this.HORARIO_GRADE_11.ReadOnly = true;
            this.HORARIO_GRADE_11.Visible = false;
            // 
            // DIA_SEMANA_GRADE_11
            // 
            this.DIA_SEMANA_GRADE_11.DataPropertyName = "DIA_SEMANA_GRADE";
            this.DIA_SEMANA_GRADE_11.HeaderText = "DIA_SEMANA_GRADE_11";
            this.DIA_SEMANA_GRADE_11.Name = "DIA_SEMANA_GRADE_11";
            this.DIA_SEMANA_GRADE_11.ReadOnly = true;
            this.DIA_SEMANA_GRADE_11.Visible = false;
            // 
            // CODIGO_DISCIPLINA_11
            // 
            this.CODIGO_DISCIPLINA_11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_DISCIPLINA_11.DataPropertyName = "CODIGO_DISCIPLINA";
            this.CODIGO_DISCIPLINA_11.HeaderText = "Disciplina";
            this.CODIGO_DISCIPLINA_11.MinimumWidth = 20;
            this.CODIGO_DISCIPLINA_11.Name = "CODIGO_DISCIPLINA_11";
            this.CODIGO_DISCIPLINA_11.ReadOnly = true;
            this.CODIGO_DISCIPLINA_11.Width = 20;
            // 
            // CODIGO_TURMA_11
            // 
            this.CODIGO_TURMA_11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO_TURMA_11.DataPropertyName = "CODIGO_TURMA";
            this.CODIGO_TURMA_11.HeaderText = "Turma";
            this.CODIGO_TURMA_11.MinimumWidth = 20;
            this.CODIGO_TURMA_11.Name = "CODIGO_TURMA_11";
            this.CODIGO_TURMA_11.ReadOnly = true;
            // 
            // CODIGO_ESPACO_11
            // 
            this.CODIGO_ESPACO_11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_ESPACO_11.DataPropertyName = "CODIGO_ESPACO";
            this.CODIGO_ESPACO_11.HeaderText = "Sala";
            this.CODIGO_ESPACO_11.MinimumWidth = 20;
            this.CODIGO_ESPACO_11.Name = "CODIGO_ESPACO_11";
            this.CODIGO_ESPACO_11.ReadOnly = true;
            this.CODIGO_ESPACO_11.Width = 20;
            // 
            // CODIGO_PROFESSOR1_11
            // 
            this.CODIGO_PROFESSOR1_11.DataPropertyName = "CODIGO_PROFESSOR1";
            this.CODIGO_PROFESSOR1_11.HeaderText = "Professor";
            this.CODIGO_PROFESSOR1_11.Name = "CODIGO_PROFESSOR1_11";
            this.CODIGO_PROFESSOR1_11.ReadOnly = true;
            this.CODIGO_PROFESSOR1_11.Visible = false;
            // 
            // CODIGO_PROFESSOR2_11
            // 
            this.CODIGO_PROFESSOR2_11.DataPropertyName = "CODIGO_PROFESSOR2";
            this.CODIGO_PROFESSOR2_11.HeaderText = "Professor";
            this.CODIGO_PROFESSOR2_11.Name = "CODIGO_PROFESSOR2_11";
            this.CODIGO_PROFESSOR2_11.ReadOnly = true;
            this.CODIGO_PROFESSOR2_11.Visible = false;
            // 
            // CODIGO_PROFESSOR3_11
            // 
            this.CODIGO_PROFESSOR3_11.DataPropertyName = "CODIGO_PROFESSOR3";
            this.CODIGO_PROFESSOR3_11.HeaderText = "Professor";
            this.CODIGO_PROFESSOR3_11.Name = "CODIGO_PROFESSOR3_11";
            this.CODIGO_PROFESSOR3_11.ReadOnly = true;
            this.CODIGO_PROFESSOR3_11.Visible = false;
            // 
            // frmGradeHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 593);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 632);
            this.Name = "frmGradeHorario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade de Horários";
            this.Load += new System.EventHandler(this.frmGradeHorario_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gbDisciplina.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaDisciplina)).EndInit();
            this.gbProfessor.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaProfessor)).EndInit();
            this.gbSala.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaEspaco)).EndInit();
            this.tblGrade.ResumeLayout(false);
            this.tblGrade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grade12)).EndInit();
            this.menuContexto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grade13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade110)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade111)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade112)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade113)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade114)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade210)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade211)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade212)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade213)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade214)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade310)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade311)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade312)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade313)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade314)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade410)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade411)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade412)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade413)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade414)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade510)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade511)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade512)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade513)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade514)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade67)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade68)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade69)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade610)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade611)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade612)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade613)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade614)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grade11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox gbDisciplina;
        private System.Windows.Forms.GroupBox gbProfessor;
        private System.Windows.Forms.GroupBox gbSala;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtPesquisaDisciplina;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dtgPesquisaProfessor;
        private System.Windows.Forms.TextBox txtPesquisaProfessor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView dtgPesquisaEspaco;
        private System.Windows.Forms.TextBox txtPesquisaEspaco;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dtgPesquisaDisciplina;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.DataGridView grade11;
        private System.Windows.Forms.DataGridView grade12;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_12;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_12;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_12;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_12;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_12;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_12;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_12;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_12;
        private System.Windows.Forms.DataGridView grade13;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_13;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_13;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_13;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_13;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_13;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_13;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_13;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_13;
        private System.Windows.Forms.DataGridView grade14;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_14;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_14;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_14;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_14;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_14;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_14;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_14;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_14;
        private System.Windows.Forms.DataGridView grade15;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_15;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_15;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_15;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_15;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_15;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_15;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_15;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_15;
        private System.Windows.Forms.DataGridView grade16;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_16;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_16;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_16;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_16;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_16;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_16;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_16;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_16;
        private System.Windows.Forms.DataGridView grade17;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_17;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_17;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_17;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_17;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_17;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_17;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_17;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_17;
        private System.Windows.Forms.DataGridView grade18;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_18;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_18;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_18;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_18;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_18;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_18;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_18;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_18;
        private System.Windows.Forms.DataGridView grade19;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_19;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_19;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_19;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_19;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_19;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_19;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_19;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_19;
        private System.Windows.Forms.DataGridView grade110;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_110;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_110;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_110;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_110;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_110;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_110;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_110;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_110;
        private System.Windows.Forms.DataGridView grade111;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_111;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_111;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_111;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_111;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_111;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_111;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_111;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_111;
        private System.Windows.Forms.DataGridView grade112;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_112;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_112;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_112;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_112;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_112;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_112;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_112;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_112;
        private System.Windows.Forms.DataGridView grade113;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_113;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_113;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_113;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_113;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_113;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_113;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_113;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_113;
        private System.Windows.Forms.DataGridView grade114;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_114;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_114;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_114;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_114;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_114;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_114;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_114;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_114;
        private System.Windows.Forms.DataGridView grade21;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_21;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_21;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_21;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_21;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_21;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_21;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_21;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_21;
        private System.Windows.Forms.DataGridView grade22;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_22;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_22;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_22;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_22;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_22;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_22;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_22;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_22;
        private System.Windows.Forms.DataGridView grade23;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_23;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_23;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_23;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_23;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_23;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_23;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_23;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_23;
        private System.Windows.Forms.DataGridView grade24;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_24;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_24;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_24;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_24;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_24;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_24;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_24;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_24;
        private System.Windows.Forms.DataGridView grade25;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_25;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_25;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_25;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_25;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_25;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_25;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_25;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_25;
        private System.Windows.Forms.DataGridView grade26;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_26;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_26;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_26;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_26;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_26;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_26;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_26;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_26;
        private System.Windows.Forms.DataGridView grade27;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_27;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_27;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_27;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_27;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_27;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_27;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_27;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_27;
        private System.Windows.Forms.DataGridView grade28;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_28;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_28;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_28;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_28;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_28;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_28;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_28;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_28;
        private System.Windows.Forms.DataGridView grade29;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_29;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_29;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_29;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_29;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_29;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_29;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_29;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_29;
        private System.Windows.Forms.DataGridView grade210;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_210;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_210;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_210;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_210;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_210;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_210;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_210;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_210;
        private System.Windows.Forms.DataGridView grade211;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_211;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_211;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_211;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_211;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_211;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_211;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_211;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_211;
        private System.Windows.Forms.DataGridView grade212;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_212;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_212;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_212;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_212;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_212;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_212;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_212;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_212;
        private System.Windows.Forms.DataGridView grade213;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_213;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_213;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_213;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_213;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_213;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_213;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_213;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_213;
        private System.Windows.Forms.DataGridView grade214;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_214;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_214;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_214;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_214;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_214;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_214;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_214;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_214;
        private System.Windows.Forms.DataGridView grade31;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_31;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_31;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_31;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_31;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_31;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_31;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_31;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_31;
        private System.Windows.Forms.DataGridView grade32;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_32;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_32;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_32;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_32;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_32;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_32;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_32;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_32;
        private System.Windows.Forms.DataGridView grade33;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_33;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_33;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_33;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_33;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_33;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_33;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_33;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_33;
        private System.Windows.Forms.DataGridView grade34;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_34;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_34;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_34;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_34;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_34;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_34;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_34;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_34;
        private System.Windows.Forms.DataGridView grade35;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_35;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_35;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_35;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_35;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_35;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_35;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_35;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_35;
        private System.Windows.Forms.DataGridView grade36;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_36;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_36;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_36;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_36;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_36;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_36;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_36;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_36;
        private System.Windows.Forms.DataGridView grade37;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_37;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_37;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_37;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_37;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_37;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_37;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_37;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_37;
        private System.Windows.Forms.DataGridView grade38;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_38;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_38;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_38;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_38;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_38;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_38;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_38;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_38;
        private System.Windows.Forms.DataGridView grade39;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_39;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_39;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_39;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_39;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_39;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_39;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_39;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_39;
        private System.Windows.Forms.DataGridView grade310;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_310;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_310;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_310;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_310;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_310;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_310;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_310;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_310;
        private System.Windows.Forms.DataGridView grade311;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_311;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_311;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_311;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_311;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_311;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_311;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_311;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_311;
        private System.Windows.Forms.DataGridView grade312;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_312;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_312;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_312;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_312;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_312;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_312;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_312;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_312;
        private System.Windows.Forms.DataGridView grade313;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_313;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_313;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_313;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_313;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_313;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_313;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_313;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_313;
        private System.Windows.Forms.DataGridView grade314;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_314;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_314;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_314;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_314;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_314;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_314;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_314;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_314;
        private System.Windows.Forms.DataGridView grade41;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_41;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_41;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_41;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_41;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_41;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_41;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_41;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_41;
        private System.Windows.Forms.DataGridView grade42;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_42;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_42;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_42;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_42;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_42;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_42;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_42;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_42;
        private System.Windows.Forms.DataGridView grade43;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_43;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_43;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_43;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_43;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_43;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_43;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_43;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_43;
        private System.Windows.Forms.DataGridView grade44;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_44;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_44;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_44;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_44;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_44;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_44;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_44;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_44;
        private System.Windows.Forms.DataGridView grade45;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_45;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_45;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_45;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_45;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_45;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_45;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_45;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_45;
        private System.Windows.Forms.DataGridView grade46;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_46;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_46;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_46;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_46;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_46;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_46;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_46;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_46;
        private System.Windows.Forms.DataGridView grade47;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_47;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_47;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_47;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_47;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_47;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_47;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_47;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_47;
        private System.Windows.Forms.DataGridView grade48;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_48;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_48;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_48;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_48;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_48;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_48;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_48;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_48;
        private System.Windows.Forms.DataGridView grade49;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_49;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_49;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_49;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_49;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_49;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_49;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_49;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_49;
        private System.Windows.Forms.DataGridView grade410;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_410;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_410;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_410;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_410;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_410;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_410;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_410;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_410;
        private System.Windows.Forms.DataGridView grade411;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_411;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_411;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_411;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_411;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_411;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_411;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_411;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_411;
        private System.Windows.Forms.DataGridView grade412;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_412;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_412;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_412;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_412;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_412;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_412;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_412;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_412;
        private System.Windows.Forms.DataGridView grade413;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_413;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_413;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_413;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_413;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_413;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_413;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_413;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_413;
        private System.Windows.Forms.DataGridView grade414;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_414;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_414;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_414;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_414;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_414;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_414;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_414;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_414;
        private System.Windows.Forms.DataGridView grade51;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_51;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_51;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_51;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_51;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_51;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_51;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_51;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_51;
        private System.Windows.Forms.DataGridView grade52;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_52;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_52;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_52;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_52;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_52;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_52;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_52;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_52;
        private System.Windows.Forms.DataGridView grade53;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_53;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_53;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_53;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_53;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_53;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_53;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_53;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_53;
        private System.Windows.Forms.DataGridView grade54;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_54;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_54;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_54;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_54;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_54;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_54;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_54;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_54;
        private System.Windows.Forms.DataGridView grade55;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_55;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_55;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_55;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_55;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_55;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_55;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_55;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_55;
        private System.Windows.Forms.DataGridView grade56;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_56;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_56;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_56;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_56;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_56;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_56;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_56;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_56;
        private System.Windows.Forms.DataGridView grade57;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_57;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_57;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_57;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_57;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_57;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_57;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_57;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_57;
        private System.Windows.Forms.DataGridView grade58;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_58;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_58;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_58;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_58;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_58;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_58;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_58;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_58;
        private System.Windows.Forms.DataGridView grade59;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_59;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_59;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_59;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_59;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_59;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_59;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_59;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_59;
        private System.Windows.Forms.DataGridView grade510;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_510;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_510;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_510;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_510;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_510;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_510;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_510;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_510;
        private System.Windows.Forms.DataGridView grade511;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_511;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_511;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_511;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_511;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_511;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_511;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_511;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_511;
        private System.Windows.Forms.DataGridView grade512;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_512;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_512;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_512;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_512;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_512;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_512;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_512;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_512;
        private System.Windows.Forms.DataGridView grade513;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_513;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_513;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_513;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_513;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_513;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_513;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_513;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_513;
        private System.Windows.Forms.DataGridView grade514;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_514;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_514;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_514;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_514;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_514;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_514;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_514;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_514;
        private System.Windows.Forms.DataGridView grade61;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_61;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_61;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_61;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_61;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_61;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_61;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_61;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_61;
        private System.Windows.Forms.DataGridView grade62;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_62;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_62;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_62;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_62;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_62;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_62;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_62;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_62;
        private System.Windows.Forms.DataGridView grade63;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_63;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_63;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_63;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_63;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_63;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_63;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_63;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_63;
        private System.Windows.Forms.DataGridView grade64;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_64;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_64;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_64;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_64;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_64;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_64;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_64;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_64;
        private System.Windows.Forms.DataGridView grade65;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_65;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_65;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_65;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_65;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_65;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_65;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_65;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_65;
        private System.Windows.Forms.DataGridView grade66;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_66;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_66;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_66;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_66;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_66;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_66;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_66;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_66;
        private System.Windows.Forms.DataGridView grade67;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_67;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_67;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_67;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_67;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_67;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_67;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_67;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_67;
        private System.Windows.Forms.DataGridView grade68;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_68;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_68;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_68;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_68;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_68;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_68;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_68;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_68;
        private System.Windows.Forms.DataGridView grade69;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_69;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_69;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_69;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_69;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_69;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_69;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_69;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_69;
        private System.Windows.Forms.DataGridView grade610;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_610;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_610;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_610;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_610;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_610;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_610;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_610;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_610;
        private System.Windows.Forms.DataGridView grade611;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_611;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_611;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_611;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_611;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_611;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_611;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_611;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_611;
        private System.Windows.Forms.DataGridView grade612;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_612;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_612;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_612;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_612;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_612;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_612;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_612;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_612;
        private System.Windows.Forms.DataGridView grade613;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_613;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_613;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_613;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_613;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_613;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_613;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_613;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_613;
        private System.Windows.Forms.DataGridView grade614;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_614;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_614;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_614;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_614;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_614;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_614;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_614;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_614;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ContextMenuStrip menuContexto;
        private System.Windows.Forms.ToolStripMenuItem itmInserir;
        private System.Windows.Forms.ToolStripMenuItem itmEditar;
        private System.Windows.Forms.ToolStripMenuItem itmExcluir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECT_PROFESSOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_PROF_PESQUISA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_PROF_PESQUISA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECT_ESPACO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_ESP_PESQUISA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_ESP_PESQUISA;
        private System.Windows.Forms.ToolStripMenuItem itmDetalhes;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GRADE_11;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA_GRADE_11;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_DISCIPLINA_11;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA_11;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ESPACO_11;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR1_11;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR2_11;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROFESSOR3_11;
        public System.Windows.Forms.TableLayoutPanel tblGrade;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECT_DISCIPLINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_DISC_PESQUISA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_DISC_PESQUISA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TURMA;
    }
}