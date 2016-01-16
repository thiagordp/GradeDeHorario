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
        ProfessorRegraNegocio professor;

        public frmProfessor()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = btnExcluir.Enabled = false;
            EstadoEditacao(true);
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
            btnCancelar.Enabled = btnSalvar.Enabled = btnExcluir.Enabled = gbProfessor.Enabled = estado;
            btnNovo.Enabled = !estado;
        }

        private void dtgProfessor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EstadoEditacao(true);

            txtCodigoProfessor.Text = dtgProfessor.Rows[e.RowIndex].Cells["CODIGO_PROFESSOR"].Value.ToString();
            txtNomeProfessor.Text = dtgProfessor.Rows[e.RowIndex].Cells["NOME_PROFESSOR"].Value.ToString();
            cbbDepartamento.SelectedItem = dtgProfessor.Rows[e.RowIndex].Cells["DEP_PROFESSOR"].Value.ToString();
        }

        private void PreencheListaDepartamento()
        {
            try
            {
                professor = new ProfessorRegraNegocio();

                cbbDepartamento.DataSource = professor.SelecionaTodoDepartamento();
                cbbDepartamento.DisplayMember = "NOME_DEPARTAMENTO";
                cbbDepartamento.ValueMember = "CODIGO_DEPARTAMENTO";
                cbbDepartamento.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencheTabelaProfessor()
        {
            try
            {
                professor = new ProfessorRegraNegocio();
                dtgProfessor.DataSource = professor.SelecionaTodoProfessor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmProfessor_Load(object sender, EventArgs e)
        {
            PreencheListaDepartamento();
            PreencheTabelaProfessor();
        }
    }
}
