using UnityEngine;
public class PlayerController : MonoBehaviour
{
    private float speed = 130; 

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.rotation *= Quaternion.Euler(0, 0, horizontalInput * speed * Time.deltaTime);
    }
}