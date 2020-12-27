using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notPlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    //public KeyCode rightTurn;
    //public KeyCode leftTurn;
    public KeyCode thrust;
    //public KeyCode shoot;

    private Vector2 speed;


    
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            //rb.AddForce(force);
        }
        
    }


   
}
