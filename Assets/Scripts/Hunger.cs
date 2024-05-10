using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hunger : MonoBehaviour
{
    public float maxHunger = 100;
    public float hungerDecreaseRate = 1; // Уменьшение голода каждую секунду
    public float hungerDamageRate = 1; // Урон каждую секунду

    private float hunger;
    public TextMeshProUGUI hungerText;



    private void Start()
    {
        hunger = maxHunger;
    }

    private void Update()
    {
        // Уменьшать голод со временем
        hunger -= hungerDecreaseRate * Time.deltaTime;

        // Обновить текст голода
        hungerText.text = "Голод: " + hunger.ToString("F0");

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