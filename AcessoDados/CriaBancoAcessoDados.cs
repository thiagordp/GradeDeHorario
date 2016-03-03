using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////    CRIAÇÃO DO BANCO DE DADOS NO COMPUTADOR DO USUÁRIO DO SISTEMA    /////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////

namespace AcessoDados
{
    public class CriaBancoAcessoDados
    {
        /// <summary>
        /// Número de linhas da grade
        /// </summary>
        const int LINHA = 14;

        /// <summary>
        /// Número de colunas da grade
        /// </summary>
        const int COLUNA = 6;

        /// <summary>
        /// Cria o banco no SQL Server caso não exista.
        /// </summary>
        /// <param name="ScriptBancoConstrucao">Script para criação do banco de dados.</param>
        /// <param name="ScriptTabelasConstrucao">Script para criação das tabelas no banco.</param>
        public void CriarBanco(string ScriptBancoConstrucao, string ScriptTabelasConstrucao)
        {
            StringBuilder sql = new StringBuilder();        // Armazena a consulta SQL
            SqlCommand comandoSql = new SqlCommand();       // A partir da script SQL e de uma conexão com o banco, executa a script sobre o banco.

            try
            {
                string stringConexao = @"Server= localhost\SQLEXPRESS; Integrated Security = SSPI";  // String de conexão diferente do pradrão!!!

                using (SqlConnection conexao = new SqlConnection(stringConexao))
                {
                    conexao.Open();

                    sql.Append(ScriptBancoConstrucao); // Adiciona o script para criação do banco de dados

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();           // Cria o Banco de dados.

                    sql.Clear();

                    sql.Append(ScriptTabelasConstrucao); // Adiciona o script para criação das tabelas

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();           // Cria as tabelas.
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Cria, automaticamente, as células que armazenam horário e data para a grade.
        /// </summary>
        public void CriaGradeBase()
        {
            try
            {
                List<Modelos.GRADE> grades = new List<Modelos.GRADE>();
                Modelos.GRADE grade;

                for (int i = 1; i <= COLUNA; i++) // colunas
                {
                    for (int j = 1; j <= LINHA; j++)
                    {
                        grade = new Modelos.GRADE();

                        grade.DIA_SEMANA_GRADE = i;
                        grade.HORARIO_GRADE = j;

                        grades.Add(grade);
                    }
                }

                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    foreach (Modelos.GRADE gr in grades)
                    {
                        contexto.GRADE.Add(gr);
                    }
                    contexto.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Inserção dos departamentos.
        /// </summary>
        public void CriaDepartamento()
        {
            try
            {
                List<Modelos.DEPARTAMENTO> departamentos = new List<Modelos.DEPARTAMENTO>();        // Usa-se uma lista para fazer a inserção de todos os departamentos.
                Modelos.DEPARTAMENTO departamento;                                                  // Objeto temporário para armazenamento dos dados de cada departamento.

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
                        contexto.DEPARTAMENTO.Add(depto); // Adiciona o departamento aos cadastrados.
                    }
                    contexto.SaveChanges();         // Salva as alterações.
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Inserção dos cursos no banco de dados.
        /// </summary>
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
                curso.QTD_FASE = 10;
                cursos.Add(curso);

                // Inserção do curso de Engenharia de Computação.
                curso = new Modelos.CURSO();
                curso.CODIGO_CURSO = 655;
                curso.NOME_CURSO = "ENGENHARIA DE COMPUTAÇÃO";
                curso.QTD_FASE = 10;
                cursos.Add(curso);

                // Inserção do curso de TIC.
                curso = new Modelos.CURSO();
                curso.CODIGO_CURSO = 652;
                curso.NOME_CURSO = "TECNOLOGIAS DA INFORMAÇÃO E COMUNICAÇÃO";
                curso.QTD_FASE = 6;
                cursos.Add(curso);

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

        /// <summary>
        /// Verifica a existência do banco de dados no sistema de banco de dados.
        /// </summary>
        /// <returns>Tabela contendo os bancos que tem o nome 'GradeHorario'</returns>
        public DataTable VerificaBanco()
        {
            SqlCommand comandoSql = new SqlCommand();
            StringBuilder sql = new StringBuilder();
            DataTable dadosTabela = new DataTable();

            try
            {
                using (SqlConnection conexao = new SqlConnection(@"Server= localhost\SQLEXPRESS; database=master; Integrated Security=SSPI"))  // String de conexão diferente do pradrão!!!
                {
                    conexao.Open();
                    sql.Append("SELECT * FROM sys.databases where name = 'GradeHorario'");      // Consulta para verificar se existe algum banco nomeado 'GradeHorario'

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
