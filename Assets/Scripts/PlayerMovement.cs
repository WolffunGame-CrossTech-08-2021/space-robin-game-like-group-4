using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public Rigidbody2D Rb;
    private Vector2 movement;
    
    public GameObject Bullet;
    public Transform FirePoint;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // rotate
        Vector3 mousePos = Input.mousePosition;
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.localPosition);
        Vector2 offset = new Vector2(mousePos.x - screenPoint.x, mousePos.y - screenPoint.y);
        float angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);




        // temp fire
        if (Input.GetMouseButtonDown(0))
        {
            float randomAngle = Random.Range(-15.0f, 15.0f);

            Instantiate(Bullet, FirePoint.position, Quaternion.Euler(0, 0, angle + randomAngle));
        }
    }

    void FixedUpdate()
    {
        Rb.MovePosition(Rb.position + movement * MoveSpeed * Time.fixedDeltaTime);
    }
}
