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
    public partial class frmGradeHorario : Form
    {
        private int curso;

        public frmGradeHorario(int curso)
        {
            InitializeComponent();
            this.curso = curso;
            InicializaGrade();


        }

        //Adicionar no BD um n..n na Grade com a Disci_Turma
        private void InicializaGrade()
        {
            int i = 0;

            for (i = 0; i < 14; i++)
            {
                dtgGradeHorario.Rows.Add();
            }
            i = 0;
            dtgGradeHorario.Rows[i++].HeaderCell.Value = "7:30 - 8:20";
            dtgGradeHorario.Rows[i++].HeaderCell.Value = "7:30 - 8:20";
            dtgGradeHorario.Rows[i++].HeaderCell.Value = "7:30 - 8:20";
            dtgGradeHorario.Rows[i++].HeaderCell.Value = "7:30 - 8:20";
            dtgGradeHorario.Rows[i++].HeaderCell.Value = "7:30 - 8:20";
            dtgGradeHorario.Rows[i++].HeaderCell.Value = "7:30 - 8:20";
            dtgGradeHorario.Rows[i++].HeaderCell.Value = "7:30 - 8:20";
            dtgGradeHorario.Rows[i++].HeaderCell.Value = "7:30 - 8:20";
            dtgGradeHorario.Rows[i++].HeaderCell.Value = "7:30 - 8:20";
            dtgGradeHorario.Rows[i++].HeaderCell.Value = "7:30 - 8:20";

            //dtgGradeHorario.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dtgGradeHorario.RowHeadersWidth = 100;
        }
    }
}
