using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FireGun : MonoBehaviour
{
    public float Bullet = 15;
    public float Ammo = 30;

    public Transform BulletPrefab;
    public Transform Point;
    public float TimeToSpawn = 0.1f;


    private float _timeSpawn;

    public float Speed = 10;
    public float Spread = 10;

    // Start is called before the first frame update
    void Start()
    {
        _timeSpawn = TimeToSpawn;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeToSpawn <= 0 && Bullet >= 0 && Input.GetMouseButton(0))
        {
            Instantiate(BulletPrefab, Point.position, Point.rotation);
            Bullet -= 1;
            TimeToSpawn = _timeSpawn;
            
        }
        TimeToSpawn -= Time.deltaTime;
    }
}
