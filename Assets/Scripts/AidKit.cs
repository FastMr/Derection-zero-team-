using UnityEngine;

public class AidKit : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        // Check if the object that collided with the food is the player
        if (other.gameObject.CompareTag("Player"))
        {
            // Check if the player is holding down the "E" key
            if (Input.GetKey(KeyCode.E))
            {
                // Get the PlayerHealth script from the player
                PlayerHealth health = other.gameObject.GetComponent<PlayerHealth>();

                // If the player has a PlayerHealth script, add 50 health
                if (health != null)
                {
                    health.AddHealth(50);
                    Destroy(gameObject);
                }
            }
        }
    }
}