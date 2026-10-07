using UnityEngine;

public class Healthase : MonoBehaviour
{
    public float startlife = 3;
    private float currenthealth;

    private void Awake()
    {
        currenthealth = startlife;
    }
    public void Damage(int damage)
    {
        Debug.Log("Damage");

        currenthealth -= damage;
        if (currenthealth <= 0)
        {
            Kill();
        }
    }
    private void Kill()
    {
        Debug.Log("Dead");
        Destroy(gameObject);
        currenthealth = startlife;

    }
}
