using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private SimpleCharacterController2D player;
    private bool isLight = false;
    private GameObject[] lightPlatforms;
    private GameObject[] darkPlatforms;

    void Start()
    {
        Light_Platform[] lightPlatformScripts = FindObjectsOfType<Light_Platform>(true);
        Dark_Platform[] darkPlatformScripts = FindObjectsOfType<Dark_Platform>(true);

        lightPlatforms = new GameObject[lightPlatformScripts.Length];
        darkPlatforms = new GameObject[darkPlatformScripts.Length];

        for (int i = 0; i < lightPlatformScripts.Length; i++)
        {
            lightPlatforms[i] = lightPlatformScripts[i].gameObject;
        }

        for (int i = 0; i < darkPlatformScripts.Length; i++)
        {
            darkPlatforms[i] = darkPlatformScripts[i].gameObject;
        }
    }

    public void ChangeColor()
    {
        Debug.Log("gm color change");
        isLight = !isLight;

        if (isLight)
        {
            player.ChangeColor("Light");

            foreach (GameObject platform in lightPlatforms)
            {
                platform.SetActive(false);
            }
            foreach (GameObject platform in darkPlatforms)
            {
                platform.SetActive(true);
            }
        }
        else
        {
            player.ChangeColor("Dark");

            foreach (GameObject platform in lightPlatforms)
            {
                platform.SetActive(true);
            }
            foreach (GameObject platform in darkPlatforms)
            {
                platform.SetActive(false);
            }
        }
    }
}