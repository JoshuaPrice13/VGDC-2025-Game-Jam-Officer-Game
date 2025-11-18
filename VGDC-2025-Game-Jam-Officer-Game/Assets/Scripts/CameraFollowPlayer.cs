using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class CameraFollowPlayer : MonoBehaviour
{

    // Source - https://stackoverflow.com/q
    // Posted by Ziv Sion, modified by community. See post 'Timeline' for change history
    // Retrieved 2025-11-17, License - CC BY-SA 4.0

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player"); // The player
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, this.transform.position.y, this.transform.position.z);
    }
}


