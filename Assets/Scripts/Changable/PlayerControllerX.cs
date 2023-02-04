using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;
    private Vector2 moveVelocityX;
    private Vector2 moveVelocityY;

    private Vector2 moveVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 moveInputX = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        moveVelocityX = moveInputX.normalized;

        Vector2 moveInputY = new Vector2(0, Input.GetAxisRaw("Vertical"));
        moveVelocityY = -moveInputY.normalized;

        moveVelocity = (moveVelocityX + moveVelocityY) * speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}
