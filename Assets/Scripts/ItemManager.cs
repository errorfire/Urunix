using TMPro;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public TextMeshProUGUI TextCoins;
    public static ItemManager instance;
    public SOint coins;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }
    private void Start()
    {
        coins.Value = 0;
        Reset();
    }
    private void Reset()
    {
        coins.Value = 0;
    }

    public void AddCoins(int amount = 1)
    {
        coins.Value += amount;
    }
}
