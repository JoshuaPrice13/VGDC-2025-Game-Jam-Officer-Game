using UnityEngine;

public class Patrol : MonoBehaviour
{
    [Header("Patrol Points")]
    //public Transform pointA;
    //public Transform pointB;

    [Header("Movement Settings")]
    public float speed = 2f;

    private Transform targetPoint;

    void Start()
    {
        // Start by moving toward point A
        //targetPoint = pointA;
    }

    void Update()
    {
        /*
        // Move toward the current target point
        transform.position = Vector2.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);

        // Check if we've reached the target point
        if (Vector2.Distance(transform.position, targetPoint.position) < 0.1f)
        {
            // Switch to the other point
            targetPoint = (targetPoint == pointA) ? pointB : pointA;
        }
        */
    }

    void OnCollisionEnter2D(Collision2D collision)
        {
            // Destroy the object that hit this object
            Destroy(collision.gameObject);

            // Or destroy this object instead
            // Destroy(gameObject);

            // Or destroy both
            // Destroy(collision.gameObject);
            // Destroy(gameObject);
        }
}