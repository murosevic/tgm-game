using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCamera : MonoBehaviour
{
    public Canvas bc;

    // Start is called before the first frame update
    void Start()
    {
        bc.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("CamArea"))
        {
            bc.enabled = true;
        }
    }
}
