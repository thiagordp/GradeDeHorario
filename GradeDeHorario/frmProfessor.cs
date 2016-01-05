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
    public partial class frmProfessor : Form
    {
        public frmProfessor()
        {
            InitializeComponent();
            dtgProfessor.Rows.Add("1234", "FULANO DE TAL", "Dep. de Computação");
            dtgProfessor.Rows.Add("4987", "CICLANO PEREIRA", "Dep. de Engenharia");
            dtgProfessor.Rows.Add("4351", "BELTRANO ITAL", "Dep. de Fisioterapia");
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = false;
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

        private void btnSalvarEdicao_Click(object sender, EventArgs e)
        {
            try
            {
                LimparTudo();
                btnNovo.Enabled = true;
                MessageBox.Show("Alterações realizadas com sucesso!", "Alterações concluídas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelarEdicao_Click(object sender, EventArgs e)
        {
            LimparTexto();

        }

        private void LimparTudo()
        {
            txtCodigoProfessor.Clear();
            txtNomeProfessor.Clear();
            dtgProfessor.Rows.Clear();

            EstadoEditacao(false);
            /**** Chamar novamente a consulta de seleção da tabela de disciplinas ****/
        }

        private void LimparTexto()
        {
            txtCodigoProfessor.Clear();
            txtNomeProfessor.Clear();
            EstadoEditacao(false);
        }
        private void EstadoEditacao(bool estado)
        {
            btnCancelar.Enabled = btnSalvar.Enabled = btnExcluir.Enabled = estado;
            btnNovo.Enabled = !estado;
        }

        private void dtgProfessor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EstadoEditacao(true);


            txtCodigoProfessor.Text = dtgProfessor.Rows[e.RowIndex].Cells["CODIGO_PROFESSOR"].Value.ToString();
            txtNomeProfessor.Text = dtgProfessor.Rows[e.RowIndex].Cells["NOME_PROFESSOR"].Value.ToString();
            cbbDepartamento.SelectedItem = dtgProfessor.Rows[e.RowIndex].Cells["DEP_PROFESSOR"].Value.ToString();
        }
    }
}
