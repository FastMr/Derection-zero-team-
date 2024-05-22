using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hunger : MonoBehaviour
{
    public float maxHunger = 100;
    public float hungerDecreaseRate = 3; // Уменьшение голода каждую секунду
    public float hungerDamageRate = 2; // Урон каждую секунду

    private float hunger;
    public Text hungerText;

    private void Start()
    {
        hunger = maxHunger;
    }

    private void Update()
    {
        // Уменьшать голод со временем
        hunger -= hungerDecreaseRate * Time.deltaTime;

        // Обновить текст голода
        hungerText.text = hunger.ToString("F0");

        // Проверить, достиг ли голод нуля
        if (hunger <= 0)
        {
            // Наносить урон игроку каждую секунду
            GetComponent<PlayerHealth>().DealDamage(hungerDamageRate);
        }
    }

    public void Eat(float amount)
    {
        // Увеличить голод на определенное количество
        hunger = Mathf.Clamp(hunger + amount, 0, maxHunger);
    }
}