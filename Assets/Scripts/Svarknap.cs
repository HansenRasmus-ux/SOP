// This script is for the buttons the answers will go on

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Svarknap : MonoBehaviour
{
    public int levelGenerate;
    private bool isCorrect;
    public Spørgsmålsopsætning questionSetup; 
    [SerializeField] private TextMeshProUGUI answerText;

    
    

    public void SetAnswerText(string newText)
    {
        answerText.text = newText;
    }

    public void SetIsCorrect(bool newBool)
    {
        isCorrect = newBool;
    }

    public void OnClick()
    {
        if(isCorrect)
        {
            Debug.Log("CORRECT ANSWER");
            Score.instance.addScore();
        }
        else
        {
            Debug.Log("WRONG ANSWER");
        }

        
        if (questionSetup.questions.Count > 0)
        {
            
            questionSetup.Start();
        }
        else
        {
            levelGenerate = 3;
            SceneManager.LoadScene(levelGenerate);
        }
    }
}