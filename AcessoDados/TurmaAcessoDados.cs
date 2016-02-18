using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class TurmaAcessoDados
    {
        private StringBuilder sql;
        private SqlCommand comandoSql;
        private DataTable dadosTabela;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable SelecionaTodaTurma()
        {
            sql = new StringBuilder();
            comandoSql = new SqlCommand();
            dadosTabela = new DataTable();

            sql.Append("SELECT CODIGO_TURMA FROM TURMA");

            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="disciplina"></param>
        /// <returns></returns>
        public DataTable SelecionaTurmaAlocada(string disciplina)
        {
            try
            {
                dadosTabela = new DataTable();
                comandoSql = new SqlCommand();
                sql = new StringBuilder();

                sql.Append("SELECT CODIGO_TURMA ");
                sql.Append(" FROM ");
                sql.Append(" (SELECT CODIGO_DISCIPLINA, CODIGO_TURMA ");
                sql.Append("    FROM DISCIPLINA_TURMA ");
                sql.Append("  WHERE CODIGO_DISCIPLINA = '" + disciplina + "') AS QUERY");

                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;

                    dadosTabela.Load(comandoSql.ExecuteReader());
                }

                return dadosTabela;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
