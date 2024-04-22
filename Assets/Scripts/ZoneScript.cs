using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        var Shot0 = gameObject.GetComponent<FireGun>();
        var zombie = other.GetComponent<Zombie>();
        if (zombie != null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //тут должен вызватся скрипт
            }
        }
    }
}
