﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código foi gerado por uma ferramenta
//     As alterações neste arquivo serão perdidas se o código for recriado
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

public class InfraestruturaAcessoDados
{
    // Insere uma nova disciplina no banco de dados
    public void InsereInfraEstrutura(Modelos.ESPACO espaco)
    {
        using (Modelos.Entidade contexto = new Modelos.Entidade())
        {
            Modelos.ESPACO espacoExiste = contexto.ESPACO.Find(espaco.CODIGO_ESPACO);

            if (espacoExiste != null)
            {
                throw new Exception("Já existe um espaço com a identificação informada");
            }

            contexto.ESPACO.Add(espaco);
            contexto.SaveChanges();
        }
    }

    // Edita os atributos da disciplina indicada de acordo com os dados fornecidos
    public void EditaInfraEstrutura(Modelos.ESPACO espacoAntigo, Modelos.ESPACO espacoNovo)
    {
        Modelos.ESPACO tempEspaco;

        using (Modelos.Entidade contexto = new Modelos.Entidade())
        {
            tempEspaco = contexto.ESPACO.Where(esp => esp.CODIGO_ESPACO == espacoNovo.CODIGO_ESPACO).FirstOrDefault();

            if (espacoAntigo.CODIGO_ESPACO != espacoNovo.CODIGO_ESPACO) // Delete e insert espaço
            {
                if (tempEspaco != null)
                {
                    throw new Exception("O novo código para o espaço já está cadastrado no banco!");
                }

                contexto.ESPACO.Add(espacoNovo); // Adiciona o novo espaço.

                //Como insiriu-se um novo objeto, é necessário apagar o antigo.
                tempEspaco = contexto.ESPACO.Where(esp => esp.CODIGO_ESPACO == espacoAntigo.CODIGO_ESPACO).FirstOrDefault();

                if (tempEspaco != null)
                {
                    contexto.Entry(tempEspaco).State = System.Data.Entity.EntityState.Deleted; //Altera o estado do objeto.
                }
            }
            else // update
            {
                if (tempEspaco == null)
                {
                    throw new Exception("Objeto não encontrado!\nVerifique se há algum programa alterando o banco de dados.");
                }

                tempEspaco.CAPACIDADE_ESPACO = espacoNovo.CAPACIDADE_ESPACO;
                tempEspaco.CODIGO_ESPACO = espacoNovo.CODIGO_ESPACO;
                tempEspaco.INTERNET_ESPACO = espacoNovo.INTERNET_ESPACO;
                tempEspaco.NUMERO_PC_ESPACO = espacoNovo.NUMERO_PC_ESPACO;
                tempEspaco.PROJETOR_ESPACO = espacoNovo.PROJETOR_ESPACO;
                tempEspaco.QUADRO_BRANCO_ESPACO = espacoNovo.QUADRO_BRANCO_ESPACO;
                tempEspaco.QUADRO_VIDRO_ESPACO = espacoNovo.QUADRO_VIDRO_ESPACO;
                tempEspaco.TIPO_ESPACO = espacoNovo.TIPO_ESPACO;

                contexto.Entry(tempEspaco).State = System.Data.Entity.EntityState.Modified; // Marca a entidade como modificada

            }
            contexto.SaveChanges();     //Salva as alterações
        }
    }

    // Deleta a disciplina especificada
    public void ApagaInfraEstrutura(Modelos.ESPACO espaco)
    {
        try
        {
            using (Modelos.Entidade contexto = new Modelos.Entidade())
            {
                Modelos.ESPACO tempEspaco = contexto.ESPACO.Where(esp => esp.CODIGO_ESPACO == espaco.CODIGO_ESPACO).FirstOrDefault();

                if (tempEspaco == null)
                {
                    throw new Exception("Objeto não encontrado!\n\nVerifique se existe algum outro aplicativo manipulando o banco de dados.");
                }

                if (tempEspaco.GRADE_TURMA.Count > 0)
                {
                    throw new Exception("O espaço não pode ser excluído pois está alocado em alguma turma.\nDesaloque este espaço para, então, excluí-lo.");
                }

                contexto.Entry(tempEspaco).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    // Retorna todas as disciplinas cadastradas
    public DataTable SelecionaTodaInfraEstrutura()
    {/*
        using (SqlConnection conexao = new SqlConnection(AcessoDados.Conexao.stringConexao))
        {
            conexao.Open();
            StringBuilder sql = new StringBuilder();
            SqlCommand comandoSql = new SqlCommand();

            sql.Append("SELECT * FROM ESPACO");
            comandoSql.CommandText = sql.ToString();
            comandoSql.Connection = conexao;
            DataTable dadosTabela = new DataTable();

            dadosTabela.Load(comandoSql.ExecuteReader());

            return dadosTabela; 
        }*/
        
        try
        {
            using (Modelos.Entidade contexto = new Modelos.Entidade())
            {
                return AcessoDados.UtilidadeAcessoDados.ListToDataTable(contexto.ESPACO.ToList());
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    // Retorna as disciplinas que contém o nome indicado -- REVER O FILTRO
    public List<Modelos.ESPACO> SelecionaInfraEstrutura(string codigoEspaco)
    {
        try
        {
            using (Modelos.Entidade contexto = new Modelos.Entidade())
            {
                var matches = from e in contexto.ESPACO
                              where e.CODIGO_ESPACO.Contains(codigoEspaco)
                              select e;
                return matches.ToList();
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}