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
        public frmPrincipal(int index_curso)
        {
            InitializeComponent();

            switch (index_curso)
            {
                case 1:
                    // pnlBackground.BackgroundImage = Properties.Resources.ic_board;
                    break;
                case 2:
                    MessageBox.Show("Teste!!");
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }

        private void btnGradeHorario_Click(object sender, EventArgs e)
        {
            (new frmGradeHorario()).ShowDialog();
        }

        private void btnDisciplina_Click(object sender, EventArgs e)
        {
            (new frmDisciplina()).ShowDialog();
        }

        private void btnFase_Click(object sender, EventArgs e)
        {
            (new frmFase()).ShowDialog();
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            (new frmProfessor()).ShowDialog();
        }

        private void btnInfraEstrutura_Click(object sender, EventArgs e)
        {
            (new frmInfraEstrutura()).ShowDialog();
        }
    }
}
