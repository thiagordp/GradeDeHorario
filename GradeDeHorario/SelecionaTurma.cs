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
    public partial class frmSelecionaTurma : Form
    {
        RegraNegocio.TurmaRegraNegocio turmaRN = new RegraNegocio.TurmaRegraNegocio();
        DataGridView tabelaTurma;

        public frmSelecionaTurma(ref DataGridView tabelaTurma)
        {
            InitializeComponent();
            this.tabelaTurma = tabelaTurma;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dtgSelecionaTurma.EndEdit();

            for (int i = 0; i < dtgSelecionaTurma.Rows.Count; i++)
            {
                dtgSelecionaTurma.Rows[i].Cells[0].Value = false;
            }

            dtgSelecionaTurma.ClearSelection();
        }

        private void ListaTurma()
        {
            turmaRN = new RegraNegocio.TurmaRegraNegocio();

            try
            {
                dtgSelecionaTurma.DataSource = turmaRN.SelecionaTodaTurma();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificaSelecao()
        {
            dtgSelecionaTurma.EndEdit();

            try
            {
                List<DataGridViewRow> linhas = new List<DataGridViewRow>();

                for (int i = 0; i < dtgSelecionaTurma.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dtgSelecionaTurma.Rows[i].Cells["SELECIONA_TURMA"].Value) == true)
                    {
                        linhas.Add(dtgSelecionaTurma.Rows[i]);

                        if (VerificaListaTurma(linhas.Count - 1, linhas) == false)
                        {
                            throw new Exception("Seleção de turmas inválida!\nCertifique-se que para turmas com sufixo A ou B, não existam correspondentes sem. E vice-versa.\n\nExemplo: \n\t01665 e 01655A não é permitido.\n\t01665A e 01665B é permitido");
                        }
                    }
                }

                if (linhas.Count <= 1)
                {
                    string size = linhas[0].Cells["CODIGO_TURMA"].Value.ToString();

                    if (linhas[0].Cells["CODIGO_TURMA"].Value.ToString().ElementAt(size.Count() - 1) >= 'A')
                    {
                        throw new Exception("Seleção incorreta.\nO sufixo ao final da turma (A, B etc.) é utilizado apenas quando há mais de uma turma da mesma disciplina.");
                    }
                    return;
                }

                for (int i = 0; i < linhas.Count; i++)
                {
                    string codigo = linhas[i].Cells["CODIGO_TURMA"].Value.ToString();

                    if (codigo.Count() == 6)
                    {
                        int count = 0;

                        for (int j = 0; j < linhas.Count; j++)
                        {
                            string novo = linhas[j].Cells["CODIGO_TURMA"].Value.ToString();

                            if (j != i && (novo.Count() == 6) && (novo.Contains(codigo.Substring(0, 5)) == true))
                            {
                                count++;
                            }
                        }

                        if (count == 0)
                        {
                            throw new Exception("Seleção incorreta.\nO sufixo ao final da turma (A, B etc.) é utilizado apenas quando há mais de uma turma da mesma disciplina.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool VerificaListaTurma(int index, List<DataGridViewRow> linhas)
        {
            if (linhas.Count <= 1) { return true; }

            string codigo = linhas.ElementAt(index).Cells["CODIGO_TURMA"].Value.ToString();
            int size = codigo.Count();

            string compare = "";
            for (int i = 0; i < linhas.Count; i++)
            {
                if (i != index)
                {
                    compare = linhas.ElementAt(i).Cells["CODIGO_TURMA"].Value.ToString();

                    if (size == 5)
                    {
                        if (compare.Count() == 5 && compare == codigo)
                        {
                            return false;
                        }

                        if (compare.Count() == 6 && compare.Contains(codigo) == true)
                        {
                            return false;
                        }
                    }
                    else // será 6
                    {
                        if (compare.Count() == 5 && codigo.Contains(compare) == true)
                        {
                            return false;
                        }
                        if (compare.Count() == 6 && codigo == compare)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificação da seleção de turmas.
                VerificaSelecao();

                // Altera a tabela do frmDisciplina com as disciplinas selecionadas.
                PreencheTabelaDisciplina();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSelecionaTurma_Load(object sender, EventArgs e)
        {
            ListaTurma();
            PreencheTabelaTurma();
        }

        /// <summary>
        /// Preenche a tabela de turmas do formulário de disciplinas.
        /// </summary>
        private void PreencheTabelaDisciplina()
        {
            string codigo;
            DataTable tabela = new DataTable();

            tabela.Columns.Add("CODIGO_TURMA");

            dtgSelecionaTurma.EndEdit();

            for (int i = 0; i < dtgSelecionaTurma.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dtgSelecionaTurma.Rows[i].Cells["SELECIONA_TURMA"].Value) == true)
                {
                    codigo = dtgSelecionaTurma.Rows[i].Cells["CODIGO_TURMA"].Value.ToString();

                    tabela.Rows.Add(codigo);
                }
            }

            tabelaTurma.DataSource = tabela;
            tabelaTurma.ClearSelection();

            this.Close();
        }

        /// <summary>
        /// Preenche a tabela de seleção de turmas com as previamente selecionadas.
        /// </summary>
        private void PreencheTabelaTurma()
        {
            for (int i = 0; i < tabelaTurma.Rows.Count; i++)
            {
                for (int j = 0; j < dtgSelecionaTurma.Rows.Count; j++)
                {
                    if (dtgSelecionaTurma.Rows[j].Cells["CODIGO_TURMA"].Value.ToString() == tabelaTurma.Rows[i].Cells["CODIGO_TURMA"].Value.ToString())
                    {
                        dtgSelecionaTurma.Rows[j].Cells["SELECIONA_TURMA"].Value = true;
                        break;
                    }
                }
            }
        }
    }
}
