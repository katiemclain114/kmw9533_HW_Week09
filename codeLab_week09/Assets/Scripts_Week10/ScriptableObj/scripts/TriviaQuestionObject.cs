using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewTriviaQuestion", menuName = "ScriptableObjects/TriviaQuestion")]
public class TriviaQuestionObject : ScriptableObject
{
    //i made each question a scriptable object to store info on that question
    public string question;

    // make it char coz I dont know how to swtich in form of 'string'

    // a - game101, b - codelab1
    public char questionType;
    // 1 - 200, 2 - 400, 3 - 600, 4 - 800, 5 - 1000
    public char pointsType;

    // int for actual adding to points
    public int points;
    
    public string answer1;
    public string answer2;
    public string answer3;
    public string answer4;

    public int correctAnswer;
}
