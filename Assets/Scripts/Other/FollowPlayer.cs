using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //public variables (do not change this to private or camera will break)
    public GameObject player;
    //private variables
    Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    //late update moves the camera after the vehicle is moved
    void LateUpdate()
    {
        // Offset the camera behind the player by adding to the players position
        transform.position = player.transform.position + offset;
    }
}
