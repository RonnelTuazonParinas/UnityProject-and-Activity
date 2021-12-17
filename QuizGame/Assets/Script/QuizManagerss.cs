using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManagerss : MonoBehaviour
{
    public List<Question> QnA;
    public GameObject[] options;
    public int currentQuestions;
    public GameObject Question;
    public GameObject GoPanel;

    public Text Questiontxt;
    public Text ScoreTxt;

    int TotalQuestions = 0;
    public int score;

    private void Start()
    {
        TotalQuestions = QnA.Count;
        GoPanel.SetActive(false);
        generateQuestions();

    }
    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
     void GameOver()
    {
        Question.SetActive(false);
        GoPanel.SetActive(true);
        ScoreTxt.text = score + "/" + TotalQuestions;
    }
    public void correct()
    {
        score += 1;
        QnA.RemoveAt(currentQuestions);
        generateQuestions();
    }
    public void wrong()
    {
        QnA.RemoveAt(currentQuestions);
        generateQuestions();
    }

    void SetAnswer()
    {
        for (int i = 0; i< options.Length; i++)
        {
            options[i].GetComponent<TamangSagot>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestions].Answers[i];
            if(QnA[currentQuestions].CorrectAnswer == i  + 1)
            {
                options[i].GetComponent<TamangSagot>().isCorrect = true;
            }
        }
       
    }

    void generateQuestions()
    {
        if(QnA.Count > 0)
        {
            currentQuestions = Random.Range(0, QnA.Count);
            Questiontxt.text = QnA[currentQuestions].Questions;
            SetAnswer();
        }
       else
        {
            Debug.Log("Out of Question");
            GameOver();
        }

       
    }
}
