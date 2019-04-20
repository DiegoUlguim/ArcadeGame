using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroBehaviour : MonoBehaviour
{
    public float speed;
    public GameObject bloco;
    public float inactive;

    void Update()
    {


        bloco.transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;

        if (bloco.transform.position.x > inactive)
        {
            bloco.SetActive(false);
        }


    }
}
