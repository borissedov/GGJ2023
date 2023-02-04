using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InertiaPlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    Vector2 move;
    Rigidbody2D body;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        //body.AddForce(move * speed * Time.deltaTime);
        //body.velocity = new Vector2(move.x * speed * Time.deltaTime, body.velocity.y);
        body.velocity = move * speed * Time.deltaTime;
    }
}
