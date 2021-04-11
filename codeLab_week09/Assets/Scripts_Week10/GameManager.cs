using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public List<TriviaQuestionObject> questionsPool;

    // three differetn UIs
    public GameObject gameUI;
    public GameObject questionUI;
    public GameObject gameOverUI;

    // every time player pressed the button, pass in a question
    public TriviaQuestionObject currentQuestion;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AssignQuestionsFromPoolToChart()
    {
        for(var i = 0; i< questionsPool.Count; i++)
        {
            switch(questionsPool[i].questionType)
            {
                case 'a':
                    
                    break;
                case 'b':
                    break;

            }
        }
    }

    public void AssignQuestionsFromColumeToSlot(char questionType, char pointsType)
    {
        switch (pointsType)
        {
            case '1':

                break;
        }
    }
    public void ShowQuestionUIHideGameUI()
    {
        gameUI.SetActive(false);
        questionUI.SetActive(true);

        QuestionManager.instance.questionText.text = currentQuestion.question;
        QuestionManager.instance.answer1Text.text = currentQuestion.answer1;
        QuestionManager.instance.answer2Text.text = currentQuestion.answer2;
        QuestionManager.instance.answer3Text.text = currentQuestion.answer3;
        QuestionManager.instance.answer4Text.text = currentQuestion.answer4;
    }
}
