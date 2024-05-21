using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSun : MonoBehaviour
{
    public float rotati = 0.02f;
    public float startRotati;

    public Transform sun;

    void Start()
    {
        sun.Rotate(new Vector3(0, startRotati, 0));
    }

    // Update is called once per frame
    void Update()
    {
        sun.Rotate(rotati * new Vector3(0, 1, 0));
    }
}
