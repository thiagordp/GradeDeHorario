using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeDeHorario
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Código para a primeira execução do sistema no computador do usuário.
                RegraNegocio.CriaBancoRegraNegocio novoBanco = new RegraNegocio.CriaBancoRegraNegocio();
                DataTable dadosTabela = new DataTable();           // Tabela que conterá o resultado da Pesquisa do banco;

                dadosTabela = novoBanco.VerificaBanco();

                if (dadosTabela.Rows.Count <= 0)
                {
                    novoBanco.CriarBanco();
                    novoBanco.CriaDepartamento();
                    novoBanco.CriaCurso();
                }

                Application.Run(new frmSelecionaCurso());       // Executando a aplicação.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar o sistema.\n\nDetalhe: \"" + ex.Message + "\"");
            }
        }
    }
}
