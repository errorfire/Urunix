using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("BaseValue")]
    public SOPlayer soPlayer;
    public Animator animator;
    public Rigidbody2D rigidbody2D;
    public Vector2 vector2;
    private void Update()
    {
        movement();
        jump();
    }
    private void movement()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {

            soPlayer.speed = soPlayer.runspeed;
            animator.speed = 2;
        }
        else
        {
            soPlayer.speed = soPlayer.walkspeed;
            animator.speed = 1;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigidbody2D.transform.localScale = new Vector3(-1, 1, 1);
            rigidbody2D.linearVelocity = new Vector2(-soPlayer.speed, rigidbody2D.linearVelocity.y);
            animator.SetBool("isRun", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigidbody2D.transform.localScale = new Vector3(1, 1, 1);
            rigidbody2D.linearVelocity = new Vector2(+soPlayer.speed, rigidbody2D.linearVelocity.y);
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
            rigidbody2D.linearVelocity = Vector2.up * soPlayer.jumpforce;
        }
    }

}
