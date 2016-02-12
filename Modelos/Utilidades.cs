using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Utilidades
    {

        public static void ExtractFromTurma(string turma, ref int fase, ref int curso, ref char indiceTurma)
        {
            indiceTurma = '\0';
            try
            {
                string temp = turma.Substring(0, 2);
                fase = Convert.ToInt32(temp);

                temp = turma.Substring(2, 3);
                curso = Convert.ToInt32(temp);

                if (turma.Length == 6)
                {
                    indiceTurma = turma.ElementAt(5);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string MakeTurma(int fase, int curso, char indiceTurma)
        {
            StringBuilder turma = new StringBuilder();

            if (fase < 10)
            {
                turma.Append("0");
            }

            turma.Append(fase.ToString());
            turma.Append(curso.ToString());

            if (indiceTurma >= 'A')
            {
                turma.Append(indiceTurma);
            }

            return turma.ToString();
        }
    }
}
