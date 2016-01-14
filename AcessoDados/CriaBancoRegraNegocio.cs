using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////    CRIAÇÃO DO BANCO DE DADOS NO COMPUTADOR DO USUÁRIO DO SISTEMA    /////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////

namespace RegraNegocio
{
    public class CriaBancoRegraNegocio
    {
        private AcessoDados.CriaBancoAcessoDados criaBanco;

        ///////////////////////////////////
        //  Executar comandos de CREATE  //
        ///////////////////////////////////

        // Cria o banco no SQL Server caso não exista.
        public void CriaBanco()
        {
            try
            {
                criaBanco = new AcessoDados.CriaBancoAcessoDados();
                criaBanco.CriaBanco(); // Função que verificará a existência e caso não exista, criará um novo banco. 
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método CriaBanco() da classe CriaBancoRegraNegocio.\n\nDetalhe do erro: \"" + ex.Message + "\""); ;
            }

        }

        // Inserção dos departamentos
        public void CriaDepartamento()
        {
            try
            {
                criaBanco = new AcessoDados.CriaBancoAcessoDados();
                criaBanco.CriaDepartamento();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método CriaDepartamento().\n\nDetalhe do erro: \"" + ex.Message + "\"");
            }
        }

        // Verifica a existência do banco de dados no sistema
        public DataTable VerificaBanco()
        {
            try
            {
                criaBanco = new AcessoDados.CriaBancoAcessoDados();
                return criaBanco.VerificaBanco();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro no método VerificaBanco().\n\nDetalhe do erro: \"" + ex.Message + "\"");
            }
        }
    }
}
