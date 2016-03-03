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
        private Modelos.CURSO curso;                                // Curso selecionado.
        private bool novoRegistro;                                  // Indicador de novo registro.
        private RegraNegocio.SemestreRegraNegocio semestreRN;       // Referência a camada de regra de negócio.

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="curso"></param>
        public frmSemestre(Modelos.CURSO curso)
        {
            InitializeComponent();

            this.curso = curso;
            PreencheTabela();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                EstadoEditacao(true);
                btnExcluir.Enabled = btnNovo.Enabled = false;

                novoRegistro = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Modelos.SEMESTRE semestre = new Modelos.SEMESTRE();

                semestre.NOME_SEMESTRE = txtNome.Text;
                if (txtCodigo.Text.Trim().Count() > 0)
                {
                    semestre.SEQ_SEMESTRE = Convert.ToInt32(txtCodigo.Text);
                }

                semestreRN = new RegraNegocio.SemestreRegraNegocio();

                if (novoRegistro == true)
                {
                    semestreRN.InsereSemestre(semestre);
                }
                else
                {
                    semestreRN.AlteraSemestre(semestre);
                }

                LimparTudo();
                PreencheTabela();
                MessageBox.Show("Alterações realizadas com sucesso!", "Alterações concluídas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EstadoEditacao(false);
                btnNovo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja excluir o semestre selecionado?", "Exclusão de semestre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Modelos.SEMESTRE semestre = new Modelos.SEMESTRE();

                    semestre.SEQ_SEMESTRE = Convert.ToInt32(txtCodigo.Text);
                    semestre.NOME_SEMESTRE = txtNome.Text;

                    semestreRN = new RegraNegocio.SemestreRegraNegocio();
                    semestreRN.ApagaSemestre(semestre);

                    LimparTudo();
                    PreencheTabela();
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
            LimparTudo();
            btnExcluir.Enabled = false;
        }

        private void dtgSemestre_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnExcluir.Enabled = true;
            btnNovo.Enabled = false;
            novoRegistro = false;
            EstadoEditacao(true);

            try
            {
                txtCodigo.Text = dtgSemestre.Rows[e.RowIndex].Cells["SEQ_SEMESTRE"].Value.ToString();
                txtNome.Text = dtgSemestre.Rows[e.RowIndex].Cells["NOME_SEMESTRE"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///  Estado de botões e afins.
        /// </summary>
        /// <param name="estado"></param>
        private void EstadoEditacao(bool estado)
        {
            btnCancelar.Enabled = btnSalvar.Enabled = gbSemestre.Enabled = estado;
            btnNovo.Enabled = !estado;
        }

        /// <summary>
        /// Limpa os campos.
        /// </summary>
        private void LimparTudo()
        {
            txtCodigo.Clear();
            txtNome.Clear();
        }

        /// <summary>
        /// Preenche a tabela de acordo com o conteúdo do banco de dados.
        /// </summary>
        private void PreencheTabela()
        {
            semestreRN = new RegraNegocio.SemestreRegraNegocio();

            dtgSemestre.DataSource = semestreRN.SelecionaTodoSemestre();
        }
    }
}