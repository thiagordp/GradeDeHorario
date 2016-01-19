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
        private Modelos.CURSO curso;

        public frmTurma(Modelos.CURSO curso)
        {
            InitializeComponent();
            this.curso = curso;
        }
    }
}
