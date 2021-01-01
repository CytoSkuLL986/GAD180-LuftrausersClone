using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] Transform player;
    private float speed = 10f;
    private Rigidbody2D rb;
    private Vector2 movement;
    [SerializeField] Vector3 offset;


    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        //offset.x = 0.5f;
        //offset.y = 0.5f;
        //offset.z = 0f;
    }

    public void Update()
    {
        //Vector3 direction = (player.position + offset) - transform.position;

        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
        
    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }

}
