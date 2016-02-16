
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegraNegocio
{
    public class FaseRegraNegocio
    {
        private AcessoDados.FaseAcessoDados faseAD = new AcessoDados.FaseAcessoDados();

        // Seleciona disciplina(s) que comece(m) com o conteúdo de 'nome'
        public DataTable SelecionaDisciplina(string nome)
        {
            faseAD = new AcessoDados.FaseAcessoDados();

            return faseAD.SelecionaDisciplinaLikeNome(nome);
        }

        // Seleciona todas as disciplinas da fase no curso especificado.
        public DataTable SelecionaDisciplinaFase(int fase, int curso)
        {
            try
            {
                faseAD = new AcessoDados.FaseAcessoDados();

                return faseAD.SelecionaDisciplinaFase(fase, curso);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }

        // Salva as alterações na lista de disciplinas da fase do curso indicados.
        public void SalvaFase(DataGridView tabelaAntiga, DataGridView tabelaNova, int fase, int curso)
        {
            try
            {
                faseAD = new AcessoDados.FaseAcessoDados();
                // faseAD.SalvaFase(tabelaAntiga, tabelaNova, fase, curso);

                // Caso não tenha nenhuma disciplina naquela fase já cadastrada.
                if (tabelaAntiga.Rows.Count == 0)
                {
                    Modelos.DISCIPLINA_CURSO novaDiscFase;
                    List<Modelos.DISCIPLINA_CURSO> listaFase = new List<Modelos.DISCIPLINA_CURSO>();

                    for (int i = 0; i < tabelaNova.Rows.Count; i++)
                    {
                        novaDiscFase = new Modelos.DISCIPLINA_CURSO();
                        novaDiscFase.CODIGO_CURSO = curso;
                        novaDiscFase.CODIGO_DISCIPLINA = tabelaNova.Rows[i].Cells["CODIGO_DISCIPLINA"].Value.ToString();
                        novaDiscFase.FASE_DISCIPLINA_CURSO = fase;

                        Modelos.DISCIPLINA_CURSO temp = faseAD.VerificaDisciplinaCurso(novaDiscFase.CODIGO_DISCIPLINA, curso);


                        if (temp != null)
                        {
                            throw new Exception("A disciplina de código " + novaDiscFase.CODIGO_DISCIPLINA + " já está vinculada à " + temp.FASE_DISCIPLINA_CURSO.ToString() + "ª fase desse curso.\nRemova a restrição e tente novamente.");
                        }
                        
                        listaFase.Add(novaDiscFase);
                    }

                    faseAD = new AcessoDados.FaseAcessoDados();
                    faseAD.InsereListaDisciplinaFase(listaFase);
                }
                else
                {
                    List<Modelos.DISCIPLINA_CURSO> listaEdita = new List<Modelos.DISCIPLINA_CURSO>();
                    List<Modelos.DISCIPLINA_CURSO> listaExclui = new List<Modelos.DISCIPLINA_CURSO>();
                    List<Modelos.DISCIPLINA_CURSO> listaInsere = new List<Modelos.DISCIPLINA_CURSO>();
                    List<Modelos.DISCIPLINA_CURSO> listaFaseAntiga = faseAD.SelecionaFaseCurso(fase, curso);
                    List<Modelos.DISCIPLINA_CURSO> listaFaseNova = PreencheFase(tabelaNova, fase, curso);
                    List<Modelos.DISCIPLINA_CURSO> lista = PreencheFase(tabelaNova, fase, curso);


                   /* for (int i = 0; i < listaFaseNova.Count; i++)
                    {
                        Modelos.DISCIPLINA_CURSO discLista = listaFaseAntiga.Find(p => (p.CODIGO_DISCIPLINA == lista.ElementAt(i).CODIGO_DISCIPLINA) && (p.CODIGO_CURSO == curso));

                        if (discLista == null)
                        {
                            Modelos.DISCIPLINA_CURSO discFaseBD = faseAD.VerificaDisciplinaCurso(listaFaseNova.ElementAt(i).CODIGO_DISCIPLINA, curso);

                            if (discFaseBD != null) // Verifica se a disciplina já está vinculada à uma fase.
                            {
                                throw new Exception("A disciplina de código " + listaFaseNova.ElementAt(i).CODIGO_DISCIPLINA + " já está vinculada à " + discFaseBD.FASE_DISCIPLINA_CURSO.ToString() + "ª fase desse curso.\nRemova a restrição e tente novamente.");
                            }

                            // É uma nova disciplina.
                            listaInsere.Add(listaFaseNova.ElementAt(i));
                        }
                        else
                        {
                            listaFaseNova.ElementAt(i).SEQ_DISCIPLINA_CURSO = discLista.SEQ_DISCIPLINA_CURSO;

                            listaEdita.Add(listaFaseNova.ElementAt(i));

                            // listaFaseAntiga.Remove(listaFaseNova.ElementAt(i)); //não removeu
                            listaFaseAntiga.Remove(listaFaseAntiga.Find(p => p.SEQ_DISCIPLINA_CURSO == listaFaseNova.ElementAt(i).SEQ_DISCIPLINA_CURSO));
                        }
                    }

                    for (int i = 0; i < listaFaseAntiga.Count; i++)
                    {
                        // NULL!
                        Modelos.DISCIPLINA_CURSO temp = faseAD.SelecionaFaseCurso(fase, curso).Find(p => (p.CODIGO_DISCIPLINA == listaFaseAntiga.ElementAt(i).CODIGO_DISCIPLINA) && (p.CODIGO_CURSO == curso));
                        listaFaseAntiga.ElementAt(i).SEQ_DISCIPLINA_CURSO = temp.SEQ_DISCIPLINA_CURSO;
                        listaExclui.Add(listaFaseAntiga.ElementAt(i));
                    }*/

                    faseAD.SalvaFase(listaEdita, listaExclui, listaInsere);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }

        // Cria uma lista de relações de Disciplina em um curso em uma fase a partir de uma tabela 'DataGridView'.
        private List<Modelos.DISCIPLINA_CURSO> PreencheFase(DataGridView tabela, int fase, int curso)
        {
            Modelos.DISCIPLINA_CURSO temp;

            List<Modelos.DISCIPLINA_CURSO> lista = new List<Modelos.DISCIPLINA_CURSO>();

            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                temp = new Modelos.DISCIPLINA_CURSO();
                temp.CODIGO_DISCIPLINA = tabela.Rows[i].Cells["CODIGO_DISCIPLINA"].Value.ToString();
                temp.CODIGO_CURSO = curso;
                temp.FASE_DISCIPLINA_CURSO = fase;

                lista.Add(temp);
            }

            return lista;
        }

        // 
       /* private void VerificaFaseRequisito(string codigo, int fase, int curso)
        {
            try
            {
                Modelos.DISCIPLINA disciplina = new Modelos.DISCIPLINA();
                List<Modelos.DISCIPLINA> requisito = new List<Modelos.DISCIPLINA>();
                List<Modelos.DISCIPLINA> requisitante = new List<Modelos.DISCIPLINA>();

                disciplina.CODIGO_DISCIPLINA = codigo;

                faseAD = new AcessoDados.FaseAcessoDados();
                faseAD.VerificaFaseRequisito(ref disciplina, ref requisito, ref requisitante);

                // Caso a disciplina não tenha requisito e nem seja requisitada.
                if (requisito == null && requisitante == null) { return; }

                if (requisito != null)
                {
                    foreach (Modelos.DISCIPLINA discRequisito in requisito)
                    {
                        if (faseAD.FaseDisciplina(discRequisito.CODIGO_DISCIPLINA, curso) == -1)
                        {
                            throw new Exception("Não é possível cadastrar a disciplina de código" + disciplina.CODIGO_DISCIPLINA + ", pois a disciplina requisito de código " + discRequisito.CODIGO_DISCIPLINA + " ainda não está cadastrada em uma fase, sendo que tal fase deve ser anterior à fase da disciplina atual.");
                        }

                        if (faseAD.FaseDisciplina(disciplina.CODIGO_DISCIPLINA, curso) > 2)
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
            }
        }*/
    }
}

