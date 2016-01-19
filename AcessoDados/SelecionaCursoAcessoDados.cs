using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class SelecionaCursoAcessoDados
    {
        // Retorna o objeto que representa o curso selecionado. 
        public Modelos.CURSO SelecionaCursoEscolhido(int codigoCurso)
        {
            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    return contexto.CURSO.Find(codigoCurso);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Retorna uma lista com todos os cursos cadastrados.
        public DataTable SelecionaTodoCurso()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    StringBuilder sql = new StringBuilder();
                    SqlCommand comandoSql = new SqlCommand();
                    DataTable dadosTabela = new DataTable();

                    sql.Append("SELECT * FROM CURSO");
                    sql.Append(" ORDER BY NOME_CURSO ASC");

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
