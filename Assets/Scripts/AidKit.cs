using UnityEngine;

public class AidKit : MonoBehaviour
{
    public GameObject eshka;

    private void OnTriggerStay(Collider other)
    {
        // Check if the object that collided with the food is the player
        if (other.gameObject.CompareTag("Player"))
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

    private void OnTriggerExit(Collider other)
    {
        // Check if the object that exited the trigger is the player
        if (other.gameObject.CompareTag("Player"))
        {
            // Deactivate the Eshka object
           
        }
    }
}
