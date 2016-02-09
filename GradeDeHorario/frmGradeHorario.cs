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

        private List<Modelos.Celula> ListaInsere { get; set; }

        private List<Modelos.Celula> ListaEdita { get; set; }

        private List<Modelos.Celula> ListaExclui { get; set; }


        public frmGradeHorario(Modelos.CURSO curso)
        {
            InitializeComponent();
            this.curso = curso;
        }

        private void frmGradeHorario_Load(object sender, EventArgs e)
        {
            this.Text += " - " + curso.NOME_CURSO;

            // Inicializações
            PreencheListaFase();
            PreencheListaSemestre();
            LayoutGrade();
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
            PreenchePesquisaDisciplina(txtPesquisaDisciplina.Text, Convert.ToInt32(cbbSelectFase.ComboBox.SelectedValue));
        }

        private void PreenchePesquisaDisciplina(string filtro, int fase)
        {
            try
            {
                gradeRN = new RegraNegocio.GradeHorarioRegraNegocio(curso);

                dtgPesquisaDisciplina.DataSource = gradeRN.SelecionaDisciplina(filtro, fase);
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

        private void btnCarregaGrade_Click(object sender, EventArgs e)
        {
            try
            {
                PreencheGrade();
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
                PreenchePesquisaDisciplina(txtPesquisaDisciplina.Text, Convert.ToInt32(cbbSelectFase.ComboBox.SelectedValue));
                PreenchePesquisaProfessor(txtPesquisaProfessor.Text);
                PreenchePesquisaEspaco(txtPesquisaEspaco.Text);
                cbbSelectFase.Enabled = cbbSelectSemestre.Enabled = btnCarregaGrade.Enabled = btnEditar.Enabled = false;
                btnCancelar.Enabled = btnSalvar.Enabled = btnGerarRelatorio.Enabled = tblGrade.Enabled = gbDisciplina.Enabled = gbProfessor.Enabled = gbSala.Enabled = true;

                ListaEdita = new List<Modelos.Celula>();
                ListaExclui = new List<Modelos.Celula>();
                ListaInsere = new List<Modelos.Celula>();
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
            LimparTabelas();

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
            try
            {
                VerificaSelecaoTabelas();

                string disciplina, espaco;
                List<int> professores = new List<int>();

                disciplina = espaco = string.Empty;

                SelecionaCampoMarcado(ref disciplina, ref espaco, ref professores);

                gradeRN = new RegraNegocio.GradeHorarioRegraNegocio(this.curso);

                Modelos.Celula celula = new Modelos.Celula();

                celula.hora = tblGrade.GetPositionFromControl(hoverGrade).Row;
                celula.dia = tblGrade.GetPositionFromControl(hoverGrade).Column;
                celula.disciplina = disciplina;
                celula.espaco = espaco;
                celula.fase = Convert.ToInt32(cbbSelectFase.ComboBox.SelectedValue);
                celula.professores = professores;
                celula.semestre = Convert.ToInt32(cbbSelectSemestre.ComboBox.SelectedValue);

                gradeRN.InsereCelula(this, celula);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void itmDetalhes_Click(object sender, EventArgs e)
        {
            if (hoverGrade.Rows.Count.Equals(0)) { return; }

            if (hoverGrade.SelectedRows.Count == 0)
            {
                MessageBox.Show("É necessário selecionar uma célula para visualizar seus detalhes.", "Selecione uma célula", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                gradeRN = new RegraNegocio.GradeHorarioRegraNegocio(this.curso);

                string disciplina = hoverGrade.Rows[hoverGrade.CurrentRow.Index].Cells[2].Value.ToString();
                int prof1 = Convert.ToInt32(hoverGrade.Rows[hoverGrade.CurrentRow.Index].Cells[5].Value);
                int prof2, prof3;

                object temp = hoverGrade.Rows[hoverGrade.CurrentRow.Index].Cells[6].Value;

                if (temp == null)
                {
                    prof2 = prof3 = -1;
                }
                else
                {
                    prof2 = Convert.ToInt32(temp);

                    temp = hoverGrade.Rows[hoverGrade.CurrentRow.Index].Cells[7].Value;

                    if (temp == null)
                    {
                        prof3 = -1;
                    }
                    else
                    {
                        prof3 = Convert.ToInt32(temp);
                    }
                }

                string turma = hoverGrade.Rows[hoverGrade.CurrentRow.Index].Cells[3].Value.ToString();
                string espaco = hoverGrade.Rows[hoverGrade.CurrentRow.Index].Cells[4].Value.ToString();

                string msg = gradeRN.SelecionaDetalhe(disciplina, turma, prof1, prof2, prof3, espaco);

                MessageBox.Show(msg, "Detalhe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void PreencheGrade()
        {
            try
            {
                gradeRN = new RegraNegocio.GradeHorarioRegraNegocio(this.curso);
                gradeRN.VerificaCarregaGrade(
                    this.curso.CODIGO_CURSO,
                    Convert.ToInt32(cbbSelectFase.ComboBox.SelectedValue),
                    Convert.ToInt32(cbbSelectSemestre.ComboBox.SelectedValue));

                DataTable query = gradeRN.SelecionaTodaGrade(
                    Convert.ToInt32(cbbSelectFase.ComboBox.SelectedValue),
                    Convert.ToInt32(cbbSelectSemestre.ComboBox.SelectedValue));

                LimpaTodaGrade();

                for (int i = 0; i < query.Rows.Count; i++)
                {
                    int linha, coluna;

                    linha = query.Rows[i].Field<int>("HORARIO_GRADE");
                    coluna = query.Rows[i].Field<int>("DIA_SEMANA_GRADE");

                    Control control = tblGrade.GetControlFromPosition(coluna, linha);

                    if (control is DataGridView)
                    {
                        DataGridView grade = tblGrade.GetControlFromPosition(coluna, linha) as DataGridView;

                        string disciplina = query.Rows[i].Field<string>("CODIGO_DISCIPLINA");
                        string turma = query.Rows[i].Field<string>("NOME_TURMA");
                        string espaco = query.Rows[i].Field<string>("CODIGO_ESPACO");

                        int? prof1 = query.Rows[i].Field<int?>("CODIGO_PROFESSOR1");        // 'int?' é um int anulável.
                        int? prof2 = query.Rows[i].Field<int?>("CODIGO_PROFESSOR2");
                        int? prof3 = query.Rows[i].Field<int?>("CODIGO_PROFESSOR3");

                        if (prof3 != null)
                        {
                            grade.Rows.Add(linha, coluna, disciplina, turma, espaco, prof1, prof2, prof3);
                        }
                        else if (prof2 != null)
                        {
                            grade.Rows.Add(linha, coluna, disciplina, turma, espaco, prof1, prof2);
                        }
                        else
                        {
                            grade.Rows.Add(linha, coluna, disciplina, turma, espaco, prof1);
                        }

                        grade.ClearSelection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Limpar todas as células da grade.
        /// </summary>
        private void LimpaTodaGrade()
        {
            foreach (Control tabela in tblGrade.Controls)
            {
                if ((tabela is DataGridView) && ((tabela as DataGridView).Name.Contains("grade") == true))
                {
                    (tabela as DataGridView).Rows.Clear();
                }
            }
        }

        /// <summary>
        /// Limpar as tabelas de disciplinas, espaços e professores.
        /// </summary>
        private void LimparTabelas()
        {
            this.PreenchePesquisaDisciplina("", -1);
            this.PreenchePesquisaEspaco("-1");
            this.PreenchePesquisaProfessor("-1");
            this.PreencheGrade();
            this.LimpaTodaGrade();
        }

        /// <summary>
        /// Verifica se as selecões de disciplina, professores e espaço está correta.
        /// </summary>
        private void VerificaSelecaoTabelas()
        {
            int contagem = 0;

            dtgPesquisaDisciplina.EndEdit();
            dtgPesquisaEspaco.EndEdit();
            dtgPesquisaProfessor.EndEdit();

            for (int i = 0; i < dtgPesquisaDisciplina.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dtgPesquisaDisciplina.Rows[i].Cells["SELECT_DISCIPLINA"].Value) == true)
                {
                    contagem++;
                }

                if (contagem > 1)
                {
                    throw new Exception("Apenas uma disciplina deve ser selecionada!");
                }
            }

            if (contagem == 0)
            {
                throw new Exception("Uma disciplina deve ser selecionada!");
            }

            contagem = 0;

            for (int i = 0; i < dtgPesquisaProfessor.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dtgPesquisaProfessor.Rows[i].Cells["SELECT_PROFESSOR"].Value) == true)
                {
                    contagem++;
                }

                if (contagem > 3)
                {
                    throw new Exception("Até 3 professores podem ser selecionados!");
                }
            }

            if (contagem == 0)
            {
                throw new Exception("Ao menos um professor deve ser selecionado!");
            }

            contagem = 0;

            for (int i = 0; i < dtgPesquisaEspaco.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dtgPesquisaEspaco.Rows[i].Cells["SELECT_ESPACO"].Value) == true)
                {
                    contagem++;
                }

                if (contagem > 1)
                {
                    throw new Exception("Apenas um espaço deve ser selecionado!");
                }

            }

            if (contagem == 0)
            {
                throw new Exception("Ao menos um espaço deve ser selecionado!");
            }
        }

        private void gradeXX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Control controle in tblGrade.Controls)
            {
                if (controle is DataGridView && controle.Name.Contains("grade") && controle.Name != (sender as DataGridView).Name)
                {
                    (controle as DataGridView).ClearSelection();
                }
            }
        }

        /// <summary>
        /// Seleciona os campos marcados de disciplina, espaco e 
        /// professor(es) e os armazena nos parâmetros por refência.
        /// </summary>
        /// <param name="disciplina">Código da disciplina selecionada.</param>
        /// <param name="espaco">Código do espaco selecionado.</param>
        /// <param name="professores">Lista de código(s) de professor(es) selecionado(s).</param>
        private void SelecionaCampoMarcado(ref string disciplina, ref string espaco, ref List<int> professores)
        {
            // Conclui a edição das tabelas.
            dtgPesquisaDisciplina.EndEdit();
            dtgPesquisaEspaco.EndEdit();
            dtgPesquisaProfessor.EndEdit();

            // Seleção da disciplina.
            for (int i = 0; i < dtgPesquisaDisciplina.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dtgPesquisaDisciplina.Rows[i].Cells["SELECT_DISCIPLINA"].Value) == true)
                {
                    disciplina = dtgPesquisaDisciplina.Rows[i].Cells["COD_DISC_PESQUISA"].Value.ToString();
                    break;
                }
            }

            // Seleção do(s) professor(es).
            for (int i = 0; i < dtgPesquisaProfessor.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dtgPesquisaProfessor.Rows[i].Cells["SELECT_PROFESSOR"].Value) == true)
                {
                    professores.Add(Convert.ToInt32(dtgPesquisaProfessor.Rows[i].Cells["COD_PROF_PESQUISA"].Value));

                    if (professores.Count > 3) { break; }
                }
            }

            // Seleção da disciplina.
            for (int i = 0; i < dtgPesquisaEspaco.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dtgPesquisaEspaco.Rows[i].Cells["SELECT_ESPACO"].Value) == true)
                {
                    espaco = dtgPesquisaEspaco.Rows[i].Cells["COD_ESP_PESQUISA"].Value.ToString();
                    break;
                }
            }
        }
    }
}