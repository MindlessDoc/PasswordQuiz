using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class QuestionsCreator : MonoBehaviour
{
    [SerializeField] private GameObject _questionPrefab;
    [SerializeField] private Button _nextButton;

    private QuestionModelCreator _questionsCreator;

    private int currentQuestionNumber = 0;
    private GameObject prevQuestion;

    private void Awake()
    {
        _questionsCreator = new QuestionModelCreator();
        _nextButton.onClick.AddListener(OnClickNextButton);
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
        Destroy(prevQuestion);
        QuestionModel questionModel = _questionsCreator.getQuestionModel(currentQuestionNumber++);
        InitQuestion initQuestion = _questionPrefab.GetComponent<InitQuestion>();
        initQuestion.setQuestionText(questionModel.getQuestionText());
        initQuestion.setleftButtonText(questionModel.getleftButtonText());
        initQuestion.setRightButtonText(questionModel.getRightButtonText());
        prevQuestion = Instantiate(_questionPrefab, transform);
    }
}
