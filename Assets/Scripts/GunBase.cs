using UnityEngine;

public class GunBase : MonoBehaviour
{
    public ProjectileBase prefabProjectile;
    public Transform positionToShoot;
    public Transform PlayerSide;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            shoot();
        }
    }
    public void shoot()
    {
        var projectile = Instantiate(prefabProjectile);
        projectile.transform.position = positionToShoot.position;
        projectile.side = PlayerSide.transform.localScale.x;
    }
}
