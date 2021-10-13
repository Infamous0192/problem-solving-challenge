using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    private static BoxSpawner _instance = null;
    public static BoxSpawner Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<BoxSpawner>();
            }

            return _instance;
        }
    }
    public GameObject box;
    public int maxBox = 7;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < maxBox; i++)
        {
            Instantiate(box, Random.insideUnitSphere * 4.5f, Quaternion.identity);
        }
    }
    
    // Spawn Box dalam detik
    public void SpawnBox(float sec)
    {
        Invoke("SpawnABox", sec);
    }

    void SpawnABox() {
        int boxCount = GameObject.FindGameObjectsWithTag("Box").Length;
        // Spawn box jika box kurang dari maksimal
        if (boxCount <= maxBox) Instantiate(box, Random.insideUnitSphere * 4.5f, Quaternion.identity);
    }   
}
