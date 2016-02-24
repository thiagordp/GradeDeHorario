﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        /// Retorna as grade que contém o nome indicado -- REVER O FILTRO
        /// </summary>
        public void SelecionaGrade(string filtro) { }

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

        public void SelectNumeroCredito(int turma, string disciplina)
        {
            try
            {

                //sql.Append("SELECT COUNT(*) AS CREDITO_GASTO, CREDITO_DISCIPLINA FROM DISCIPLINA_TURMA AS DISC_TRM ");
                //sql.Append("INNER JOIN ");
                //sql.Append("	(SELECT * FROM TURMA ");
                //sql.Append("	WHERE SEQ_TURMA = " + turma.ToString() + ") AS TRM ");
                //sql.Append("	ON DISC_TRM.SEQ_TURMA = TRM.SEQ_TURMA ");
                //sql.Append("INNER JOIN ");
                //sql.Append("	(SELECT * FROM DISCIPLINA_CURSO ");
                //sql.Append("	WHERE CODIGO_DISCIPLINA = '" + disciplina.ToString() + "' ");
                //sql.Append("		AND CODIGO_CURSO = " + this.curso.CODIGO_CURSO.ToString() + ") AS DISC ");
                //sql.Append("	ON DISC.SEQ_DISCIPLINA_CURSO = DISC_TRM.SEQ_DISCIPLINA_CURSO ");
                //sql.Append("INNER JOIN ");
                //sql.Append("	(SELECT * FROM GRADE_TURMA) AS GRD_TRM ");
                //sql.Append("	ON GRD_TRM.SEQ_DISCIPLINA_CURSO = DISC_TRM.SEQ_DISCIPLINA_CURSO AND ");
                //sql.Append("		GRD_TRM.SEQ_TURMA = DISC_TRM.SEQ_TURMA ");
                //sql.Append("INNER JOIN ");
                //sql.Append("	(SELECT * FROM DISCIPLINA ");
                //sql.Append("	WHERE DISCIPLINA.CODIGO_DISCIPLINA = '" + disciplina.ToString() + "') AS DIC ");
                //sql.Append("	ON DIC.CODIGO_DISCIPLINA = DISC.CODIGO_DISCIPLINA ");
                //sql.Append("GROUP BY CREDITO_DISCIPLINA ");

                var query = from DISC_TRM in contexto.DISCIPLINA_TURMA.Local
                            join TRM in (from TRM in contexto.TURMA.Local
                                         where TRM.CODIGO_TURMA == "01655"
                                         select new { TRM.CODIGO_TURMA })
                            on DISC_TRM.CODIGO_TURMA.ToString() equals TRM.CODIGO_TURMA
                            join DISC in (from DISC in contexto.DISCIPLINA_CURSO.Local );

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Verifica a disponibilidade de cada disciplina, turma, professores e espaço no horário atual.
        /// </summary>
        /// <param name="novoRegistro">Indicador de novo registro em caso verdadeiro.</param>
        /// <param name="celula">Célula com os dados a serem verificados.</param>
        public void VerificaCelula(bool novoRegistro, Modelos.Celula celula)
        {
            #region Algoritmo
            /*
            Novo Registro:
                • Verifica disciplina
                    Sim: • Mesmo prof's e espaço e turma ≠
                            Sim: • Insere e return;
                            Não: Prossegue

                            • Verifica turma / disciplina (sem considerar o indíce)
                                Sim: • Verifica índice
                                        Sim: erro return
                                        Não: prosseguir
                                Não: prosseguir.
                    Não: • Verifica prof's
                            Sim: • erro
                            Não: prossegue
                         • Verifica Espaco
                            Sim: erro
                            Não: prossegue. Insere.
            */
            #endregion

            try
            {
                // Verificação de todas as alocações no dia, horário e semestre indicados.
                var alocacao = (from DISC_TRM in contexto.DISCIPLINA_TURMA
                                join GRD_TRM in contexto.GRADE_TURMA
                                on DISC_TRM.SEQ_DISCIPLINA_TURMA.ToString() equals GRD_TRM.SEQ_DISCIPLINA_TURMA.ToString()
                                where GRD_TRM.HORARIO_GRADE == celula.hora &&
                                     GRD_TRM.DIA_SEMANA_GRADE == celula.dia &&
                                     DISC_TRM.SEQ_SEMESTRE == celula.semestre
                                select new
                                {
                                    GRD_TRM.HORARIO_GRADE,
                                    GRD_TRM.DIA_SEMANA_GRADE,
                                    DISC_TRM.CODIGO_CURSO,
                                    DISC_TRM.CODIGO_DISCIPLINA,
                                    DISC_TRM.CODIGO_TURMA,
                                    DISC_TRM.CODIGO_PROFESSOR1,
                                    DISC_TRM.CODIGO_PROFESSOR2,
                                    DISC_TRM.CODIGO_PROFESSOR3,
                                    GRD_TRM.CODIGO_ESPACO,
                                    DISC_TRM.SEQ_SEMESTRE,
                                    DISC_TRM.SEQ_DISCIPLINA_TURMA
                                }).ToList();

                if (novoRegistro == true)
                {
                    foreach (var item in alocacao)
                    {
                        if (item.CODIGO_DISCIPLINA == celula.disciplina)
                        {
                            if (item.CODIGO_ESPACO == celula.espaco && item.CODIGO_CURSO != curso.CODIGO_CURSO)
                            {
                                if (item.CODIGO_CURSO != curso.CODIGO_CURSO)
                                {
                                    int countCelula = celula.professores.Count;
                                    int countItem = 3;

                                    if (item.CODIGO_PROFESSOR3 == null) { countItem--; }
                                    if (item.CODIGO_PROFESSOR2 == null) { countItem--; }

                                    if (countItem != countCelula)
                                    {
                                        // Verificar os professores diferentes e iguais e exibir turma e disciplina.

                                        if (true)
                                        {

                                        }

                                        throw new Exception("Já existe uma turma desta disciplina em outro curso no mesmo dia e horário. Mas o ");
                                    }

                                    // Sequência que verifica diferença entre professores.
                                    if (item.CODIGO_PROFESSOR1 != celula.professores.ElementAt(0))
                                    {
                                        throw new Exception("O 1º professor da lista é diferente ao de outra turma da mesma disciplina do curso " + item.CODIGO_CURSO +
                                            "\n\nTurma:" + item.CODIGO_TURMA + "\nCódigo prof. existente: " + item.CODIGO_PROFESSOR1);
                                    }

                                    if (countCelula == 2 && item.CODIGO_PROFESSOR2 != celula.professores.ElementAt(1))
                                    {
                                        throw new Exception("");
                                    }

                                    if (countCelula == 3 && item.CODIGO_PROFESSOR3 != celula.professores.ElementAt(2))
                                    {
                                        throw new Exception("");
                                    }
                                }




                                return;
                            }
                        }
                    }


                }

                else
                {

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Insere uma nova grade no banco de dados
        /// </summary>
        public void InsereGrade(ref TableLayoutPanel grade, Modelos.Celula celula)
        {
            try
            {
                Modelos.DISCIPLINA_TURMA turma = contexto.DISCIPLINA_TURMA.ToList().Find(p => p.CODIGO_CURSO == curso.CODIGO_CURSO &&
                                                                                  p.CODIGO_DISCIPLINA == celula.disciplina &&
                                                                                  p.CODIGO_TURMA == celula.turma &&
                                                                                  p.SEQ_SEMESTRE == celula.semestre); // Rever keys

                if (turma == null)
                {
                    turma = new Modelos.DISCIPLINA_TURMA();
                    Modelos.GRADE_TURMA gradeTurma = new Modelos.GRADE_TURMA();

                    turma.CODIGO_CURSO = curso.CODIGO_CURSO;
                    turma.CODIGO_DISCIPLINA = celula.disciplina;
                    turma.CODIGO_TURMA = celula.turma;
                    turma.SEQ_SEMESTRE = celula.semestre;

                    if (celula.professores.Count == 3)
                    {
                        turma.CODIGO_PROFESSOR1 = celula.professores.ElementAt(0);
                        turma.CODIGO_PROFESSOR2 = celula.professores.ElementAt(1);
                        turma.CODIGO_PROFESSOR3 = celula.professores.ElementAt(2);
                    }
                    else if (celula.professores.Count == 2)
                    {
                        turma.CODIGO_PROFESSOR1 = celula.professores.ElementAt(0);
                        turma.CODIGO_PROFESSOR2 = celula.professores.ElementAt(1);
                    }
                    else
                    {
                        turma.CODIGO_PROFESSOR1 = celula.professores.ElementAt(0);
                    }

                    contexto.DISCIPLINA_TURMA.Add(turma);

                    turma = contexto.DISCIPLINA_TURMA.ToList().Find(p => p.CODIGO_CURSO == curso.CODIGO_CURSO &&
                                                                                 p.CODIGO_DISCIPLINA == celula.disciplina &&
                                                                                 p.CODIGO_TURMA == celula.turma &&
                                                                                 p.SEQ_SEMESTRE == celula.semestre);

                    gradeTurma = new Modelos.GRADE_TURMA();

                    gradeTurma.SEQ_DISCIPLINA_TURMA = turma.SEQ_DISCIPLINA_TURMA;
                    gradeTurma.HORARIO_GRADE = celula.hora;
                    gradeTurma.DIA_SEMANA_GRADE = celula.dia;
                    gradeTurma.CODIGO_ESPACO = celula.espaco;

                    contexto.GRADE_TURMA.Add(gradeTurma);

                    AdicionaGrade(ref grade, celula);
                }
                else
                {

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void AdicionaGrade(ref TableLayoutPanel grade, Modelos.Celula celula)
        {
            DataGridView local = grade.GetControlFromPosition(celula.dia, celula.hora) as DataGridView;

            local.Rows.Add(celula.hora, celula.dia, celula.disciplina, celula.turma, celula.espaco, celula.espaco, celula.professores.ElementAt(0), celula.professores.ElementAt(1), celula.professores.ElementAt(2));
        }

        /// <summary>
        /// Edita os atributos da grade indicada de acordo com os dados fornecidos
        /// </summary>
        public void EditaGrade() { }

        /// <summary>
        /// Deleta a grade especificada
        /// </summary>
        public void ApagaGrade(Modelos.Celula celula)
        {
            Modelos.DISCIPLINA_TURMA turma = contexto.DISCIPLINA_TURMA.Where(p => p.SEQ_SEMESTRE == celula.semestre).First();

            Modelos.GRADE_TURMA grd = contexto.GRADE_TURMA.Find();
        }

        public void CarregaLocalmente()
        {
            foreach (var disc in contexto.DISCIPLINA.ToList())
            {
                foreach (var fase in disc.DISCIPLINA_CURSO.ToList())
                {
                    var x = fase.DISCIPLINA;
                    var y = fase.CURSO;

                    foreach (var turma in fase.DISCIPLINA_TURMA.ToList())
                    {
                        var a = turma.SEMESTRE;

                        foreach (var grade in turma.GRADE_TURMA)
                        {
                            var b = grade.ESPACO;
                        }
                    }
                }
            }

            foreach (var espaco in contexto.ESPACO.ToList())
            {
                foreach (var grd in espaco.GRADE_TURMA)
                {

                }

            }

            foreach (var grd in contexto.GRADE)
            {
                foreach (var item in grd.GRADE_TURMA)
                {

                }
            }
        }

    }
}