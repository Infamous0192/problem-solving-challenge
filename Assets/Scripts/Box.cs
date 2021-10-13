using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector2(Random.Range(.2f, .6f), Random.Range(.2f, .6f));
        transform.position = Random.insideUnitSphere * 4.5f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if (collision.gameObject.tag == "Ball")
    //     {
    //         Destroy(gameObject);
    //     }
    // }
}
