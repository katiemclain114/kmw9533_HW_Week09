using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ListTest : MonoBehaviour
{
    public List<TriviaQuestionObject> testList = new List<TriviaQuestionObject>();
    public Stack<TriviaQuestionObject> testStack = new Stack<TriviaQuestionObject>();

    private int listStartCount;
    private void Start()
    {
        listStartCount = testList.Count;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < listStartCount; i++)
            {
                int randomNum = Random.Range(0, testList.Count);
                testStack.Push(testList[randomNum]);
                testList.Remove(testList[randomNum]);
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            for (int i = 0; i < listStartCount; i++)
            {
                TriviaQuestionObject testObject = testStack.Pop();
                testList.Add(testObject);
                Debug.Log(testObject.question);
            }
            
        }
    }
}
