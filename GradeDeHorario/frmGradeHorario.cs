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


        public frmGradeHorario(Modelos.CURSO curso)
        {
            InitializeComponent();
            this.curso = curso;
            InicializaGrade();

            // Inicializações
            PreenchePesquisaDisciplina(txtPesquisaDisciplina.Text);
            PreenchePesquisaProfessor(txtPesquisaProfessor.Text);
            PreenchePesquisaEspaco(txtPesquisaEspaco.Text);
            PreencheListaFase();
            PreencheListaSemestre();
        }

        //Adicionar no BD um n..n na Grade com a Disc_Turma
        private void InicializaGrade()
        {
            /*
            tblGrade.GetControlFromPosition(1, 1);

            MessageBox.Show(tblGrade.GetControlFromPosition(1, 1).Name); // Grid a partir da posição

            TableLayoutPanelCellPosition posicao = tblGrade.GetPositionFromControl(dataGridView16); // posição a partir do grid.
            MessageBox.Show("linha: " + posicao.Row + "\ncoluna: " + posicao.Column);

            grade11.Height = grade11.Rows.GetRowsHeight(DataGridViewElementStates.None)-5; // Altura automática com base no conteúdo da tabela.
            */
            grade11.Rows.Add("123", "123", "123");
            grade11.Rows.Add("abc", "abc", "abc");
            grade11.Rows.Add("123", "123", "123");
            grade11.Rows.Add("abc", "abc", "abc");


            /*   grade12.Rows.Add("123", "123", "123");
               grade12.Rows.Add("abc", "abc", "abc");
               grade12.Rows.Add("123", "123", "123");
               grade12.Rows.Add("abc", "abc", "abc");

               grade13.Rows.Add("123", "123", "123");
               grade13.Rows.Add("abc", "abc", "abc");
               grade14.Rows.Add("123", "123", "123");
               grade15.Rows.Add("abc", "abc", "abc");*/
            //       tblGrade.RowStyles[1].Height = (float) (grade11.Rows.GetRowsHeight(DataGridViewElementStates.Visible));

            grade11.Height = grade11.Rows.GetRowsHeight(DataGridViewElementStates.None) - 5;
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
    }

}
