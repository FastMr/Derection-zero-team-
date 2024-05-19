using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Auto : MonoBehaviour
{

    //KeyText.keys

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (KeyText.keys == 8)
            {
                SceneManager.LoadScene("Final");
            }
            else
            {
                return;
            }
        }
    }
}
