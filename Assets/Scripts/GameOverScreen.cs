using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text lastScore;
    public Text highScore;

    void Start()
    {
        highScore.text = "HIGH SCORE:" + PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        lastScore.text = "YOUR SCORE:" + score.ToString();

        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }

    public void ReturnMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}