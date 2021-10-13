using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl2 : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    private Rigidbody2D rb2d;
    private float movementSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        rb2d.AddForce(new Vector2(5, 10));
    }

    void Update()
    {
        Vector2 pos = transform.position;
        Vector2 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        rb2d.velocity = new Vector2(movementSpeed * (mousePos.x - pos.x), movementSpeed * (mousePos.y - pos.y));
    }
}
