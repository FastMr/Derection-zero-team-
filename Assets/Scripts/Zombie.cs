using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    NavMeshAgent Agent;
    private PlayerHealth _playerHealth;
    PlayerController player;
    public float damage = 30;
    public float value = 100;

    private float stopedD;

    // Start is called before the first frame update
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        player = FindObjectOfType<PlayerController>();
        _playerHealth = player.GetComponent<PlayerHealth>();
        stopedD = Agent.stoppingDistance;
    }

    public void DealDamage(float damage)
    {

        value -= damage;
        if (value <= 0)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Agent.SetDestination(player.transform.position);
        AttackUpdate();
    }
    private void AttackUpdate()
    {
         if (Agent.remainingDistance <= stopedD)
         {
             _playerHealth.DealDamage(damage * Time.deltaTime);
         }
    }
}