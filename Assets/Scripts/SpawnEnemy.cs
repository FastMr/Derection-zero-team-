using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class SpawnEnemy : MonoBehaviour
{
    public Zombie EnemyPrefab;
    public float TimeToSpawn = 10;

    private float _timeSpawn;
    // Start is called before the first frame update
    void Start()
    {
        _timeSpawn = TimeToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeToSpawn <= 0)
        {
            Instantiate(EnemyPrefab, transform.position, transform.rotation);
            TimeToSpawn = _timeSpawn;
        }
        TimeToSpawn -= Time.deltaTime;
    }
}
