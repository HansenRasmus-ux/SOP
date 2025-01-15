using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spørgsmålsopsætning : MonoBehaviour
{
    [SerializeField]
    public List<Spørgsmålsdata> questions;
    private Spørgsmålsdata currentQuestion;

    [SerializeField]
    private TextMeshProUGUI questionText;
    [SerializeField]
    private TextMeshProUGUI categoryText;
    [SerializeField]
    private Svarknap[] answerButtons;

    [SerializeField]
    private int correctAnswerChoice;

    private void Awake()
    {
        
        GetQuestionAssets();
    }

    
    public void Start()
    {
        
        if (questions.Count > 0)
        {
            
            SelectNewQuestion();
            
            SetQuestionValues();
            
            SetAnswerValues();
        }
       
    }

   

    private void GetQuestionAssets()
    {
        
        questions = new List<Spørgsmålsdata>(Resources.LoadAll<Spørgsmålsdata>("Questions"));
        
    }

    private void SelectNewQuestion()
    {
        
        int randomQuestionIndex = Random.Range(0, questions.Count);
        
        
        
        currentQuestion = questions[randomQuestionIndex];
        
        questions.RemoveAt(randomQuestionIndex);
        
    }

    private void SetQuestionValues()
    {
        
        questionText.text = currentQuestion.question;
        
        categoryText.text = currentQuestion.category;
        
    }

    private void SetAnswerValues()
    {
        
        List<string> answers = RandomizeAnswers(new List<string>(currentQuestion.answers));

        
        for (int i = 0; i < answerButtons.Length; i++)
        {
            if (i >= answers.Count)
            {
                break; 
            }

            
            bool isCorrect = i == correctAnswerChoice;

            answerButtons[i].SetIsCorrect(isCorrect);
            answerButtons[i].SetAnswerText(answers[i]);
            
        }
    }

    private List<string> RandomizeAnswers(List<string> originalList)
    {
        bool correctAnswerChosen = false;
        List<string> newList = new List<string>();

        for (int i = 0; i < answerButtons.Length; i++)
        {
            if (originalList.Count == 0)
            {
                break; 
            }

            int random = Random.Range(0, originalList.Count);


            
            if (random == 0 && !correctAnswerChosen)
            {
                correctAnswerChoice = i;
                correctAnswerChosen = true;
            }

            newList.Add(originalList[random]);
            
            originalList.RemoveAt(random);
            
        }

        return newList;
    }
}