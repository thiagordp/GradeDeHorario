﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AcessoDados
{
    public class GradeHorarioAcessoDados
    {
        /// <summary>
        /// Objeto que referencia o curso da grade atual.
        /// </summary>
        private Modelos.CURSO curso;

        public GradeHorarioAcessoDados(Modelos.CURSO curso)
        {
            this.curso = curso;
        }

        /// <summary>
        /// Insere uma nova grade no banco de dados
        /// </summary>
        public void InsereGrade() { }

        /// <summary>
        /// Edita os atributos da grade indicada de acordo com os dados fornecidos
        /// </summary>
        public void EditaGrade() { }

        /// <summary>
        /// Deleta a grade especificada
        /// </summary>
        public void ApagaGrade() { }

        /// <summary>
        /// Retorna todas as grade cadastradas
        /// </summary>
        public void SelecionaTodaGrade() { }

        /// <summary>
        /// Retorna as grade que contém o nome indicado -- REVER O FILTRO
        /// </summary>
        public void SelecionaGrade(string filtro) { }

        /// <summary>
        /// Seleciona um conjunto de disciplinas com base no filtro.
        /// </summary>
        /// <param name="filtro">Filtro para a pesquisa, sendo o começo do nome.</param>
        /// <returns>Retorna o conjunto de disciplinas que estão de acordo com o friltro.</returns>
        public DataTable SelecionaDisciplina(string filtro)
        {
            DataTable dadosTabela = new DataTable();
            StringBuilder sql = new StringBuilder();
            SqlCommand comandoSql = new SqlCommand();

            try
            {
                sql.Append("SELECT CODIGO_DISCIPLINA, NOME_DISCIPLINA ");
                sql.Append("FROM DISCIPLINA ");
                sql.Append("WHERE NOME_DISCIPLINA LIKE \'" + filtro + "%' ");
                sql.Append("ORDER BY NOME_DISCIPLINA ASC");

                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();
                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;

                    dadosTabela.Load(comandoSql.ExecuteReader());
                }

                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Seleciona um conjunto de professores(as) com base no filtro.
        /// </summary>
        /// <param name="filtro">Contém uma cadeia de caracteres nas quais o nome do(a) professor(a) deve iniciar.</param>
        /// <returns>Conjunto de professor de acordo com o filtro</returns>
        public DataTable SelecionaProfessor(string filtro)
        {
            DataTable dadosTabela = new DataTable();
            StringBuilder sql = new StringBuilder();
            SqlCommand comandoSql = new SqlCommand();

            try
            {
                sql.Append("SELECT CODIGO_PROFESSOR, NOME_PROFESSOR ");
                sql.Append("FROM PROFESSOR ");
                sql.Append("WHERE NOME_PROFESSOR LIKE \'" + filtro + "%' ");
                sql.Append("ORDER BY NOME_PROFESSOR ASC");

                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();
                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;

                    dadosTabela.Load(comandoSql.ExecuteReader());
                }

                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Seleciona um conjunto de espaços com base no filtro.
        /// </summary>
        /// <param name="filtro">Filtro para a pesquisa, sendo o começo do código do espaço.</param>
        /// <returns>Conjundo de espaços</returns>
        public DataTable SelecionaEspaco(string filtro)
        {
            DataTable dadosTabela = new DataTable();
            StringBuilder sql = new StringBuilder();
            SqlCommand comandoSql = new SqlCommand();

            try
            {
                sql.Append("SELECT CODIGO_ESPACO, TIPO_ESPACO ");
                sql.Append("FROM ESPACO ");
                sql.Append("WHERE CODIGO_ESPACO LIKE \'" + filtro + "%' ");
                sql.Append("ORDER BY CODIGO_ESPACO ASC");

                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();
                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;

                    dadosTabela.Load(comandoSql.ExecuteReader());
                }

                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable SelecionaTodoSemestre()
        {
            StringBuilder sql = new StringBuilder();
            DataTable dadosTabela = new DataTable();
            SqlCommand comandoSql = new SqlCommand();

            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT SEQ_SEMESTRE, NOME_SEMESTRE ");
                    sql.Append("FROM SEMESTRE ");
                    sql.Append("ORDER BY NOME_SEMESTRE ASC");

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