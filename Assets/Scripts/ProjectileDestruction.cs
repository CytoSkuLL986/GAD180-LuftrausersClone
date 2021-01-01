using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDestruction : MonoBehaviour
{    
    // Start is called before the first frame update

    //Destroys projectile after a number of seconds from instantiation.
    void Start()
    {
        Destroy(gameObject, 7.0f);
    }

    //Destroys Projectile on collision.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        Debug.Log("Collision!");
    }


}
