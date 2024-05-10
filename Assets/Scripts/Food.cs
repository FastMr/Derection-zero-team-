using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Проверить, нажата ли клавиша E
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Получить компонент Hunger игрока
            Hunger hunger = GetComponent<Hunger>();

            // Проверить, есть ли у игрока компонент Hunger
            if (hunger != null)
            {
                // Увеличить голод игрока на 50
                hunger.Eat(50);
            }
        }
    }
}
