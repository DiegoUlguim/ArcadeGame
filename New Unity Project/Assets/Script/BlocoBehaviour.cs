using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlocoBehaviour : MonoBehaviour
{
    public GameObject game;

    public float speed;
    public GameObject bloco;
    public Text textAsteroids;

    public float inactive;

    void Update()
    {
        bloco.transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;

        if (bloco.transform.position.x < inactive)
        {
            int contador = Convert.ToInt32(textAsteroids.text);
            contador += 1;
            textAsteroids.text = contador.ToString();

            game.GetComponent<GameScript>().GeraMunicao(contador);

            game.GetComponent<GameScript>().AceleraFase(contador);

            bloco.SetActive(false);
        }        
        
    }
    
}
