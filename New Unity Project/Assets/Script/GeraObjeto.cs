using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeraObjeto : MonoBehaviour
{
    public float minH;
    public float maxH;
    public float rateSapwn;

    private float currentRateSapwn;

    public GameObject prefab;
    public int maxBloco;

    public List<GameObject> bloco;

    private float randPosition;

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
    void Update()
    {
         currentRateSapwn += Time.deltaTime;

        if (currentRateSapwn > rateSapwn)
        {
            currentRateSapwn = 0;
            Spawn();
        }

    }
    private void Spawn()
    {
        float rand = Random.Range(minH, maxH);

        GameObject tempBloco = null;

        for (int i = 0; i < maxBloco; i++)
        {
            if(bloco[i].activeSelf == false)
            {
                tempBloco = bloco[i];       
                break;
            }
        }

        if (tempBloco != null)
        {
            tempBloco.transform.position = new Vector3(transform.position.x, rand, transform.position.z);
            tempBloco.SetActive(true);
        }   
    }
    public void UpSpeed()
    {
        if (currentRateSapwn<3)
            currentRateSapwn += 0.05f;

        if (maxBloco > 6)
            maxBloco -= 1;

        for (int i = 0; i < maxBloco; i++)
        {
            if (bloco[i].GetComponent<BlocoBehaviour>().speed < 30f)
                bloco[i].GetComponent<BlocoBehaviour>().speed += 0.5f;
        }

    }

}
