using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class UiManager : MonoBehaviour
{
    public static UiManager instance;
    public GameObject gameOverPanel;
    public GameObject tapText;
    public TextMeshProUGUI menuScore;
    public TextMeshProUGUI highScore;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameStart()
    {
        tapText.SetActive(false);

    }
    public void gameOver()
    {
        menuScore.text = "Score: " + PlayerPrefs.GetInt("score").ToString();
        highScore.text = "Highscore: " + PlayerPrefs.GetInt("highScore").ToString();

        gameOverPanel.SetActive(true);

    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void ResetData()
    {
        ScoreManager.instance.Reset();
        SceneManager.LoadScene(0);
        

    }
}
