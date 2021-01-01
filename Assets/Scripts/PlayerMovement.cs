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

    AudioSource thrustSound;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        thrustSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //thrust force + direction defined.
        if (Input.GetKeyDown(thrust))
           {
            thrustSound.Play();
            }

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
            rotationSpeed = 190;
        }
        else
        {
            rotationSpeed = 90;
        }
    
        if(Input.GetKey(KeyCode.X))
        {
            //rb.velocity = new Vector3(-thrustPower, -thrustPower, 0);

            rb.AddRelativeForce(new Vector3(0, -7 * thrustPower, 0));

            
        }
    }

    private void LateUpdate()
    {
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

//KeyCode X:
//rb.AddForce(new Vector3(-thrustPower, -thrustPower, 0));
//rb.transform.up = new Vector3(-thrustPower, -thrustPower, 0);