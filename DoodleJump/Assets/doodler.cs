using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doodler : MonoBehaviour
{
    public float movementSpeed = 10f;
    public Rigidbody2D doodlerRb;
    public SpriteRenderer doodlerSprit;
    public float movement = 0f;
    public float jumpAmount = 0.5f;
    public platformGenerator platformGenerator;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        if (movement > 0)
        {
            doodlerSprit.flipX = false;
        }
        if (movement < 0)
        {
            doodlerSprit.flipX = true;
        }
        Vector2 velocity = doodlerRb.velocity;
        //Debug.Log(velocity);
        velocity.x = movement;
        doodlerRb.velocity = velocity;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("platform"))
        {
            
            if (collision.relativeVelocity.y >= 0f)
            {
                doodlerRb.AddForce(transform.up * jumpAmount, ForceMode2D.Impulse);
                Debug.Log(transform.up);
            }

        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("platform"))
        {
            //doodlerRb.AddForce(transform.up * jumpAmount, ForceMode2D.Impulse);
            Debug.Log("not doodool");

        }
    }

    
}
