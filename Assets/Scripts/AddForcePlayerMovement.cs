using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForcePlayerMovement : MonoBehaviour
{
    [SerializeField] private bool grounded;
    [SerializeField] private float jumpPower;

    private Rigidbody2D body;
    private Animator anim;

    [SerializeField] private float moveForce;
    [SerializeField] private float maxSpeed;

    private Vector2 v;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        //Flip player when facing left/right.
        if (horizontalInput > 0.01f)
            transform.localScale = new Vector3(-1, 1, 1);
        else if (horizontalInput < -0.01f)
            transform.localScale = Vector3.one;

        // if (Input.GetKey(KeyCode.RightArrow))
        // {
        //     BP = Right;
        // }
        // else if (Input.GetKey(KeyCode.LeftArrow))
        // {
        //     BP = Left;
        // }
        // else if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
        //     Jump();
        // Debug.Log($"{Input.GetAxis("Horizontal")} - {Input.GetAxis("Vertical")}");
        v = new Vector2(Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"));

        //sets animation parameters
        anim.SetBool("run", horizontalInput != 0);
        anim.SetBool("grounded", grounded);
    }

    private void FixedUpdate()
    {
        // if (BP == Right)
        // {
        //     body.AddForce(new Vector2(speed, 0));
        // }
        // else if (BP == Left)
        // {
        //     body.AddForce(new Vector2(-speed, 0));
        // }

        if (grounded && v.y != 0)
        {
            body.velocity = new Vector2(body.velocity.x, jumpPower);
            grounded = false;
        }
        else
        {
            body.velocity = Vector2.ClampMagnitude(body.velocity, maxSpeed);
            body.AddForce(v.normalized * moveForce);
        }
    }

    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, jumpPower);
        grounded = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Down")
        {
            Application.LoadLevel("GameOverScreen");
        }

        if (collision.gameObject.tag == "Finish")
        {
            Application.LoadLevel("NextLevelLoadinScreen1");
        }
    }
}