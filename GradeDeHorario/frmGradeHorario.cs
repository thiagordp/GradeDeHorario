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

        }

        private void frmGradeHorario_Load(object sender, EventArgs e)
        {
            InicializaGrade();

            this.Text += " - " + curso.NOME_CURSO;

            // Inicializações
            PreenchePesquisaDisciplina(txtPesquisaDisciplina.Text);
            PreenchePesquisaProfessor(txtPesquisaProfessor.Text);
            PreenchePesquisaEspaco(txtPesquisaEspaco.Text);
            PreencheListaFase();
            PreencheListaSemestre();


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
                        if (data.Name.Contains("grade") == true)
                        {
                            data.Rows.Add("ARA1234", "01665", "ARA301", "Fulano");
                        }
                        data.ClearSelection();

                        data.BackgroundColor = Color.SeaGreen;
                    }
                    else
                    {
                        data.BackgroundColor = Color.SteelBlue;
                    }
                }
            }

            (tblGrade.GetControlFromPosition(1, 1) as DataGridView).Rows.Add("ARA4513", "01655", "ARA302", "Fulano");
            (tblGrade.GetControlFromPosition(1, 1) as DataGridView).ClearSelection();
            (tblGrade.GetControlFromPosition(6, 13) as DataGridView).Rows.Add("ARA2635", "01655", "ARC119", "Fulano");
            (tblGrade.GetControlFromPosition(6, 13) as DataGridView).ClearSelection();
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


    }

}
