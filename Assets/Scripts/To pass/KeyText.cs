using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class KeyText : MonoBehaviour
{
    public static int keys;
    public TextMeshProUGUI keyText;
    public GameObject Eshka;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateKeyText();
    }

    private void OnTriggerStay(Collider other)
    {
        // Check if the object that collided with the food is the player
        if (other.gameObject.CompareTag("Key"))
        {
            Eshka.SetActive(true);

            // Check if the player is holding down the "E" key
            if (Input.GetKey(KeyCode.E))
            {
                AddKey();
                Destroy(other.gameObject);
                Eshka.SetActive(false);
            }
        }
    }

    void AddKey()
    {
        keys++;
        UpdateKeyText();
    }

    void UpdateKeyText()
    {
        keyText.text = "Детали Авто:" + keys;
    }
    
    private void OnTriggerExit(Collider other)
    {
        // Check if the object that exited the trigger is the player
        if (other.gameObject.CompareTag("Key"))
        {
            // Deactivate the Eshka object
            Eshka.SetActive(false);
        }
    }

}
