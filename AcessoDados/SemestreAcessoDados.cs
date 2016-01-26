using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class SemestreAcessoDados
    {
        public void InsereSemestre(Modelos.SEMESTRE semestre)
        {
            try
            {
                using (Modelos.Entidade contexto = new Modelos.Entidade())
                {
                    contexto.SEMESTRE.Add(semestre);
                    contexto.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlteraSemetre(Modelos.SEMESTRE semestre)
        {
            using (Modelos.Entidade contexto = new Modelos.Entidade())
            {
                Modelos.SEMESTRE temp = contexto.SEMESTRE.Find(semestre.SEQ_SEMESTRE);

                temp.NOME_SEMESTRE = semestre.NOME_SEMESTRE;

                contexto.Entry(temp).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public DataTable SelecionaTodoSemestre()
        {
            DataTable dadosTabela = new DataTable();

            StringBuilder sql = new StringBuilder();
            SqlCommand comandoSql = new SqlCommand();

            using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
            {
                sql.Append("SELECT SEQ_SEMESTRE, NOME_SEMESTRE ");
                sql.Append("    FROM SEMESTRE");

                conexao.Open();
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conexao;

                dadosTabela.Load(comandoSql.ExecuteReader());
                return dadosTabela;
            }
        }

        public void ApagaSemestre(Modelos.SEMESTRE semestre)
        {
            using (Modelos.Entidade contexto = new Modelos.Entidade())
            {
                Modelos.SEMESTRE temp = contexto.SEMESTRE.Find(semestre.SEQ_SEMESTRE);

                contexto.Entry(temp).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }

        public List<Modelos.TURMA> VerificaTemTurma(Modelos.SEMESTRE semestre)
        {
            using (Modelos.Entidade contexto = new Modelos.Entidade())
            {
                return contexto.SEMESTRE.Find(semestre.SEQ_SEMESTRE).TURMA.ToList();
            }
        }

        public Modelos.SEMESTRE SelecionaSemestrePorNome(string nome)
        {
            using (Modelos.Entidade contexto = new Modelos.Entidade())
            {
                Modelos.SEMESTRE semestre = contexto.SEMESTRE.Where(b => b.NOME_SEMESTRE == nome).FirstOrDefault();

                return semestre;
            }

        }
    }
}
