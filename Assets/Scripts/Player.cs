using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //check for keyboard input
        float input = Input.GetAxisRaw("Horizontal");
        print(input);

        //Moving the player
        rb.velocity = new Vector2(input * speed, rb.velocity.y);
    }
}
