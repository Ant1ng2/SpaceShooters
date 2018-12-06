using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public float spawnTime;
    public int hazardCount;
    public GameObject hazard;
    private float nextHazard;

    public Text scoreText;
    public Text gameOverText;
    public Text restartText;
    private int score;

    private bool isGameOver;

    void Start()
    {
        score = 0;
        gameOverText.text = "";
        restartText.text = "";
        isGameOver = false;
        updateScore();
    }

    void Update ()
    {
        if (Time.time > nextHazard)
        {
            nextHazard = Time.time + spawnTime;
            Instantiate(hazard, new Vector3(Random.Range(-9.0f, 9.0f), 0.0f, 26.0f), hazard.transform.rotation);
        }
        restart();
        showText();
    }

    public void addScore(int scoreIncrease)
    {
        score = score + scoreIncrease;
        updateScore();
    }

    void updateScore()
    {
        scoreText.text = "Score: " + score;
    }

    void restart()
    {
        if(Input.GetKeyDown(KeyCode.R) && isGameOver)
        {
            SceneManager.LoadScene("Space Shooters", LoadSceneMode.Single);
        }
    }

    void showText()
    {
        if(isGameOver)
        {
            gameOverText.text = "Game Over";
            restartText.text = "Press 'R' to Restart";       
        }        
    }

    public void gameOver()
    {
        isGameOver = true;
    }
}
