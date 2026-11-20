using UnityEngine;

public class CrystalCollect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.CollectCrystal();

            Destroy(gameObject);
        }
    }
}