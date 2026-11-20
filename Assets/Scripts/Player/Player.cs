using System;
using UnityEditor.Rendering.Universal.ShaderGUI;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("BaseValue")]
    public SOPlayer soPlayer;
    public Animator animator;
    public Rigidbody2D rigidbody2D;
    public Vector2 vector2;
    public float time;
    public float time2;
    public GameObject RunVFX;
    public GameObject JumpVFX;
    public AudioSource audioSource;
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
            RunVFX.SetActive(true);
            time = 1f;
        }
        else
        {
            soPlayer.speed = soPlayer.walkspeed;
            animator.speed = 1;
            time -= Time.deltaTime;

            if (time <= 0)
            {
                RunVFX.SetActive(false);
            }
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
            if (audioSource != null) audioSource.Play();
            rigidbody2D.linearVelocity = Vector2.up * soPlayer.jumpforce;
            JumpVFX.SetActive(true);
            time2 = 0.2f;
        }
        else if (time2 > 0)
        {
            time2 -= Time.deltaTime;
            if (time2 <= 0)
            {
                JumpVFX.SetActive(false);
            }
        }
    }
}
