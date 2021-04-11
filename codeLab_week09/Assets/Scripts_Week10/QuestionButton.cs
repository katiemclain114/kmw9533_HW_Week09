using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionButton : MonoBehaviour
{
    public TriviaQuestionObject question;
    public SpriteRenderer pointValueSprite;

    private bool isQuestionAnswered = false;
    
    

    private void OnMouseDown()
    {
        Debug.Log(question.question);
        if (!isQuestionAnswered)
        {
            isQuestionAnswered = true;
            GameManager.instance.currentQuestion = question;
            GameManager.instance.ShowQuestionUIHideGameUI();
        }
    }
}
