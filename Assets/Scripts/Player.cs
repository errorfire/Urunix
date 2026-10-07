using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public Vector2 vector2;
    public float speed;
    public float walkspeed;
    public float runspeed;
    public float jumpforce = 2;
    private void Update()
    {
        movement();
        jump();
    }
    private void movement()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {

            speed = runspeed;
        }
        else
        {
            speed = walkspeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigidbody2D.linearVelocity = new Vector2(-speed, rigidbody2D.linearVelocity.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigidbody2D.linearVelocity = new Vector2(+speed, rigidbody2D.linearVelocity.y);
        }
        if (rigidbody2D.linearVelocity.x > 0)

        {
            rigidbody2D.linearVelocity += new Vector2(-.5f, 0);
        }
        else if (rigidbody2D.linearVelocity.x < 0)

        {
            rigidbody2D.linearVelocity -= new Vector2(-.5f, 0);
        }
    }
    private void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.linearVelocity = Vector2.up * jumpforce;
        }
    }
}
