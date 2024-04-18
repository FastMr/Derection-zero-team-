using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ak : MonoBehaviour {

    public GameObject Gun;
    public Transform Bullet;

    public int Speed;
    public int ammo = 45;
    public int magazine = 450;

    public Text Text_Ak;

    public AudioClip NullAmmo;

    private float Time_Reload;

    void Start()
    {

    }

    void Update()
    {

        Text_Ak.text = "Патроны : " + ammo + " / " + magazine;


        if(Time_Reload > 0)
        {
            Time_Reload -= Time.deltaTime;
        }


        if (Input.GetMouseButton(0) & ammo > 0 & Time_Reload <= 0)
        {
            ammo -= 1;
            Gun.GetComponent<Animator>().SetBool("Fire", true);
            Transform BulInst = (Transform)Instantiate(Bullet, GameObject.Find("BulletS").transform.position, Quaternion.identity);
            BulInst.GetComponent<Rigidbody>().AddForce(-transform.forward * Speed);
        }
        if (Input.GetMouseButtonUp(0))
        {
            Gun.GetComponent<Animator>().SetBool("Fire", false);
        }
        if(ammo == 0)
        {
            Gun.GetComponent<Animator>().SetBool("Fire", false);
        }

        if (Input.GetKeyDown(KeyCode.R) & ammo == 0 & magazine > 0)
        {
            Time_Reload += 1.5f;
            magazine -= 45;
            ammo += 45;
            Gun.GetComponent<Animator>().SetTrigger("Reload");
        }
        }
    }
