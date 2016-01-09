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

            dtgDisciplina.Rows.Add("ARA1234", "Inteligência Artificial II", "4", "ARA312", "DEC - Depto. de Computação");
            dtgDisciplina.Rows.Add("ARA1235", "Inteligência Artificial II", "4", "ARA311", "ENS - Depto. de Energia e Sustentabilidade");
        }

        private void btnSelecionaRequisito_Click(object sender, EventArgs e)
        {
            List<object> teste = new List<object>();

            (new frmSelecionaDisciplina(teste)).ShowDialog();

            MessageBox.Show(teste.First<object>().ToString());

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
    }
}
