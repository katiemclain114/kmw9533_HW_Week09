using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{

    public TriviaQuestionObject m_question;

    // calls every time player click it
    public void PassQuestionToGameManager()
    {
        // pass m_question to gameManager
        GameManager.instance.currentQuestion = m_question;
        GameManager.instance.ShowQuestionUIHideGameUI();
    }

}
