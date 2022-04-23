using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class InitQuestion : MonoBehaviour
{
    [SerializeField] private Text _questionText;
    [SerializeField] private Text _leftButtonText;
    [SerializeField] private Text _rightButtonText;

    public void setQuestionText(string questionText)
    {
        _questionText.text = questionText;
    }

    public void setleftButtonText(string leftButtonText)
    {
        _leftButtonText.text = leftButtonText;
    }

    public void setRightButtonText(string rightButtonText)
    {
        _rightButtonText.text = rightButtonText;
    }
}