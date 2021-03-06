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
    public partial class frmProfessor : Form
    {
        private AcessoDados.ProfessorRegraNegocio professorRN;              //
        private bool novoRegistro = false;
        private Modelos.PROFESSOR profAntigo = new Modelos.PROFESSOR();

        public frmProfessor()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            EstadoEditacao(true);
            btnNovo.Enabled = btnExcluir.Enabled = false;

            novoRegistro = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja excluir o professor selecionado?", "Exclusão de professor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    professorRN = new AcessoDados.ProfessorRegraNegocio();
                    professorRN.ApagaProfessor(profAntigo);

                    // Excluir professor
                    LimparTudo();
                    EstadoEditacao(false);
                    MessageBox.Show("Professor excluído com sucesso!", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao excluir professor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalvarEdicao_Click(object sender, EventArgs e)
        {
            try
            {
                Modelos.PROFESSOR prof = new Modelos.PROFESSOR();

                prof.CODIGO_PROFESSOR = int.Parse(txtCodigoProfessor.Text);
                prof.CODIGO_DEPARTAMENTO = Convert.ToInt32(cbbDepartamento.SelectedValue);
                prof.NOME_PROFESSOR = txtNomeProfessor.Text;

                professorRN = new AcessoDados.ProfessorRegraNegocio();

                if (novoRegistro == true)
                {
                    professorRN.InsereProfessor(prof);
                }
                else
                {
                    professorRN.EditaProfessor(profAntigo, prof);
                }

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

        /// <summary>
        /// Limpar campos e caixas de seleção
        /// </summary>
        private void LimparTudo()
        {
            professorRN = new AcessoDados.ProfessorRegraNegocio();

            txtCodigoProfessor.Clear();
            txtNomeProfessor.Clear();
            dtgProfessor.DataSource = professorRN.SelecionaTodoProfessor();
            cbbDepartamento.SelectedIndex = -1;
            EstadoEditacao(false);
        }

        /// <summary>
        /// Limpa a caixas de texto
        /// </summary>
        private void LimparTexto()
        {
            txtCodigoProfessor.Clear();
            txtNomeProfessor.Clear();
            cbbDepartamento.SelectedIndex = -1;
            EstadoEditacao(false);
        }

        /// <summary>
        /// Dita o estado de botões e afins de acordo com o parâmetro.
        /// </summary>
        /// <param name="estado">Estado desejado.</param>
        private void EstadoEditacao(bool estado)
        {
            btnCancelar.Enabled = btnSalvar.Enabled = btnExcluir.Enabled = gbProfessor.Enabled = estado;
            btnNovo.Enabled = !estado;
        }

        private void dtgProfessor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            novoRegistro = false;

            try
            {
                EstadoEditacao(true);

                txtCodigoProfessor.Text = dtgProfessor.Rows[e.RowIndex].Cells["CODIGO_PROFESSOR"].Value.ToString();
                txtNomeProfessor.Text = dtgProfessor.Rows[e.RowIndex].Cells["NOME_PROFESSOR"].Value.ToString();
                cbbDepartamento.SelectedValue = dtgProfessor.Rows[e.RowIndex].Cells["CODIGO_DEPARTAMENTO"].Value.ToString();

                profAntigo.CODIGO_PROFESSOR = Convert.ToInt32(txtCodigoProfessor.Text);
                profAntigo.NOME_PROFESSOR = txtNomeProfessor.Text;
                profAntigo.CODIGO_DEPARTAMENTO = Convert.ToInt32(cbbDepartamento.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao interagir com a tabela", MessageBoxButtons.OK, MessageBoxIcon.Error);

                LimparTexto();
                btnNovo.Enabled = true;
                btnCancelar.Enabled = btnExcluir.Enabled = btnSalvar.Enabled = false;
            }
        }

        /// <summary>
        /// Preenche a lista de departamento de acordo com o conteúdo do banco de dados.
        /// </summary>
        private void PreencheListaDepartamento()
        {
            try
            {
                professorRN = new AcessoDados.ProfessorRegraNegocio();

                cbbDepartamento.DataSource = professorRN.SelecionaTodoDepartamento();
                cbbDepartamento.DisplayMember = "NOME_DEPARTAMENTO";
                cbbDepartamento.ValueMember = "CODIGO_DEPARTAMENTO";
                cbbDepartamento.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Preenche a lista de professores de acordo com o conteúdo do banco de dados.
        /// </summary>
        private void PreencheTabelaProfessor()
        {
            try
            {
                professorRN = new AcessoDados.ProfessorRegraNegocio();
                dtgProfessor.DataSource = professorRN.SelecionaTodoProfessor();
                dtgProfessor.ClearSelection();
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
