using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    //Health System
    public Sprite redHeart;
    public Sprite blackHeart;
    public List<Image> healthes;
    public int health = 4;

    //Points System
    public int currentPoints;
    public Text pointsText;
    public int currentPointsLevel;

    //GameOver System
    public Text finalScoreText;
    public int questionsLeftToBeAnswered = 12;


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

    public void ShowGameUiHideQuestionUI()
    {
        QuestionManager.instance.correctText.SetActive(false);
        QuestionManager.instance.wrongText.SetActive(false);
        QuestionManager.instance.backButton.SetActive(false);
        answerChosen = false;

        gameUI.SetActive(true);
        questionUI.SetActive(false);

        UpdatePoints();

        ShowButtons();

        DeathCheck();
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
                currentPoints += currentPointsLevel;
            }
            else
            {
                QuestionManager.instance.correctText.SetActive(false);
                QuestionManager.instance.wrongText.SetActive(true);
                LoseHealth();
            }
        }
    }

    public void LoseHealth()
    {
        health -= 1;

        healthes[health].sprite = blackHeart;
    }

    public void UpdatePoints()
    {
        pointsText.text = "Points:" + currentPoints;
    }

    public void DeathCheck()
    {
       if(health <= 0 || questionsLeftToBeAnswered <= 0)
       {
            gameUI.SetActive(false);
            questionUI.SetActive(false);
            HideButtons();

            gameOverUI.SetActive(true);

            finalScoreText.text = "Your Final Score Is:" + currentPoints;
       }
    }
}
