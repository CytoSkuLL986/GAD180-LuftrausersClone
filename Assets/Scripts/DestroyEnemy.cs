﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("PlayerProjectile"))
        {
            
            Destroy(gameObject);
            Debug.Log("Enemy Down!");
        }
    
    
        
    
    }
}
