using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Celula
    {

        /// <summary>
        /// Constante para critério de comparação na lista de alterações por Disciplina e Turma.
        /// </summary>
        public const int COMPARA_DISCIPLINA_TURMA = 1;

        /// <summary>
        /// Constante para critério de comparação na lista de alterações por Professor.
        /// </summary>
        public const int COMPARA_PROFESSOR = 2;

        /// <summary>
        /// Constante para critério de comparação na lista de alterações por Sala.
        /// </summary>
        public const int COMPARA_SALA = 3;

        public int hora { get; set; }

        public int dia { get; set; }

        public string disciplina { get; set; }

        public string espaco { get; set; }

        public List<int> professores { get; set; }

        public string turma { get; set; }

        public int fase { get; set; }

        public int semestre { get; set; }

        public Celula()
        {
            hora = dia = fase = semestre = 0;
            disciplina = espaco = string.Empty;
            professores = new List<int>();
        }

        public bool Equal(Celula obj, int operacao)
        {
            switch (operacao)
            {
                case COMPARA_DISCIPLINA_TURMA:
                    if ((this.disciplina != obj.disciplina) || (this.turma != obj.turma)) { return false; }

                    break;
                case COMPARA_PROFESSOR:

                    for (int i = 0; i < obj.professores.Count; i++)
                    {
                        if (this.professores.ElementAt(i) != obj.professores.ElementAt(i)) { return false; }
                    }

                    break;
                case COMPARA_SALA:
                    if (this.espaco != obj.espaco) { return false; }

                    break;
            }
            return true;
        }
    }
}
