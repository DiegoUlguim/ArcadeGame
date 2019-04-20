using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colisao : MonoBehaviour
{
    public GameObject Objeto;
    public int teste;
    public Text score;
    public AudioSource newRecord;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Objeto)
        {
            PauseMenu.pausaGame = true;
            if (Convert.ToInt16(score.text) > PlayerPrefs.GetInt("recorde"))
            {
                Debug.Log("recorde = " + score.text);
                PlayerPrefs.SetInt("recorde", Convert.ToInt16(score.text));
                Debug.Log("recorde salvo = " + PlayerPrefs.GetInt("recorde").ToString());
                
                newRecord.Play();
            }

            
        }
    }
}
