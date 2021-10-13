using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box3 : MonoBehaviour
{
    void Start()
    {
        transform.localScale = new Vector2(Random.Range(.2f, .6f), Random.Range(.2f, .6f));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ScoreController.Instance.TakeScore();
            BoxSpawner.Instance.SpawnBox(3f);
            Destroy(gameObject);
        }
    }
}
