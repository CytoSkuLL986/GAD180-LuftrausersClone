using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    //public KeyCode rightTurn;
    //public KeyCode leftTurn;
    public KeyCode thrust;
    //public KeyCode shoot;

    private Vector2 speed;
    public int thrustPower;

    public bool isFlying = false;






    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            isFlying = true;

            if(isFlying)
            {
                rb.AddForce(new Vector2(0, 5 * thrustPower));
                
            }
            //rb.AddForce(Vector2.up * thrustPower);
            //rb.velocity += rb.velocity * speed;
            
        }
        else
        {
            isFlying = false;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.rotation += -100;
            //rb.transform.Rotate(0.0f, 0.0f, 40 * Time.deltaTime);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.rotation += 100;
            
        }
    }   
}
