using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    private static ScoreController _instance = null;
    public static ScoreController Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<ScoreController>();
            }

            return _instance;
        }
    }
    private int _score = 0;
    public int Score => _score;

    private Text scoreTxt;
    // Start is called before the first frame update
    void Start()
    {
        scoreTxt = GameObject.Find("Score").GetComponent<Text>();
    }

    public void TakeScore()
    {
        scoreTxt.text = string.Format("Score {0}", ++_score);
    }
}
