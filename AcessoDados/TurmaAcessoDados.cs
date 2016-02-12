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
    }
}
