using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WalkingDetection : MonoBehaviour
{
    public SceneLoader sceneloader;
    private float xRange = 75f;
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > xRange)
        {
            canvas.gameObject.SetActive(true);
            sceneloader.LoadScene();
           



        }

    }
}

