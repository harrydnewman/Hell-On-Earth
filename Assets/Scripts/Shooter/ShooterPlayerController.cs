using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterPlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 40f;
    public float xRangeTop = 30f;
    public float xRangeBottom = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > xRangeTop)
        {
            transform.position = new Vector3(xRangeTop, transform.position.y, transform.position.z);
        }
        if (transform.position.x < xRangeBottom)
        {
            transform.position = new Vector3(xRangeBottom, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
