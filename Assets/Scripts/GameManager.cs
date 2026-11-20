using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int crystalsCollected = 0;
    public int totalCrystals = 25;

    public TMP_Text crystalText;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateUI();
    }

    public void CollectCrystal()
    {
        crystalsCollected++;

        UpdateUI();

        Debug.Log("Crystals collected: " + crystalsCollected);
    }

    void UpdateUI()
    {
        crystalText.text = "Crystals: " +
                           crystalsCollected + " / " + totalCrystals;
    }
}