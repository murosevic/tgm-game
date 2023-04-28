using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatronicMovement : MonoBehaviour
{
    public Transform[] positions = new Transform[6];

    public GameObject umaar;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(umaar, positions[0]);
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: Animatronic Movement
    }
}
