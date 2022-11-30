using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool gameOver;


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
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        UiManager.instance.gameStart();
        ScoreManager.instance.startScore();
        GameObject.Find("platformspawner").GetComponent<PlatformSpawner>().startSpawningPlatform();

    }

    public void GameOver()
    {
        UiManager.instance.gameOver();
        ScoreManager.instance.stopScore();
        gameOver = true;
    }
}
