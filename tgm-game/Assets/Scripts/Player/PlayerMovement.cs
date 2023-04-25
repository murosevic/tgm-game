using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float moveSpeed;
    public AnimationCurve c;

    public float moveTime;    

    public Rigidbody2D rb;

    public Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        moveSpeed = c.Evaluate(moveTime);
        print(moveSpeed);

        if (movement != new Vector2(0,0))
        {
            moveTime += Time.deltaTime;

            if (movement.x == 0 && movement.y == 0)
            {
                moveSpeed = 0;
            }
        }

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
    
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}