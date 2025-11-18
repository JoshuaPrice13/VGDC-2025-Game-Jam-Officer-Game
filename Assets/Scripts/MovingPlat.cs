using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlat : MonoBehaviour
{

    // Using a game object to register an end-point
    [SerializeField] public GameObject finish;
    private Vector3 finishPos;
    public float speed = 0.5f;

    private Vector3 startPos;
    private float trackPercent = 0.0f;
    private int direction = 1;

    
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

        // Finish is basically wherever I put the end point, takes a direct path to it!
        finishPos = new Vector3(finish.transform.position.x, finish.transform.position.y, finish.transform.position.z);    
    }
//
    // Update is called once per frame
    void Update()
    {
        trackPercent += direction * speed * Time.deltaTime;
        float x = (finishPos.x - startPos.x) * trackPercent + startPos.x;
        float y = (finishPos.y - startPos.y) * trackPercent + startPos.y;
        transform.position = new Vector3(x,y,startPos.z);

        if((direction == 1 && trackPercent > .9f) || (direction == -1 && trackPercent < 0.1f)){
            direction *= -1;
        }
    }
}
