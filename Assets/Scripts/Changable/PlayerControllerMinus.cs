using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerMinus : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = -moveInput.normalized * speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

    public void Off()
    {
        gameObject.GetComponent<PlayerControllerMinus>().enabled = false;
    }

    public void On()
    {
        gameObject.GetComponent<PlayerControllerMinus>().enabled = true;
    }
}
