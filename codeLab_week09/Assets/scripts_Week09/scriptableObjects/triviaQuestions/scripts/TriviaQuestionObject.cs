using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewTriviaQuestion", menuName = "ScriptableObjects/TriviaQuestion")]
public class TriviaQuestionObject : ScriptableObject
{
    //i made each question a scriptable object to store info on that question
    public string question;
    
    public string answer1;
    public string answer2;
    public string answer3;
    public string answer4;

    public int correctAnswer;
}
