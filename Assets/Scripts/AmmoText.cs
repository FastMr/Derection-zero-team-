using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmmoText : MonoBehaviour
{
    public TextMeshProUGUI ammoText;
    public TextMeshProUGUI bulletText;

    private float ammo;
    private float bullet;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0.05)
        {
            GameObject go = GameObject.Find("Player");
            FireGun fireGun = go.GetComponent<FireGun>();
            ammo = fireGun.Ammo;
            bullet = fireGun.Bullet;

            ammoText.text = ammo.ToString();
            bulletText.text = bullet.ToString();
            timer = 0.05f;
        }
    }
}
