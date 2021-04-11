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
    public int score;

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

    private bool answerChosen = false;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        gameUI.SetActive(true);
        questionUI.SetActive(false);
        gameOverUI.SetActive(false);
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
        
        HideButtons();

        QuestionManager.instance.questionText.text = currentQuestion.question;
        QuestionManager.instance.answer1Text.text = "1. " + currentQuestion.answer1;
        QuestionManager.instance.answer2Text.text = "2. " + currentQuestion.answer2;
        QuestionManager.instance.answer3Text.text = "3. " + currentQuestion.answer3;
        QuestionManager.instance.answer4Text.text = "4. " + currentQuestion.answer4;
    }

    public void HideButtons()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                questionGrid[x,y].SetActive(false);
            }
        }
    }

    public void ShowButtons()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                questionGrid[x,y].SetActive(true);
            }
        }
    }

    public void AnswerPress(int answerNum)
    {
        if (!answerChosen)
        {
            answerChosen = true;
            QuestionManager.instance.backButton.SetActive(true);

            if (currentQuestion.correctAnswer == answerNum)
            {
                score += currentQuestion.pointLevel;
                QuestionManager.instance.correctText.SetActive(true);
                QuestionManager.instance.wrongText.SetActive(false);
            }
            else
            {
                QuestionManager.instance.correctText.SetActive(false);
                QuestionManager.instance.wrongText.SetActive(true);
            }
        }
    }
}
