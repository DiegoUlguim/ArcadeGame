using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeraTiro : MonoBehaviour
{
    public GameObject sing;
    public GameObject prefab;
    public Transform local;
    public int maxBloco;
    public Text text;

    public List<GameObject> bloco;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < maxBloco; i++)
        {
            GameObject tempBloco = Instantiate(prefab) as GameObject;
            bloco.Add(tempBloco);
            tempBloco.SetActive(false);
        }

    }

    // Update is called once per frame
    public void Fire()
    {
        if (Convert.ToInt32(text.text) > 0)
        {
            int contador = Convert.ToInt32(text.text);
            contador -= 1;
            text.text = contador.ToString();
            Spawn();
        }
    }
    private void Spawn()
    {
        GameObject tempBloco = null;

        for (int i = 0; i < maxBloco; i++)
        {
            if (bloco[i].activeSelf == false)
            {
                sing.GetComponent<AudioSource>().Play();
                tempBloco = bloco[i];
                break;
            }
        }

        if (tempBloco != null)
        {
            tempBloco.transform.position = new Vector3(local.transform.position.x - 7, local.transform.position.y, 0);
            tempBloco.SetActive(true);
        }

    }

}
