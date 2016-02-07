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

        /// <summary>
        /// Construtor da classe
        /// </summary> 
        public GradeHorarioRegraNegocio(Modelos.CURSO curso)
        {
            this.curso = curso;
        }

        /// <summary>
        /// Seleciona um conjunto de disciplinas com base no filtro.
        /// </summary>
        /// <param name="filtro">Filtro para a pesquisa, sendo o começo do nome.</param>
        public DataTable SelecionaDisciplina(string filtro)
        {
            try
            {
                gradeAD = new AcessoDados.GradeHorarioAcessoDados(curso);

                return gradeAD.SelecionaDisciplina(filtro);
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
                gradeAD = new AcessoDados.GradeHorarioAcessoDados(curso);

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
                gradeAD = new AcessoDados.GradeHorarioAcessoDados(curso);

                return gradeAD.SelecionaEspaco(filtro);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }

        public DataTable SelecionaTodoSemestre()
        {
            gradeAD = new AcessoDados.GradeHorarioAcessoDados(curso);

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
                msg.Append("Professor:\t\t" + prof1 + " - " + nomeProf1 + "\n");

                if (!prof2.Equals(-1))
                {
                    msg.Append("Professor 2:\t" + prof2 + " - " + nomeProf2 + "\n");
                }

                if (!prof3.Equals(-1))
                {
                    msg.Append("Professor 3:\t" + prof3 + " - " + nomeProf3 + "\n");
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
                gradeAD = new AcessoDados.GradeHorarioAcessoDados(this.curso);

                return gradeAD.SelecionaTodaGrade(fase, semestre);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }
    }
}

