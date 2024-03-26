using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPPlayerBallDestroy : MonoBehaviour
{
    //this script also does destroy out of bounds
    private float zRange = 13f;
    private float xRange = 3.75f;
    private float yRange = 1.75f;

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
        }
        else if (transform.position.x > xRange)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < -xRange)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y < yRange)
        {
            Destroy(gameObject);
        }
    }
}
