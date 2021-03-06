﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código foi gerado por uma ferramenta
//     As alterações neste arquivo serão perdidas se o código for recriado
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;

namespace AcessoDados
{

    public class DisciplinaAcessoDados
    {
        StringBuilder sql;
        SqlCommand comandoSql;
        Modelos.CURSO curso;
        DataTable dadosTabela;
        FaseAcessoDados faseAD;

        public DisciplinaAcessoDados()
        {

        }

        public DisciplinaAcessoDados(Modelos.CURSO curso)
        {
            this.curso = curso;
        }

        /// <summary>
        /// Insere uma nova disciplina no banco de dados
        /// </summary>
        /// <param name="disciplina">Disciplina a ser inserida/editada.</param>
        /// <param name="requisitos">Lista de requisitos.</param>
        /// <param name="turmas">Lista de turmas.</param>
        public void InsereDisciplina(Modelos.DISCIPLINA disciplina, DataGridView requisitos, DataTable turmaAntiga, DataTable turmaNova)
        {
            Modelos.DISCIPLINA tempDisciplina;

            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    Modelos.DISCIPLINA discExiste = contexto.DISCIPLINA.Find(disciplina.CODIGO_DISCIPLINA);

                    if (discExiste != null)
                    {
                        throw new Exception("Já existe uma disciplina com a identificação informada.");
                    }

                    Modelos.DEPARTAMENTO depto = contexto.DEPARTAMENTO.Find(disciplina.CODIGO_DEPARTAMENTO);

                    if (depto == null)
                    {
                        throw new Exception("O departamento indicado não existe!\nCertifique-se que nenhuma outra aplicação esteja manipulando o banco de dados!");
                    }

                    disciplina.DEPARTAMENTO = depto;

                    for (int i = 0; i < requisitos.Rows.Count; i++)
                    {
                        tempDisciplina = contexto.DISCIPLINA.Find(requisitos.Rows[i].Cells["CODIGO_DISCIPLINA_REQUISITO"].Value.ToString());

                        if (tempDisciplina == null)
                        {
                            throw new Exception("Uma disciplina requisito não foi encontrada no banco de dados.\nVerifique se existe alguma aplicação externa que esteja manipulando o banco de dados.");
                        }

                        disciplina.DISCIPLINA1.Add(tempDisciplina);
                    }

                    contexto.DISCIPLINA.Add(disciplina);

                    Modelos.Entidade tempCont = contexto;

                    SalvaTurmas(ref tempCont, disciplina.CODIGO_DISCIPLINA, turmaAntiga, turmaNova);

                    contexto.SaveChanges();

                    //if (turmas.Rows.Count > 0)
                    //{
                    //    string codigoDisc = disciplina.CODIGO_DISCIPLINA;
                    //    int codigoCurso = 0;
                    //    int codigoFase = 0;
                    //    string turma = "";
                    //    char aux = '\0';

                    //    Modelos.DISCIPLINA_CURSO turmaFase = new Modelos.DISCIPLINA_CURSO();

                    //    for (int i = 0; i < turmas.Rows.Count; i++)
                    //    {
                    //        turma = turmas.Rows[i].Cells["CODIGO_TURMA"].Value.ToString();

                    //        Modelos.Utilidades.ExtractFromTurma(turma, ref codigoFase, ref codigoCurso, ref aux);

                    //        turmaFase = new Modelos.DISCIPLINA_CURSO();

                    //        turmaFase.CODIGO_DISCIPLINA = disciplina.CODIGO_DISCIPLINA;
                    //        turmaFase.CODIGO_CURSO = codigoCurso;
                    //        turmaFase.CODIGO_TURMA = turma;

                    //        turmaFase.FASE_DISCIPLINA_CURSO = codigoFase;
                    //        contexto.DISCIPLINA_CURSO.Add(turmaFase);
                    //    }
                    //    contexto.SaveChanges();
                    //}
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // 
        public void SalvaTurmas(ref Modelos.Entidade contexto, string disciplina, DataTable turmaAntiga, DataTable turmaNova)
        {
            int curso = 0;
            int fase = 0;
            string turma = "";
            char aux = '\0';

            try
            {
                faseAD = new AcessoDados.FaseAcessoDados();

                // Caso não tenha nenhuma turma naquela disciplina já cadastrada.
                if (turmaAntiga.Rows.Count == 0)
                {
                    Modelos.DISCIPLINA_CURSO novaTurmaFase;
                    List<Modelos.DISCIPLINA_CURSO> listaFase = new List<Modelos.DISCIPLINA_CURSO>();

                    for (int i = 0; i < turmaNova.Rows.Count; i++)
                    {
                        turma = turmaNova.Rows[i].Field<string>("CODIGO_TURMA");

                        Modelos.Utilidades.ExtractFromTurma(turma, ref fase, ref curso, ref aux);

                        novaTurmaFase = new Modelos.DISCIPLINA_CURSO();
                        novaTurmaFase.CODIGO_CURSO = curso;
                        novaTurmaFase.CODIGO_DISCIPLINA = disciplina;
                        novaTurmaFase.CODIGO_TURMA = turma;
                        novaTurmaFase.FASE_DISCIPLINA_CURSO = fase;

                        Modelos.DISCIPLINA_CURSO temp = faseAD.VerificaDisciplinaCurso(novaTurmaFase);

                        if (temp != null)
                        { // Arrumar
                            throw new Exception("A disciplina de código " + novaTurmaFase.CODIGO_DISCIPLINA + " já está vinculada à " + temp.FASE_DISCIPLINA_CURSO.ToString() + "ª fase desse curso.\nRemova a restrição e tente novamente.");
                        }

                        listaFase.Add(novaTurmaFase);
                    }

                    faseAD.InsereListaDisciplinaFase(ref contexto, listaFase);
                }
                else
                {

                    List<Modelos.DISCIPLINA_CURSO> listaEdita = new List<Modelos.DISCIPLINA_CURSO>();
                    List<Modelos.DISCIPLINA_CURSO> listaExclui = new List<Modelos.DISCIPLINA_CURSO>();
                    List<Modelos.DISCIPLINA_CURSO> listaInsere = new List<Modelos.DISCIPLINA_CURSO>();
                    List<Modelos.DISCIPLINA_CURSO> listaFaseAntiga = faseAD.SelecionaFaseCurso(disciplina);
                    List<Modelos.DISCIPLINA_CURSO> listaFaseNova = PreencheTurma(turmaNova, disciplina);
                    List<Modelos.DISCIPLINA_CURSO> lista = PreencheTurma(turmaNova, disciplina);

                    // lista FaseAntiga deve ser revisado para ter mais de um curso.
                    for (int i = 0; listaFaseNova != null && i < listaFaseNova.Count; i++)
                    {
                        Modelos.DISCIPLINA_CURSO discLista = listaFaseAntiga.Find(
                            p =>
                            (p.CODIGO_DISCIPLINA == disciplina) &&
                            (p.CODIGO_CURSO == lista.ElementAt(i).CODIGO_CURSO) &&
                            (p.CODIGO_TURMA == lista.ElementAt(i).CODIGO_TURMA));

                        if (discLista == null)
                        {
                            Modelos.DISCIPLINA_CURSO discFaseBD = faseAD.VerificaDisciplinaCurso(listaFaseNova.ElementAt(i));

                            if (discFaseBD != null)
                            {//REVER
                                throw new Exception("A disciplina de código " + listaFaseNova.ElementAt(i).CODIGO_DISCIPLINA + " já está vinculada à " + discFaseBD.FASE_DISCIPLINA_CURSO.ToString() + "ª fase desse curso.\nRemova a restrição e tente novamente.");
                            }

                            listaInsere.Add(listaFaseNova.ElementAt(i));
                        }
                        else
                        {
                            listaEdita.Add(listaFaseNova.ElementAt(i));

                            listaFaseAntiga.Remove(listaFaseAntiga.Find(
                                p =>
                                (p.CODIGO_CURSO == listaFaseNova.ElementAt(i).CODIGO_CURSO) &&
                                (p.CODIGO_DISCIPLINA == listaFaseNova.ElementAt(i).CODIGO_DISCIPLINA) &&
                                (p.CODIGO_TURMA == listaFaseNova.ElementAt(i).CODIGO_TURMA)));
                        }
                    }

                    for (int i = 0; i < listaFaseAntiga.Count; i++)
                    {
                        //Modelos.DISCIPLINA_CURSO temp = faseAD.SelecionaFaseCurso(fase, curso).Find(
                        //    p =>
                        //    (p.CODIGO_CURSO == listaFaseAntiga.ElementAt(i).CODIGO_CURSO) &&
                        //    (p.CODIGO_DISCIPLINA == listaFaseAntiga.ElementAt(i).CODIGO_DISCIPLINA) &&
                        //    (p.CODIGO_TURMA == listaFaseAntiga.ElementAt(i).CODIGO_TURMA));

                        listaExclui.Add(listaFaseAntiga.ElementAt(i));
                    }

                    faseAD.SalvaFase(ref contexto, listaEdita, listaExclui, listaInsere);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }

        private List<Modelos.DISCIPLINA_CURSO> PreencheTurma(DataTable turmas, string disciplina)
        {
            List<Modelos.DISCIPLINA_CURSO> lista = new List<Modelos.DISCIPLINA_CURSO>();
            Modelos.DISCIPLINA_CURSO turmaFase;

            int curso = 0;
            int fase = 0;
            string turma = "";
            char aux = '\0';

            for (int i = 0; i < turmas.Rows.Count; i++)
            {
                turma = turmas.Rows[i].Field<string>("CODIGO_TURMA");

                Modelos.Utilidades.ExtractFromTurma(turma, ref fase, ref curso, ref aux);

                turmaFase = new Modelos.DISCIPLINA_CURSO();
                turmaFase.CODIGO_CURSO = curso;
                turmaFase.CODIGO_DISCIPLINA = disciplina;
                turmaFase.CODIGO_TURMA = turma;
                turmaFase.FASE_DISCIPLINA_CURSO = fase;

                lista.Add(turmaFase);
            }

            return lista;
        }


        // Edita os atributos da disciplina indicada de acordo com os dados fornecidos
        public void EditaDisciplina(
            Modelos.DISCIPLINA disciplinaAntiga,
            Modelos.DISCIPLINA disciplinaNova,
            DataTable requisitoAntigo,
            DataTable requisitoNovo,
            DataTable turmaAntiga,
            DataTable turmaNova)
        {
            Modelos.DISCIPLINA tempDisciplina;
            Modelos.Entidade contex;
            string subject = "";

            using (Modelos.Entidade contexto = new Modelos.Entidade())
            {
                disciplinaNova.DEPARTAMENTO = contexto.DEPARTAMENTO.Find(disciplinaNova.CODIGO_DEPARTAMENTO);
                contex = contexto;
                AdicionaRequisito(ref disciplinaNova, requisitoNovo, ref contex);

                tempDisciplina = contexto.DISCIPLINA.Find(disciplinaNova.CODIGO_DISCIPLINA);

                if (disciplinaAntiga.CODIGO_DISCIPLINA != disciplinaNova.CODIGO_DISCIPLINA)
                {
                    if (tempDisciplina != null)
                    {
                        throw new Exception("O novo código para a disciplina já está cadastrado no banco!");
                    }

                    tempDisciplina = contexto.DISCIPLINA.Where(disc => disc.CODIGO_DISCIPLINA == disciplinaAntiga.CODIGO_DISCIPLINA).FirstOrDefault();

                    // Cópia das disciplinas requisitantes.
                    foreach (Modelos.DISCIPLINA disciplina in tempDisciplina.DISCIPLINA2.ToList()) { disciplinaNova.DISCIPLINA2.Add(disciplina); }

                    // Cópia das fases alocadas.
                    foreach (Modelos.DISCIPLINA_CURSO disciplina in tempDisciplina.DISCIPLINA_CURSO.ToList()) { disciplinaNova.DISCIPLINA_CURSO.Add(disciplina); }

                    subject = disciplinaNova.CODIGO_DISCIPLINA;
                    contexto.DISCIPLINA.Add(disciplinaNova);

                    tempDisciplina.DISCIPLINA1.Clear();
                    tempDisciplina.DISCIPLINA2.Clear();
                    tempDisciplina.DISCIPLINA_CURSO.Clear();
                    contexto.Entry(tempDisciplina).State = System.Data.Entity.EntityState.Deleted;
                }
                else
                {
                    if (tempDisciplina == null)
                    {
                        throw new Exception("Objeto não encontrado!\nVerifique se há algum programa alterando o banco de dados.");
                    }

                    tempDisciplina.CODIGO_DISCIPLINA = subject = disciplinaNova.CODIGO_DISCIPLINA;
                    tempDisciplina.NOME_DISCIPLINA = disciplinaNova.NOME_DISCIPLINA;
                    tempDisciplina.CODIGO_DEPARTAMENTO = disciplinaNova.CODIGO_DEPARTAMENTO;
                    tempDisciplina.CREDITO_DISCIPLINA = disciplinaNova.CREDITO_DISCIPLINA;
                    tempDisciplina.DEPARTAMENTO = disciplinaNova.DEPARTAMENTO;

                    tempDisciplina.DISCIPLINA1.Clear();
                    tempDisciplina.DISCIPLINA1 = disciplinaNova.DISCIPLINA1;

                    contexto.Entry(tempDisciplina).State = System.Data.Entity.EntityState.Modified;
                }
                Modelos.Entidade cont = contexto;

                SalvaTurmas(ref cont, disciplinaNova.CODIGO_DISCIPLINA, turmaAntiga, turmaNova);
                contexto.SaveChanges();

                //Inserir turmas
            }
        }

        private void AdicionaRequisito(ref Modelos.DISCIPLINA disciplina, DataTable requisito, ref Modelos.Entidade contexto)
        {
            Modelos.DISCIPLINA tempRequisito;

            if (disciplina.DISCIPLINA1.Count > 0)
            {
                disciplina.DISCIPLINA1.Clear();
            }

            for (int i = 0; i < requisito.Rows.Count; i++)
            {
                tempRequisito = contexto.DISCIPLINA.Find(requisito.Rows[i].Field<string>("CODIGO_DISCIPLINA"));

                if (tempRequisito == null)
                {
                    throw new Exception("Uma disciplina requisito não foi encontrada no banco de dados.\nVerifique se existe alguma aplicação externa que esteja manipulando o banco de dados.");
                }

                disciplina.DISCIPLINA1.Add(tempRequisito);
            }
        }

        // Deleta a disciplina especificada.
        public void ApagaDisciplina(Modelos.DISCIPLINA disciplina)
        {
            using (Modelos.Entidade contexto = new Modelos.Entidade())
            {
                Modelos.DISCIPLINA temp = contexto.DISCIPLINA.Find(disciplina.CODIGO_DISCIPLINA);

                temp.DISCIPLINA1.Clear();

                contexto.Entry(temp).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }

        // Retorna todas as disciplinas cadastradas
        public DataTable SelecionaTodaDisciplina()
        {
            sql = new StringBuilder();
            comandoSql = new SqlCommand();
            dadosTabela = new DataTable();

            using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
            {
                sql.Append("SELECT	CODIGO_DISCIPLINA, NOME_DISCIPLINA, CREDITO_DISCIPLINA,");
                sql.Append("        DISCIPLINA.CODIGO_DEPARTAMENTO, NOME_DEPARTAMENTO ");
                sql.Append("        FROM DISCIPLINA INNER JOIN DEPARTAMENTO");
                sql.Append("        ON DISCIPLINA.CODIGO_DEPARTAMENTO = DEPARTAMENTO.CODIGO_DEPARTAMENTO");
                sql.Append("        ORDER BY NOME_DISCIPLINA ASC; ");


                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conexao;

                conexao.Open();

                dadosTabela.Load(comandoSql.ExecuteReader());

                return dadosTabela;
            }
        }

        // Retorna as disciplinas que contém o nome indicado -- REVER O FILTRO
        public Modelos.DISCIPLINA SelecionaDisciplina(string codigoDisciplina)
        {
            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    return contexto.DISCIPLINA.Find(codigoDisciplina);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Retorna uma tabela com as disciplinas-requisito da disciplina especificada.
        public DataTable SelecionaRequisito(Modelos.DISCIPLINA disciplina)
        {
            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    Modelos.DISCIPLINA dis = contexto.DISCIPLINA.Find(disciplina.CODIGO_DISCIPLINA);

                    //  dis.DISCIPLINA1.CopyTo(lista.ToArray(), 0);
                    if (dis == null) { throw new Exception("Disciplina não existe."); }
                }

                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();
                    comandoSql = new SqlCommand();

                    sql.Append("SELECT DISCIPLINA.CODIGO_DISCIPLINA, DISCIPLINA.NOME_DISCIPLINA ");
                    sql.Append("FROM PRE_REQUISITO ");
                    sql.Append("INNER JOIN DISCIPLINA ");
                    sql.Append("ON PRE_REQUISITO.CODIGO_DISCIPLINA_REQUISITO = DISCIPLINA.CODIGO_DISCIPLINA ");
                    sql.Append("WHERE PRE_REQUISITO.CODIGO_DISCIPLINA = ");
                    sql.Append("'" + disciplina.CODIGO_DISCIPLINA + "'");
                    sql.Append("ORDER BY NOME_DISCIPLINA ASC");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela = new DataTable();
                    dadosTabela.Load(comandoSql.ExecuteReader());
                }

                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable SelecionaTurmaPorDisciplina(string disciplina)
        {
            try
            {
                dadosTabela = new DataTable();
                comandoSql = new SqlCommand();
                sql = new StringBuilder();

                sql.Append("SELECT CODIGO_TURMA ");
                sql.Append(" FROM ");
                sql.Append(" (SELECT CODIGO_DISCIPLINA, CODIGO_TURMA ");
                sql.Append("    FROM DISCIPLINA_CURSO ");
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

        // Verifica se a disciplina possui requisitos.
        public bool VerificaTemRequisito(Modelos.DISCIPLINA disciplina)
        {
            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    Modelos.DISCIPLINA temp = contexto.DISCIPLINA.Find(disciplina.CODIGO_DISCIPLINA);

                    if (temp.DISCIPLINA1.Count > 0) { return true; }

                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Verifica se a disciplina é requisito de outra(s).
        public bool VerificaERequisito(Modelos.DISCIPLINA disciplina)
        {
            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    Modelos.DISCIPLINA temp = contexto.DISCIPLINA.Find(disciplina.CODIGO_DISCIPLINA);

                    if (temp.DISCIPLINA2.Count > 0) { return true; }
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Verifica se a disciplina está alocada em alguma(s) turma(s).
        public bool VerificaAlocacao(Modelos.DISCIPLINA disciplina)
        {
            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    if ((contexto.DISCIPLINA_TURMA.Where(p => p.CODIGO_DISCIPLINA == disciplina.CODIGO_DISCIPLINA)).ToList().Count > 0) { return true; }
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable SelecionaDisciplinaPorNome(string nome)
        {
            sql = new StringBuilder();
            comandoSql = new SqlCommand();
            dadosTabela = new DataTable();

            using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
            {
                sql.Append("SELECT	CODIGO_DISCIPLINA, NOME_DISCIPLINA, CREDITO_DISCIPLINA,");
                sql.Append("        DISCIPLINA.CODIGO_DEPARTAMENTO, NOME_DEPARTAMENTO ");
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
    }
}