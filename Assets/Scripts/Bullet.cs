using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{ 
    public float lifetime = 10;

    private float speed;
    private float spread;

    // Start is called before the first frame update
    void Start()
    {
        // Найти объект по имени
        GameObject go = GameObject.Find("Player");
        // взять его компонент где лежит скорость
        FireGun fireGun = go.GetComponent<FireGun>();
        // взять переменную скорости
        speed = fireGun.Speed;
        spread = fireGun.Spread;

        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + Random.Range(-spread, spread), 0);
        Invoke("DestroyBullet", lifetime);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.fixedDeltaTime;
    }

    private void DestroyBullet()
    {
        Destroy(gameObject);
    }
    
}

