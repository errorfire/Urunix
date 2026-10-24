using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;
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
            animator.speed = 2;
        }
        else
        {
            speed = walkspeed;
            animator.speed = 1;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigidbody2D.transform.localScale = new Vector3(-1, 1, 1);
            rigidbody2D.linearVelocity = new Vector2(-speed, rigidbody2D.linearVelocity.y);
            animator.SetBool("isRun", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigidbody2D.transform.localScale = new Vector3(1, 1, 1);
            rigidbody2D.linearVelocity = new Vector2(+speed, rigidbody2D.linearVelocity.y);
            animator.SetBool("isRun", true);
        }
        else
        {

            animator.SetBool("isRun", false);
        }
        if (rigidbody2D.linearVelocity.x > 0)

        {
            rigidbody2D.linearVelocity += new Vector2(-.5f, 0);
        }
        else if (rigidbody2D.linearVelocity.x < 0)

        {
            rigidbody2D.linearVelocity -= new Vector2(-.5f, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            animator.SetTrigger("attack");
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
