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
        Debug.Log("Collision!");
        Destroy(gameObject, 0.08f);
    
    }
}
