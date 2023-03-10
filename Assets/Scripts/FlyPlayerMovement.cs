using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private Animator anim;
    [SerializeField] private bool grounded;

    private void Awake()
    {
        //Grabs references for rigidbody and animator from game object.
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        //Flip player when facing left/right.
        if (horizontalInput > 0.01f)
            transform.localScale = new Vector3(-1, 1, 1);
        else if (horizontalInput < -0.01f)
            transform.localScale = Vector3.one;

        if (Input.GetKeyDown(KeyCode.UpArrow))
            Jump();

        //sets animation parameters
        anim.SetBool("run", horizontalInput != 0);
        anim.SetBool("grounded", grounded);
    }

    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, speed);
        //anim.SetTrigger("jump");
        grounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = true;
    }



    //[SerializeField] private float speed;
    //[SerializeField] private float jumpPower;
    //private Rigidbody2D body;

    ////private Animator anim;

    //[SerializeField] private bool grounded;

    //private void Awake()
    //{
    //    body = GetComponent<Rigidbody2D>();

    //    //anim = GetComponent<Animator>();
    //}

    //private void Update()
    //{
    //    body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

    //    if (Input.GetKeyDown(KeyCode.UpArrow))
    //        body.velocity = new Vector2(body.velocity.x, jumpPower);

    //    //Flip player when facing left / right.
    //    if (horizontalInput > 0.01f)
    //        transform.localScale = Vector3.one;
    //    else if (horizontalInput < -0.01f)
    //        transform.localScale = new Vector3(-1, 1, 1);

    //    //sets animation parameters
    //    //anim.SetBool("run", horizontalInput != 0);
    //    //anim.SetBool("grounded", grounded);
    //}

    //private void Jump()
    //{
    //    body.velocity = new Vector2(body.velocity.x, speed);
    //    //anim.SetTrigger("jump");
    //    grounded = false;
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Down")
        {
            Application.LoadLevel("GameOverScreen");
        }

        if (collision.gameObject.tag == "Finish")
        {
            Application.LoadLevel("NextLevelLoadinScreen");
        }
    }
}
