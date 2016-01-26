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
                departamento.NOME_DEPARTAMENTO = "DEPTO. DE COMPUTAÇÃO (DEC)";
                departamentos.Add(departamento);

                // Inserção do Departamento de Energia e Sustentabilidade.
                departamento = new Modelos.DEPARTAMENTO();
                departamento.CODIGO_DEPARTAMENTO = 2;
                departamento.NOME_DEPARTAMENTO = "DEPTO. DE ENERGIA E SUSTENTABILIDADE (ENS)";
                departamentos.Add(departamento);

                // Inserção do Departamento de Física, Química e Matemática.
                departamento = new Modelos.DEPARTAMENTO();
                departamento.CODIGO_DEPARTAMENTO = 3;
                departamento.NOME_DEPARTAMENTO = "DEPTO. DE FÍSICA, QUÍMICA E MATEMÁTICA (FQM)";
                departamentos.Add(departamento);

                // Inserção do Departamento de Tecnologia da Informação e Comunicação.
                departamento = new Modelos.DEPARTAMENTO();
                departamento.CODIGO_DEPARTAMENTO = 4;
                departamento.NOME_DEPARTAMENTO = "DEPTO. DE TECNOLOGIA DA INFORMAÇÃO E COMUNICAÇÃO (TIC)";
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

        // Inserção dos cursos.
        public void CriaCurso()
        {
            try
            {
                //Usa-se uma lista para fazer a inserção de todos os cursos.
                List<Modelos.CURSO> cursos = new List<Modelos.CURSO>();
                Modelos.CURSO curso;

                // Inserção do curso de Fisioterapia.
                curso = new Modelos.CURSO();
                curso.CODIGO_CURSO = 654;
                curso.NOME_CURSO = "FISIOTERAPIA";
                curso.QTD_FASE = 10;
                cursos.Add(curso);

                // Inserção do curso de Engenharia de Energia.
                curso = new Modelos.CURSO();
                curso.CODIGO_CURSO = 653;
                curso.NOME_CURSO = "ENGENHARIA DE ENERGIA";
                cursos.Add(curso);
                curso.QTD_FASE = 10;

                // Inserção do curso de Engenharia de Computação.
                curso = new Modelos.CURSO();
                curso.CODIGO_CURSO = 655;
                curso.NOME_CURSO = "ENGENHARIA DE COMPUTAÇÃO";
                cursos.Add(curso);
                curso.QTD_FASE = 10;

                // Inserção do curso de TIC.
                curso = new Modelos.CURSO();
                curso.CODIGO_CURSO = 652;
                curso.NOME_CURSO = "TECNOLOGIAS DA INFORMAÇÃO E COMUNICAÇÃO";
                cursos.Add(curso);
                curso.QTD_FASE = 6;

                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    foreach (Modelos.CURSO item in cursos)
                    {
                        contexto.CURSO.Add(item);
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
