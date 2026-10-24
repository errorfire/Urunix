using UnityEngine;

public class Coin : MonoBehaviour
{
    public string CompareTag = "Player";
    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.transform.CompareTag(CompareTag)){ }
        Collect();
    }
    protected virtual void Collect()
    {
        Debug.Log("Moeda coletada");
        Destroy(gameObject);
        OnCollect();
    }
    protected virtual void OnCollect()
    {
        ItemManager.instance.AddCoins();
    }
}
