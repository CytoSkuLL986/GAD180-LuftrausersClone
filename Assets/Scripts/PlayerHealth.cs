using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int health;
    bool isHit = false;
    public bool isFiring = false;
    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        StartCoroutine(PlayerHeal());

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            isFiring = true;
        }
        else
        {
            isFiring = false;
        }




        if (health <= 0)
        {
            Debug.Log("Game Over!");
            GetComponent<PlayerMovement>().enabled = false;
            rb.gravityScale = 3;
        }
    }

   IEnumerator PlayerHeal()
    {
        while (health < 40 && !isFiring)
        {
            health += 5;
            yield return new WaitForSecondsRealtime(2);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("EnemyProjectile"))
        {
            Debug.Log("You Have Been Hit!");
            health -= 10;
        }
    }



}
