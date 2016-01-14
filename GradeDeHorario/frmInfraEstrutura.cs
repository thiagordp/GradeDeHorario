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
    public partial class frmInfraEstrutura : Form
    {
        public frmInfraEstrutura()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            gbSala.Enabled = btnSalvar.Enabled = btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            
            try
            {
                InfraestruturaRegraNegocio novoespaco = new InfraestruturaRegraNegocio();
                
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpar();



                MessageBox.Show("Alterações realizadas com sucesso!", "Alterações concluídas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnNovo.Enabled = true;
                btnCancelar.Enabled = btnExcluir.Enabled = btnSalvar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja excluir o espaço selecionado?", "Exclusão de espaço", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Excluir disciplina
                    Limpar();
                    EstadoEditacao(false);
                    MessageBox.Show("Espaço excluído com sucesso!", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao excluir espaço", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EstadoEditacao(bool estado)
        {
            btnCancelar.Enabled = btnSalvar.Enabled = btnExcluir.Enabled = gbSala.Enabled = estado;
        }

        private void Limpar()
        {
            txtIdentificacao.Clear();
            nudCapacidade.Value = nudNumComputador.Value = 1;
            dtgInfraestrutura.Rows.Clear();
            cbbTipoEspaco.SelectedIndex = -1;
            EstadoEditacao(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            btnNovo.Enabled = true;
        }

        private void dtgInfraestrutura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EstadoEditacao(true);

            txtIdentificacao.Text = dtgInfraestrutura.Rows[e.RowIndex].Cells["CODIGO_ESPACO"].Value.ToString();

            cbbTipoEspaco.SelectedItem = dtgInfraestrutura.Rows[e.RowIndex].Cells["TIPO_ESPACO"].Value.ToString();
            nudCapacidade.Value = Convert.ToDecimal(dtgInfraestrutura.Rows[e.RowIndex].Cells["CAPACIDADE_ESPACO"].Value.ToString());
            nudNumComputador.Value = Convert.ToDecimal(dtgInfraestrutura.Rows[e.RowIndex].Cells["COMPUTADOR_ESPACO"].Value.ToString());
            chkInternet.Checked = Convert.ToBoolean(dtgInfraestrutura.Rows[e.RowIndex].Cells["INTERNET_ESPACO"].Value);
            chkProjetor.Checked = Convert.ToBoolean(dtgInfraestrutura.Rows[e.RowIndex].Cells["PROJETOR_ESPACO"].Value);
            chkQuadroBranco.Checked = Convert.ToBoolean(dtgInfraestrutura.Rows[e.RowIndex].Cells["QUADRO_BRANCO_ESPACO"].Value);
            chkQuadroVidro.Checked = Convert.ToBoolean(dtgInfraestrutura.Rows[e.RowIndex].Cells["QUADRO_VIDRO_ESPACO"].Value);

            // Verificar como resgatar os requisitos
        }
    }
}
