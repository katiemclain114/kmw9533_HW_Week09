using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class TriviaManager : MonoBehaviour
{
    //I used a list to shuffle the question before popping them
    //shuffled questions go into the questions stack
    public List<TriviaQuestionObject> shuffleList = new List<TriviaQuestionObject>();
    public Stack<TriviaQuestionObject> questions = new Stack<TriviaQuestionObject>();

    //all of the UI text
    public Text questionText;
    public Text answer1Text;
    public Text answer2Text;
    public Text answer3Text;
    public Text answer4Text;
    public Text nextButtonText;
    public Text scoreText;

    //gameObject that need to be hidden at different points
    public GameObject CorrectText;
    public GameObject WrongText;
    public GameObject nextButton;
    public GameObject GameUI;
    public GameObject EndUI;
    
    //private variables for keeping track of answer, if the player has answered the question or not, and score
    private int correctAnswer;

    private bool answeredQuestion;

    private int score;
    
    

    //setting up first question
    private void Start()
    {
        score = 0;
        GameUI.SetActive(true);
        EndUI.SetActive(false);
        nextButton.SetActive(false);
        nextButtonText.text = "Next Question";
        CorrectText.SetActive(false);
        WrongText.SetActive(false);
        StackQuestions();
        PopQuestion();
    }

    //shuffles all of the questions into then stacks them
    public void StackQuestions()
    {
        //questionNum is used to keep track of how many times the loop has run
        //the shuffleList is removing one each time
        int QuestionNum = shuffleList.Count;
        for (int i = 0; i < QuestionNum; i++)
        {
            int randomNum = Random.Range(0, shuffleList.Count);
            questions.Push(shuffleList[randomNum]);
            shuffleList.Remove(shuffleList[randomNum]);
        }
    }

    
    //for every new question
    public void PopQuestion()
    {
        answeredQuestion = false;
        nextButton.SetActive(false);
        //if questions.count is 1 then the next time players see the next button it should say end game
        if (questions.Count == 1)
        {
            nextButtonText.text = "End Game";
        }
        if (questions.Count > 0)
        {
            CorrectText.SetActive(false);
            WrongText.SetActive(false);
            
            TriviaQuestionObject temp = questions.Pop();
            
            //add object back to shuffle list to be reshuffled next round
            shuffleList.Add(temp);

            correctAnswer = temp.correctAnswer;

            questionText.text = temp.question;
            answer1Text.text = "1. " + temp.answer1;
            answer2Text.text = "2. " + temp.answer2;
            answer3Text.text = "3. " + temp.answer3;
            answer4Text.text = "4. " + temp.answer4;
        }
        else
        {
            //show endUI after all questions 
            GameUI.SetActive(false);
            EndUI.SetActive(true);
            scoreText.text = "Final Score: " + score + "/10";
        }
        
    }

    
    //player buttons for answering questions
    public void Pressed01()
    {
        if (!answeredQuestion)
        {
            answeredQuestion = true;
            nextButton.SetActive(true);

            if (correctAnswer == 1)
            {
                score++;
                CorrectText.SetActive(true);
                WrongText.SetActive(false);
            }
            else
            {
                CorrectText.SetActive(false);
                WrongText.SetActive(true);
            }
        }
    }
    
    public void Pressed02()
    {
        if (!answeredQuestion)
        {
            answeredQuestion = true;
            nextButton.SetActive(true);

            if (correctAnswer == 2)
            {
                score++;
                CorrectText.SetActive(true);
                WrongText.SetActive(false);
            }
            else
            {
                CorrectText.SetActive(false);
                WrongText.SetActive(true);
            }
        }
    }
    
    public void Pressed03()
    {
        if (!answeredQuestion)
        {
            answeredQuestion = true;
            nextButton.SetActive(true);

            if (correctAnswer == 3)
            {
                score++;
                CorrectText.SetActive(true);
                WrongText.SetActive(false);
            }
            else
            {
                CorrectText.SetActive(false);
                WrongText.SetActive(true);
            }
        }
    }
    
    public void Pressed04()
    {
        if (!answeredQuestion)
        {
            answeredQuestion = true;
            nextButton.SetActive(true);

            if (correctAnswer == 4)
            {
                score++;
                CorrectText.SetActive(true);
                WrongText.SetActive(false);
            }
            else
            {
                CorrectText.SetActive(false);
                WrongText.SetActive(true);
            }
        }
    }

    //same as start but added to button to restart game
    //i could just call this in start but i like to see these in start as well for right now
    public void Restart()
    {
        score = 0;
        GameUI.SetActive(true);
        EndUI.SetActive(false);
        nextButton.SetActive(false);
        nextButtonText.text = "Next Question";
        CorrectText.SetActive(false);
        WrongText.SetActive(false);
        StackQuestions();
        PopQuestion();
    }
}
