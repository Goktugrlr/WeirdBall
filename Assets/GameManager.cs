using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameOverScreen gameOverScreen;
    public Text scoreText;
    public AudioSource audioPlayer;
    public void GameOver()
    {
        string finalScoreString = scoreText.text;
        int finalScore = int.Parse(finalScoreString);
        Time.timeScale = 0;
        gameOverScreen.Setup(finalScore);
        audioPlayer.Play();
    }
}