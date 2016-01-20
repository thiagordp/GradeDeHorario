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
    public partial class frmSelecionaDisciplina : Form
    {
        List<object> disciplinaSelecionada;

        public frmSelecionaDisciplina(ref List<object> disciplina)
        {
            InitializeComponent();
            disciplinaSelecionada = disciplina;

            disciplina.Add("Teste");

            // Selecionar as disciplinas e preencher a tabela
            dtgSelecionaDisciplina.Rows.Add(false, "ARA1234", "Análise de Sinais e Sistemas");
            dtgSelecionaDisciplina.Rows.Add(false, "ARA1235", "Circuitos Elétricos para Computação");
            dtgSelecionaDisciplina.Rows.Add(false, "ARA1236", "Cálculo I");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgSelecionaDisciplina.Rows.Count; i++)
            {
                dtgSelecionaDisciplina.Rows[i].Selected = false;
                dtgSelecionaDisciplina.Rows[i].Cells[0].Value = false;
            }
        }

        private void VerificaDisciplinaSelecionada()
        {
            //teste
            disciplinaSelecionada.Add("Yeah!!");



            //Verificar as disciplinas selecionadas e colocar no List
        }
    }
}
