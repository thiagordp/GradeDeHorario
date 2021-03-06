﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
        public void CriarBanco()
        {
            try
            {
                string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

                path = path.Replace(@"\bin\Debug", ""); // Isso é feito pois a linha anterior retorna o caminho para o Debug e não para a raiz do projeto.

                string caminhoScriptBanco = path + @"\Resources\ScriptBancoConstrucao.sql";
                FileInfo arquivoBanco = new FileInfo(caminhoScriptBanco);
                string scriptBanco = arquivoBanco.OpenText().ReadToEnd();

                string caminhoScriptTabelas = path + @"\Resources\ScriptTabelasConstrucao.sql";
                FileInfo arquivoTabelas = new FileInfo(caminhoScriptTabelas);
                string scriptTabela = arquivoTabelas.OpenText().ReadToEnd();

                criaBanco = new AcessoDados.CriaBancoAcessoDados();
                criaBanco.CriarBanco(scriptBanco, scriptTabela); // Função que verificará a existência do BD e, caso não exista, criará um novo banco. 
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
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
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }

        //Inserção dos cursos
        public void CriaCurso()
        {
            try
            {
                criaBanco = new AcessoDados.CriaBancoAcessoDados();
                criaBanco.CriaCurso();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }

        public void CriaGradeBase()
        {
            try
            {
                criaBanco = new AcessoDados.CriaBancoAcessoDados();
                criaBanco.CriaGradeBase();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
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
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }
    }
}
