using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    public KeyCode rightTurn;
    public KeyCode leftTurn;
    public KeyCode thrust;

    public int thrustPower;
    public int speed;

    public bool isFlying = false;
    public bool isRotatingR = false;
    public bool isRotatingL = false;

    private float rot;
    private float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //thrust force + direction defined.
        if (Input.GetKey(thrust))
        {
            isFlying = true;

            if(isFlying)
            {
                rb.AddRelativeForce(new Vector3(0, speed * thrustPower, 0));
            } 
        }
        else
        {
            isFlying = false;
        }

        //Player rotation (z axis rotation).

        rb.transform.eulerAngles = new Vector3(rb.transform.eulerAngles.x, rb.transform.eulerAngles.y, rot);

        if (Input.GetKey(rightTurn))
        {
            isRotatingR = true;

            if (isRotatingR)
            {
                rot -= rotationSpeed * Time.deltaTime;
            }               
        }
        else
        {
            isRotatingR = false;
        }
        
        if(Input.GetKey(leftTurn))
        {
            isRotatingL = true;

            if (isRotatingL)
            {
                rot += rotationSpeed * Time.deltaTime;
            }    
        }
        else
        {
            isRotatingL = false;
        }
        
    
        //Player rotation speed without using thust, else when using thrust.
        if (isFlying != true)
        {
            rotationSpeed = 200;
        }
        else
        {
            rotationSpeed = 75;
        }
    }
}



//Different attempts:
//isFlying:
//rb.AddForce(Vector2.up * thrustPower);
//rb.velocity += rb.velocity * speed;

//IsRotating:
//rb.rotation += -100;
//rb.transform.Rotate(0.0f, 0.0f, -40 * Time.deltaTime);
//rb.MoveRotation(30 * Time.deltaTime);