using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puan : MonoBehaviour
{
    public bool sagMisin;

    void OnTriggerEnter2D(Collider2D coll2)
    {
        if (coll2.gameObject.CompareTag("Ball"))
        {
            if (!sagMisin)
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().Player1Scored();
            }
            else {
                GameObject.Find("GameManager").GetComponent<GameManager>().Player2Scored();
            }
        }
    }
}