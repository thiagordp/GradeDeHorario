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
        public frmFase()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            dtgDisciplinaFase.Rows.Add("ARA7132", "07655", "Fundamentos Matemáticos para Computação - Entre outros", "4");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
        }
    }
}
