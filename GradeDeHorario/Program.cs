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

                //Criação de uma thread para mostra uma tela de splash enquanto carrega o banco.
                Thread thread = new Thread(new ThreadStart(RunSplash));
                thread.Start();
                
               
                RegraNegocio.CriaBancoRegraNegocio novoBanco = new RegraNegocio.CriaBancoRegraNegocio();

                DataTable dadosTabela = new DataTable();           // Tabela que conterá o resultado da Pesquisa do banco;
                Thread.Sleep(5000);
                dadosTabela = novoBanco.VerificaBanco();

                // Código para a primeira execução do sistema no computador do usuário.
                if (dadosTabela.Rows.Count <= 0)
                {
                    novoBanco.CriarBanco();
                    novoBanco.CriaDepartamento();
                    novoBanco.CriaCurso();
                    novoBanco.CriaGradeBase();
                }
               
                thread.Abort(); // Cancelar a thread.
                Application.Run(new frmSelecionaCurso());       // Executando a aplicação.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar o sistema.\n\nDetalhe: \"" + ex.Message + "\"");
            }
        }

        /// <summary>
        /// Função que é executada enquanto a thread está habilitada.
        /// </summary>
        static void RunSplash()
        {
            Application.Run(new frmSplash());
        }
    }
}
