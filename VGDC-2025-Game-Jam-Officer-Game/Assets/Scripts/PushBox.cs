using UnityEngine;

public class PushBox : MonoBehaviour
{
    [Header("Movement Settings")]
    public Transform target;           // The object to move toward
    public float moveSpeed = 2f;       // Speed of movement

    [Header("Reset Settings")]
    private Vector3 startPosition;     // Starting position to reset to

    void Start()
    {
        // Save the starting position
        startPosition = transform.position;
    }

    void Update()
    {
        // Move toward the target if it exists
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                target.position,
                moveSpeed * Time.deltaTime
            );
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Reset position when colliding with player
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<SimpleCharacterController2D>().Reset();
            ResetPosition();
        }
    }

    public void ResetPosition()
    {
        transform.position = startPosition;
        Debug.Log("Box reset to start position");
    }
}