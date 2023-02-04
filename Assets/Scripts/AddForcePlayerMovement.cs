using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForcePlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private bool grounded;
    [SerializeField] private float jumpPower;

    private Rigidbody2D body;

    public const string Right = "right";
    public const string Left = "left";

    string BP;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            BP = Right;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            BP = Left;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
            Jump();
    }
    private void FixedUpdate()
    {
        if (BP == Right)
        {
            body.AddForce(new Vector2(speed, 0));
        }
        else if (BP == Left)
        {
            body.AddForce(new Vector2(-speed, 0));
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
}
