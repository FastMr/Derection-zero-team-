using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifetime = 10;
    public float damage = 20;

    private float speed;
    private float spread;
    private Zombie zombie;

    // Start is called before the first frame update
    void Start()
    {
        // Найти объект по имени
        GameObject go = GameObject.Find("Player");
        // Взять его компонент, где лежит скорость
        FireGun fireGun = go.GetComponent<FireGun>();
        // Взять переменную скорости
        speed = fireGun.Speed;
        spread = fireGun.Spread;

        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + Random.Range(-spread, spread), 0);
        Invoke("DestroyBullet", lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void DestroyBullet()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Проверить, является ли объект, с которым произошло столкновение, зомби
        if (collision.gameObject.tag == "Zombie")
        {
            // Получить компонент EnemyHealth зомби
            Zombie zombie = collision.gameObject.GetComponent<Zombie>();

            // Проверить, есть ли у зомби компонент EnemyHealth
            if (zombie != null)
            {
                // Нанести урон зомби
                zombie.DealDamage(damage);
            }
        }
        // Уничтожить пулю
        Destroy(gameObject);
    }
}

