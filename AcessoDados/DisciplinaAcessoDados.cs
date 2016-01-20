﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código foi gerado por uma ferramenta
//     As alterações neste arquivo serão perdidas se o código for recriado
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace AcessoDados
{

    public class DisciplinaAcessoDados
    {
        StringBuilder sql;
        SqlCommand comandoSql;
        DataTable dadosTabela;


        //
        // Insere uma nova disciplina no banco de dados
        //
        public void InsereDisciplina(Modelos.DISCIPLINA disciplina, DataGridView requisitos)
        {
            Modelos.DISCIPLINA tempDisciplina;

            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    for (int i = 0; i < requisitos.Rows.Count; i++)
                    {
                        tempDisciplina = contexto.DISCIPLINA.Find(requisitos.Rows[i].Cells["CODIGO_DISCIPLINA_REQ"].Value.ToString());

                        if (tempDisciplina == null)
                        {
                            throw new Exception("Uma disciplina requisito não foi encontrada no banco de dados.\nVerifique se existe alguma aplicação externa que esteja manipulando o banco de dados.");
                        }

                        disciplina.DISCIPLINA1.Add(tempDisciplina);
                    }

                    contexto.DISCIPLINA.Add(disciplina);
                    contexto.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //
        // Edita os atributos da disciplina indicada de acordo com os dados fornecidos
        //
        public void EditaDisciplina()
        {
        }

        // Deleta a disciplina especificada
        public void ApagaDisciplina()
        {
        }

        // Retorna todas as disciplinas cadastradas
        public DataTable SelecionaTodaDisciplina()
        {
            sql = new StringBuilder();
            comandoSql = new SqlCommand();
            dadosTabela = new DataTable();

            using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
            {
                sql.Append("SELECT	CODIGO_DISCIPLINA, NOME_DISCIPLINA, CREDITO_DISCIPLINA,");
                sql.Append("        DISCIPLINA.CODIGO_DEPARTAMENTO, NOME_DEPARTAMENTO ");
                sql.Append("        FROM DISCIPLINA INNER JOIN DEPARTAMENTO");
                sql.Append("        ON DISCIPLINA.CODIGO_DEPARTAMENTO = DEPARTAMENTO.CODIGO_DEPARTAMENTO");
                sql.Append("        ORDER BY NOME_DISCIPLINA ASC; ");


                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conexao;

                conexao.Open();

                dadosTabela.Load(comandoSql.ExecuteReader());

                return dadosTabela;
            }
        }

        // Retorna as disciplinas que contém o nome indicado -- REVER O FILTRO
        public Modelos.DISCIPLINA SelecionaDisciplina(string codigoDisciplina)
        {
            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    return contexto.DISCIPLINA.Find(codigoDisciplina);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}