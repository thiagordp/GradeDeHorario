using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeDeHorario
{
    public partial class frmGradeHorario : Form
    {
        private Modelos.CURSO curso { set; get; }
        private RegraNegocio.GradeHorarioRegraNegocio gradeRN;
        private DataGridView hoverGrade;

        public frmGradeHorario(Modelos.CURSO curso)
        {
            InitializeComponent();
            this.curso = curso;

        }

        private void frmGradeHorario_Load(object sender, EventArgs e)
        {
            InicializaGrade();

            this.Text += " - " + curso.NOME_CURSO;

            // Inicializações
            PreencheListaFase();
            PreencheListaSemestre();
            LayoutGrade();


            (tblGrade.GetControlFromPosition(1, 1) as DataGridView).Rows.Add("ARA4513", "01655", "ARA302", "Fulano");
            (tblGrade.GetControlFromPosition(1, 1) as DataGridView).ClearSelection();
            (tblGrade.GetControlFromPosition(6, 13) as DataGridView).Rows.Add("ARA2635", "01655", "ARC119", "Fulano");
            (tblGrade.GetControlFromPosition(6, 13) as DataGridView).ClearSelection();
            (tblGrade.GetControlFromPosition(5, 10) as DataGridView).Rows.Add("ARA2635", "01655", "ARC119", "Fulano");
            (tblGrade.GetControlFromPosition(5, 10) as DataGridView).ClearSelection();
        }

        private void LayoutGrade()
        {
            foreach (Component tabela in tblGrade.Controls)
            {
                DataGridView data;

                if (tabela is DataGridView)
                {
                    data = (tabela as DataGridView);

                    if (tblGrade.GetCellPosition(data).Row <= 5)
                    {
                        data.BackgroundColor = Color.DarkKhaki;
                    }
                    else if (tblGrade.GetCellPosition(data).Row > 5 && tblGrade.GetCellPosition(data).Row < 11)
                    {
                        data.BackgroundColor = Color.SeaGreen;
                    }
                    else
                    {
                        data.BackgroundColor = Color.SteelBlue;
                    }
                }
            }
        }

        private void InicializaGrade()
        {
            /*
            tblGrade.GetControlFromPosition(1, 1);

            MessageBox.Show(tblGrade.GetControlFromPosition(1, 1).Name); // Grid a partir da posição

            TableLayoutPanelCellPosition posicao = tblGrade.GetPositionFromControl(dataGridView16); // posição a partir do grid.
            MessageBox.Show("linha: " + posicao.Row + "\ncoluna: " + posicao.Column);

            grade11.Height = grade11.Rows.GetRowsHeight(DataGridViewElementStates.None)-5; // Altura automática com base no conteúdo da tabela.
            */

            //       tblGrade.RowStyles[1].Height = (float) (grade11.Rows.GetRowsHeight(DataGridViewElementStates.Visible));

            //    grade11.Height = grade11.Rows.GetRowsHeight(DataGridViewElementStates.None) - 5;
        }

        private void txtPesquisaDisciplina_TextChanged(object sender, EventArgs e)
        {
            PreenchePesquisaDisciplina(txtPesquisaDisciplina.Text);
        }

        private void PreenchePesquisaDisciplina(string filtro)
        {
            try
            {
                gradeRN = new RegraNegocio.GradeHorarioRegraNegocio(curso);

                dtgPesquisaDisciplina.DataSource = gradeRN.SelecionaDisciplina(filtro);
                dtgPesquisaDisciplina.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPesquisaProfessor_TextChanged(object sender, EventArgs e)
        {
            PreenchePesquisaProfessor(txtPesquisaProfessor.Text);
        }

        private void PreenchePesquisaProfessor(string filtro)
        {
            try
            {
                gradeRN = new RegraNegocio.GradeHorarioRegraNegocio(curso);

                dtgPesquisaProfessor.DataSource = gradeRN.SelecionaProfessor(filtro);
                dtgPesquisaProfessor.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPesquisaEspaco_TextChanged(object sender, EventArgs e)
        {
            PreenchePesquisaEspaco(txtPesquisaEspaco.Text);
        }

        private void PreenchePesquisaEspaco(string filtro)
        {
            try
            {
                gradeRN = new RegraNegocio.GradeHorarioRegraNegocio(curso);

                dtgPesquisaEspaco.DataSource = gradeRN.SelecionaEspaco(filtro);
                dtgPesquisaEspaco.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencheListaFase()
        {
            int qtd_fase = Convert.ToInt32(curso.QTD_FASE);
            cbbSelectFase.Items.Clear();

            DataTable tabela = new DataTable();

            tabela.Columns.Add("NUMERO_FASE", typeof(int));
            tabela.Columns.Add("NOME_FASE", typeof(string));

            for (int i = 1; i <= qtd_fase; i++)
            {
                tabela.Rows.Add(i, i.ToString() + "a FASE");
            }

            cbbSelectFase.ComboBox.DataSource = tabela;

            cbbSelectFase.ComboBox.ValueMember = "NUMERO_FASE";
            cbbSelectFase.ComboBox.DisplayMember = "NOME_FASE";

            cbbSelectFase.SelectedIndex = -1;
        }

        private void PreencheListaSemestre()
        {
            try
            {
                gradeRN = new RegraNegocio.GradeHorarioRegraNegocio(curso);

                cbbSelectSemestre.ComboBox.DataSource = gradeRN.SelecionaTodoSemestre();
                cbbSelectSemestre.ComboBox.ValueMember = "SEQ_SEMESTRE";
                cbbSelectSemestre.ComboBox.DisplayMember = "NOME_SEMESTRE";

                cbbSelectSemestre.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carrega uma grade de horários com base nos parâmetros.
        /// </summary>
        /// <param name="curso"></param>
        /// <param name="fase"></param>
        /// <param name="semestre"></param>
        private void CarregaGrade(int curso, int fase, int semestre)
        {
            gradeRN = new RegraNegocio.GradeHorarioRegraNegocio(this.curso);

            List<DataGridView> grade = gradeRN.CarregaGrade(curso, fase, semestre);
        }

        private void btnCarregaGrade_Click(object sender, EventArgs e)
        {
            try
            {
                CarregaGrade(
                    curso.CODIGO_CURSO,
                    Convert.ToInt32(cbbSelectFase.ComboBox.SelectedValue),
                    Convert.ToInt32(cbbSelectSemestre.ComboBox.SelectedValue));

                btnEditar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao carregar a grade", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbSelectFase_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
        }

        private void cbbSelectSemestre_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                PreenchePesquisaDisciplina(txtPesquisaDisciplina.Text);
                PreenchePesquisaProfessor(txtPesquisaProfessor.Text);
                PreenchePesquisaEspaco(txtPesquisaEspaco.Text);

                cbbSelectFase.Enabled = cbbSelectSemestre.Enabled = btnCarregaGrade.Enabled = btnEditar.Enabled = false;
                btnCancelar.Enabled = btnSalvar.Enabled = btnGerarRelatorio.Enabled = tblGrade.Enabled = gbDisciplina.Enabled = gbProfessor.Enabled = gbSala.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em estágio de implementação.", "Implementando", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cbbSelectFase.Enabled = cbbSelectSemestre.Enabled = btnCarregaGrade.Enabled = true;
            btnCancelar.Enabled = btnSalvar.Enabled = btnGerarRelatorio.Enabled = tblGrade.Enabled = gbDisciplina.Enabled = gbProfessor.Enabled = gbSala.Enabled = btnEditar.Enabled = false;
        }

        private void gradeXX_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridView grade = (sender as DataGridView);

            string disciplina, turma, professor, espaco;

            disciplina = dtgPesquisaDisciplina.Rows[Convert.ToInt32(dtgPesquisaDisciplina.CurrentRow.Index)].Cells["COD_DISC_PESQUISA"].Value.ToString();

            grade.Rows.Add(disciplina);
        }

        private void gradeXX_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            AutoSizeGrade(sender);
        }

        private void AutoSizeGrade(object grade)
        {
            if (grade is DataGridView)
            {
                (grade as DataGridView).Height = (grade as DataGridView).Rows.GetRowsHeight(DataGridViewElementStates.None);
            }
        }

        private void itmInserir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hoverGrade.Name);
            
        }

        private void itmEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edita");
        }

        private void itmExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Excluir");
        }

        private void gradeXX_MouseMove(object sender, MouseEventArgs e)
        {
            hoverGrade = sender as DataGridView;
        }

        private void dtgPesquisaDisciplina_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
