using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class SemestreRegraNegocio
    {
        private AcessoDados.SemestreAcessoDados semestreAD;

        public void InsereSemestre(Modelos.SEMESTRE semestre)
        {
            VerificaSemestre(semestre);

            try
            {
                semestreAD.InsereSemestre(semestre);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }

        public void AlteraSemestre(Modelos.SEMESTRE semestre)
        {
            VerificaSemestre(semestre);

            semestreAD = new AcessoDados.SemestreAcessoDados();

            semestreAD.AlteraSemetre(semestre);
        }

        public DataTable SelecionaTodoSemestre()
        {
            semestreAD = new AcessoDados.SemestreAcessoDados();

            return semestreAD.SelecionaTodoSemestre();
        }

        public void ApagaSemestre(Modelos.SEMESTRE semestre)
        {
            semestreAD = new AcessoDados.SemestreAcessoDados();

            if (semestreAD.VerificaTemTurma(semestre).Count > 0)
            {
                throw new Exception("Não é possível apagar o semestre pois este contém turmas cadastradas.\nRemova essas turmas e tente novamente.");
            }

            semestreAD.ApagaSemestre(semestre);
        }

        public void VerificaSemestre(Modelos.SEMESTRE semestre)
        {
            if (semestre.NOME_SEMESTRE.Trim().Count() == 0)
            {
                throw new Exception("O campo de nome do semestre não pode ser vazio.");
            }


            semestreAD = new AcessoDados.SemestreAcessoDados();
            Modelos.SEMESTRE lista = semestreAD.SelecionaSemestrePorNome(semestre.NOME_SEMESTRE);

            if (lista != null)
            {
                throw new Exception("Já existe um semestre com este nome.");
            }

        }
    }
}
