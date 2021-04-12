using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewTriviaQuestion", menuName = "ScriptableObjects/TriviaQuestion")]
public class TriviaQuestionObject : ScriptableObject
{
    //question categories
    public enum QuestionTheme
    {
        CodeLab,
        Games,
        Food
    }
    
    public QuestionTheme questionTheme;
    //keep track of with row question should be on and how many points to give
    public int pointLevel;
    
    //the question
    public string question;

    //answers
    public string answer1;
    public string answer2;
    public string answer3;
    public string answer4;

    //used to determine if player was right
    public int correctAnswer;
}
