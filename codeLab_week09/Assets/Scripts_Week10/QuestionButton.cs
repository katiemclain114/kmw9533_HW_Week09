using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionButton : MonoBehaviour
{
    public TriviaQuestionObject question;
    public SpriteRenderer pointValueSprite;

    private bool isQuestionAnswered = false;
    private SpriteRenderer sprite;
    

    private void OnMouseDown()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>();
        Debug.Log(question.question);
        if (!isQuestionAnswered)
        {
            sprite.color = Color.black;
            isQuestionAnswered = true;
            GameManager.instance.currentQuestion = question;
            GameManager.instance.ShowQuestionUIHideGameUI();
            GameManager.instance.currentPointsLevel = question.pointLevel;
            GameManager.instance.questionsLeftToBeAnswered -= 1;
        }
    }
}
