using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class TurmaRegraNegocio
    {
        private AcessoDados.TurmaAcessoDados turmaAD;

        public void InsereTurma(Modelos.TURMA turma)
        {
            turmaAD = new AcessoDados.TurmaAcessoDados();

            try
            {
                VerificaTurma(turma);

                if (turmaAD.SelecionaTurma(turma) != null)
                {
                    throw new Exception("A turma " + turma.CODIGO_TURMA + " já está cadastrada.");
                }

                turmaAD.InsereTurma(turma);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }

        public void EditaTurma(Modelos.TURMA turmaAntiga, Modelos.TURMA turmaAtual)
        {
            try
            {
                turmaAD = new AcessoDados.TurmaAcessoDados();

                VerificaTurma(turmaAtual);


                turmaAD.EditaTurma(turmaAntiga, turmaAtual);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }

        public void ExcluiTurma(Modelos.TURMA turma)
        {
            try
            {
                turmaAD = new AcessoDados.TurmaAcessoDados();
                turmaAD.ExcluiTurma(turma);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }

        private void VerificaTurma(Modelos.TURMA turma)
        {
            int curso = 0;
            char index = '\0';
            int fase = 0;

            try
            {
                Modelos.Utilidades.ExtractFromTurma(turma.CODIGO_TURMA, ref fase, ref curso, ref index);

                Modelos.CURSO tempCurso = turmaAD.SelecionaCurso(curso);

                if (tempCurso == null)
                {
                    throw new Exception("Turma inválida.\nNão há nenhum curso com o código " + curso.ToString() + ".");
                }

                if (fase > tempCurso.QTD_FASE)
                {
                    throw new Exception("Turma inválida.\nO curso possui apenas " + tempCurso.QTD_FASE + " fases.");
                }

                if (true)
                {

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void VerificaTurmaAlocada()
        {

        }

        public DataTable SelecionaTodaTurma()
        {
            try
            {
                turmaAD = new AcessoDados.TurmaAcessoDados();

                return turmaAD.SelecionaTodaTurma();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }

        public DataTable SelecionaTurmaAlocada(string disciplina)
        {
            try
            {
                turmaAD = new AcessoDados.TurmaAcessoDados();

                return turmaAD.SelecionaTurmaAlocada(disciplina);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }

        }

        public Modelos.TURMA SelecionaTurma(Modelos.TURMA turma)
        {
            try
            {
                turmaAD = new AcessoDados.TurmaAcessoDados();

                return turmaAD.SelecionaTurma(turma);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }

        public void VerificaTurmaAlocada(Modelos.TURMA turma)
        {
            try
            {
                turmaAD = new AcessoDados.TurmaAcessoDados();

                if (turmaAD.SelecionaNumeroAlocacao(turma) > 0)
                {
                    throw new Exception("Não é possível editar a turma atual pois ela já está alocada na fase de um curso.");
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
