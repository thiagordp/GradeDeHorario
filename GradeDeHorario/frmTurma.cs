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
    public partial class frmTurma : Form
    {
        private int curso;

        public frmTurma(int curso)
        {
            InitializeComponent();
            this.curso = curso;
        }
    }
}
