﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

public class InfraestruturaRegraNegocio
{
    InfraestruturaAcessoDados infraEstruturaAD;

    //Seleciona todos os espacos
    public DataTable SelecionaTodaInfraEstrutura()
    {
        try
        {
            infraEstruturaAD = new InfraestruturaAcessoDados();

            return infraEstruturaAD.SelecionaTodaInfraEstrutura();
        }
        catch (Exception ex)
        {
            throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
        }
    }

    // Verifica o novo registro e caso esteja correto, a camada de dados o armazenará.
    // Caso o registro apresente algum erro, este será reportado ao usuário.
    public void InsereInfraEstrutura(Modelos.ESPACO espaco)
    {
        VerificaInfraEstrutura(espaco);

        try
        {
            infraEstruturaAD = new InfraestruturaAcessoDados();
            infraEstruturaAD.InsereInfraEstrutura(espaco);
        }
        catch (Exception ex)
        {
            throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
        }
    }

    // Verifica o novo registro e caso esteja correto, a camada de dados o armazenará.
    // Caso o registro apresente algum erro, este será reportado ao usuário.
    public void EditaInfraEstrutura(Modelos.ESPACO espacoAtual, Modelos.ESPACO espacoNovo)
    {
        VerificaInfraEstrutura(espacoNovo);

        try
        {
            infraEstruturaAD = new InfraestruturaAcessoDados();


            infraEstruturaAD.EditaInfraEstrutura(espacoAtual, espacoNovo);
        }
        catch (Exception ex)
        {
            throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
        }
    }

    // Verifica os campos do Espaço informado.
    private void VerificaInfraEstrutura(Modelos.ESPACO espaco)
    {
        if (espaco.CODIGO_ESPACO.Trim() == "")
        {
            throw new Exception("O campo código do espaço não pode ser vazio!");
        }
        if (espaco.CAPACIDADE_ESPACO == 0)
        {
            throw new Exception("A capacidade deve ser maior que zero!");
        }
        if (espaco.TIPO_ESPACO == "")
        {
            throw new Exception("Selecione um tipo de espaço!");
        }
    }

    // Apaga o objeto de InfraEstrutura indicado.
    public void ApagaInfraEstrutura(Modelos.ESPACO espaco)
    {
        VerificaInfraEstrutura(espaco);

        try
        {
            infraEstruturaAD = new InfraestruturaAcessoDados();
            infraEstruturaAD.ApagaInfraEstrutura(espaco);
        }
        catch (Exception ex)
        {
            throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
        }
    }

    public List<Modelos.ESPACO> SelecionaInfraEstrutura(string codigoEspaco)
    {
        try
        {
            infraEstruturaAD = new InfraestruturaAcessoDados();

            return infraEstruturaAD.SelecionaInfraEstrutura(codigoEspaco);
        }
        catch (Exception ex)
        {
            throw new Exception("Erro no método " + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n\nDetalhe:\n\n" + ex.Message);
        }
    }
}

