using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    public Text text;
    public float inactive;

    private int contador;

    public void ContaAsteroid()
    {
        contador += 1;
        text.text = contador.ToString();
    }

}
