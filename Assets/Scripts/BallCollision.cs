using UnityEngine;
using UnityEngine.UI;

public class BallCollision : MonoBehaviour
{
    public BallMovement movement;
    public Text scoreText;
    public AudioSource audioPlayer;
    private int collisionCount = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Bound")
        {
            movement.enabled = false;           
            FindObjectOfType<GameManager>().GameOver();
        }

        if (collision.gameObject.tag == "Player")
        {
            collisionCount++;
            scoreText.text = collisionCount.ToString();
            audioPlayer.Play();
        }
    }
}