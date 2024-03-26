using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeginGameScene : MonoBehaviour
{
    public SceneLoader sceneloader;
    private float xRange = 85.45f;
    private float yRange = -29f;
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < xRange && transform.position.y < yRange)
        {
            canvas.gameObject.SetActive(true);
            sceneloader.LoadScene();
        }

    }
}
