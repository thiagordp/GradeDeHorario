using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////    CRIAÇÃO DO BANCO DE DADOS NO COMPUTADOR DO USUÁRIO DO SISTEMA    /////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////

namespace AcessoDados
{
    public class CriaBancoAcessoDados
    {
        // Cria o banco no SQL Server caso não exista.
        public void CriarBanco(string ScriptBancoConstrucao, string ScriptTabelasConstrucao)
        {
            StringBuilder sql = new StringBuilder();
            SqlCommand comandoSql = new SqlCommand();

            try
            {
                using (SqlConnection conexao = new SqlConnection(@"Server= localhost\SQLEXPRESS; Integrated Security = SSPI"))
                {
                    conexao.Open();

                    sql.Append(ScriptBancoConstrucao);

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();           // Cria o Banco de dados.

                    sql.Clear();

                    sql.Append(ScriptTabelasConstrucao);

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();           // Cria as tabelas.
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n" + ex.StackTrace);
            }
        }

        // Inserção dos departamentos.
        public void CriaDepartamento()
        {
            try
            {
                //Usa-se uma lista para fazer a inserção de todos os departamentos.
                List<Modelos.DEPARTAMENTO> departamentos = new List<Modelos.DEPARTAMENTO>();
                Modelos.DEPARTAMENTO departamento;

                // Inserção do Departamento de Computação.
                departamento = new Modelos.DEPARTAMENTO();
                departamento.CODIGO_DEPARTAMENTO = 1;
                departamento.NOME_DEPARTAMENTO = "Depto. de Computação (DEC)";
                departamentos.Add(departamento);

                // Inserção do Departamento de Energia e Sustentabilidade.
                departamento = new Modelos.DEPARTAMENTO();
                departamento.CODIGO_DEPARTAMENTO = 2;
                departamento.NOME_DEPARTAMENTO = "Depto. de Energia e Sustentabilidade (ENS)";
                departamentos.Add(departamento);

                // Inserção do Departamento de Física, Química e Matemática.
                departamento = new Modelos.DEPARTAMENTO();
                departamento.CODIGO_DEPARTAMENTO = 3;
                departamento.NOME_DEPARTAMENTO = "Depto. de Física, Química e Matemática (FQM)";
                departamentos.Add(departamento);

                // Inserção do Departamento de Tecnologia da Informação e Comunicação.
                departamento = new Modelos.DEPARTAMENTO();
                departamento.CODIGO_DEPARTAMENTO = 4;
                departamento.NOME_DEPARTAMENTO = "Depto. de Tecnologia da Informação e Comunicação (TIC)";
                departamentos.Add(departamento);

                // Adição de todos os departamentos no banco.
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    foreach (Modelos.DEPARTAMENTO depto in departamentos)
                    {
                        contexto.DEPARTAMENTO.Add(depto);
                    }
                    contexto.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Verifica a existência do banco de dados no sistema
        public DataTable VerificaBanco()
        {
            SqlCommand comandoSql = new SqlCommand();
            StringBuilder sql = new StringBuilder();
            DataTable dadosTabela = new DataTable();

            try
            {
                using (SqlConnection conexao = new SqlConnection(@"Server= localhost\SQLEXPRESS; database=master; Integrated Security=SSPI"))
                {
                    conexao.Open();
                    sql.Append("SELECT * FROM sys.databases where name = 'GradeHorario'");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("VerificarBanco(): \"" + ex.Message + "\"");
            }
        }
    }
}
