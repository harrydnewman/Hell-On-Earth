using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterCameraController : MonoBehaviour
{
    public GameObject player;
    //private variables
    Vector3 offset = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
