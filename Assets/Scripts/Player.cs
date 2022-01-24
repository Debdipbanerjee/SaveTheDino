using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private float input;

    public int health;

    Rigidbody2D rb;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (input != 0)
        {
            anim.SetBool("IsRunning", true);
        }
        else
        {
            anim.SetBool("IsRunning", false);
        }

        //change directions

        if (input < 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (input > 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }


    
    void FixedUpdate()
    {
        //check for keyboard input
        input = Input.GetAxisRaw("Horizontal");
        //print(input);

        //Moving the player
        rb.velocity = new Vector2(input * speed, rb.velocity.y);
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;

        //destroy player
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
