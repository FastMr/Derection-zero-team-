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
    // Start is called before the first frame update
    void Start()
    {
        GameObject go = GameObject.Find("Player");
        FireGun fireGun = go.GetComponent<FireGun>();
        bullet = fireGun.Bullet;
        ammo = fireGun.Ammo;

        ammoText.text = ammo.ToString();
        bulletText.text = bullet.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject go = GameObject.Find("Player");
            FireGun fireGun = go.GetComponent<FireGun>();
            ammo = fireGun.Ammo;
            bullet = fireGun.Bullet;

            ammoText.text = ammo.ToString();
            bulletText.text = bullet.ToString();
        }
        
    }
}
