using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NadrochkaPlayerMovement : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    //public Sprite[] sprites;
    //public Sprite damaged;
    //public AudioSource sound;

    //private int spriteIndex;

    private Vector3 direction;

    public float Gravity = -9.81f;
    public float Strength = 5f;
    public float FallStrength = 5f;
    public float tilt = 0.5f;

    

    
    //private void Awake()
    //{
    //    spriteRenderer = GetComponent<SpriteRenderer>();
    //}

    //private void Start()
    //{
    //    InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
    //}

    //private void OnEnable()
    //{
    //    Vector3 position = transform.position;
    //    position.y = 0f;
    //    position.x = -5f;
    //    transform.position = position;
    //    direction = Vector3.zero;
    //}


    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            Move(Vector3.up * Strength);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            Move(Vector3.right * Strength);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            Move(Vector3.left * Strength);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            Move(Vector3.down * FallStrength);
        }

        direction.y += Gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;

        Vector3 rotation = transform.eulerAngles;
        //rotation.z = direction.y * tilt;
        //transform.eulerAngles = rotation;
    }

    //private void AnimateSprite()
    //{
    //    spriteIndex++;

    //    if (spriteIndex >= sprites.Length)
    //    {
    //        spriteIndex = 0;
    //    }

    //    spriteRenderer.sprite = sprites[spriteIndex];
    //}

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "Crash")
    //    {
    //        FindObjectOfType<GameManager>().GameOver();
    //        spriteRenderer.sprite = damaged;
    //        sound.Play();
    //    }
    //}

    private void Move(Vector3 dimention)
    {
        direction = dimention;
    }
}
