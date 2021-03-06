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
namespace AcessoDados
{
    public class ProfessorRegraNegocio
    {
        private AcessoDados.ProfessorAcessoDados professorAD;

        // Insere um novo cadastro de professor
        public void InsereProfessor(Modelos.PROFESSOR professor)
        {
            VerificaProfessor(professor);

            try
            {
                professorAD = new AcessoDados.ProfessorAcessoDados();
                professorAD.InsereProfessor(professor);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }

        // Retorna uma lista com todos os professores cadastrados.
        public DataTable SelecionaTodoProfessor()
        {
            try
            {
                professorAD = new AcessoDados.ProfessorAcessoDados();

                return professorAD.SelecionaTodoProfessor();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }

        }

        // Edita dados de um professor cadastrado.
        public void EditaProfessor(Modelos.PROFESSOR profAntigo, Modelos.PROFESSOR profAtual)
        {
            VerificaProfessor(profAtual);

            try
            {
                professorAD = new ProfessorAcessoDados();
                professorAD.EditaProfessor(profAntigo, profAtual);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }

        // Verifica se o usuário preencheu corretamente os dados do professor.
        private void VerificaProfessor(Modelos.PROFESSOR professor)
        {
            if (professor.CODIGO_PROFESSOR == 0)
            {
                throw new Exception("O campo código do professor não pode ser nulo nem vazio!");
            }
            if (professor.CODIGO_DEPARTAMENTO == 0)
            {
                throw new Exception("O campo código do Departamento não pode ser nulo nem vazio!");
            }
            if (professor.NOME_PROFESSOR.Trim() == "")
            {
                throw new Exception("O campo nome do professor não pode ser vazio!");
            }
        }

        // Apaga um professor da lista.
        public void ApagaProfessor(Modelos.PROFESSOR professor)
        {
            try
            {
                professorAD = new ProfessorAcessoDados();
                professorAD.ApagaProfessor(professor);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }

        // Seleciona um professor de acordo com o código de identificação.
        public void SelecionaProfessor(Modelos.PROFESSOR professor)
        {
            professorAD = new ProfessorAcessoDados();
            professorAD.SelecionaProfessor(professor);
        }

        // Seleciona todos os departamentos cadastrados.
        public DataTable SelecionaTodoDepartamento()
        {
            try
            {
                return AcessoDados.UtilidadeAcessoDados.SelecionaTodoDepartamento();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }
    }
}