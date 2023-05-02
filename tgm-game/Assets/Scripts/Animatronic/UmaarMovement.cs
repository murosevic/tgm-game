using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmaarMovement : MonoBehaviour
{
    public Transform[] positions = new Transform[6];

    public GameObject umaar;

    public int random;
    public int randomPos;
    public int moveDiff = 1;

    private float nextActionTime = 0.0f;
    private float period = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        randomPos = Random.Range(0, 6);

        if ((Time.time > nextActionTime))
        {
            nextActionTime += period;

            random = Random.Range(0, 11);
        }

        if (random <= moveDiff)
        {
            umaar.transform.position = new Vector3(positions[randomPos].position.x, positions[randomPos].position.y, 0);

            random = 11;
        }
    }
}
