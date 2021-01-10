using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SagHareket : MonoBehaviour
{

    public float speed = 10.0f;
    public Rigidbody2D rb;
    public float boundY;


    // Update is called once per frame
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        var vel = rb.velocity;
        if (Input.GetKey(KeyCode.UpArrow))
        {

            vel.y = speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {

            vel.y = -speed;
        }

        else
        {
            vel.y = 0;
        }
        rb.velocity = vel;

        var pos = transform.position;
        if (pos.y > boundY)
        {
            pos.y = boundY;
        }
        else if (pos.y < -boundY)
        {
            pos.y = -boundY;
        }
        transform.position = pos;
    }
}