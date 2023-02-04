using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;
    private Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        if (Input.GetKeyDown(KeyCode.UpArrow))
            body.velocity = new Vector2(body.velocity.x, jumpPower);
    }
}