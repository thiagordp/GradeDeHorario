﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código foi gerado por uma ferramenta
//     As alterações neste arquivo serão perdidas se o código for recriado
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

public class ProfessorRegraNegocio
{
    private AcessoDados.ProfessorAcessoDados professor;

    // Insere um novo cadastro de professor
    public void InsereProfessor()
    {

    }

    public DataTable SelecionaTodoProfessor()
    {
        professor = new AcessoDados.ProfessorAcessoDados();

        return professor.SelecionaTodoProfessor();
    }

    public void EditaProfessor()
    {

    }
    public void VerificaProfessor()
    {

    }

    public void ApagaProfessor()
    {

    }

    public void SelecionaProfessor()
    {

    }

    public DataTable SelecionaTodoDepartamento()
    {
        professor = new AcessoDados.ProfessorAcessoDados();
        return professor.SelecionaTodoDepartamento();
    }
}

