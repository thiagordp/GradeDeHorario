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
        private Modelos.CURSO curso { set; get; }

        public frmPrincipal(Modelos.CURSO curso)
        {
            InitializeComponent();

            this.curso = curso;
            this.Text = "Grade de horários - " + curso.NOME_CURSO;
        }

        private void btnGradeHorario_Click(object sender, EventArgs e)
        {
            (new frmGradeHorario(curso)).ShowDialog();
        }

        private void btnDisciplina_Click(object sender, EventArgs e)
        {
            (new frmDisciplina()).ShowDialog();
        }
        
        private void btnFase_Click(object sender, EventArgs e)
        {
            (new frmFase(curso)).ShowDialog();
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            (new frmProfessor()).ShowDialog();
        }

        private void btnInfraEstrutura_Click(object sender, EventArgs e)
        {
            (new frmInfraEstrutura()).ShowDialog();
        }

        private void btnSemestre_Click(object sender, EventArgs e)
        {
            (new frmSemestre(curso)).ShowDialog();
        }

        private void btnTurma_Click(object sender, EventArgs e)
        {
            (new frmTurma(curso)).ShowDialog();
        }
    }
}
