using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score =0;
    public int highScore;
    public TextMeshProUGUI textScore;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("score", score); //store the score in computer
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void incrementScore()
    {
        score++;
        textScore.text = "Score: " + score;
      
    }
    public void startScore()
    {
        //InvokeRepeating("incrementScore", 0.1f, 0.5f);
        incrementScore();
    }
    public void stopScore()
    {
        CancelInvoke("incrementScore");
        PlayerPrefs.SetInt("score", score);

        /*if (score > PlayerPrefs.GetInt("highScore", score))
        {
            PlayerPrefs.SetInt("highScore", score);

        }
        */

        if (PlayerPrefs.HasKey("highScore"))
        {
            if (score > PlayerPrefs.GetInt("highScore", score))
            {
                PlayerPrefs.SetInt("highScore", score);
            }
        }
        else
        {
            PlayerPrefs.SetInt("highScore", score);
        }
        
    }

    public void Reset()
    {
        PlayerPrefs.DeleteKey("highScore");
        highScore = 0;
    }
}
