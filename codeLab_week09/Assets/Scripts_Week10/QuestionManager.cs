using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    //keeps track of ui elements for the questions
    //could combine with gamemanager but keeps it less crowded 
    public static QuestionManager instance;

    public Text questionText;
    public Text answer1Text;
    public Text answer2Text;
    public Text answer3Text;
    public Text answer4Text;

    public GameObject correctText;
    public GameObject wrongText;

    public GameObject backButton;
    private void Awake()
    {
        instance = this;
        backButton.SetActive(false);
    }
    
}
