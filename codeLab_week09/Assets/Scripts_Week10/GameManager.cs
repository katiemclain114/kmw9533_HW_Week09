using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public List<TriviaQuestionObject> questionsPool;
    public GameObject[,] questionGrid;
    public int width=3;
    public int height=4;
    public int xStart;
    public int yStart;

    // three differetn UIs
    public GameObject gameUI;
    public GameObject questionUI;
    public GameObject gameOverUI;

    public GameObject gridButtonPrefab;
    // every time player pressed the button, pass in a question
    public TriviaQuestionObject currentQuestion;

    public Sprite tenPointSprite;
    public Sprite twentyPointSprite;
    public Sprite thirtyPointSprite;
    public Sprite fortyPointSprite;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        questionGrid = new GameObject[width, height];
        SetUpGrid();
    }

    // public void AssignQuestionsFromPoolToChart()
    // {
    //     for(var i = 0; i< questionsPool.Count; i++)
    //     {
    //         switch(questionsPool[i].questionType)
    //         {
    //             case 'a':
    //                 
    //                 break;
    //             case 'b':
    //                 break;
    //
    //         }
    //     }
    // }

    public void SetUpGrid()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                var newObj = Instantiate(gridButtonPrefab);
                questionGrid[x, y] = newObj;
                for (int i = 0; i < questionsPool.Count; i++)
                {
                    switch (x)
                    {
                        case 0:
                            if (questionsPool[i].questionTheme == TriviaQuestionObject.QuestionTheme.CodeLab)
                            {
                                switch (y)
                                {
                                    case 0:
                                        if (questionsPool[i].pointLevel == 10)
                                        {
                                            questionGrid[x, y].GetComponent<QuestionButton>().pointValueSprite.sprite =
                                                tenPointSprite;
                                            questionGrid[x, y].GetComponent<QuestionButton>().question =
                                                questionsPool[i];
                                        }
                                        break;
                                    case 1:
                                        if (questionsPool[i].pointLevel == 20)
                                        {
                                            questionGrid[x, y].GetComponent<QuestionButton>().pointValueSprite.sprite =
                                                twentyPointSprite;
                                            questionGrid[x, y].GetComponent<QuestionButton>().question =
                                                questionsPool[i];
                                        }
                                        break;
                                    case 2:
                                        if (questionsPool[i].pointLevel == 30)
                                        {
                                            questionGrid[x, y].GetComponent<QuestionButton>().pointValueSprite.sprite =
                                                thirtyPointSprite;
                                            questionGrid[x, y].GetComponent<QuestionButton>().question =
                                                questionsPool[i];
                                        }
                                        break;
                                    case 3:
                                        if (questionsPool[i].pointLevel == 40)
                                        {
                                            questionGrid[x, y].GetComponent<QuestionButton>().pointValueSprite.sprite =
                                                fortyPointSprite;
                                            questionGrid[x, y].GetComponent<QuestionButton>().question =
                                                questionsPool[i];
                                        }
                                        break;
                                }
                            }
                            break;
                        case 1:
                            if (questionsPool[i].questionTheme == TriviaQuestionObject.QuestionTheme.Games)
                            {
                                switch (y)
                                {
                                    case 0:
                                        if (questionsPool[i].pointLevel == 10)
                                        {
                                            questionGrid[x, y].GetComponent<QuestionButton>().pointValueSprite.sprite =
                                                tenPointSprite;
                                            questionGrid[x, y].GetComponent<QuestionButton>().question =
                                                questionsPool[i];
                                        }
                                        break;
                                    case 1:
                                        if (questionsPool[i].pointLevel == 20)
                                        {
                                            questionGrid[x, y].GetComponent<QuestionButton>().pointValueSprite.sprite =
                                                twentyPointSprite;
                                            questionGrid[x, y].GetComponent<QuestionButton>().question =
                                                questionsPool[i];
                                        }
                                        break;
                                    case 2:
                                        if (questionsPool[i].pointLevel == 30)
                                        {
                                            questionGrid[x, y].GetComponent<QuestionButton>().pointValueSprite.sprite =
                                                thirtyPointSprite;
                                            questionGrid[x, y].GetComponent<QuestionButton>().question =
                                                questionsPool[i];
                                        }
                                        break;
                                    case 3:
                                        if (questionsPool[i].pointLevel == 40)
                                        {
                                            questionGrid[x, y].GetComponent<QuestionButton>().pointValueSprite.sprite =
                                                fortyPointSprite;
                                            questionGrid[x, y].GetComponent<QuestionButton>().question =
                                                questionsPool[i];
                                        }
                                        break;
                                }
                            }
                            break;
                        case 2:
                            if (questionsPool[i].questionTheme == TriviaQuestionObject.QuestionTheme.Food)
                            {
                                switch (y)
                                {
                                    case 0:
                                        if (questionsPool[i].pointLevel == 10)
                                        {
                                            questionGrid[x, y].GetComponent<QuestionButton>().pointValueSprite.sprite =
                                                tenPointSprite;
                                            questionGrid[x, y].GetComponent<QuestionButton>().question =
                                                questionsPool[i];
                                        }
                                        break;
                                    case 1:
                                        if (questionsPool[i].pointLevel == 20)
                                        {
                                            questionGrid[x, y].GetComponent<QuestionButton>().pointValueSprite.sprite =
                                                twentyPointSprite;
                                            questionGrid[x, y].GetComponent<QuestionButton>().question =
                                                questionsPool[i];
                                        }
                                        break;
                                    case 2:
                                        if (questionsPool[i].pointLevel == 30)
                                        {
                                            questionGrid[x, y].GetComponent<QuestionButton>().pointValueSprite.sprite =
                                                thirtyPointSprite;
                                            questionGrid[x, y].GetComponent<QuestionButton>().question =
                                                questionsPool[i];
                                        }
                                        break;
                                    case 3:
                                        if (questionsPool[i].pointLevel == 40)
                                        {
                                            questionGrid[x, y].GetComponent<QuestionButton>().pointValueSprite.sprite =
                                                fortyPointSprite;
                                            questionGrid[x, y].GetComponent<QuestionButton>().question =
                                                questionsPool[i];
                                        }
                                        break;
                                }
                            }
                            break;
                    }
                }
                questionGrid[x, y].transform.position = new Vector3((x * 3) - xStart, (-(y + y))+yStart);
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
