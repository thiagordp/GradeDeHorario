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
        public frmDisciplina()
        {
            InitializeComponent();
            dtgDisciplina.Rows.Add("ARA1234", "Inteligência Artificial II", "4", "ARA312");
            dtgDisciplina.Rows.Add("ARA1235", "Inteligência Artificial II", "4", "ARA312");
            dtgDisciplina.Rows.Add("ARA12342", "Inteligência Artificial II", "4", "ARA312");
            dtgDisciplina.Rows.Add("ARA12304", "Inteligência Artificial II", "4", "ARA312");
            dtgDisciplina.Rows.Add("ARA1236544", "Inteligência Artificial II", "4", "ARA312");
            dtgDisciplina.Rows.Add("ARA123144", "Inteligência Artificial II", "4", "ARA312");
            dtgDisciplina.Rows.Add("ARA12394", "Inteligência Artificial II", "4", "ARA312");

        }

        private void btnSelecionaRequisito_Click(object sender, EventArgs e)
        {
            (new frmSelecionaDisciplina()).ShowDialog();
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
            EstadoEditacao(false);
        }

        private void LimparTudo()
        {
            txtCodigo.Clear();
            txtNomeDisciplina.Clear();
            nudCreditoDisplicina.Value = 1;
            dtgDisciplinaRequisito.Rows.Clear();

            EstadoEditacao(false);
            /**** Chamar novamente a consulta de seleção da tabela de disciplinas ****/


        }

        private void btnSalvarEdicao_Click(object sender, EventArgs e)
        {
            try
            {
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
            EstadoEditacao(true);


            txtCodigo.Text = dtgDisciplina.Rows[e.RowIndex].Cells["CODIGO_DISCIPLINA"].Value.ToString();
            txtNomeDisciplina.Text = dtgDisciplina.Rows[e.RowIndex].Cells["NOME_DISCIPLINA"].Value.ToString();
            nudCreditoDisplicina.Value = Convert.ToDecimal(dtgDisciplina.Rows[e.RowIndex].Cells["CREDITO_DISCIPLINA"].Value.ToString());

            // Verificar como resgatar os requisitos
        }
    }
}
