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
    public partial class frmPrincipal : Form
    {
        private Modelos.CURSO curso { set; get; }

        public frmPrincipal(Modelos.CURSO curso)
        {
            InitializeComponent();

            this.curso = curso;

            switch (curso.CODIGO_CURSO)
            {
                case 654:
                    this.Text = "Grade de horários - Fisioterapia";
                    break;
                case 655:
                    this.Text = "Grade de horários - Engenharia de Computação";
                    break;
                case 653:
                    this.Text = "Grade de horários - Engenharia de Energia";
                    break;
                case 652:
                    this.Text = "Grade de horários - Tecnologias da Informação e Comunicação";
                    break;
            }
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
