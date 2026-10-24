using TMPro;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public TextMeshProUGUI TextCoins;
    public static ItemManager instance;
    public int coins;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }
    private void Start()
    {
        Reset();
    }
    private void Reset()
    {
        coins = 0;
    }

    public void AddCoins()
    {
        coins++;
        TextCoins.text = coins.ToString();
    }
}
