using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FireGun : MonoBehaviour
{
    public Transform BulletPrefab;
    public Transform Point;
    public Transform Zone;
    public float fire;

    public float Speed = 10;
    public float Spread = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shot();
        if (Input.GetMouseButtonDown(0))
        {
            
        }
        
    }
    public void Shot()
    {
        //этот скрипт должен вызватся
        //ок попробую
        Instantiate(BulletPrefab, Point.position, Point.rotation);
    }
}
