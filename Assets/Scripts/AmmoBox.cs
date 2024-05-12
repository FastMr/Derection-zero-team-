using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    public int ammoAmount = 15; // Количество патронов, которое будет добавлено

    private void OnTriggerEnter(Collider collision)
    {
        // Проверить, является ли объект, который столкнулся с триггером, игроком
        if (collision.gameObject.tag == "Player")
        {
            // Получить компонент FireGun игрока
            FireGun fireGun = collision.gameObject.GetComponent<FireGun>();

            // Проверить, есть ли у игрока компонент AmmoPluseText
            if (fireGun != null)
            {
                // Увеличить значение AmmoPluse на количество патронов
                fireGun.Ammo += ammoAmount;
            }

            // Уничтожить ящик с патронами
            Destroy(gameObject);
        }
    }
}
