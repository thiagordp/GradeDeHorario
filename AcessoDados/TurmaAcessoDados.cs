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

        public void InsereTurma(Modelos.TURMA turma)
        {
            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    contexto.TURMA.Add(turma);
                    contexto.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void EditaTurma(Modelos.TURMA turmaAntiga, Modelos.TURMA turmaAtual)
        {
            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    if (turmaAntiga.CODIGO_TURMA != turmaAtual.CODIGO_TURMA)
                    {

                        Modelos.TURMA temp = contexto.TURMA.Find(turmaAntiga.CODIGO_TURMA);
                        contexto.Entry(temp).State = System.Data.Entity.EntityState.Deleted;
                        contexto.TURMA.Add(turmaAtual);
                        contexto.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ExcluiTurma(Modelos.TURMA turma)
        {
            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    contexto.Entry(contexto.TURMA.Find(turma.CODIGO_TURMA)).State = System.Data.Entity.EntityState.Deleted;
                    contexto.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Modelos.CURSO SelecionaCurso(int curso)
        {
            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    return contexto.CURSO.Find(curso);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Modelos.TURMA SelecionaTurma(Modelos.TURMA turma)
        {
            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    return contexto.TURMA.Find(turma.CODIGO_TURMA);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

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

        public int SelecionaNumeroAlocacao(Modelos.TURMA turma)
        {
            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    return contexto.TURMA.Find(turma.CODIGO_TURMA).DISCIPLINA_CURSO.Count;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
