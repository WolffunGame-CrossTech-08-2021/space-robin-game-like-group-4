using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //public float ExistTime = 2f;
    public float Speed = 10f;
    public Rigidbody2D Rb;

    void Update()
    {
        Rb.velocity = transform.right * Speed;

        //ExistTime -= Time.deltaTime;
        //if (ExistTime <=  0)
        //{
        //    Destroy(gameObject);
        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
            Destroy(gameObject);

            Destroy(collision.gameObject);
        }

        if (collision.gameObject.layer == 9)
        {
            Destroy(gameObject);
        }

        
    }
}
