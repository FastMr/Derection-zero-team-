﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float value = 100;
    public RectTransform valueRectTransform;
    public GameObject gamplayUI;
    public GameObject gameOverScreen;

    private float _maxValue;

    // Start is called before the first frame update
    private void Start()
    {
        _maxValue = value;
        value = Mathf.Clamp(value, 0, _maxValue);
        DrawHealthBar();
    }

    public void AddHealth(float amount)
    {
        value += amount;
        DrawHealthBar();
    }

    public void DealDamage(float damage)
    {
        value -= damage;
        if (value <= 0)
        {
            gamplayUI.SetActive(false);
            gameOverScreen.SetActive(true);
            GetComponent<PlayerController>().enabled = false;
        }

        DrawHealthBar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DrawHealthBar()
    {
        valueRectTransform.anchorMax = new Vector2(value / _maxValue, 1);
    }
}
