using UnityEngine;
using UnityEngine.Playables;

public class timelineM : MonoBehaviour
{
    public PlayableDirector timeline;

    void Start()
    {
        if (timeline != null)
        {
            timeline.Play();
        }
    }
}