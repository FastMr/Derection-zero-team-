using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneScript : MonoBehaviour
{
    public Transform BulletPrefab;
    public Transform Point;
    public float TimeToSpawn = 1;

    private float _timeSpawn;
    private byte f = 0;

    void Start()
    {
        _timeSpawn = TimeToSpawn;
    }

    void Update()
    {
        if (TimeToSpawn <= 0 && f == 1)
        {
            Instantiate(BulletPrefab, Point.position, Point.rotation);
            TimeToSpawn = _timeSpawn;
            f = 0;
        }
        TimeToSpawn -= Time.deltaTime;
        
    }
    private void OnTriggerStay(Collider other)
    {  
        var zombie = other.GetComponent<Zombie>();
        if (zombie != null)
        {
            f = 1; 
        }
    }
}
