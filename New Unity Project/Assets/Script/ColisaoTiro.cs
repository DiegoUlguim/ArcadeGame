using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ColisaoTiro : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.SetActive(false);
    }
}
