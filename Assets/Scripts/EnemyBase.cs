using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var health = collision.gameObject.GetComponent<Healthase>();

        if (health != null)
        {
            health.Damage(1);
        }
    }
}
