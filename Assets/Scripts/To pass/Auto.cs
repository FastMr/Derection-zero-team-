using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Auto : MonoBehaviour
{
    public GameObject Eshka;
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
                Eshka.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {
                    SceneManager.LoadScene("ZastavkaFinala");
                    Eshka.SetActive(false);
                }
            }
            else
            {
                return;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the object that exited the trigger is the player
        if (other.gameObject.CompareTag("Player"))
        {
            // Deactivate the Eshka object
            Eshka.SetActive(false);
        }
    }
}
