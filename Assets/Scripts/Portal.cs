using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private Animator PortalAnimator;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hit portal");
        if (collision.gameObject.CompareTag("Player"))
        {
            //PortalAnimator.SetBool("TouchedPortal", true);
            SceneChanger sceneChanger = FindObjectOfType<SceneChanger>();

            if (sceneChanger != null)
            {
                sceneChanger.LoadNextScene();
            }
            else
            {
                Debug.LogError("SceneChanger not found in scene!");
            }
        }

    }
}