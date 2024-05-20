using UnityEngine;

public class Food : MonoBehaviour
{
    public GameObject Eshka;
    private void OnTriggerStay(Collider other)
    {
        // Check if the object that collided with the food is the player
        if (other.gameObject.CompareTag("Player"))
        {
            Eshka.SetActive(true);
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
                    Eshka.SetActive(false);
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
            Eshka.SetActive(false);
        }
    }
}
