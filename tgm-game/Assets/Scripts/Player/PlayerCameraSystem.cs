using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCameraSystem : MonoBehaviour
{
    public Canvas bc;
    public Canvas cc;

    // Start is called before the first frame update
    void Start()
    {
        bc.enabled = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("CamArea"))
        {
            bc.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("CamArea"))
        {
            bc.enabled = false;
            cc.enabled = false;
        }
    }
}