using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegraNegocio
{
    public class GradeHorarioRegraNegocio
    {
        /// <summary>
        /// Objeto que referencia o curso da grade atual.
        /// </summary>
        private Modelos.CURSO curso;

        /// <summary>
        /// Objeto de referência à camada de acessos aos dados.
        /// </summary>
        private AcessoDados.GradeHorarioAcessoDados gradeAD;

        private Modelos.Entidade contexto;

        /// <summary>
        /// Construtor da classe
        /// </summary> 
        public GradeHorarioRegraNegocio(Modelos.CURSO curso, ref Modelos.Entidade contexto)
        {
            this.curso = curso;
            this.contexto = contexto;
        }

        /// <summary>
        /// Seleciona um conjunto de disciplinas com base no filtro.
        /// </summary>
        /// <param name="filtro">Filtro para a pesquisa, sendo o começo do nome.</param>
        public DataTable SelecionaDisciplina(string filtro, int fase)
        {
            try
            {
                gradeAD = new AcessoDados.GradeHorarioAcessoDados(curso, ref contexto);

                return gradeAD.SelecionaDisciplina(filtro, fase);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }

        /// <summary>
        /// Seleciona um conjunto de professores com base no filtro.
        /// </summary>
        /// <param name="filtro">Filtro para a pesquisa, sendo o começo do nome.</param>
        /// <returns></returns>
        public DataTable SelecionaProfessor(string filtro)
        {
            try
            {
                gradeAD = new AcessoDados.GradeHorarioAcessoDados(curso, ref contexto);

                return gradeAD.SelecionaProfessor(filtro);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }

        /// <summary>
        /// Seleciona um conjunto de espaços com base no filtro.
        /// </summary>
        /// <param name="filtro">Filtro para a pesquisa, sendo o começo do código do espaço.</param>
        /// <returns></returns>
        public DataTable SelecionaEspaco(string filtro)
        {
            try
            {
                gradeAD = new AcessoDados.GradeHorarioAcessoDados(curso, ref contexto);

                return gradeAD.SelecionaEspaco(filtro);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }

        public DataTable SelecionaTodoSemestre()
        {
            gradeAD = new AcessoDados.GradeHorarioAcessoDados(curso, ref contexto);

            return gradeAD.SelecionaTodoSemestre();
        }

        public List<DataGridView> CarregaGrade(int curso, int fase, int semestre)
        {
            VerificaCarregaGrade(curso, fase, semestre);

            return null;
        }

        public void VerificaCarregaGrade(int curso, int fase, int semestre)
        {
            if (curso <= 0)
            {
                throw new Exception("Curso inválido!");
            }
            if (fase == 0)
            {
                throw new Exception("É necessário escolher uma fase para carregar uma grade.");
            }
            if (semestre == 0)
            {
                throw new Exception("É necessário escolher um semestre para carregar uma grade.");
            }
        }

        /// <summary>
        /// REFAZER
        /// </summary>
        /// <param name="disciplina"></param>
        /// <param name="turma"></param>
        /// <param name="prof1"></param>
        /// <param name="prof2"></param>
        /// <param name="prof3"></param>
        /// <param name="espaco"></param>
        /// <returns>Informações da célula.</returns>
        public string SelecionaDetalhe(string disciplina, string turma, int prof1, int prof2, int prof3, string espaco)
        {
            StringBuilder msg = new StringBuilder();
            string nomeDisciplina = "";
            string nomeProf1 = "";
            string nomeProf2 = "";
            string nomeProf3 = "";
            try
            {
                nomeDisciplina = (new AcessoDados.DisciplinaAcessoDados()).SelecionaDisciplina(disciplina).NOME_DISCIPLINA;

                Modelos.PROFESSOR temp = (new AcessoDados.ProfessorAcessoDados()).SelecionaProfessorByCodigo(prof1);
                if (temp != null)
                {
                    nomeProf1 = temp.NOME_PROFESSOR;
                }

                temp = (new AcessoDados.ProfessorAcessoDados()).SelecionaProfessorByCodigo(prof2);

                if (temp != null)
                {
                    nomeProf2 = temp.NOME_PROFESSOR;
                }

                temp = (new AcessoDados.ProfessorAcessoDados()).SelecionaProfessorByCodigo(prof3);

                if (temp != null)
                {
                    nomeProf3 = temp.NOME_PROFESSOR;
                }


                Modelos.ESPACO esp = (new InfraestruturaAcessoDados()).SelecionaInfraEstrutura(espaco).First();

                string tipoEspaco = "Desconhecido";

                if (esp != null)
                {
                    tipoEspaco = esp.TIPO_ESPACO;
                }


                msg.Append("Disciplina:\t\t" + disciplina + " - " + nomeDisciplina + "\n");
                msg.Append("Turma:\t\t" + turma + "\n");
                msg.Append("Professores:\t" + prof1 + " - " + nomeProf1 + "\n");

                if (!prof2.Equals(-1))
                {
                    msg.Append("\t\t" + prof2 + " - " + nomeProf2 + "\n");
                }

                if (!prof3.Equals(-1))
                {
                    msg.Append("\t\t" + prof3 + " - " + nomeProf3 + "\n");
                }

                msg.Append("Espaço:\t\t" + espaco + "\n  • " + "Tipo:\t\t" + tipoEspaco);

                return msg.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
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
            try
            {
                gradeAD = new AcessoDados.GradeHorarioAcessoDados(this.curso, ref contexto);

                return gradeAD.SelecionaTodaGrade(fase, semestre);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }

        /// <summary>
        /// Insere uma nova célula na grade
        /// </summary>
        /// <param name="grade">Formulário da grade</param>
        /// <param name="celula">Célula a ser inserida</param>
        public void InsereCelula(ref TableLayoutPanel grade, Modelos.Celula celula)
        {
            try
            {
                gradeAD = new AcessoDados.GradeHorarioAcessoDados(curso, ref contexto);

                // Verificações aqui...
                gradeAD.SelectDisciplinaTurmaFromDiaHora(celula);
                gradeAD.SelectProfessorFromHora(celula);
                gradeAD.SelectEspacoFromHora(celula);

                gradeAD.InsereGrade(ref grade, celula);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }

        public void ApagaCelula(ref TableLayoutPanel grade, Modelos.Celula celula)
        {
            try
            {
                gradeAD = new AcessoDados.GradeHorarioAcessoDados(curso, ref contexto);

                gradeAD.ApagaGrade(ref grade, celula);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private string ProximaTurma(string turmaAtual, int fase)
        {
            string turmaFinal = "";

            if (turmaAtual == string.Empty)
            {
                turmaFinal = "0" + fase.ToString() + this.curso.CODIGO_CURSO.ToString();

                if (fase >= 10)
                {
                    turmaFinal = turmaFinal.Remove(0, 1);
                }
            }
            else
            {
                if (turmaAtual.Length == 5)
                {
                    turmaFinal = turmaAtual + "B";

                    // Colocar o sufixo A na anterior (turmaAtual).

                }
                else // Provavelmente será 6.
                {
                    char ch = turmaAtual.ElementAt(turmaAtual.Length - 1);

                    ch = (char)(ch + 1);

                    turmaFinal = turmaAtual.Remove(turmaAtual.Length - 1, 1) + ch.ToString();
                }
            }
            MessageBox.Show(turmaAtual + "\n" + turmaFinal);

            return turmaFinal;
        }

        /// <summary>
        /// Seleciona o número de créditos gastos e o máximo de uma turma de uma disciplina de um semestre
        /// </summary>
        /// <param name="turma"></param>
        /// <param name="disciplina"></param>
        /// <param name="semestre"></param>
        /// <param name="countCredito"></param>
        /// <param name="maxCredito"></param>
        public void Credito(string turma, string disciplina, string semestre, ref int countCredito, ref int maxCredito)
        {
            try
            {
                gradeAD = new AcessoDados.GradeHorarioAcessoDados(curso, ref contexto);
                gradeAD.SelectNumeroCredito(turma, disciplina, semestre, ref countCredito, ref maxCredito);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }

        public void CarregaLocalmente()
        {
            gradeAD = new AcessoDados.GradeHorarioAcessoDados(curso, ref contexto);

            gradeAD.CarregaLocalmente();
        }

        public void SelectProfessorFromHora(Modelos.Celula celula)
        {
            gradeAD = new AcessoDados.GradeHorarioAcessoDados(curso, ref contexto);

            gradeAD.SelectProfessorFromHora(celula);
        }

        public void SelectEspacoFromEspaco(Modelos.Celula celula)
        {
            gradeAD = new AcessoDados.GradeHorarioAcessoDados(curso, ref contexto);
            gradeAD.SelectEspacoFromHora(celula);
        }

        public void SelectDisciplinaTurmaFromDiaHora(Modelos.Celula celula)
        {
            gradeAD = new AcessoDados.GradeHorarioAcessoDados(curso, ref contexto);

            gradeAD.SelectDisciplinaTurmaFromDiaHora(celula);
        }
    }
}