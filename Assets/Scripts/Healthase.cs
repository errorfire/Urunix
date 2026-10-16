using UnityEngine;

public class Healthase : MonoBehaviour
{
    public Animator animator;
    public float startlife = 3;
    private float currenthealth;

    private void Awake()
    {
        currenthealth = startlife;
    }
    public void Damage(int damage)
    {
        animator.SetTrigger("hurt");
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
