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
    public partial class frmDisciplina : Form
    {
        public frmDisciplina()
        {
            InitializeComponent();
        }

        private void btnSelecionaRequisito_Click(object sender, EventArgs e)
        {
            (new frmSelecionaDisciplina()).ShowDialog();
        }
    }
}
