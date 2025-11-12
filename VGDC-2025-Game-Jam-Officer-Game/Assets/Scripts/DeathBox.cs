using UnityEngine;

public class CollisionDestroy : MonoBehaviour
{
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