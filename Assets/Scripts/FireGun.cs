﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour
{
    public float BulletMax = 15;
    public float Bullet = 0;
    public float Ammo = 30;
    public float ReloadTime = 2;

    private float BulletFull;
    private bool Reloading = false;

    public Transform BulletPrefab;
    public Transform Point;
    public float RateOfFire = 0.3f;

    private float _timeSpawn;

    public float Speed = 10;
    public float Spread = 10;

    public AudioSource shot;
    public AudioSource shot2;
    public AudioSource moveSound2;


    // Start is called before the first frame update
    void Start()
    {
        _timeSpawn = RateOfFire;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false; 
    }

    // Update is called once per frame
    void Update()
    {
        //стрельба 
        if (RateOfFire <= 0 && Bullet > 0 && Input.GetMouseButton(0) && Reloading == false)
        {
            Instantiate(BulletPrefab, Point.position, Point.rotation);
            Bullet -= 1;
            RateOfFire = _timeSpawn;
            
            if (Random.Range(1, 3) == 1)
            {
                if (shot.isPlaying) return;
                shot.Play();
            }
            else
            {
                if (shot2.isPlaying) return;
                shot2.Play();
            }
        }
        RateOfFire -= Time.deltaTime;

        //авто перезарядка
        if (Bullet <= 0)
        {
            if (Reloading == false)
            {
               Reload();
            }
        }

        if (Ammo == 0)
        {
            Reloading = false;
        }

        //перезарядка по кнопке
        if (Input.GetKeyDown(KeyCode.R) && Reloading != true && Bullet != BulletMax)
        {
            Reload();
        }
    }
    private void Reload()
    {
        Reloading = true;
        //то сколько нужно зарядить
        BulletFull = BulletMax - Bullet;
        if (0 < Ammo)
        {
            Invoke("Reloaded", ReloadTime);
            if (moveSound2.isPlaying) return;           
               moveSound2.Play();           
        }
    }
    private void Reloaded()
    {
        Bullet = BulletMax;
        Ammo -= BulletFull;
        Reloading = false;
        if (Ammo < 0)
        {
            Bullet += Ammo;
            Ammo = 0;
        }
    }
}
