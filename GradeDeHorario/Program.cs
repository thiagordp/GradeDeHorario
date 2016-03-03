using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
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

                Thread thread = new Thread(new ThreadStart(RunSplash));
                thread.Start();
                
                // Código para a primeira execução do sistema no computador do usuário.
                RegraNegocio.CriaBancoRegraNegocio novoBanco = new RegraNegocio.CriaBancoRegraNegocio();
                DataTable dadosTabela = new DataTable();           // Tabela que conterá o resultado da Pesquisa do banco;
                Thread.Sleep(5000);
                dadosTabela = novoBanco.VerificaBanco();

                if (dadosTabela.Rows.Count <= 0)
                {
                    novoBanco.CriarBanco();
                    novoBanco.CriaDepartamento();
                    novoBanco.CriaCurso();
                    novoBanco.CriaGradeBase();
                }
               
                thread.Abort();
                Application.Run(new frmSelecionaCurso());       // Executando a aplicação.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar o sistema.\n\nDetalhe: \"" + ex.Message + "\"");
            }
        }

        static void RunSplash()
        {
            Application.Run(new frmSplash());
        }
    }
}
