using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float velocity = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        rb2d.AddForce(new Vector2(5, 10));
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb2d.velocity = new Vector2(0, velocity);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.velocity = new Vector2(velocity, 0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb2d.velocity = new Vector2(0, -velocity);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.velocity = new Vector2(-velocity, 0);
        }
    }
}
