using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public AnimationCurve c;

    float moveTime;    

    public Rigidbody2D rb;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        /*
         * Unity crashes on move
         * TODO: Implement move axis value to see if while loop is fitting
         * TODO: Increase moveTime if moving
         */

        moveSpeed = c.Evaluate(moveTime);
        
        while ((movement.x != 0) || (movement.y != 0))
        {
            moveTime += Time.deltaTime;
        }
        
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
