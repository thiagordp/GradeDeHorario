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
    public partial class frmPrincipal : Form
    {
        /// <summary>
        /// Curso escolhido no início da execução.
        /// </summary>
        private Modelos.CURSO curso { set; get; }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="curso">Curso escolhido</param>
        public frmPrincipal(Modelos.CURSO curso)
        {
            InitializeComponent();

            this.curso = curso;
            this.Text = "Grade de horários - " + curso.NOME_CURSO;
        }

        private void btnGradeHorario_Click(object sender, EventArgs e)
        {
            (new frmGradeHorario(curso)).ShowDialog(); // Cria e executa o formulário para gerenciamento da grade de horários.
        }

        private void btnDisciplina_Click(object sender, EventArgs e)
        {
            (new frmDisciplina()).ShowDialog();     // Cria e executa o formulário para gerenciamento da disciplinas.
        }

        private void btnFase_Click(object sender, EventArgs e)
        {
            (new frmFase(curso)).ShowDialog();  // Cria e executa o formulário para gerenciamento de fases.
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            (new frmProfessor()).ShowDialog();  // Cria e executa o formulário para gerenciamento de professores.
        }

        private void btnInfraEstrutura_Click(object sender, EventArgs e)
        {
            (new frmInfraEstrutura()).ShowDialog(); // Cria e executa o formulário para gerenciamento de infraestrutura.
        }

        private void btnSemestre_Click(object sender, EventArgs e)
        {
            (new frmSemestre(curso)).ShowDialog(); // Cria e executa o formulário para gerenciamento de semestres.
        }

        private void btnTurma_Click(object sender, EventArgs e)
        {
            (new frmTurma(curso)).ShowDialog();     // Cria e executa o formulário para gerenciamento de turma.
        }
    }
}
