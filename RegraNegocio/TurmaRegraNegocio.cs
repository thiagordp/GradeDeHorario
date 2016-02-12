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
        private TurmaRegraNegocio turmaAD;

        public DataTable SelecionaTodaTurma()
        {
            try
            {
                turmaAD = new TurmaRegraNegocio();

                return turmaAD.SelecionaTodaTurma();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }
    }
}
