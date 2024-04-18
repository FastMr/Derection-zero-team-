using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSun : MonoBehaviour
{
    public float rotati;

    public Transform sun;

    void Start()
    {
        rotati = 0.003f;
    }

    // Update is called once per frame
    void Update()
    {
        sun.Rotate(rotati * new Vector3(0, 1, 0));
    }
}
