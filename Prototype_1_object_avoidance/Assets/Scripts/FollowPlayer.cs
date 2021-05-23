using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -12);

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void lateUpdate()
    {
        // Offset the camera behind the player 
        transform.position = player.transform.position + offset;
    }
}
