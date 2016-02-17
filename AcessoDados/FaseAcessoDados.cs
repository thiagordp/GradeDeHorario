using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AcessoDados
{
    public class FaseAcessoDados
    {
        StringBuilder sql;
        SqlCommand comandoSql;
        DataTable dadosTabela;

        // Adiciona Fase
        public void InsereListaDisciplinaFase(List<Modelos.DISCIPLINA_CURSO> disciplinaFase)
        {
            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    for (int i = 0; i < disciplinaFase.Count; i++)
                    {
                        contexto.DISCIPLINA_CURSO.Add(disciplinaFase.ElementAt(i));
                    }
                    contexto.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //
        public DataTable SelecionaDisciplinaLikeNome(string nome)
        {
            sql = new StringBuilder();
            comandoSql = new SqlCommand();
            dadosTabela = new DataTable();

            using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
            {
                sql.Append("SELECT	CODIGO_DISCIPLINA, NOME_DISCIPLINA, CREDITO_DISCIPLINA");
                sql.Append("        FROM DISCIPLINA INNER JOIN DEPARTAMENTO");
                sql.Append("        ON DISCIPLINA.CODIGO_DEPARTAMENTO = DEPARTAMENTO.CODIGO_DEPARTAMENTO");
                sql.Append("        WHERE NOME_DISCIPLINA LIKE '" + nome + "%'");
                sql.Append("        ORDER BY NOME_DISCIPLINA ASC; ");

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conexao;
                conexao.Open();
                dadosTabela.Load(comandoSql.ExecuteReader());

                return dadosTabela;
            }
        }

        //
        public DataTable SelecionaDisciplinaFase(int fase, int curso)
        {
            sql = new StringBuilder();
            comandoSql = new SqlCommand();
            DataTable tabela = new DataTable();

            sql.Append("SELECT DISCIPLINA.CODIGO_DISCIPLINA, DISCIPLINA.NOME_DISCIPLINA, DISCIPLINA.CREDITO_DISCIPLINA ");
            sql.Append("FROM DISCIPLINA_CURSO INNER JOIN DISCIPLINA ");
            sql.Append("ON DISCIPLINA_CURSO.CODIGO_DISCIPLINA = DISCIPLINA.CODIGO_DISCIPLINA ");
            sql.Append("WHERE DISCIPLINA_CURSO.FASE_DISCIPLINA_CURSO = " + fase.ToString());
            sql.Append(" AND DISCIPLINA_CURSO.CODIGO_CURSO = " + curso.ToString());
            sql.Append(" ORDER BY NOME_DISCIPLINA");

            using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
            {
                conexao.Open();

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conexao;

                tabela.Load(comandoSql.ExecuteReader());

                return tabela;
            }
        }

        public void SalvaFase(List<Modelos.DISCIPLINA_CURSO> listaEdita, List<Modelos.DISCIPLINA_CURSO> listaExclui, List<Modelos.DISCIPLINA_CURSO> listaInsere)
        {
            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    Modelos.DISCIPLINA_CURSO temp;
                    // Deletando as disciplinas que não fase mais parte da fase.
                    foreach (Modelos.DISCIPLINA_CURSO item in listaExclui)
                    {
                        temp = contexto.DISCIPLINA_CURSO.Find(item.CODIGO_DISCIPLINA, item.CODIGO_CURSO, item.CODIGO_TURMA);

                        if (temp.DISCIPLINA_TURMA.Count > 0)
                        {
                            throw new Exception("Não é possível exclui a disciplina de código " + temp.CODIGO_DISCIPLINA + ", pois já existe uma ou mais turmas vinculadas à ela.");
                        }

                        contexto.Entry(temp).State = System.Data.Entity.EntityState.Deleted;
                    }

                    // Editando as disciplinas alteradas. // TALVEZ NÃO PRECISA
                    foreach (Modelos.DISCIPLINA_CURSO item in listaEdita)
                    {
                        temp = contexto.DISCIPLINA_CURSO.Find(item.CODIGO_DISCIPLINA, item.CODIGO_CURSO, item.CODIGO_TURMA);
                        temp.FASE_DISCIPLINA_CURSO = item.FASE_DISCIPLINA_CURSO;

                        contexto.Entry(temp).State = System.Data.Entity.EntityState.Modified;
                    }
                    contexto.SaveChanges();

                }
                // Inserindo as novas disciplinas.
                InsereListaDisciplinaFase(listaInsere);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Modelos.DISCIPLINA_CURSO> SelecionaFaseCurso(int fase, int curso)
        {
            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    List<Modelos.DISCIPLINA_CURSO> lista = contexto.DISCIPLINA_CURSO.ToList().FindAll(faseCurso => (faseCurso.CODIGO_CURSO == curso) && (faseCurso.FASE_DISCIPLINA_CURSO == fase));

                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Modelos.DISCIPLINA_CURSO> SelecionaTodaFase()
        {
            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    List<Modelos.DISCIPLINA_CURSO> lista = contexto.DISCIPLINA_CURSO.ToList();

                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Modelos.DISCIPLINA_CURSO VerificaDisciplinaCurso(Modelos.DISCIPLINA_CURSO turma)
        {
            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    return contexto.DISCIPLINA_CURSO.ToList().Find(
                        p =>
                        (p.CODIGO_CURSO == turma.CODIGO_CURSO) &&
                        (p.CODIGO_DISCIPLINA == turma.CODIGO_DISCIPLINA) &&
                        (p.CODIGO_TURMA == turma.CODIGO_TURMA));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        // Procura por alguma tupla que já contenha os códigos da disciplina e curso informados.
        public Modelos.DISCIPLINA_CURSO VerificaDisciplinaCurso(string disciplina, int curso)
        {
            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    return contexto.DISCIPLINA_CURSO.ToList().Find(p => (p.CODIGO_CURSO == curso) && (p.CODIGO_DISCIPLINA == disciplina));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void VerificaFaseRequisito(ref Modelos.DISCIPLINA disciplina, ref List<Modelos.DISCIPLINA> requisito, ref List<Modelos.DISCIPLINA> requisitante)
        {
            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    disciplina = contexto.DISCIPLINA.Find(disciplina.CODIGO_DISCIPLINA);

                    if (disciplina == null)
                    {
                        throw new Exception("Disciplina não existe.");
                    }
                    requisito = disciplina.DISCIPLINA1.ToList();
                    requisitante = disciplina.DISCIPLINA2.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Retorna a fase da disciplina em um curso.
        // Retorna -1 caso não esteja em nenhuma fase.
        public int FaseDisciplina(string codigoDisciplina, int curso)
        {
            using (Modelos.Entidade contexto = new Modelos.Entidade())
            {
                Modelos.DISCIPLINA_CURSO discCurso = contexto.DISCIPLINA_CURSO.ToList().Where(p => p.CODIGO_CURSO == curso && p.CODIGO_DISCIPLINA == codigoDisciplina).First();

                if (discCurso == null)
                {
                    return -1;
                }

                return Convert.ToInt32(discCurso.FASE_DISCIPLINA_CURSO);
            }
        }
    }
}