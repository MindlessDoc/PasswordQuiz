using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButtonController : MonoBehaviour
{
    [SerializeField] private Button _startButton;
    private const int QUIZ_NUMBER = 1;

    private void Awake()
    {
        _startButton.onClick.AddListener(onClick);
    }
    
    public void onClick()
    {
        SceneManager.LoadScene(QUIZ_NUMBER);
    }
}
