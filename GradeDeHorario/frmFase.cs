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
    public partial class frmFase : Form
    {
        private bool ativo = false;
        private Modelos.CURSO curso;
        private RegraNegocio.FaseRegraNegocio faseRN;
        private DataGridView tabelaFaseAntiga;

        private bool edit = true;

        //
        public frmFase(Modelos.CURSO curso)
        {
            InitializeComponent();

            this.curso = curso;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Adicionar comando para remover disciplinas da fase
            if (MessageBox.Show("Você realmente deseja excluir as disciplinas da fase?", "Exclusão de disciplinas da fase", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Excluir disciplina
                    dtgDisciplinaFase.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao excluir disciplinas da fase\n\nDetalhe:\n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                faseRN = new RegraNegocio.FaseRegraNegocio();
                faseRN.SalvaFase(tabelaFaseAntiga, dtgDisciplinaFase, Convert.ToInt32(cbbFase.SelectedValue), curso.CODIGO_CURSO);

                MessageBox.Show("Fase salva com sucesso!");
                btnEditar.Enabled = cbbFase.Enabled = true;
                dtgDisciplinaFase.ClearSelection();
                dtgListaDisciplina.ClearSelection();
                btnExcluir.Enabled = btnSalvar.Enabled = btnCancelar.Enabled = dtgListaDisciplina.Enabled = dtgDisciplinaFase.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = cbbFase.Enabled = true;
            dtgDisciplinaFase.Rows.Clear();
            PreencheListaDisciplina(txtPesquisaDisciplina.Text);
            cbbFase.SelectedIndex = -1;
            dtgDisciplinaFase.ClearSelection();
            dtgListaDisciplina.ClearSelection();
            btnExcluir.Enabled = btnSalvar.Enabled = btnCancelar.Enabled = dtgListaDisciplina.Enabled = dtgDisciplinaFase.Enabled = false;
        }

        private void dtgListaDisciplina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo = dtgListaDisciplina.Rows[e.RowIndex].Cells["CODIGO_DISCIPLINA_FASE"].Value.ToString();
            string nome = dtgListaDisciplina.Rows[e.RowIndex].Cells["NOME_DISCIPLINA_FASE"].Value.ToString();
            int credito = Convert.ToInt32(dtgListaDisciplina.Rows[e.RowIndex].Cells["CREDITO_DISCIPLINA_FASE"].Value);

            // Verificação para garantir que a nova disciplina não está alocada na fase.
            for (int i = 0; i < dtgDisciplinaFase.Rows.Count; i++)
            {
                if (dtgDisciplinaFase.Rows[i].Cells["CODIGO_DISCIPLINA"].Value.ToString().Equals(codigo) == true)
                {
                    MessageBox.Show("A disciplina selecionada já está na lista da fase atual.", "A disciplina já está na lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Caso a disciplina não esteja, ela é adicionada. //

            // Adição da disciplina na lista.
            dtgDisciplinaFase.Rows.Add(codigo, nome, credito);
            // Ordenação da lista.
            dtgDisciplinaFase.Sort(dtgDisciplinaFase.Columns[1], ListSortDirection.Ascending);

            // Limpa a seleção das tabelas.
            dtgListaDisciplina.ClearSelection();
            dtgDisciplinaFase.ClearSelection();
        }

        private void dtgDisciplinaFase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dtgDisciplinaFase.Rows.RemoveAt(e.RowIndex);
                dtgDisciplinaFase.Sort(dtgDisciplinaFase.Columns[1], ListSortDirection.Ascending);
                dtgDisciplinaFase.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbFase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ativo) { return; }

            PreencheTabelaDisciplina();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cbbFase.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma fase do curso antes de começar.", "Selecione uma fase", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tabelaFaseAntiga = CopyDataGridView(dtgDisciplinaFase);

            btnEditar.Enabled = cbbFase.Enabled = false;
            btnExcluir.Enabled = btnSalvar.Enabled = btnCancelar.Enabled = dtgListaDisciplina.Enabled = dtgDisciplinaFase.Enabled = true;
        }

        private void frmFase_Load(object sender, EventArgs e)
        {
            PreencheListaFase();
            PreencheListaDisciplina(txtPesquisaDisciplina.Text);

            ativo = true;

            btnExcluir.Enabled = btnSalvar.Enabled = btnCancelar.Enabled = false;
        }

        private void PreencheListaFase()
        {
            int qtd_fase = Convert.ToInt32(curso.QTD_FASE);
            cbbFase.Items.Clear();

            DataTable tabela = new DataTable();

            tabela.Columns.Add("NUMERO_FASE", typeof(int));
            tabela.Columns.Add("NOME_FASE", typeof(string));

            for (int i = 1; i <= qtd_fase; i++)
            {
                tabela.Rows.Add(i, i.ToString() + "a FASE");
            }

            cbbFase.DataSource = tabela;

            cbbFase.ValueMember = "NUMERO_FASE";
            cbbFase.DisplayMember = "NOME_FASE";

            cbbFase.SelectedIndex = -1;
        }

        /// <summary>
        /// Preenche a lista de pesquisa de disciplinas com aquelas que comecem com o conteúdo de 'nome'.
        /// </summary>
        /// <param name="nome"></param>
        private void PreencheListaDisciplina(string nome)
        {
            faseRN = new RegraNegocio.FaseRegraNegocio();

            dtgListaDisciplina.DataSource = faseRN.SelecionaDisciplina(nome);
        }

        private void txtPesquisaDisciplina_TextChanged(object sender, EventArgs e)
        {
            PreencheListaDisciplina(txtPesquisaDisciplina.Text);
        }

        /// <summary>
        /// Preenche a tabela de disciplinas.
        /// </summary> 
        private void PreencheTabelaDisciplina()
        {
            faseRN = new RegraNegocio.FaseRegraNegocio();

            DataTable tabela = faseRN.SelecionaDisciplinaFase(Convert.ToInt32(cbbFase.SelectedValue), curso.CODIGO_CURSO);
            dtgDisciplinaFase.Rows.Clear();

            foreach (DataRow linha in tabela.Rows)
            {
                dtgDisciplinaFase.Rows.Add(linha[0], linha[1], linha[2]);
            }

            dtgDisciplinaFase.ClearSelection();
            dtgListaDisciplina.ClearSelection();
        }

        /// <summary>
        /// Copia o conteúdo de um datagridview para outro.
        /// </summary>
        /// <param name="tabela"></param>
        /// <returns></returns>
        private DataGridView CopyDataGridView(DataGridView tabela)
        {
            DataGridView tabelaCopia = new DataGridView();
            try
            {
                if (tabelaCopia.Columns.Count == 0)
                {
                    foreach (DataGridViewColumn dgvc in tabela.Columns)
                    {
                        tabelaCopia.Columns.Add(dgvc.Clone() as DataGridViewColumn);
                    }
                }

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    row = (DataGridViewRow)tabela.Rows[i].Clone();
                    int intColIndex = 0;
                    foreach (DataGridViewCell cell in tabela.Rows[i].Cells)
                    {
                        row.Cells[intColIndex].Value = cell.Value;
                        intColIndex++;
                    }
                    tabelaCopia.Rows.Add(row);
                }
                tabelaCopia.AllowUserToAddRows = false;
                tabelaCopia.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabelaCopia;
        }
    }
}
