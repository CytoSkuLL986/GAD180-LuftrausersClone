using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oldPlayerMovement : MonoBehaviour
{
    public float speed;
    public float acceleration;

    Rigidbody2D rb;

    public float rotationControl;

    float movY, movX = 1;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movY = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Vector2 vel = transform.right * (movX * acceleration);
        rb.AddForce(vel);

        float dir = Vector2.Dot(rb.velocity, rb.GetRelativeVector(Vector2.right));

        if(acceleration > 0)
        {
            rb.rotation += movY * rotationControl * (rb.velocity.magnitude / speed);
        }
        else
        {
            rb.rotation -= movY * rotationControl * (rb.velocity.magnitude / speed);
        }

        float thrustForce = Vector2.Dot(rb.velocity, rb.GetRelativeVector(Vector2.down)) * 2.0f;

        Vector2 relativeForce = Vector2.up * thrustForce;

        rb.AddForce(rb.GetRelativeVector(relativeForce));

        if(rb.velocity.magnitude > speed)
        {
            rb.velocity = rb.velocity.normalized * speed;
        }
    }

}
