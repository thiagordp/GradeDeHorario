using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AcessoDados
{
    public class ProfessorAcessoDados
    {
        StringBuilder sql;
        SqlCommand comandoSql;
        DataTable dadosTabela;

        //
        // Insere um professor no banco de dados
        //
        public void InsereProfessor(Modelos.PROFESSOR professor)
        {
            using (Modelos.Entidade contexto = new Modelos.Entidade())
            {
                Modelos.PROFESSOR profExiste = contexto.PROFESSOR.Find(professor.CODIGO_PROFESSOR);

                if (profExiste != null)
                {
                    throw new Exception("Já existe um professor com a identificação informada.");
                }

                // Referenciação do Departamento ao qual o professor pertence.
                Modelos.DEPARTAMENTO depto = contexto.DEPARTAMENTO.Find(professor.CODIGO_DEPARTAMENTO);
                if (depto == null)
                {
                    throw new Exception("O departamento indicado não existe!\nCertifique-se que nenhuma outra aplicação esteja manipulando o banco de dados!");
                }
                professor.DEPARTAMENTO = depto;

                // Insere e Salvar alterações.
                contexto.PROFESSOR.Add(professor);
                contexto.SaveChanges();
            }
        }

        //
        // Edita os atributos do professor indicado de acordo com os dados fornecidos.
        //
        public void EditaProfessor(Modelos.PROFESSOR profAntigo, Modelos.PROFESSOR profNovo)
        {
            Modelos.PROFESSOR tempProf;

            using (Modelos.Entidade contexto = new Modelos.Entidade())
            {
                profNovo.DEPARTAMENTO = contexto.DEPARTAMENTO.Find(profNovo.CODIGO_DEPARTAMENTO); // Busca a instância do departamento indicado e armazena no objeto professor.

                tempProf = contexto.PROFESSOR.Where(prof => prof.CODIGO_PROFESSOR == profNovo.CODIGO_PROFESSOR).FirstOrDefault();

                if (profAntigo.CODIGO_PROFESSOR != profNovo.CODIGO_PROFESSOR)
                {
                    if (tempProf != null)
                    {
                        throw new Exception("O novo código para o professor já está cadastrado no banco!");
                    }

                    contexto.PROFESSOR.Add(profNovo);// Adiciona o novo espaço.

                    //Como insiriu-se um novo objeto, é necessário apagar o antigo.
                    tempProf = contexto.PROFESSOR.Where(prof => prof.CODIGO_PROFESSOR == profAntigo.CODIGO_PROFESSOR).FirstOrDefault();

                    if (tempProf != null)
                    {
                        contexto.Entry(tempProf).State = System.Data.Entity.EntityState.Deleted; //Altera o estado do objeto para excluído.
                    }
                }
                else
                {
                    if (tempProf == null)
                    {
                        throw new Exception("Objeto não encontrado!\nVerifique se há algum programa alterando o banco de dados.");
                    }

                    tempProf.CODIGO_PROFESSOR = profNovo.CODIGO_PROFESSOR;
                    tempProf.CODIGO_DEPARTAMENTO = profNovo.CODIGO_DEPARTAMENTO;
                    tempProf.NOME_PROFESSOR = profNovo.NOME_PROFESSOR;
                    tempProf.DEPARTAMENTO = profNovo.DEPARTAMENTO;

                    contexto.Entry(tempProf).State = System.Data.Entity.EntityState.Modified; // Marca a entidade como modificada
                }
                contexto.SaveChanges();
            }
        }

        //
        // Apaga o professor especificado
        //
        public void ApagaProfessor(Modelos.PROFESSOR professor)
        {
            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    Modelos.PROFESSOR tempProfessor = contexto.PROFESSOR.Where(prof => prof.CODIGO_PROFESSOR == professor.CODIGO_PROFESSOR).FirstOrDefault();

                    if (tempProfessor == null)
                    {
                        throw new Exception("Objeto não encontrado!\n\nVerifique se existe algum outro aplicativo manipulando o banco de dados.");
                    }

                    if (tempProfessor.DISCIPLINA_TURMA.Count != 0)
                    {
                        throw new Exception("O professor não pode ser excluído pois está alocado em alguma turma.\nDesaloque este professor para, então, excluí-lo.");
                    }

                    contexto.Entry(tempProfessor).State = System.Data.Entity.EntityState.Deleted;
                    contexto.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //
        // Retorna todos os professores cadastrados e os departamentos aos quais estão vinculados
        //
        public DataTable SelecionaTodoProfessor()
        {
            sql = new StringBuilder();
            comandoSql = new SqlCommand();

            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT PROFESSOR.*, NOME_DEPARTAMENTO FROM PROFESSOR INNER JOIN DEPARTAMENTO");
                    sql.Append(" ON PROFESSOR.CODIGO_DEPARTAMENTO = DEPARTAMENTO.CODIGO_DEPARTAMENTO");
                    sql.Append(" ORDER BY NOME_PROFESSOR ASC");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    DataTable dadoTabela = new DataTable();

                    dadoTabela.Load(comandoSql.ExecuteReader());

                    /*      MODO ALTERNATIVO

                    using (Modelos.Entidade ctx = new Modelos.Entidade())
                    {
                        var query = (from prof in ctx.PROFESSOR
                                     join dep in ctx.DEPARTAMENTO on prof.CODIGO_DEPARTAMENTO equals dep.CODIGO_DEPARTAMENTO
                                     orderby prof.NOME_PROFESSOR
                                     select new { prof, dep}).ToList();

                        return AcessoDados.UtilidadeAcessoDados.ListToDataTable(query);
                    }*/

                    return dadoTabela;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //
        // Retorna o professor que contém o nome indicado -- REVER O FILTRO
        //
        public DataTable SelecionaProfessor(Modelos.PROFESSOR professor)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    sql = new StringBuilder();
                    comandoSql = new SqlCommand();

                    sql.Append("SELECT PROFESSOR.*, NOME_DEPARTAMENTO");
                    sql.Append(" FROM PROFESSOR INNER JOIN DEPARTAMENTO");
                    sql.Append(" ON PROFESSOR.CODIGO_DEPARTAMENTO = DEPARTAMENTO.CODIGO_DEPARTAMENTO");
                    sql.Append(" WHERE PROFESSOR.NOME_PROFESSOR LIKE '@NOME%';");



                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Parameters.AddWithValue("@NOME", professor.NOME_PROFESSOR);
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());

                    return dadosTabela;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public Modelos.PROFESSOR SelecionaProfessorByCodigo(int codigo)
        {
            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    return contexto.PROFESSOR.Find(codigo);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }


}
