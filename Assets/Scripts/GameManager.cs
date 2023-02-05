using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // public Player player;

    public GameObject startButton;
    public GameObject aboutButton;
    public GameObject exitButton;

    // public GameObject continueButton;

    public int currentLevel;

    private void Awake()
    {
        Application.targetFrameRate = 60;

        // player = FindObjectOfType<Player>();
        //
        // gameOver.SetActive(false);
        // restartButton.SetActive(false);
        //
        // continueButton.SetActive(false);
        
        Pause();
    }

    //new
    private void Start()
    {
        // highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
        
    }

    public void Play()
    {
        // startButton.SetActive(false);
        // gameOver.SetActive(false);
        // restartButton.SetActive(false);
        //
        // continueButton.SetActive(false);
        //
        // plane.SetActive(false);
        // bigBirds.SetActive(false);
        //
        // Time.timeScale = 1f;
        // player.enabled = true;
    }

    public void ContinuePlay()
    {
        // startButton.SetActive(false);
        // gameOver.SetActive(false);
        // restartButton.SetActive(false);
        //
        // plane.SetActive(false);
        // bigBirds.SetActive(false);
        //
        // Time.timeScale = 1f;
        // player.enabled = true;
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        // player.enabled = false;
    }

    public void GameOver()
    {
        // gameOver.SetActive(true);
        // restartButton.SetActive(true);
        //
        // continueButton.SetActive(true);

        Pause();
    }

    // public void IncreaseScore()
    // {
    //     score++;
    //     scoreText.text = score.ToString();
    //
    //     if (score >= planeRelease)
    //     {
    //         plane.SetActive(true);
    //     }
    //
    //     if (score >= bigBirdRelease)
    //     {
    //         bigBirds.SetActive(true);
    //     }
    // }

    //new
    // private void Update()
    // {
    //
    //     if (score > PlayerPrefs.GetInt("HighScore", 0))
    //     {
    //         PlayerPrefs.SetInt("HighScore", score);
    //         highScoreText.text = score.ToString();
    //     }
    // }

}
