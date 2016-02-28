using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AcessoDados
{
    public class GradeHorarioAcessoDados
    {
        /// <summary>
        /// Objeto que referencia o curso da grade atual.
        /// </summary>
        private Modelos.CURSO curso;

        /// <summary>
        /// Objeto que gerencia em memória as alterações feita pelo usuário e posteriormente as salva no banco.
        /// </summary>
        private Modelos.Entidade contexto;

        public GradeHorarioAcessoDados(Modelos.CURSO curso, ref Modelos.Entidade contexto)
        {
            this.curso = curso;
            this.contexto = contexto;
        }

        /// <summary>
        /// Retorna toda uma grade a partir dos atributos
        /// </summary>
        /// <param name="curso">Curso</param>
        /// <param name="fase">Fase do curso</param>
        /// <param name="semestre">Semestre da grade desejada</param>
        /// <returns></returns>
        public DataTable SelecionaTodaGrade(int fase, int semestre)
        {
            DataTable dadosTabela = new DataTable();
            SqlCommand comandoSql = new SqlCommand();
            StringBuilder sql = new StringBuilder();

            string nomeSemestre = (new Modelos.Entidade()).SEMESTRE.Find(semestre).NOME_SEMESTRE;

            sql.Append("SELECT GRD_TRM.HORARIO_GRADE, GRD_TRM.DIA_SEMANA_GRADE,  ");
            sql.Append("	GRD_TRM.CODIGO_ESPACO, DISC_TRM.CODIGO_TURMA, ");
            sql.Append("	DISC_TRM.CODIGO_DISCIPLINA, DISC_TRM.CODIGO_PROFESSOR1, ");
            sql.Append("	DISC_TRM.CODIGO_PROFESSOR2, DISC_TRM.CODIGO_PROFESSOR3 ");
            sql.Append("FROM ");
            sql.Append("	DISCIPLINA_TURMA AS DISC_TRM ");
            sql.Append("    INNER JOIN ");
            sql.Append("        (SELECT * FROM DISCIPLINA_CURSO AS DISC_CUR ");
            sql.Append("        WHERE FASE_DISCIPLINA_CURSO = " + fase + " AND CODIGO_CURSO = " + curso.CODIGO_CURSO + ") AS DISC_CUR");
            sql.Append("	ON DISC_TRM.CODIGO_CURSO = DISC_CUR.CODIGO_CURSO AND ");
            sql.Append("	DISC_TRM.CODIGO_DISCIPLINA = DISC_CUR.CODIGO_DISCIPLINA AND ");
            sql.Append("	DISC_TRM.CODIGO_TURMA = DISC_CUR.CODIGO_TURMA ");
            sql.Append("	INNER JOIN ");
            sql.Append("	GRADE_TURMA AS GRD_TRM ");
            sql.Append("	ON GRD_TRM.SEQ_DISCIPLINA_TURMA = DISC_TRM.SEQ_DISCIPLINA_TURMA ");
            sql.Append("    WHERE DISC_TRM.SEQ_SEMESTRE = " + semestre);

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
        /// Seleciona um conjunto de disciplinas com base no filtro.
        /// </summary>
        /// <param name="filtro">Filtro para a pesquisa, sendo o começo do nome.</param>
        /// <returns>Retorna o conjunto de disciplinas que estão de acordo com o friltro.</returns>
        public DataTable SelecionaDisciplina(string filtro, int fase)
        {
            DataTable dadosTabela = new DataTable();
            StringBuilder sql = new StringBuilder();
            SqlCommand comandoSql = new SqlCommand();

            try
            {
                sql.Append("SELECT DISCIPLINA.CODIGO_DISCIPLINA, NOME_DISCIPLINA, CODIGO_TURMA ");
                sql.Append("FROM DISCIPLINA_CURSO ");
                sql.Append("	INNER JOIN ");
                sql.Append("		DISCIPLINA ON DISCIPLINA.CODIGO_DISCIPLINA = DISCIPLINA_CURSO.CODIGO_DISCIPLINA ");
                sql.Append("WHERE NOME_DISCIPLINA LIKE '" + filtro + "%' AND FASE_DISCIPLINA_CURSO = " + fase + " AND CODIGO_CURSO = " + curso.CODIGO_CURSO);
                sql.Append(" ORDER BY NOME_DISCIPLINA ASC");

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

        /// <summary>
        /// Selecionar todos os semestres cadastros
        /// </summary>
        /// <returns>Lista de semestres</returns>
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

        public DataTable SelecionaTurma(string disciplina, int fase, int semestre)
        {
            try
            {
                SqlCommand comandoSql = new SqlCommand();
                StringBuilder sql = new StringBuilder();
                DataTable dadosTabela = new DataTable();

                sql.Append("SELECT TRM.SEQ_TURMA, MAX(NOME_TURMA) AS NOME_TURMA FROM DISCIPLINA_TURMA AS DISC_TRM ");
                sql.Append("INNER JOIN ");
                sql.Append("	(SELECT * FROM DISCIPLINA_CURSO");
                sql.Append("	WHERE CODIGO_DISCIPLINA = '" + disciplina.ToString() + "'");
                sql.Append("		AND FASE_DISCIPLINA_CURSO = " + fase.ToString() + " ");
                sql.Append("        AND CODIGO_CURSO = " + this.curso.CODIGO_CURSO.ToString() + ") AS DISC ");
                sql.Append("	ON DISC_TRM.SEQ_DISCIPLINA_CURSO = DISC.SEQ_DISCIPLINA_CURSO ");
                sql.Append("INNER JOIN ");
                sql.Append("	(SELECT SEQ_TURMA, NOME_TURMA FROM TURMA ");
                sql.Append("	WHERE SEQ_SEMESTRE = " + semestre.ToString() + ") AS TRM ");
                sql.Append("    ON TRM.SEQ_TURMA = DISC_TRM.SEQ_TURMA ");
                sql.Append("GROUP BY TRM.SEQ_TURMA");

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
        /// Verifica se a celula atender as seguintes condições:
        ///     - Caso exista alguma célula neste horário, não pode haver uma mesma turma com a mesma disciplina
        ///     - 
        /// </summary>
        /// <param name="celula">Contém o conteúdo da posição da grade e turma.</param>
        public void SelectDisciplinaTurmaFromDiaHora(Modelos.Celula celula)
        {
            try
            {
                // Verificação de uma mesma disciplina com mesma turma com o mesmo horário.
                var query1 = (from DISC_TRM in contexto.DISCIPLINA_TURMA.Local
                              join GRD_TRM in contexto.GRADE_TURMA.Local
                              on DISC_TRM.SEQ_DISCIPLINA_TURMA.ToString() equals GRD_TRM.SEQ_DISCIPLINA_TURMA.ToString()
                              join SEM in contexto.SEMESTRE.Local
                              on DISC_TRM.SEQ_SEMESTRE.ToString() equals SEM.SEQ_SEMESTRE.ToString()
                              where
                                 DISC_TRM.CODIGO_DISCIPLINA == celula.disciplina &&
                                 DISC_TRM.CODIGO_TURMA == celula.turma &&
                                 GRD_TRM.DIA_SEMANA_GRADE == celula.dia &&
                                 GRD_TRM.HORARIO_GRADE == celula.hora &&
                                 SEM.SEQ_SEMESTRE == celula.semestre
                              select new { DISC_TRM.CODIGO_DISCIPLINA, DISC_TRM.CODIGO_TURMA }).ToList();

                if (query1.Count > 0)
                {
                    throw new Exception("O conjunto de disciplina e turma indicados já está cadastrado nessa dia e horário.");
                }

                // Verificação de uma disciplina de turmas diferentes mas professor(es) e espaço igual.
                var query2 = (from DISC_TRM in contexto.DISCIPLINA_TURMA.Local
                              join GRD_TRM in contexto.GRADE_TURMA.Local
                              on DISC_TRM.SEQ_DISCIPLINA_TURMA.ToString() equals GRD_TRM.SEQ_DISCIPLINA_TURMA.ToString()
                              join SEM in contexto.SEMESTRE.Local
                              on DISC_TRM.SEQ_SEMESTRE.ToString() equals SEM.SEQ_SEMESTRE.ToString()
                              where
                                 DISC_TRM.CODIGO_DISCIPLINA == celula.disciplina &&
                                 DISC_TRM.CODIGO_TURMA != celula.turma &&
                                 GRD_TRM.DIA_SEMANA_GRADE == celula.dia &&
                                 GRD_TRM.HORARIO_GRADE == celula.hora &&
                                 SEM.SEQ_SEMESTRE == celula.semestre
                              select new
                              {
                                  DISC_TRM.CODIGO_CURSO,
                                  DISC_TRM.CODIGO_DISCIPLINA,
                                  DISC_TRM.CODIGO_TURMA,
                                  DISC_TRM.CODIGO_PROFESSOR1,
                                  DISC_TRM.CODIGO_PROFESSOR2,
                                  DISC_TRM.CODIGO_PROFESSOR3,
                                  GRD_TRM.CODIGO_ESPACO
                              }).ToList();

                foreach (var item in query2)
                {

                    // Sim... Estes if's fazem sentido...
                    if (item.CODIGO_PROFESSOR1 == celula.professores.ElementAt(0) ||
                        (celula.professores.Count >= 2 && item.CODIGO_PROFESSOR2 == celula.professores.ElementAt(1)) ||
                        (celula.professores.Count >= 3 && item.CODIGO_PROFESSOR3 == celula.professores.ElementAt(2)) ||
                        item.CODIGO_ESPACO == celula.espaco)
                    {
                        if ((item.CODIGO_PROFESSOR1 != celula.professores.ElementAt(0)) ||
                            (celula.professores.Count >= 2 && item.CODIGO_PROFESSOR2 != celula.professores.ElementAt(1)) ||
                            celula.professores.Count >= 3 && item.CODIGO_PROFESSOR3 != celula.professores.ElementAt(2) ||
                            item.CODIGO_ESPACO != celula.espaco)
                        {
                            StringBuilder exception = new StringBuilder();

                            exception.Append("A disciplina " + item.CODIGO_DISCIPLINA);
                            exception.Append(" será compartilhada com a turma " + item.CODIGO_TURMA);

                            using (Modelos.Entidade contextoAux = new Modelos.Entidade())
                            {
                                string nomeCurso = contextoAux.CURSO.Find(item.CODIGO_CURSO).NOME_CURSO;

                                exception.Append(" do curso de " + nomeCurso + ".\n\n");
                            }

                            exception.Append("Portanto a célula que será inserida/modificada deve atender os seguintes requisitos:\n");
                            exception.Append("\nDisciplina:\t\t" + item.CODIGO_DISCIPLINA);
                            exception.Append(" - " + contexto.DISCIPLINA.Find(item.CODIGO_DISCIPLINA).NOME_DISCIPLINA);
                            exception.Append("\nProfessor(es):\n\t" + item.CODIGO_PROFESSOR1 + " - " + contexto.PROFESSOR.Local.Where(p => p.CODIGO_PROFESSOR == item.CODIGO_PROFESSOR1).First().NOME_PROFESSOR);

                            if (item.CODIGO_PROFESSOR2 != null)
                            {
                                exception.Append("\n\t" + item.CODIGO_PROFESSOR2 + " - " + contexto.PROFESSOR.Local.Where(p => p.CODIGO_PROFESSOR == item.CODIGO_PROFESSOR2).First().NOME_PROFESSOR);

                                if (item.CODIGO_PROFESSOR3 != null)
                                {
                                    exception.Append("\n\t" + item.CODIGO_PROFESSOR3 + " - " + contexto.PROFESSOR.Local.Where(p => p.CODIGO_PROFESSOR == item.CODIGO_PROFESSOR3).First().NOME_PROFESSOR);
                                }
                            }

                            exception.Append("\nEspaço:\t" + item.CODIGO_ESPACO);

                            throw new Exception(exception.ToString());
                        }
                    }
                }

                // Verificação de créditos.
                int creditoAtual, creditoMax;

                creditoAtual = creditoMax = 0;
                string semestre = contexto.SEMESTRE.Find(celula.semestre).NOME_SEMESTRE;

                SelectNumeroCredito(celula.turma, celula.disciplina, semestre, ref creditoAtual, ref creditoMax);

                if (creditoAtual == creditoMax)
                {
                    throw new Exception("Não é possível alocar a turma e disciplina indicados, pois já atribuiram o número máximo de créditos possíveis (" + creditoMax + ").");
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
        /// <param name="turma"></param>
        /// <param name="disciplina"></param>
        /// <param name="semestre"></param>
        /// <param name="countCredito"></param>
        /// <param name="maxCredito"></param>
        public void SelectNumeroCredito(string turma, string disciplina, string semestre, ref int countCredito, ref int maxCredito)
        {
            try
            {
                var query = (from DISC_TRM in contexto.DISCIPLINA_TURMA.Local
                             join GRD_TRM in contexto.GRADE_TURMA.Local
                             on DISC_TRM.SEQ_DISCIPLINA_TURMA.ToString() equals GRD_TRM.SEQ_DISCIPLINA_TURMA.ToString()
                             join DISC in contexto.DISCIPLINA.Local
                             on DISC_TRM.CODIGO_DISCIPLINA equals DISC.CODIGO_DISCIPLINA
                             join SEM in contexto.SEMESTRE.Local
                             on DISC_TRM.SEQ_SEMESTRE.ToString() equals SEM.SEQ_SEMESTRE.ToString()
                             where
                                DISC_TRM.CODIGO_DISCIPLINA == disciplina &&
                                DISC_TRM.CODIGO_TURMA == turma &&
                                SEM.NOME_SEMESTRE == semestre
                             select new { DISC.CREDITO_DISCIPLINA }).ToList();

                if (query.Count() == 0)
                {
                    countCredito = 0;
                    maxCredito = Convert.ToInt32(contexto.DISCIPLINA.Local.Where(p => p.CODIGO_DISCIPLINA == disciplina).First().CREDITO_DISCIPLINA);

                }
                else
                {
                    countCredito = query.Count();
                    maxCredito = Convert.ToInt32(query.First().CREDITO_DISCIPLINA);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Verifica a disponibilidade de cada disciplina, turma, professores e espaço no horário atual.
        /// </summary>
        /// <param name="celula">Célula com os dados a serem verificados.</param>
        public int SelectGradeFromHora(Modelos.Celula celula)
        {
            var query = (from DISC_TRM in contexto.DISCIPLINA_TURMA.Local
                         join GRD_TRM in contexto.GRADE_TURMA.Local
                         on DISC_TRM.SEQ_DISCIPLINA_TURMA.ToString() equals GRD_TRM.SEQ_DISCIPLINA_TURMA.ToString()
                         where DISC_TRM.CODIGO_TURMA == celula.turma &&
                             DISC_TRM.CODIGO_DISCIPLINA == celula.disciplina &&
                             DISC_TRM.SEQ_SEMESTRE == celula.semestre &&
                             GRD_TRM.DIA_SEMANA_GRADE == celula.dia &&
                             GRD_TRM.HORARIO_GRADE == celula.hora
                         select new { DISC_TRM.SEQ_DISCIPLINA_TURMA }).ToList();

            if (query == null) { return 0; }

            return query.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="celula"></param>
        public void SelectProfessorFromHora(Modelos.Celula celula)
        {
            try
            {
                if (celula.professores.Count == 0) { return; }

                // Verificação do primeiro professor
                var query = (from DISC_TRM in contexto.DISCIPLINA_TURMA.Local
                             join GRD_TRM in contexto.GRADE_TURMA.Local
                             on DISC_TRM.SEQ_DISCIPLINA_TURMA.ToString() equals GRD_TRM.SEQ_DISCIPLINA_TURMA.ToString()
                             where
                                DISC_TRM.CODIGO_PROFESSOR1 == celula.professores.ElementAt(0) &&
                                DISC_TRM.SEQ_SEMESTRE == celula.semestre &&
                                GRD_TRM.DIA_SEMANA_GRADE == celula.dia &&
                                GRD_TRM.HORARIO_GRADE == celula.hora
                             select new
                             {
                                 DISC_TRM.PROFESSOR,
                                 DISC_TRM.CODIGO_TURMA,
                                 DISC_TRM.CODIGO_DISCIPLINA,
                                 DISC_TRM.CODIGO_CURSO
                             }).ToList();

                if (query.Count > 0)
                {
                    StringBuilder excecao = new StringBuilder();

                    int codigoCurso = Convert.ToInt32(query.ElementAt(0).CODIGO_CURSO);

                    excecao.Append("O professor:\n\n");
                    excecao.Append(query.ElementAt(0).PROFESSOR.NOME_PROFESSOR + "\n\n");
                    excecao.Append("já está alocado, nesse horário, na seguinte turma:");
                    excecao.Append("\n\nTurma:\t\t" + query.ElementAt(0).CODIGO_TURMA);

                    string codigoDisciplina = query.ElementAt(0).CODIGO_DISCIPLINA;
                    int curso = Convert.ToInt32(query.ElementAt(0).CODIGO_CURSO);

                    excecao.Append("\nDisciplina:\t\t" + codigoDisciplina);
                    excecao.Append(" - " + contexto.DISCIPLINA.Find(codigoDisciplina).NOME_DISCIPLINA);
                    excecao.Append("\nCurso:\t\t" + curso);

                    Modelos.Entidade contextoAux = new Modelos.Entidade();

                    string nomeCurso = contextoAux.CURSO.Find(codigoCurso).NOME_CURSO;
                    contextoAux.Dispose();
                    excecao.Append(" - " + nomeCurso);

                    throw new Exception(excecao.ToString());
                }

                if (celula.professores.Count == 1) { return; }

                // Verificação do segundo professor

                var query2 = (from DISC_TRM in contexto.DISCIPLINA_TURMA.Local
                              join GRD_TRM in contexto.GRADE_TURMA.Local
                              on DISC_TRM.SEQ_DISCIPLINA_TURMA.ToString() equals GRD_TRM.SEQ_DISCIPLINA_TURMA.ToString()
                              where
                                 DISC_TRM.CODIGO_PROFESSOR2 == celula.professores.ElementAt(1) &&
                                 DISC_TRM.SEQ_SEMESTRE == celula.semestre &&
                                 GRD_TRM.DIA_SEMANA_GRADE == celula.dia &&
                                 GRD_TRM.HORARIO_GRADE == celula.hora
                              select new
                              {
                                  DISC_TRM.CODIGO_PROFESSOR2,
                                  DISC_TRM.CODIGO_TURMA,
                                  DISC_TRM.CODIGO_DISCIPLINA,
                                  DISC_TRM.CODIGO_CURSO
                              }).ToList();

                if (query2.Count > 0)
                {
                    StringBuilder excecao = new StringBuilder();

                    string codigoDisciplina = query2.ElementAt(0).CODIGO_DISCIPLINA;
                    int codigoCurso = Convert.ToInt32(query2.ElementAt(0).CODIGO_CURSO);
                    int codigoProfessor = Convert.ToInt32(query2.ElementAt(0).CODIGO_PROFESSOR2);

                    excecao.Append("O professor:\n\n");
                    excecao.Append(contexto.PROFESSOR.Local.Where(p => p.CODIGO_PROFESSOR == codigoProfessor).First().NOME_PROFESSOR + "\n\n");
                    excecao.Append("já está alocado, nesse horário, na seguinte turma:");
                    excecao.Append("\n\nTurma:\t\t" + query2.ElementAt(0).CODIGO_TURMA);

                    excecao.Append("\nDisciplina:\t\t" + codigoDisciplina);
                    excecao.Append(" - " + contexto.DISCIPLINA.Local.Where(p => p.CODIGO_DISCIPLINA == codigoDisciplina).First().NOME_DISCIPLINA);
                    excecao.Append("\nCurso:\t\t" + codigoCurso);

                    Modelos.Entidade contextoAux = new Modelos.Entidade();

                    string nomeCurso = contextoAux.CURSO.Find(codigoCurso).NOME_CURSO;
                    contextoAux.Dispose();
                    excecao.Append(" - " + nomeCurso);

                    throw new Exception(excecao.ToString());
                }

                if (celula.professores.Count == 2) { return; }

                // Verificação do terceiro professor
                var query3 = (from DISC_TRM in contexto.DISCIPLINA_TURMA.Local
                              join GRD_TRM in contexto.GRADE_TURMA.Local
                              on DISC_TRM.SEQ_DISCIPLINA_TURMA.ToString() equals GRD_TRM.SEQ_DISCIPLINA_TURMA.ToString()
                              where
                                 DISC_TRM.CODIGO_PROFESSOR2 == celula.professores.ElementAt(2) &&
                                 DISC_TRM.SEQ_SEMESTRE == celula.semestre &&
                                 GRD_TRM.DIA_SEMANA_GRADE == celula.dia &&
                                 GRD_TRM.HORARIO_GRADE == celula.hora
                              select new
                              {
                                  DISC_TRM.CODIGO_PROFESSOR3,
                                  DISC_TRM.CODIGO_TURMA,
                                  DISC_TRM.CODIGO_DISCIPLINA,
                                  DISC_TRM.CODIGO_CURSO
                              }).ToList();

                if (query3.Count > 0)
                {
                    StringBuilder excecao = new StringBuilder();

                    string codigoDisciplina = query3.ElementAt(0).CODIGO_DISCIPLINA;
                    int codigoCurso = Convert.ToInt32(query3.ElementAt(0).CODIGO_CURSO);
                    int codigoProfessor = Convert.ToInt32(query3.ElementAt(0).CODIGO_PROFESSOR3);

                    excecao.Append("O professor:\n\n");
                    excecao.Append(contexto.PROFESSOR.Local.Where(p => p.CODIGO_PROFESSOR == codigoProfessor).First().NOME_PROFESSOR + "\n\n");
                    excecao.Append("já está alocado, nesse horário, na seguinte turma:");
                    excecao.Append("\n\nTurma:\t\t" + query3.ElementAt(0).CODIGO_TURMA);

                    excecao.Append("\nDisciplina:\t\t" + codigoDisciplina);
                    excecao.Append(" - " + contexto.DISCIPLINA.Local.Where(p => p.CODIGO_DISCIPLINA == codigoDisciplina).First().NOME_DISCIPLINA);
                    excecao.Append("\nCurso:\t\t" + codigoCurso);

                    Modelos.Entidade contextoAux = new Modelos.Entidade();

                    string nomeCurso = contextoAux.CURSO.Find(codigoCurso).NOME_CURSO;
                    contextoAux.Dispose();
                    excecao.Append(" - " + nomeCurso);

                    throw new Exception(excecao.ToString());
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
        /// <param name="celula"></param>
        public void SelectEspacoFromHora(Modelos.Celula celula)
        {
            try
            {
                var query = (from DISC_TRM in contexto.DISCIPLINA_TURMA.Local
                             join GRD_TRM in contexto.GRADE_TURMA.Local
                             on DISC_TRM.SEQ_DISCIPLINA_TURMA.ToString() equals GRD_TRM.SEQ_DISCIPLINA_TURMA.ToString()
                             where
                                GRD_TRM.CODIGO_ESPACO == celula.espaco &&
                                DISC_TRM.SEQ_SEMESTRE == celula.semestre &&
                                GRD_TRM.DIA_SEMANA_GRADE == celula.dia &&
                                GRD_TRM.HORARIO_GRADE == celula.hora
                             select new
                             {
                                 GRD_TRM.CODIGO_ESPACO,
                                 DISC_TRM.CODIGO_TURMA,
                                 DISC_TRM.CODIGO_DISCIPLINA,
                                 DISC_TRM.CODIGO_CURSO
                             }).ToList();

                if (query.Count > 0)
                {
                    StringBuilder excecao = new StringBuilder();

                    int codigoCurso = Convert.ToInt32(query.ElementAt(0).CODIGO_CURSO);

                    excecao.Append("O espaço ");
                    excecao.Append(query.ElementAt(0).CODIGO_ESPACO);
                    excecao.Append(" já está alocado, nesse horário, na seguinte turma:");
                    excecao.Append("\n\nTurma:\t\t" + query.ElementAt(0).CODIGO_TURMA);

                    string codigoDisciplina = query.ElementAt(0).CODIGO_DISCIPLINA;
                    int curso = Convert.ToInt32(query.ElementAt(0).CODIGO_CURSO);

                    excecao.Append("\nDisciplina:\t\t" + codigoDisciplina);
                    excecao.Append(" - " + contexto.DISCIPLINA.Find(codigoDisciplina).NOME_DISCIPLINA);
                    excecao.Append("\nCurso:\t\t" + curso);

                    Modelos.Entidade contextoAux = new Modelos.Entidade();

                    string nomeCurso = contextoAux.CURSO.Find(codigoCurso).NOME_CURSO;
                    contextoAux.Dispose();
                    excecao.Append(" - " + nomeCurso);

                    throw new Exception(excecao.ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Insere uma nova grade no banco de dados
        /// </summary>
        public void InsereGrade(ref TableLayoutPanel grade, Modelos.Celula celula)
        {
            try
            {
                DataGridView posicao = grade.GetControlFromPosition(celula.dia, celula.hora) as DataGridView;

                int LastIndex = SelectDisciplinaTurma(celula);

                if (LastIndex == 0)
                {
                    Modelos.DISCIPLINA_TURMA turma = new Modelos.DISCIPLINA_TURMA();
                    turma.CODIGO_CURSO = this.curso.CODIGO_CURSO;
                    turma.CODIGO_DISCIPLINA = celula.disciplina;
                    turma.CODIGO_TURMA = celula.turma;
                    turma.SEQ_SEMESTRE = celula.semestre;

                    LastIndex = contexto.DISCIPLINA_TURMA.Local.OrderByDescending(p => p.SEQ_DISCIPLINA_TURMA).First().SEQ_DISCIPLINA_TURMA + 1;

                    turma.SEQ_DISCIPLINA_TURMA = LastIndex;

                    turma.CODIGO_PROFESSOR1 = celula.professores.ElementAt(0);
                    if (celula.professores.Count >= 2)
                    {
                        turma.CODIGO_PROFESSOR2 = celula.professores.ElementAt(1);

                        if (celula.professores.Count >= 3)
                        {
                            turma.CODIGO_PROFESSOR3 = celula.professores.ElementAt(2);
                        }
                    }

                    contexto.DISCIPLINA_TURMA.Add(turma);

                }

                Modelos.GRADE_TURMA horaDia = new Modelos.GRADE_TURMA();

                horaDia.SEQ_DISCIPLINA_TURMA = LastIndex;
                horaDia.HORARIO_GRADE = celula.hora;
                horaDia.DIA_SEMANA_GRADE = celula.dia;
                horaDia.CODIGO_ESPACO = celula.espaco;

                contexto.GRADE_TURMA.Add(horaDia);

                AdicionaCelula(ref grade, celula);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="celula"></param>
        /// <returns></returns>
        private int SelectGradeTurma(ref int seq, Modelos.Celula celula)
        {
            var query = from DISC_TRM in contexto.DISCIPLINA_TURMA.Local
                        join GRD_TRM in contexto.GRADE_TURMA.Local
                        on DISC_TRM.SEQ_DISCIPLINA_TURMA.ToString() equals GRD_TRM.SEQ_DISCIPLINA_TURMA.ToString()
                        where DISC_TRM.CODIGO_CURSO == this.curso.CODIGO_CURSO &&
                           DISC_TRM.CODIGO_DISCIPLINA == celula.disciplina &&
                           DISC_TRM.CODIGO_TURMA == celula.turma &&
                           DISC_TRM.SEQ_SEMESTRE == celula.semestre
                        select new { GRD_TRM.HORARIO_GRADE, GRD_TRM.DIA_SEMANA_GRADE };

            return query.Count();
        }

        /// <summary>
        /// Verifica se a lista de professores é valida e retorna o último ID de Disciplina_Turma.
        /// </summary>
        /// <param name="celula"></param>
        private int SelectDisciplinaTurma(Modelos.Celula celula)
        {
            var query = (contexto.DISCIPLINA_TURMA.Local.Where(p =>
                p.CODIGO_CURSO == this.curso.CODIGO_CURSO &&
                p.CODIGO_DISCIPLINA == celula.disciplina &&
                p.CODIGO_TURMA == celula.turma &&
                p.SEQ_SEMESTRE == celula.semestre));

            if (query.Count() == 0)
            {
                return 0;
            }

            if ((celula.professores.ElementAt(0) != query.First().CODIGO_PROFESSOR1) ||
                (celula.professores.Count >= 2 && celula.professores.ElementAt(1) != query.First().CODIGO_PROFESSOR2) ||
                (celula.professores.Count == 3 && celula.professores.ElementAt(2) != query.First().CODIGO_PROFESSOR3))
            {
                throw new Exception("Já existe uma ou mais células da mesma turma, disciplina, curso e semestre, no entanto, a lista de professores não bate com a existente.\nVerifique a lista de professores e tente novamente.");
            }

            return query.First().SEQ_DISCIPLINA_TURMA;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="grade"></param>
        /// <param name="celula"></param>
        private void AdicionaCelula(ref TableLayoutPanel grade, Modelos.Celula celula)
        {
            DataGridView posicao = grade.GetControlFromPosition(celula.dia, celula.hora) as DataGridView;

            if (celula.professores.Count == 1)
            {
                posicao.Rows.Add(celula.hora, celula.dia, celula.disciplina, celula.turma, celula.espaco, celula.espaco, celula.professores.ElementAt(0));
            }
            else if (celula.professores.Count == 2)
            {
                posicao.Rows.Add(celula.hora, celula.dia, celula.disciplina, celula.turma, celula.espaco, celula.espaco, celula.professores.ElementAt(0), celula.professores.ElementAt(1));
            }
            else if (celula.professores.Count == 3)
            {
                posicao.Rows.Add(celula.hora, celula.dia, celula.disciplina, celula.turma, celula.espaco, celula.espaco, celula.professores.ElementAt(0), celula.professores.ElementAt(1), celula.professores.ElementAt(2));
            }
            else
            {
                throw new Exception("O número de professores é inválido!\nVerifique se escolheu entre 1 a 3 e que não exista nenhuma aplicação interagindo com o banco neste momento.");
            }
            posicao.ClearSelection();
        }

        /// <summary>
        /// Edita os atributos da grade indicada de acordo com os dados fornecidos
        /// </summary>
        public void EditaGrade(ref TableLayoutPanel grade, Modelos.Celula celulaAntiga, Modelos.Celula celulaNova)
        {
            try
            {
                DataGridView posicao = grade.GetControlFromPosition(celulaAntiga.dia, celulaAntiga.hora) as DataGridView;

                Modelos.DISCIPLINA_TURMA turma = new Modelos.DISCIPLINA_TURMA();
                Modelos.GRADE_TURMA horaDia = new Modelos.GRADE_TURMA();

                turma = contexto.DISCIPLINA_TURMA.Local.Where(p =>
                    p.CODIGO_CURSO == curso.CODIGO_CURSO &&
                    p.CODIGO_DISCIPLINA == celulaAntiga.disciplina &&
                    p.CODIGO_TURMA == celulaAntiga.turma &&
                    p.SEQ_SEMESTRE == celulaAntiga.semestre).First();

                horaDia = turma.GRADE_TURMA.Where(p => p.DIA_SEMANA_GRADE == celulaAntiga.dia && p.HORARIO_GRADE == celulaAntiga.hora).First();

                horaDia.CODIGO_ESPACO = celulaNova.espaco;

                turma.CODIGO_PROFESSOR1 = celulaNova.professores.ElementAt(0);

                if (celulaNova.professores.Count > 1)
                {
                    turma.CODIGO_PROFESSOR2 = celulaNova.professores.ElementAt(1);

                    if (celulaNova.professores.Count > 2)
                    {
                        turma.CODIGO_PROFESSOR3 = celulaNova.professores.ElementAt(2);
                    }
                    else
                    {
                        turma.CODIGO_PROFESSOR3 = null;
                    }
                }
                else
                {
                    turma.CODIGO_PROFESSOR2 = null;
                }

                contexto.Entry(horaDia).State = System.Data.Entity.EntityState.Modified;
                contexto.Entry(turma).State = System.Data.Entity.EntityState.Modified;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deleta a grade especificada
        /// </summary>
        public void ApagaGrade(ref TableLayoutPanel grade, Modelos.Celula celula)
        {
            try
            {
                int seq = 0;
                int count = SelectGradeTurma(ref seq, celula);

                Modelos.DISCIPLINA_TURMA turma = contexto.DISCIPLINA_TURMA.Local.Where(p =>
                        p.CODIGO_CURSO == curso.CODIGO_CURSO &&
                        p.CODIGO_DISCIPLINA == celula.disciplina &&
                        p.CODIGO_TURMA == celula.turma &&
                        p.SEQ_SEMESTRE == celula.semestre).First();

                if (count > 1)
                {
                    Modelos.GRADE_TURMA gradeTurma = contexto.GRADE_TURMA.Where(p => p.SEQ_DISCIPLINA_TURMA == turma.SEQ_DISCIPLINA_TURMA &&
                     p.HORARIO_GRADE == celula.hora &&
                     p.DIA_SEMANA_GRADE == celula.dia).First();

                    contexto.Entry(gradeTurma).State = System.Data.Entity.EntityState.Deleted;
                }
                else if (count == 1)
                {
                    turma.GRADE_TURMA.Clear();
                    contexto.Entry(turma).State = System.Data.Entity.EntityState.Modified;
                }
                else
                {
                    throw new Exception("Erro ao excluir a célula indicada.\nCertifique-se de que nenhuma aplicação esteja interagindo com o banco de dados.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Cambiarras... Muitas cambiarras
        /// </summary>
        public void CarregaLocalmente()
        {
            foreach (var disc in contexto.DISCIPLINA.ToList()) { }

            foreach (var fase in contexto.DISCIPLINA_CURSO.ToList()) { }

            foreach (var turma in contexto.DISCIPLINA_TURMA.ToList()) { }

            foreach (var grade in contexto.GRADE_TURMA.ToList()) { }

            foreach (var espaco in contexto.ESPACO.ToList()) { }

            foreach (var grd in contexto.GRADE.ToList()) { }

            foreach (var item in contexto.PROFESSOR.ToList()) { }

            foreach (var item in contexto.SEMESTRE.ToList()) { }

            foreach (var item in contexto.TURMA.ToList()) { }

            foreach (var item in contexto.CURSO.ToList()) { }
        }
    }
}