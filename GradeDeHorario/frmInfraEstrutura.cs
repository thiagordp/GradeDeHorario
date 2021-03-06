﻿using System;
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
        private InfraestruturaRegraNegocio infraEstruturaRN;            // Referência ao objeto da camada de regra de negócios.
        private bool novoRegistro = false;                              // Indica que é um novo registro caso 1 ou já existe caso contrário.
        private Modelos.ESPACO espacoAntigo = new Modelos.ESPACO();     // Referência ao estado do espaço anterior à edição.

        /// <summary>
        /// Construtor
        /// </summary>
        public frmInfraEstrutura()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            gbSala.Enabled = btnSalvar.Enabled = btnCancelar.Enabled = true;
            btnNovo.Enabled = false;

            novoRegistro = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Modelos.ESPACO espaco = new Modelos.ESPACO();

                espaco.CODIGO_ESPACO = txtIdentificacao.Text;
                espaco.CAPACIDADE_ESPACO = Convert.ToInt32(nudCapacidade.Value);
                espaco.TIPO_ESPACO = cbbTipoEspaco.SelectedItem.ToString();
                espaco.NUMERO_PC_ESPACO = Convert.ToInt32(nudNumComputador.Value);
                espaco.PROJETOR_ESPACO = chkProjetor.Checked;
                espaco.INTERNET_ESPACO = chkInternet.Checked;
                espaco.QUADRO_BRANCO_ESPACO = chkQuadroBranco.Checked;
                espaco.QUADRO_VIDRO_ESPACO = chkQuadroVidro.Checked;

                infraEstruturaRN = new InfraestruturaRegraNegocio();

                if (novoRegistro == true)
                {
                    infraEstruturaRN.InsereInfraEstrutura(espaco);
                }
                else
                {
                    infraEstruturaRN.EditaInfraEstrutura(espacoAntigo, espaco);
                }


                Limpar();
                PreencheTabela();

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
                    infraEstruturaRN = new InfraestruturaRegraNegocio();

                    infraEstruturaRN.ApagaInfraEstrutura(espacoAntigo);
                    PreencheTabela();

                    Limpar();
                    EstadoEditacao(false);
                    btnNovo.Enabled = true;
                    MessageBox.Show("Espaço excluído com sucesso!", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao excluir espaço", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Estado de botões e afins.
        /// </summary>
        /// <param name="estado"></param>
        private void EstadoEditacao(bool estado)
        {
            btnCancelar.Enabled = btnSalvar.Enabled = btnExcluir.Enabled = gbSala.Enabled = estado;
        }

        /// <summary>
        /// Limpa caixa de texto e de seleção.
        /// </summary>
        private void Limpar()
        {
            txtIdentificacao.Clear();
            nudCapacidade.Value = nudNumComputador.Value = 1;
            cbbTipoEspaco.SelectedIndex = -1;

            chkInternet.Checked = chkProjetor.Checked = chkQuadroBranco.Checked = chkQuadroVidro.Checked = false;

            EstadoEditacao(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            btnNovo.Enabled = true;
        }

        private void dtgInfraestrutura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                EstadoEditacao(true);
                btnNovo.Enabled = false;
                novoRegistro = false;

                txtIdentificacao.Text = espacoAntigo.CODIGO_ESPACO = dtgInfraestrutura.Rows[e.RowIndex].Cells["CODIGO_ESPACO"].Value.ToString();
                cbbTipoEspaco.SelectedItem = espacoAntigo.TIPO_ESPACO = dtgInfraestrutura.Rows[e.RowIndex].Cells["TIPO_ESPACO"].Value.ToString();
                nudCapacidade.Value = Convert.ToDecimal(dtgInfraestrutura.Rows[e.RowIndex].Cells["CAPACIDADE_ESPACO"].Value.ToString());
                nudNumComputador.Value = Convert.ToDecimal(dtgInfraestrutura.Rows[e.RowIndex].Cells["COMPUTADOR_ESPACO"].Value.ToString());
                chkInternet.Checked = bool.Parse(dtgInfraestrutura.Rows[e.RowIndex].Cells["INTERNET_ESPACO"].Value.ToString());
                chkProjetor.Checked = bool.Parse(dtgInfraestrutura.Rows[e.RowIndex].Cells["PROJETOR_ESPACO"].Value.ToString());
                chkQuadroBranco.Checked = bool.Parse(dtgInfraestrutura.Rows[e.RowIndex].Cells["QUADRO_BRANCO_ESPACO"].Value.ToString());
                chkQuadroVidro.Checked = bool.Parse(dtgInfraestrutura.Rows[e.RowIndex].Cells["QUADRO_VIDRO_ESPACO"].Value.ToString());

                espacoAntigo.CAPACIDADE_ESPACO = int.Parse(dtgInfraestrutura.Rows[e.RowIndex].Cells["CAPACIDADE_ESPACO"].Value.ToString());
                espacoAntigo.INTERNET_ESPACO = bool.Parse(dtgInfraestrutura.Rows[e.RowIndex].Cells["INTERNET_ESPACO"].Value.ToString());
                espacoAntigo.NUMERO_PC_ESPACO = int.Parse(dtgInfraestrutura.Rows[e.RowIndex].Cells["COMPUTADOR_ESPACO"].Value.ToString());
                espacoAntigo.PROJETOR_ESPACO = bool.Parse(dtgInfraestrutura.Rows[e.RowIndex].Cells["PROJETOR_ESPACO"].Value.ToString());
                espacoAntigo.QUADRO_BRANCO_ESPACO = bool.Parse(dtgInfraestrutura.Rows[e.RowIndex].Cells["QUADRO_BRANCO_ESPACO"].Value.ToString());
                espacoAntigo.QUADRO_VIDRO_ESPACO = bool.Parse(dtgInfraestrutura.Rows[e.RowIndex].Cells["QUADRO_VIDRO_ESPACO"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Limpar();
                btnNovo.Enabled = true;
                btnCancelar.Enabled = btnExcluir.Enabled = btnSalvar.Enabled = false;
            }

            /*OBS: o campo DISCIPLINA_TURMA do objeto não deve ser alterado, para garantir que nada será perdido.*/
        }

        private void frmInfraEstrutura_Load(object sender, EventArgs e)
        {
            PreencheTabela();
        }

        // Prenche a lista de espaços de acordo com o conteúdo do banco.
        private void PreencheTabela()
        {
            try
            {
                infraEstruturaRN = new InfraestruturaRegraNegocio();
                dtgInfraestrutura.DataSource = infraEstruturaRN.SelecionaTodaInfraEstrutura();
                dtgInfraestrutura.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
