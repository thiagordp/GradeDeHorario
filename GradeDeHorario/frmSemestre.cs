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
    public partial class frmSemestre : Form
    {
        private Modelos.CURSO curso;

        public frmSemestre(Modelos.CURSO curso)
        {
            InitializeComponent();

            this.curso = curso;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            EstadoEditacao(true);
            btnExcluir.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            EstadoEditacao(false);
            LimparTudo();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja excluir o semestre selecionado?", "Exclusão de semestre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Excluir semestre
                    LimparTudo();

                    EstadoEditacao(false);
                    btnExcluir.Enabled = false;
                    MessageBox.Show("Semestre excluído com sucesso!", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao excluir semestre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            EstadoEditacao(false);
            btnExcluir.Enabled = false;
        }

        private void dtgSemestre_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnExcluir.Enabled = true;
            EstadoEditacao(true);

            try
            {
                txtCodigo.Text = dtgSemestre.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                txtNome.Text = dtgSemestre.Rows[e.RowIndex].Cells["NOME"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EstadoEditacao(bool estado)
        {
            btnCancelar.Enabled = btnSalvar.Enabled = gbSemestre.Enabled = estado;
            btnNovo.Enabled = !estado;
        }

        private void LimparTudo()
        {
            foreach (Component componente in this.Controls)
            {
                if (componente is TextBox)
                {
                    (componente as TextBox).Clear();
                }
            }
        }
    }
}
