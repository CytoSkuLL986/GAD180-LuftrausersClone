using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
     public Rigidbody2D projectile;
    public Transform fireLocation;

    int projectileCount = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LaunchProjectile());
    }

    IEnumerator LaunchProjectile()
    {
        while (projectileCount < 100)
        {
            Rigidbody2D projectileInstance;
            projectileInstance = Instantiate(projectile, fireLocation.position, fireLocation.rotation) as Rigidbody2D;
            projectileInstance.AddForce(fireLocation.up * 450);
            yield return new WaitForSecondsRealtime(Random.Range(2, 7));
            projectileCount += 1;
        }
    }    
}
