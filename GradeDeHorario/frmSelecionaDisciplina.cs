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
    public partial class frmSelecionaDisciplina : Form
    {
        private RegraNegocio.SelecionaDisciplinaRegraNegocio selecionaDisciplinaRN;
        private DataGridView tabelaDisciplina;

        public frmSelecionaDisciplina(ref DataGridView tabelaDisciplina)
        {
            InitializeComponent();
            this.tabelaDisciplina = tabelaDisciplina;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dtgSelecionaDisciplina.EndEdit();
            for (int i = 0; i < dtgSelecionaDisciplina.Rows.Count; i++)
            {
                dtgSelecionaDisciplina.Rows[i].Cells[0].Value = false;
            }

            dtgSelecionaDisciplina.ClearSelection();
        }

        private void ListaRequisito()
        {
            selecionaDisciplinaRN = new RegraNegocio.SelecionaDisciplinaRegraNegocio();

            dtgSelecionaDisciplina.DataSource = selecionaDisciplinaRN.SelecionaTodaDisciplina();
            dtgSelecionaDisciplina.ClearSelection();
        }

        // Verifica a presença de disciplinas já existentes na tabela de requisitos.
        private void VerificaDisciplinaSelecionada()
        {
            try
            {
                string codigo;

                foreach (DataGridViewRow linha in tabelaDisciplina.Rows)
                {
                    codigo = linha.Cells["CODIGO_DISCIPLINA_REQUISITO"].Value.ToString();

                    foreach (DataGridViewRow linha2 in dtgSelecionaDisciplina.Rows)
                    {
                        if (linha2.Cells["CODIGO_DISCIPLINA"].Value.ToString() == codigo)
                        {
                            linha2.Cells["SELECIONA_DISCIPLINA"].Value = true;

                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgSelecionaDisciplina_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string codigo;
            string nome;

            DataTable tabela = new DataTable();
            tabela.Columns.Add("CODIGO_DISCIPLINA");
            tabela.Columns.Add("NOME_DISCIPLINA");



            dtgSelecionaDisciplina.EndEdit();

            for (int i = 0; i < dtgSelecionaDisciplina.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dtgSelecionaDisciplina.Rows[i].Cells["SELECIONA_DISCIPLINA"].Value) == true)
                {
                    codigo = dtgSelecionaDisciplina.Rows[i].Cells["CODIGO_DISCIPLINA"].Value.ToString();
                    nome = dtgSelecionaDisciplina.Rows[i].Cells["NOME_DISCIPLINA"].Value.ToString();

                    tabela.Rows.Add(codigo, nome);
                }
            }

            tabelaDisciplina.DataSource = tabela;
            tabelaDisciplina.Columns["CODIGO_DISCIPLINA_REQUISITO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tabelaDisciplina.Columns["NOME_DISCIPLINA_REQUISITO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.Close();
        }

        private void frmSelecionaDisciplina_Load(object sender, EventArgs e)
        {
            ListaRequisito();
            VerificaDisciplinaSelecionada();
        }
    }
}
