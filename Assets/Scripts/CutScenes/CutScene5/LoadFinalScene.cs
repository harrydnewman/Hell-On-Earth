using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadFinalScene : MonoBehaviour
{
    public SceneLoader sceneloader;
    public Canvas canvas;
    private float xRange = -55f;

    void Update()
    {
        if (transform.position.x < xRange)
        {
            canvas.gameObject.SetActive(true);
            sceneloader.LoadScene();
        }
    }
}
