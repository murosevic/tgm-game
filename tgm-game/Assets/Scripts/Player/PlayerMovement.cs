using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public AnimationCurve c;

    public float moveTime;    

    public Rigidbody2D rb;

    public Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        moveSpeed = c.Evaluate(moveTime);

        if (movement != new Vector2(0, 0)) moveTime += Time.deltaTime;
        else if (((movement.x == 0f) && (movement.y == 0f) && moveTime != 0))
        {
            moveSpeed = 0f;
            moveTime = 0f;
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}