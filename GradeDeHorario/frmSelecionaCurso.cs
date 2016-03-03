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
        RegraNegocio.SelecionaCursoRegraNegocio cursoRN;    // Referência ao objeto da camada de regra de negócios.

        /// <summary>
        /// Construtor
        /// </summary>
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
                cursoRN = new RegraNegocio.SelecionaCursoRegraNegocio();
                Modelos.CURSO cursoEscolhido = cursoRN.SelecionaCursoEscolhido(Convert.ToInt32(cbbCurso.SelectedValue));

                (new frmPrincipal(cursoEscolhido)).ShowDialog();
            }
        }

        private void frmSelecionaCurso_Load(object sender, EventArgs e)
        {
            try
            {
                PreencheListaCurso();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Preenche a lista de cursos de acordo com o conteúdo do banco de dados.
        /// </summary>
        private void PreencheListaCurso()
        {
            cursoRN = new RegraNegocio.SelecionaCursoRegraNegocio();

            cbbCurso.DataSource = cursoRN.SelecionaTodoCurso();
            cbbCurso.ValueMember = "CODIGO_CURSO";
            cbbCurso.DisplayMember = "NOME_CURSO";
            cbbCurso.SelectedIndex = -1;
        }
    }
}
