using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;

    public Vector3 playerPos;

    public float smoothSpeed = 0.125f;

    // Update is called once per frame
    void FixedUpdate()
    {
        playerPos = new Vector3(player.transform.position.x, player.transform.position.y, -10);

        Vector3 desiredPosition = playerPos;
        Vector3 smoothedPosition = Vector3.Lerp(this.transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        this.transform.position = smoothedPosition;
    }
}
