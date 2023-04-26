using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOnOff : MonoBehaviour
{
    public Canvas cc;

    // Start is called before the first frame update
    void Start()
    {
        cc.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if (!cc.enabled) cc.enabled = true;
        else cc.enabled = false;
    }
}
