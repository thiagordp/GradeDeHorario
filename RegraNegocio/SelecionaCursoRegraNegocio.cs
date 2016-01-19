using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class SelecionaCursoRegraNegocio
    {
        AcessoDados.SelecionaCursoAcessoDados curso;

        // Retorna o Model do curso escolhido a partir do ID deste.
        public Modelos.CURSO SelecionaCursoEscolhido(int codigoCurso)
        {
            curso = new AcessoDados.SelecionaCursoAcessoDados();

            return curso.SelecionaCursoEscolhido(codigoCurso);
        }

        // Retorna uma lista com todos os cursos.
        public DataTable SelecionaTodoCurso()
        {
            curso = new AcessoDados.SelecionaCursoAcessoDados();
            return curso.SelecionaTodoCurso();
        }
    }
}
