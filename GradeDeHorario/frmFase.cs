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
        private int curso;

        public frmFase(int curso)
        {
            InitializeComponent();

            this.curso = curso;

            dtgDisciplinaFase.Rows.Add("ARA1234", "0655", "ANÁLISE DE SINAIS", "4");
            dtgDisciplinaFase.Rows.Add("ARA1244", "0655", "ANÁLISE DE SINAIS", "4");
            dtgDisciplinaFase.Rows.Add("ARA1294", "0655", "ANÁLISE DE SINAIS", "4");
            dtgDisciplinaFase.Rows.Add("ARA1454", "0655", "ANÁLISE DE SINAIS", "4");
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////
            // Adicionar comando para adicionar nova fase //
            ////////////////////////////////////////////////

            btnExcluir.Enabled = btnNovo.Enabled = false;
            btnSalvar.Enabled = btnCancelar.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (cbbFase.Items.Count == 0)
            {
                MessageBox.Show("Não há nenhuma fase cadastrada que possa ser excluída.", "Não é possível excluir fase", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Adicionar comando para remover fase
            if (MessageBox.Show("Você realmente deseja excluir a última fase?", "Exclusão de fase", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Excluir disciplina
                    cbbFase.Items.RemoveAt(cbbFase.Items.Count - 1);
                    MessageBox.Show("Fase excluída com sucesso!", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (cbbFase.Items.Count == 0)
                    {
                        btnExcluir.Enabled = false;
                    }

                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = btnCancelar.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao excluir fase\n\nCausa:\n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Salvar
            //Não deve ser permitido adicionar nova fase, caso a atual ainda não tenha sido salva.
            cbbFase.Items.Add((cbbFase.Items.Count + 1) + "A FASE");

            btnExcluir.Enabled = btnNovo.Enabled = true;
            btnSalvar.Enabled = btnCancelar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnExcluir.Enabled = btnNovo.Enabled = true;
            btnSalvar.Enabled = btnCancelar.Enabled = false;

            if (cbbFase.Items.Count == 0)
            {
                btnExcluir.Enabled = false;
            }
        }

        private void dtgListaDisciplina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Adiciona a lista de disciplina
        }

        private void dtgDisciplinaFase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Remove da lista
        }

        private void cbbFase_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = btnCancelar.Enabled = true;
        }
    }
}
