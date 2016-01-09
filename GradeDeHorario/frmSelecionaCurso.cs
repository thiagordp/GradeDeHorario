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
    public partial class frmSelecionaCurso : Form
    {
        public frmSelecionaCurso()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbbCurso.SelectedIndex == -1)
            {
                MessageBox.Show("É necessário selecionar um curso para iniciar o sistema.", "Selecione um curso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                (new frmPrincipal(cbbCurso.SelectedIndex)).ShowDialog();
            }
        }
    }
}
