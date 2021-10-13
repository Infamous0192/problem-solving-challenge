using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector2(Random.Range(.2f, .6f), Random.Range(.2f, .6f));
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("watawet");
        if (collision.gameObject.tag == "Player")
        {
            ScoreController.Instance.TakeScore();
            Destroy(gameObject);
        }
    }
}
