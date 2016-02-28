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
    }
}
