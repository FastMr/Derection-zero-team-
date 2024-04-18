using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    [SerializeField] Light flashlight;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            flashlight.enabled = !flashlight.enabled;
        }
    }
}
