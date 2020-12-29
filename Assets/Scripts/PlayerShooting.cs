using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public KeyCode fire;
    public Transform spawnlocation;
    public Rigidbody2D projectile;


    // Update is called once per frame
    void Update()
    {
        //Instantiation of projectile on 'fire'; launching from the desired location, with desired force.
        if(Input.GetKeyDown(fire))
        {
            Rigidbody2D projectileInstance;
            projectileInstance = Instantiate(projectile, spawnlocation.position, spawnlocation.rotation) as Rigidbody2D;
            projectileInstance.AddForce(spawnlocation.up * 500);
        }
        
    }
}
