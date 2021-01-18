using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopZıplama : MonoBehaviour
{
    public Rigidbody2D rb;
    float speed = 5.0f;

    void Basla()
    {
        int x = Random.Range(0, 2) * 2 - 1;
        int y = Random.Range(0, 2) * 2 - 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("Basla", 2);
    }

    void SilBastan()
    {
        rb.velocity = new Vector2 (0,0);
        transform.position = Vector2.zero;
    }
    public void EnBastan()
    {
        SilBastan();
        Invoke("Basla", 1);
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            Vector2 vel;
            vel.x = rb.velocity.x;
            vel.y = (rb.velocity.y / 2.0f) + (coll.collider.attachedRigidbody.velocity.y / 3.0f);
            rb.velocity = vel;
        }
    }
}