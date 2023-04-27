using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;

public class CameraOnOff : MonoBehaviour
{
    public Canvas cc;

    private void Start()
    {
        cc.enabled = false;
    }

    public void OpenCloseCamera()
    {
        if (cc.enabled) cc.enabled = false;
        else cc.enabled = true;
    }
}
