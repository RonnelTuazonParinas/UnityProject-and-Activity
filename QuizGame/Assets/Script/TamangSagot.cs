using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TamangSagot : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManagerss quizManager;
    public void ScriptAnswer()
    {
        if (isCorrect)
        {
            Debug.Log("Correct Answer");
            quizManager.correct();
        }
        else
        {
            Debug.Log("Wrong Answer");
            quizManager.wrong();
        }
    }
}
