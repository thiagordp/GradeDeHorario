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


        public frmDisciplina()
        {
            InitializeComponent();

            dtgDisciplinaRequisito.Rows.Add("ARA3214", "CÁLCULO I");
            dtgDisciplinaRequisito.Rows.Add("ARA1234", "FÍSICA B");

        }

        private void btnSelecionaRequisito_Click(object sender, EventArgs e)
        {
            (new frmSelecionaDisciplina(ref dtgDisciplinaRequisito)).ShowDialog();//teste

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            EstadoEditacao(true);

            btnExcluir.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja excluir a disciplina selecionada?", "Exclusão de disciplina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Excluir disciplina

                    LimparTudo();
                    EstadoEditacao(false);
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
            dtgDisciplinaRequisito.Rows.Clear();
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

                disciplinaRN.InsereDisciplina(disciplina, dtgDisciplinaRequisito);

                LimparTudo();
                MessageBox.Show("Alterações realizadas com sucesso!", "Alterações concluídas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgDisciplina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gbDisciplina.Enabled == true)
            {
                MessageBox.Show("Não é possível editar a disciplina selecionada enquanto outra estiver sendo criada ou editada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EstadoEditacao(true);

            txtCodigo.Text = dtgDisciplina.Rows[e.RowIndex].Cells["CODIGO_DISCIPLINA"].Value.ToString();
            txtNomeDisciplina.Text = dtgDisciplina.Rows[e.RowIndex].Cells["NOME_DISCIPLINA"].Value.ToString();
            nudCreditoDisplicina.Value = Convert.ToDecimal(dtgDisciplina.Rows[e.RowIndex].Cells["CREDITO_DISCIPLINA"].Value.ToString());
            cbbDepartamento.SelectedItem = dtgDisciplina.Rows[e.RowIndex].Cells["DEPARTAMENTO_DISCIPLINA"].Value.ToString();
            // Verificar como resgatar os requisitos
        }

        private void frmDisciplina_Load(object sender, EventArgs e)
        {
            PreencheListaDepartamento();
            PreencheTabelaDisciplina();
        }

        private void PreencheTabelaRequisitos()
        {
            try
            {

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
    }
}
