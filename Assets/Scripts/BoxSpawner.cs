using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject box;
    public int maxBox = 7;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < maxBox; i++)
        {
            Instantiate(box);
        }
        // InvokeRepeating("SpawnBox", 0, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // void SpawnBox()
    // {
    //     int boxCount = GameObject.FindGameObjectsWithTag("Box").Length;
    //     if (boxCount <= maxBox) Instantiate(box);
    // }
}
