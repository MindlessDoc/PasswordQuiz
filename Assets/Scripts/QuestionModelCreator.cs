using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Assets.Scripts;
using UnityEngine;

public class QuestionModelCreator
{
    private List<QuestionModel> _questions = new List<QuestionModel>();

    public QuestionModelCreator()
    {
        string textAsset = Resources.Load("questionsFile").ToString();
        StringReader reader = new StringReader(textAsset);
        while (true)
        {
            string additionalLine = reader.ReadLine();
            if (additionalLine == null)
            {
                break;
            }
            else
            {
                QuestionModel model = new QuestionModel();
                model.setQuestionText(additionalLine);
                model.setleftButtonText(reader.ReadLine());
                model.setRightButtonText(reader.ReadLine());
                model.setIsLeft(Convert.ToBoolean(reader.ReadLine()));
                _questions.Add(model);
                reader.ReadLine();
            }
        }
    }

    public QuestionModel getQuestionModel(int index)
    {
        return _questions[index];
    }

    public int getQuestionCount()
    {
        return _questions.Count;
    }
}
