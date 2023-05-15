using UnityEngine;
public class BallMovement : MonoBehaviour
{
    public Rigidbody2D rb; 
    private float ballSpeed = 3;
    void Start()
    {
        Invoke("ballMovement", 1);
    }

    void ballMovement()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -ballSpeed);
    }
}