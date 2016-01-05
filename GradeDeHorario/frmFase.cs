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

        private List<Fase> fases;

        public frmFase()
        {
            InitializeComponent();
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


            //Não deve ser permitido adicionar nova fase, caso a atual ainda não tenha sido salva.
            cbbFase.Items.Add((cbbFase.Items.Count + 1) + "A FASE");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Adicionar comando para remover fase
            if (cbbFase.Items.Count > 0)
            {
                cbbFase.Items.RemoveAt(cbbFase.Items.Count - 1);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Salvar
            btnExcluir.Enabled = btnNovo.Enabled = true;
            btnSalvar.Enabled = btnCancelar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnExcluir.Enabled = btnNovo.Enabled = true;
            btnSalvar.Enabled = btnCancelar.Enabled = false;
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
            if (cbbFase.Items.Count == 0)
            {
                btnExcluir.Enabled = false;
            }
            else
            {
                btnExcluir.Enabled = true;
            }

            btnSalvar.Enabled = btnCancelar.Enabled = true;
        }
    }
}
