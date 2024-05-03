using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    private PlayerHealth _playerHealth;
    PlayerController player;
    public float damage = 30;
    public float value = 100;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        player = FindObjectOfType<PlayerController>();
        _playerHealth = player.GetComponent<PlayerHealth>();
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
        navMeshAgent.SetDestination(player.transform.position);
        AttackUpdate();
    }

    private void AttackUpdate()
    {
            if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
            {
                _playerHealth.DealDamage(damage * Time.deltaTime);
            }
    }
}