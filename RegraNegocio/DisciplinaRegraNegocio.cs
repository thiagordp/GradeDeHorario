﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código foi gerado por uma ferramenta
//     As alterações neste arquivo serão perdidas se o código for recriado
// </auto-generated>
//------------------------------------------------------------------------------
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace RegraNegocio
{
    public class DisciplinaRegraNegocio
    {
        AcessoDados.DisciplinaAcessoDados disciplinaAD;
        Form frmDisciplina;

        public DisciplinaRegraNegocio(Form frm)
        {
            frmDisciplina = frm;
        }
        
        // Insere uma disciplina no banco.
        public void InsereDisciplina(Modelos.DISCIPLINA disciplina, DataTable disciplinaRequisito)
        {

        }

        // Edita uma disciplina cadastrada.
        public void EditaDisciplina() { }

        // Apaga uma disciplina informada.
        public void ApagaDisciplina()
        {

        }

        // Retorna uma lista com todas as disciplinas cadastradas.
        public DataTable SelecionaTodaDisciplina()
        {
            disciplinaAD = new AcessoDados.DisciplinaAcessoDados();

            return disciplinaAD.SelecionaTodaDisciplina();
        }

        //
        public void SelecionaDisciplina()
        {

        }

        // Seleciona todo os departamentos
        public DataTable SelecionaTodoDepartamento()
        {
            return AcessoDados.UtilidadeAcessoDados.SelecionaTodoDepartamento();
        }

    }
}