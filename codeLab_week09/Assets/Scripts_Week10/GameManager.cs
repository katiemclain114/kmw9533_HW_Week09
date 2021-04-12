using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    //insert all of the questions
    public List<TriviaQuestionObject> questionsPool;
    public GameObject[,] questionGrid;
    public int width=3;
    public int height=4;
    public int xStart;
    public int yStart;
    public int score;

    // three different UIs
    public GameObject gameUI;
    public GameObject questionUI;
    public GameObject gameOverUI;

    //game object that is stored in questionGrid
    public GameObject gridButtonPrefab;
    // every time player pressed the button, pass in a question
    public TriviaQuestionObject currentQuestion;

    //display different sprites for point value
    public Sprite tenPointSprite;
    public Sprite twentyPointSprite;
    public Sprite thirtyPointSprite;
    public Sprite fortyPointSprite;

    //keeps track of if the player has input an answer for a specific question
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

        for (int i = 0; i < healthes.Count; i++)
        {
            healthes[i].sprite = redHeart;
        }
    }

    //instantiate new question button for each grid place
    //use switch statements to put correct question in correct place
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

    //hides the game ui and sets up question ui
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

    //resets question ui and hides it then shows the game ui
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

    //hides every game object in the grid
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

    //reshows every game object in the grid
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

    //on question when player chooses clicks an answer button
    public void AnswerPress(int answerNum)
    {
        //player hasnt chosed answer yet
        if (!answerChosen)
        {
            answerChosen = true;
            QuestionManager.instance.backButton.SetActive(true);

            //check if answer was correct
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

    //if player answers wrong loose one health and change one heart black
    public void LoseHealth()
    {
        health -= 1;

        healthes[health].sprite = blackHeart;
    }

    //keep point text equal to currentPoints
    public void UpdatePoints()
    {
        pointsText.text = "Points:" + currentPoints;
    }

    //go to end screen in player has lost all health or answered all questions
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
