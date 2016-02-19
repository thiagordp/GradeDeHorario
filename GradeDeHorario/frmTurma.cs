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
    public partial class frmTurma : Form
    {
        private Modelos.CURSO curso;
        private RegraNegocio.TurmaRegraNegocio turmaRn;
        private Modelos.TURMA turmaAntiga;
        private bool novoRegistro = false;

        public frmTurma(Modelos.CURSO curso)
        {
            InitializeComponent();
            this.curso = curso;

            turmaAntiga = new Modelos.TURMA();
        }

        private void SelecionaTodaTurma()
        {
            try
            {
                turmaRn = new RegraNegocio.TurmaRegraNegocio();

                dtgTurma.DataSource = turmaRn.SelecionaTodaTurma();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtTurma.Enabled = btnCancelar.Enabled = btnSalvar.Enabled = novoRegistro = true;
            btnNovo.Enabled = btnExcluir.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                turmaRn = new RegraNegocio.TurmaRegraNegocio();

                Modelos.TURMA novaTurma = new Modelos.TURMA();
                novaTurma.CODIGO_TURMA = txtTurma.Text;

                if (novoRegistro)
                {
                    turmaRn.InsereTurma(novaTurma);

                    MessageBox.Show("Turma inserida com sucesso.", "Inserção concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Modelos.TURMA turmaAnt = new Modelos.TURMA();
                    turmaAnt = turmaAntiga;

                    turmaRn.EditaTurma(turmaAntiga, novaTurma);
                    MessageBox.Show("Turma alterada com sucesso.", "Inserção concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                SelecionaTodaTurma();
                btnExcluir.Enabled = btnSalvar.Enabled = btnCancelar.Enabled = txtTurma.Enabled = false;
                btnNovo.Enabled = true;
                txtTurma.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Você realmente deseja excluir o espaço selecionado?", "Exclusão de espaço", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    turmaRn = new RegraNegocio.TurmaRegraNegocio();

                    Modelos.TURMA novaTurma = new Modelos.TURMA();
                    novaTurma.CODIGO_TURMA = txtTurma.Text;

                    turmaRn.ExcluiTurma(novaTurma);

                    SelecionaTodaTurma();
                    btnExcluir.Enabled = btnSalvar.Enabled = btnCancelar.Enabled = txtTurma.Enabled = false;
                    btnNovo.Enabled = true;
                    txtTurma.Clear();
                    MessageBox.Show("Turma excluída com sucesso!", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtTurma.Enabled = btnExcluir.Enabled = btnSalvar.Enabled = btnCancelar.Enabled = txtTurma.Enabled = false;
            btnNovo.Enabled = true;

            txtTurma.Clear();
        }

        private void dtgTurma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnNovo.Enabled == false)
            {
                MessageBox.Show("Não é possível editar uma turma enquanto outra estiver sendo editada.");
                return;
            }
            try
            {
                turmaRn = new RegraNegocio.TurmaRegraNegocio();

                turmaAntiga.CODIGO_TURMA = txtTurma.Text = dtgTurma.Rows[e.RowIndex].Cells["CODIGO_TURMA"].Value.ToString();

                turmaRn.VerificaTurmaAlocada(turmaAntiga);

                btnSalvar.Enabled = btnExcluir.Enabled = btnCancelar.Enabled = txtTurma.Enabled = true;
                btnNovo.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnExcluir.Enabled = btnSalvar.Enabled = btnCancelar.Enabled = txtTurma.Enabled = false;
                btnNovo.Enabled = true;
                txtTurma.Clear();
            }
        }

        private void frmTurma_Load(object sender, EventArgs e)
        {
            SelecionaTodaTurma();
        }
    }
}
