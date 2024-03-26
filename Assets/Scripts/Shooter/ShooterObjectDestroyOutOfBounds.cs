using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterObjectDestroyOutOfBounds : MonoBehaviour
{
    private float zRange = 60;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > zRange)
        {
            Destroy(gameObject);
            //Debug.Log("GameObject Destroyed");
        }
    }
}
