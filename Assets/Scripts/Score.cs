using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Score : MonoBehaviour
{
    public static Score instance;
    public Text scoreText;

    int score = 0;

    private void Awake() 
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.text = score.ToString() + " Point";
    }

    public void addScore()
    {
        score += 1;
        scoreText.text = score.ToString() + " Point";
    }
}
