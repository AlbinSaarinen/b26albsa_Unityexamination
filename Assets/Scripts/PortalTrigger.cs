using UnityEngine;

public class PortalTrigger : MonoBehaviour
{
    public GameObject victoryPanel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManager.instance.crystalsCollected >= GameManager.instance.totalCrystals)
            {
                // Stop the player's movement
                CustomizablePlatformerMovement movement =
                    other.GetComponent<CustomizablePlatformerMovement>();

                if (movement != null)
                {
                    movement.enabled = false;
                }

                // Stop any remaining momentum
                Rigidbody2D rb = other.GetComponent<Rigidbody2D>();

                if (rb != null)
                {
                    rb.linearVelocity = Vector2.zero;
                }

                // Show victory screen
                victoryPanel.SetActive(true);

                Debug.Log("YOU WIN!");
            }
            else
            {
                Debug.Log("You need more crystals!");
            }
        }
    }
}