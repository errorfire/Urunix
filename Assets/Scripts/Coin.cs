using UnityEngine;

public class Coin : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public int amount;
    public string CompareTag = "Player";
    private void Awake()
    {
        if (particleSystem != null) particleSystem.transform.SetParent(null);
    }
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
        if (particleSystem != null) particleSystem.Play();
        ItemManager.instance.AddCoins(amount);
    }
}
