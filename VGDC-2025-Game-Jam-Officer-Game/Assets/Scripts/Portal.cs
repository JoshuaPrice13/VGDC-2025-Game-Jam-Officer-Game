using UnityEngine;

public class Portal : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        SceneChanger sceneChanger = FindObjectOfType<SceneChanger>();
        sceneChanger.LoadNextScene();
    }
}