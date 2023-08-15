using UnityEngine;

public class CustomGravity : MonoBehaviour
{
    private Vector2 gravityDirection = Vector2.down;
    public Transform playerTransform;
    void FixedUpdate()
    {
        Physics2D.gravity = gravityDirection;
        if (playerTransform.transform.position.y >= 0) gravityDirection = Vector2.up;
        else if (playerTransform.transform.position.y < 0) gravityDirection = Vector2.down;

        Physics2D.gravity = gravityDirection * 5.0f;
    }
}