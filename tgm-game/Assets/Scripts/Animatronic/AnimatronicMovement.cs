using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatronicMovement : MonoBehaviour
{
    public Transform[] positions = new Transform[4];

    public GameObject wehr;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(wehr, positions[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
