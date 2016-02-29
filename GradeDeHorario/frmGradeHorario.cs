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
        public DataGridView hoverGrade;

        private Modelos.Entidade contextoUniversal;

        private Modelos.Celula celulaAntiga;
        private Modelos.Celula celulaNova;

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
                gradeRN = new RegraNegocio.GradeHorarioRegraNegocio(curso, ref contextoUniversal);

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
                gradeRN = new RegraNegocio.GradeHorarioRegraNegocio(curso, ref contextoUniversal);

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
                gradeRN = new RegraNegocio.GradeHorarioRegraNegocio(curso, ref contextoUniversal);

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
                gradeRN = new RegraNegocio.GradeHorarioRegraNegocio(curso, ref contextoUniversal);

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

                this.contextoUniversal = new Modelos.Entidade();
                gradeRN = new RegraNegocio.GradeHorarioRegraNegocio(curso, ref contextoUniversal);
                gradeRN.CarregaLocalmente();

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
                contextoUniversal.SaveChanges();

                cbbSelectFase.Enabled = cbbSelectSemestre.Enabled = btnCarregaGrade.Enabled = true;
                btnCancelar.Enabled = btnSalvar.Enabled = btnGerarRelatorio.Enabled = tblGrade.Enabled = gbDisciplina.Enabled = gbProfessor.Enabled = gbSala.Enabled = btnEditar.Enabled = false;

                MessageBox.Show("Alterações salvas com sucesso.", "Alterações salvas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                string disciplina, espaco, turma;
                List<int> professores = new List<int>();

                disciplina = espaco = turma = string.Empty;

                SelecionaCampoMarcado(ref disciplina, ref espaco, ref professores, ref turma);

                gradeRN = new RegraNegocio.GradeHorarioRegraNegocio(this.curso, ref contextoUniversal);

                Modelos.Celula celula = new Modelos.Celula();

                celula.hora = tblGrade.GetPositionFromControl(hoverGrade).Row;
                celula.dia = tblGrade.GetPositionFromControl(hoverGrade).Column;
                celula.disciplina = disciplina;
                celula.espaco = espaco;
                celula.fase = Convert.ToInt32(cbbSelectFase.ComboBox.SelectedValue);
                celula.professores = professores;
                celula.semestre = Convert.ToInt32(cbbSelectSemestre.ComboBox.SelectedValue);
                celula.turma = turma;

                gradeRN.InsereCelula(ref tblGrade, celula); // Insere na grade
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void itmEditar_Click(object sender, EventArgs e)
        {
            if (hoverGrade.Rows.Count.Equals(0)) { return; }

            if (hoverGrade.SelectedRows.Count == 0)
            {
                MessageBox.Show("É necessário selecionar uma célula para visualizar seus detalhes.", "Selecione uma célula", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            celulaAntiga = new Modelos.Celula();
            celulaNova = new Modelos.Celula();

            try
            {
                // Recolhendo dados da célula antiga.
                celulaAntiga.disciplina = hoverGrade.Rows[hoverGrade.CurrentRow.Index].Cells[2].Value.ToString();
                celulaAntiga.turma = hoverGrade.Rows[hoverGrade.CurrentRow.Index].Cells[3].Value.ToString();
                celulaAntiga.espaco = hoverGrade.Rows[hoverGrade.CurrentRow.Index].Cells[4].Value.ToString();
                celulaAntiga.semestre = Convert.ToInt32(cbbSelectSemestre.ComboBox.SelectedValue);
                celulaAntiga.hora = tblGrade.GetPositionFromControl(hoverGrade).Row;
                celulaAntiga.dia = tblGrade.GetPositionFromControl(hoverGrade).Column;

                List<int> lista = new List<int>();

                int prof = Convert.ToInt32(hoverGrade.Rows[hoverGrade.CurrentRow.Index].Cells[5].Value);
                lista.Add(prof);

                object temp = hoverGrade.Rows[hoverGrade.CurrentRow.Index].Cells[6].Value;

                if (temp != null)// prof2
                {
                    prof = Convert.ToInt32(temp);
                    lista.Add(prof);

                    temp = hoverGrade.Rows[hoverGrade.CurrentRow.Index].Cells[7].Value;

                    if (temp != null) // prof3
                    {
                        prof = Convert.ToInt32(temp);
                        lista.Add(prof);
                    }
                }

                celulaAntiga.professores = lista;

                for (int i = 0; i < dtgPesquisaDisciplina.Rows.Count; i++)
                {
                    if (dtgPesquisaDisciplina.Rows[i].Cells["COD_DISC_PESQUISA"].Value.ToString() == celulaAntiga.disciplina &&
                        dtgPesquisaDisciplina.Rows[i].Cells["CODIGO_TURMA"].Value.ToString() == celulaAntiga.turma)
                    {
                        dtgPesquisaDisciplina.Rows[i].Cells["SELECT_DISCIPLINA"].Value = true;
                        break;
                    }
                }

                for (int i = 0; i < dtgPesquisaEspaco.Rows.Count; i++)
                {
                    if (dtgPesquisaEspaco.Rows[i].Cells["COD_ESP_PESQUISA"].Value.ToString() == celulaAntiga.espaco)
                    {
                        dtgPesquisaEspaco.Rows[i].Cells["SELECT_ESPACO"].Value = true;
                        break;
                    }
                }

                bool find1, find2, find3;
                find1 = find2 = find3 = false;

                for (int i = 0; i < dtgPesquisaProfessor.Rows.Count; i++)
                {
                    object codigo = dtgPesquisaProfessor.Rows[i].Cells["COD_PROF_PESQUISA"].Value;

                    if (
                        celulaAntiga.professores.Count >= 1 &&
                        find1 == false &&
                        Convert.ToInt32(codigo) == celulaAntiga.professores.ElementAt(0))
                    {
                        dtgPesquisaProfessor.Rows[i].Cells["SELECT_PROFESSOR"].Value = true;
                        find1 = true;
                    }

                    if (
                        celulaAntiga.professores.Count >= 2 &&
                        find2 == false &&
                        Convert.ToInt32(codigo) == celulaAntiga.professores.ElementAt(1))
                    {
                        dtgPesquisaProfessor.Rows[i].Cells["SELECT_PROFESSOR"].Value = true;
                        find2 = true;
                    }

                    if (
                        celulaAntiga.professores.Count >= 3 &&
                        find3 == false &&
                        Convert.ToInt32(codigo) == celulaAntiga.professores.ElementAt(2))
                    {
                        dtgPesquisaProfessor.Rows[i].Cells["SELECT_PROFESSOR"].Value = true;
                        find3 = true;
                    }
                }

                btnFimEdicao.Enabled = true;
                cbbSelectFase.Enabled = cbbSelectSemestre.Enabled = btnCarregaGrade.Enabled = btnEditar.Enabled = false;
                btnCancelar.Enabled = btnSalvar.Enabled = btnGerarRelatorio.Enabled = tblGrade.Enabled = gbDisciplina.Enabled = false;
                gbProfessor.Enabled = gbSala.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nInner:\n" + ex.InnerException);
            }

        }

        private void itmExcluir_Click(object sender, EventArgs e)
        {
            if (hoverGrade.Rows.Count.Equals(0)) { return; }

            if (hoverGrade.SelectedRows.Count == 0)
            {
                MessageBox.Show("É necessário selecionar uma célula para excluí-la.", "Selecione uma célula", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                Modelos.Celula celula = new Modelos.Celula();
                gradeRN = new RegraNegocio.GradeHorarioRegraNegocio(this.curso, ref contextoUniversal);

                celula.disciplina = hoverGrade.Rows[hoverGrade.CurrentRow.Index].Cells[2].Value.ToString();
                celula.turma = hoverGrade.Rows[hoverGrade.CurrentRow.Index].Cells[3].Value.ToString();
                celula.espaco = hoverGrade.Rows[hoverGrade.CurrentRow.Index].Cells[4].Value.ToString();
                celula.semestre = Convert.ToInt32(cbbSelectSemestre.ComboBox.SelectedValue);
                celula.hora = tblGrade.GetPositionFromControl(hoverGrade).Row;
                celula.dia = tblGrade.GetPositionFromControl(hoverGrade).Column;

                gradeRN.ApagaCelula(ref tblGrade, celula);

                hoverGrade.Rows.RemoveAt(hoverGrade.CurrentRow.Index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                gradeRN = new RegraNegocio.GradeHorarioRegraNegocio(this.curso, ref contextoUniversal);

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
                gradeRN = new RegraNegocio.GradeHorarioRegraNegocio(this.curso, ref contextoUniversal);
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
                        string turma = query.Rows[i].Field<string>("CODIGO_TURMA");
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
                throw new Exception(ex.Message);
            }
        }

        private void LimpaSelecaoTabelas()
        {
            dtgPesquisaDisciplina.EndEdit();
            dtgPesquisaEspaco.EndEdit();
            dtgPesquisaProfessor.EndEdit();

            for (int i = 0; i < dtgPesquisaDisciplina.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dtgPesquisaDisciplina.Rows[i].Cells["SELECT_DISCIPLINA"].Value) == true)
                {
                    dtgPesquisaDisciplina.Rows[i].Cells["SELECT_DISCIPLINA"].Value = false;
                }
            }

            for (int i = 0; i < dtgPesquisaEspaco.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dtgPesquisaEspaco.Rows[i].Cells["SELECT_ESPACO"].Value) == true)
                {
                    dtgPesquisaEspaco.Rows[i].Cells["SELECT_ESPACO"].Value = false;
                }
            }

            for (int i = 0; i < dtgPesquisaProfessor.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dtgPesquisaProfessor.Rows[i].Cells["SELECT_PROFESSOR"].Value) == true)
                {
                    dtgPesquisaProfessor.Rows[i].Cells["SELECT_PROFESSOR"].Value = false;
                }
            }

            dtgPesquisaDisciplina.ClearSelection();
            dtgPesquisaEspaco.ClearSelection();
            dtgPesquisaProfessor.ClearSelection();
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

        /// <summary>
        /// Limpa a seleção de todas células exceto a que invocou o evento 'CellClick'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        private void SelecionaCampoMarcado(ref string disciplina, ref string espaco, ref List<int> professores, ref string turma)
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
                    turma = dtgPesquisaDisciplina.Rows[i].Cells["CODIGO_TURMA"].Value.ToString();
                    break;
                }
            }

            // Seleção do(s) professor(es).
            for (int i = 0; i < dtgPesquisaProfessor.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dtgPesquisaProfessor.Rows[i].Cells["SELECT_PROFESSOR"].Value) == true)
                {
                    professores.Add(Convert.ToInt32(dtgPesquisaProfessor.Rows[i].Cells["COD_PROF_PESQUISA"].Value));

                    if (professores.Count == 3) { break; }
                }
            }

            // Seleção da espaço.
            for (int i = 0; i < dtgPesquisaEspaco.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dtgPesquisaEspaco.Rows[i].Cells["SELECT_ESPACO"].Value) == true)
                {
                    espaco = dtgPesquisaEspaco.Rows[i].Cells["COD_ESP_PESQUISA"].Value.ToString();
                    break;
                }
            }
        }

        private void btnFimEdicao_Click(object sender, EventArgs e)
        {
            try
            {
                VerificaSelecaoTabelas();

                // Recolhimento de informações da nova célula.
                string disciplina, espaco, turma;
                List<int> professores = new List<int>();

                disciplina = espaco = turma = string.Empty;

                SelecionaCampoMarcado(ref disciplina, ref espaco, ref professores, ref turma);

                gradeRN = new RegraNegocio.GradeHorarioRegraNegocio(this.curso, ref contextoUniversal);


                celulaNova.hora = tblGrade.GetPositionFromControl(hoverGrade).Row;
                celulaNova.dia = tblGrade.GetPositionFromControl(hoverGrade).Column;
                celulaNova.disciplina = disciplina;
                celulaNova.espaco = espaco;
                celulaNova.fase = Convert.ToInt32(cbbSelectFase.ComboBox.SelectedValue);
                celulaNova.professores = professores;
                celulaNova.semestre = Convert.ToInt32(cbbSelectSemestre.ComboBox.SelectedValue);
                celulaNova.turma = turma;

                gradeRN.EditaGrade(ref tblGrade, celulaAntiga, celulaNova);

                hoverGrade.Rows[hoverGrade.CurrentRow.Index].Cells[4].Value = celulaNova.espaco;

                hoverGrade.Rows[hoverGrade.CurrentRow.Index].Cells[5].Value = celulaNova.professores.ElementAt(0);
                if (celulaNova.professores.Count >= 2)
                {
                    hoverGrade.Rows[hoverGrade.CurrentRow.Index].Cells[6].Value = celulaNova.professores.ElementAt(1);

                    if (celulaNova.professores.Count == 3)
                    {
                        hoverGrade.Rows[hoverGrade.CurrentRow.Index].Cells[7].Value = celulaNova.professores.ElementAt(2);
                    }
                    else
                    {
                        hoverGrade.Rows[hoverGrade.CurrentRow.Index].Cells[7].Value = null;
                    }
                }
                else
                {
                    hoverGrade.Rows[hoverGrade.CurrentRow.Index].Cells[6].Value = null;
                }

                bool asked = false;
                bool answer = false;
                foreach (var item in tblGrade.Controls)
                {
                    if (item is DataGridView && (item as DataGridView).Rows.Count > 0)
                    {
                        DataGridView temp = item as DataGridView;

                        for (int i = 0; i < temp.Rows.Count; i++)
                        {
                            if (temp.Rows[i].Cells[2].Value.ToString() == celulaNova.disciplina &&
                                temp.Rows[i].Cells[3].Value.ToString() == celulaNova.turma)
                            {
                                temp.Rows[i].Cells[5].Value = celulaNova.professores.ElementAt(0);

                                if (celulaNova.professores.Count >= 2)
                                {
                                    temp.Rows[i].Cells[6].Value = celulaNova.professores.ElementAt(1);

                                    if (celulaNova.professores.Count == 3)
                                    {
                                        temp.Rows[i].Cells[7].Value = celulaNova.professores.ElementAt(2);
                                    }
                                }

                                if (asked == false)
                                {
                                    if (MessageBox.Show("Deseja aplicar a alteração de espaço aos demais horários?", "Aplicar alterações de espaço", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        answer = true;
                                    }
                                    else
                                    {
                                        answer = false;
                                    }

                                    asked = true;
                                }

                                if (answer == true &&
                                    celulaNova.espaco != temp.Rows[i].Cells[4].Value.ToString())
                                {
                                    temp.Rows[i].Cells[4].Value = celulaNova.espaco;
                                }
                            }
                        }
                    }
                }

                if(answer == true)
                {
                    ///// TRANSFERIR PARA O ACESSO DADOS
                    var query1 = contextoUniversal.DISCIPLINA_TURMA.Local.Where(p =>
                                    p.SEQ_SEMESTRE == celulaNova.semestre &&
                                    p.CODIGO_CURSO == this.curso.CODIGO_CURSO &&
                                    p.CODIGO_DISCIPLINA == celulaNova.disciplina &&
                                    p.CODIGO_TURMA == celulaNova.turma).First();

                    var query = contextoUniversal.GRADE_TURMA.Local.Where(p => p.SEQ_DISCIPLINA_TURMA == query1.SEQ_DISCIPLINA_TURMA).ToList();

                    foreach (var grade in query)
                    {
                        if (contextoUniversal.Entry(grade).State == System.Data.Entity.EntityState.Added)
                        {
                            grade.CODIGO_ESPACO = celulaNova.espaco;
                            contextoUniversal.Entry(grade).State = System.Data.Entity.EntityState.Added;
                        }
                        else
                        {
                            grade.CODIGO_ESPACO = celulaNova.espaco;
                        }
                    }
                    ////////////////////
                }
            
                this.LimpaSelecaoTabelas();

                btnFimEdicao.Enabled = false;
                cbbSelectFase.Enabled = cbbSelectSemestre.Enabled = btnCarregaGrade.Enabled = btnEditar.Enabled = false;
                btnCancelar.Enabled = btnSalvar.Enabled = btnGerarRelatorio.Enabled = tblGrade.Enabled = true;
                gbDisciplina.Enabled = gbProfessor.Enabled = gbSala.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}