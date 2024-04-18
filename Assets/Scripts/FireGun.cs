using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour
{
    public Transform BulletPrefab;
    public Transform Point;

    public float Speed = 10;
    public float Spread = 10;

    private float MoveFixedUpdate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           Instantiate(BulletPrefab, Point.position, Point.rotation);
        }
        
    }
    
}
