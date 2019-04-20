using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    public Text textMunicao;
    private int contProxMunicao = 20;
    private int contStageFase = 20;

    public GameObject geraBloco;

    public int GetContStageFase() { return contStageFase; }

    public void GeraMunicao(int contAsteroids)
    {
        if (contAsteroids == contProxMunicao)
        {
            contProxMunicao += 20;
            int municao = Convert.ToInt32(textMunicao.text);
            if (municao < 3)
            {
                municao += 1;
                textMunicao.text = municao.ToString();
            }

        }
    }

    public void AceleraFase(int contAsteroids)
    {
        if (contAsteroids > contStageFase)
        {
            contStageFase += 20;
            geraBloco.GetComponent<GeraObjeto>().UpSpeed();
        }
    }
}
