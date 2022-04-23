using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class QuestionsCreator : MonoBehaviour
{
    [SerializeField] private Text _questionText;
    [SerializeField] private Text _leftButtonText;
    [SerializeField] private Text _rightButtonText;
    
    [SerializeField] private Button _leftButton;
    [SerializeField] private Button _rightButton;
    [SerializeField] private Button _nextButton;

    private Color normalButtonColor = Color.white;

    private QuestionModelCreator _questionsCreator;

    private QuestionModel _currentQuestionModel;
    private int currentQuestionNumber = 0;

    private int count = 0;
    
    private GameObject prevQuestion;

    private void Awake()
    {
        _questionsCreator = new QuestionModelCreator();
        _nextButton.onClick.AddListener(OnClickNextButton);
        _leftButton.onClick.AddListener(OnClickLeftButton);
        _rightButton.onClick.AddListener(OnClickRightButton);
    }
    
    void Start()
    {
        createNewQuestion();
    }

    private void OnClickNextButton()
    {
        if (currentQuestionNumber < _questionsCreator.getQuestionCount())
        {
            createNewQuestion();
        }
    }

    private void createNewQuestion()
    {
        questionChanged();
        
        _currentQuestionModel = _questionsCreator.getQuestionModel(currentQuestionNumber++);
        _questionText.text = _currentQuestionModel.getQuestionText();
        _leftButtonText.text = _currentQuestionModel.getleftButtonText();
        _rightButtonText.text = _currentQuestionModel.getRightButtonText();
        _nextButton.enabled = false;
    }

    private void OnClickLeftButton()
    {
        if (_currentQuestionModel.getIsLeft())
        {
            count++;
        }
        AnswerIsChoose();
    }
    
    
    private void OnClickRightButton()
    {
        if (!_currentQuestionModel.getIsLeft())
        {
            count++;
        }
        AnswerIsChoose();
    }

    private void AnswerIsChoose()
    {
        _leftButton.GetComponent<Graphic>().color = _currentQuestionModel.getIsLeft() ? Color.green : Color.red;
        _rightButton.GetComponent<Graphic>().color = !_currentQuestionModel.getIsLeft() ? Color.green : Color.red;

        _leftButton.enabled = false;
        _rightButton.enabled = false;
        _nextButton.enabled = true;
    }

    private void questionChanged()
    {
        _leftButton.GetComponent<Graphic>().color = normalButtonColor;
        _rightButton.GetComponent<Graphic>().color = normalButtonColor;
        
        _leftButton.enabled = true;
        _rightButton.enabled = true;
    }
    
}
