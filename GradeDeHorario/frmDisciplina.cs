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
    public partial class frmDisciplina : Form
    {
        private RegraNegocio.DisciplinaRegraNegocio disciplinaRN;
        private Modelos.DISCIPLINA disciplinaAntiga = new Modelos.DISCIPLINA();
        private DataTable requisitoAntigo = new DataTable();
        private DataTable requisitoNovo = new DataTable();
        private bool novoRegistro = false;

        public frmDisciplina()
        {
            InitializeComponent();
        }

        private void btnSelecionaRequisito_Click(object sender, EventArgs e)
        {
            try
            {
                (new frmSelecionaDisciplina(ref dtgDisciplinaRequisito)).ShowDialog();//teste

                if (novoRegistro == true)
                {
                    requisitoAntigo = dtgDisciplinaRequisito.DataSource as DataTable;

                    if (requisitoAntigo == null)
                    {
                        requisitoAntigo = new DataTable();
                    }
                }
                else
                {
                    requisitoNovo = dtgDisciplinaRequisito.DataSource as DataTable;

                    if (requisitoNovo == null)
                    {
                        requisitoNovo = new DataTable();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao selecionar requisitos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            EstadoEditacao(true);

            btnExcluir.Enabled = btnNovo.Enabled = false;

            novoRegistro = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja excluir a disciplina selecionada?\nAs alterações que não foram salvas serão desconsideradas!", "Exclusão de disciplina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    disciplinaRN.ApagaDisciplina(disciplinaAntiga);

                    LimparTudo();
                    EstadoEditacao(false);
                    btnNovo.Enabled = true;
                    PreencheTabelaDisciplina();
                    PreencheListaDepartamento();

                    MessageBox.Show("Disciplina excluída com sucesso!", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao excluir disciplina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparTexto();
            PreencheVazio(ref dtgDisciplinaRequisito);
            btnNovo.Enabled = true;
        }

        private void PreencheVazio(ref DataGridView dtg)
        {
            DataTable tabela = new DataTable();
            tabela.Columns.Add("CODIGO_DISCIPLINA");
            tabela.Columns.Add("NOME_DISCIPLINA");

            dtg.DataSource = tabela;
        }

        private void EstadoEditacao(bool estado)
        {
            btnCancelar.Enabled = btnSalvarEdicao.Enabled = btnExcluir.Enabled = gbDisciplina.Enabled = estado;
        }

        private void LimparTexto()
        {
            txtCodigo.Clear();
            txtNomeDisciplina.Clear();
            nudCreditoDisplicina.Value = 1;
            cbbDepartamento.SelectedIndex = -1;
            EstadoEditacao(false);
        }

        private void LimparTudo()
        {
            txtCodigo.Clear();
            txtNomeDisciplina.Clear();
            nudCreditoDisplicina.Value = 1;
            cbbDepartamento.SelectedIndex = -1;
            EstadoEditacao(false);

            /**** Chamar novamente a consulta de seleção da tabela de disciplinas ****/
        }

        private void btnSalvarEdicao_Click(object sender, EventArgs e)
        {
            try
            {
                Modelos.DISCIPLINA disciplina = new Modelos.DISCIPLINA();

                disciplina.CODIGO_DISCIPLINA = txtCodigo.Text;
                disciplina.CREDITO_DISCIPLINA = Convert.ToInt32(nudCreditoDisplicina.Value);
                disciplina.CODIGO_DEPARTAMENTO = Convert.ToInt32(cbbDepartamento.SelectedValue);
                disciplina.NOME_DISCIPLINA = txtNomeDisciplina.Text;

                disciplinaRN = new RegraNegocio.DisciplinaRegraNegocio(this);

                if (novoRegistro == true)
                {
                    disciplinaRN.InsereDisciplina(disciplina, dtgDisciplinaRequisito);
                }
                else
                {
                    disciplinaRN.EditaDisciplina(disciplinaAntiga, disciplina, requisitoAntigo, requisitoNovo);
                }

                PreencheTabelaDisciplina();
                PreencheVazio(ref dtgDisciplinaRequisito);

                LimparTudo();
                btnNovo.Enabled = true;
                MessageBox.Show("Alterações realizadas com sucesso!", "Alterações concluídas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgDisciplina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Modelos.DISCIPLINA temp = new Modelos.DISCIPLINA();

                if (gbDisciplina.Enabled == true)
                {
                    MessageBox.Show("Não é possível editar a disciplina selecionada enquanto outra estiver sendo criada ou editada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                novoRegistro = false;
                EstadoEditacao(true);
                btnNovo.Enabled = false;

                txtCodigo.Text = dtgDisciplina.Rows[e.RowIndex].Cells["CODIGO_DISCIPLINA"].Value.ToString();
                txtNomeDisciplina.Text = dtgDisciplina.Rows[e.RowIndex].Cells["NOME_DISCIPLINA"].Value.ToString();
                nudCreditoDisplicina.Value = Convert.ToDecimal(dtgDisciplina.Rows[e.RowIndex].Cells["CREDITO_DISCIPLINA"].Value.ToString());
                cbbDepartamento.SelectedValue = dtgDisciplina.Rows[e.RowIndex].Cells["CODIGO_DEPARTAMENTO"].Value.ToString();

                temp.CODIGO_DISCIPLINA = txtCodigo.Text;
                PreencheTabelaRequisitos(temp);

                disciplinaAntiga.CODIGO_DISCIPLINA = txtCodigo.Text;
                disciplinaAntiga.NOME_DISCIPLINA = txtNomeDisciplina.Text;
                disciplinaAntiga.CREDITO_DISCIPLINA = Convert.ToInt32(nudCreditoDisplicina.Value.ToString());
                disciplinaAntiga.CODIGO_DEPARTAMENTO = Convert.ToInt32(cbbDepartamento.SelectedValue.ToString());

                requisitoAntigo = requisitoNovo = dtgDisciplinaRequisito.DataSource as DataTable;

                if (requisitoNovo == null)
                {
                    requisitoAntigo = requisitoNovo = new DataTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmDisciplina_Load(object sender, EventArgs e)
        {
            PreencheListaDepartamento();
            PreencheTabelaDisciplina();
        }

        private void PreencheTabelaRequisitos(Modelos.DISCIPLINA disciplina)
        {
            try
            {
                disciplinaRN = new RegraNegocio.DisciplinaRegraNegocio(this);

                requisitoAntigo = disciplinaRN.SelecionaRequisito(disciplina);
                //dtgDisciplinaRequisito.DataSource = requisitoAntigo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencheListaDepartamento()
        {
            try
            {
                disciplinaRN = new RegraNegocio.DisciplinaRegraNegocio(this);

                cbbDepartamento.DataSource = disciplinaRN.SelecionaTodoDepartamento();
                cbbDepartamento.DisplayMember = "NOME_DEPARTAMENTO";
                cbbDepartamento.ValueMember = "CODIGO_DEPARTAMENTO";
                cbbDepartamento.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencheTabelaDisciplina()
        {
            try
            {
                disciplinaRN = new RegraNegocio.DisciplinaRegraNegocio(this);

                dtgDisciplina.DataSource = disciplinaRN.SelecionaTodaDisciplina();
                dtgDisciplina.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPesquisaDisciplina_TextChanged(object sender, EventArgs e)
        {
            disciplinaRN = new RegraNegocio.DisciplinaRegraNegocio(this);
            dtgDisciplina.DataSource = disciplinaRN.SelecionaDisciplinaPorNome(txtPesquisaDisciplina.Text);
        }

        private void btnSelecionaTurma_Click(object sender, EventArgs e)
        {
            (new frmSelecionaTurma(ref dtgSelecionaTurma)).ShowDialog();
        }
    }
}