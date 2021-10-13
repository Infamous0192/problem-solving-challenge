using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Button _problem_1;
    [SerializeField] private Button _problem_2;
    [SerializeField] private Button _problem_3;
    [SerializeField] private Button _problem_4;
    [SerializeField] private Button _problem_5;
    [SerializeField] private Button _problem_6;
    [SerializeField] private Button _problem_7;
    [SerializeField] private Button _problem_8;
    [SerializeField] private Button _problem_9;
    [SerializeField] private Button _problem_10;

    void Start()
    {
        _problem_1.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(1);
        });
        _problem_2.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(2);
        });
        _problem_3.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(3);
        });
        _problem_4.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(4);
        });
        _problem_5.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(5);
        });
        _problem_6.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(6);
        });
        _problem_7.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(7);
        });
        _problem_8.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(8);
        });
        _problem_9.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(9);
        });
        _problem_10.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(0);
        });
    }
}
