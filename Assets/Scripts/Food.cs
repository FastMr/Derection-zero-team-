using UnityEngine;
using UnityEngine.UI;

public class Food : MonoBehaviour
{
    public GameObject eshka;

    private void OnTriggerStay(Collider other)
    {
        // Check if the object that collided with the food is the player
        if (other.gameObject.CompareTag("Player"))
        {
            // Activate the Eshka object
            eshka.SetActive(true);

            // Check if the player is holding down the "E" key
            if (Input.GetKey(KeyCode.E))
            {
                // Get the Hunger script from the player
                Hunger hunger = other.gameObject.GetComponent<Hunger>();

                // If the player has a Hunger script, add 50 units of hunger
                if (hunger != null)
                {
                    hunger.Eat(50);
                    Destroy(gameObject);
                    eshka.SetActive(false);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the object that exited the trigger is the player
        if (other.gameObject.CompareTag("Player"))
        {
            // Deactivate the Eshka object
            eshka.SetActive(false);
        }
    }
}