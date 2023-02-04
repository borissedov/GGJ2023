using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForcePlayerMovement : MonoBehaviour
{
    [SerializeField] private bool grounded;
    [SerializeField] private float jumpPower;

    private Rigidbody2D body;

    [SerializeField] private float moveForce;         
    [SerializeField] private float maxSpeed;     
 
    private Vector2 v;
    
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
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
}
