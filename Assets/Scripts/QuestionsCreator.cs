using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class QuestionsCreator : MonoBehaviour
{
    [SerializeField] private GameObject _questionPrefab;

    private QuestionModelCreator _questionsCreator;

    private int currentQuestionNumber = 0;

    private void Awake()
    {
        _questionsCreator = new QuestionModelCreator();
    }
    
    void Start()
    {
        QuestionModel questionModel = _questionsCreator.getQuestionModel(currentQuestionNumber++);
        InitQuestion initQuestion = _questionPrefab.GetComponent<InitQuestion>();
        initQuestion.setQuestionText(questionModel.getQuestionText());
        initQuestion.setleftButtonText(questionModel.getleftButtonText());
        initQuestion.setRightButtonText(questionModel.getRightButtonText());
        Instantiate(_questionPrefab, transform);
    }
    
    
}
