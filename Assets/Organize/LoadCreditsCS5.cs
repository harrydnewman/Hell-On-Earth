using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCreditsCS5 : MonoBehaviour
{
   // public SceneLoader sceneloader;
    public CS5FadeToWhite2 cs5fade;
    private float xRange = -50f;
    private float yrange = -29f;
    
    void Update()
    {
        if (transform.position.x > xRange && transform.position.y < yrange)
        {
            Debug.Log("Hello");
            cs5fade.FadeWhiteOutSquare();
            //sceneloader.LoadScene();
        }
    }
}
