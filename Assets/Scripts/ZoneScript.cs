using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneScript : MonoBehaviour
{
    FireGun fireGun;

    void Start()
    {
        // Получение ссылки на скрипт
        fireGun = GetComponent<FireGun>();
    }

    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        
        var zombie = other.GetComponent<Zombie>();
        if (zombie != null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //тут должен вызватся скрипт
                //попробую :)

                // Вызов метода 
                fireGun.Shot();
            }
        }
    }
}
