using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CupPongLossLoadNextScene : MonoBehaviour
{
    public SceneLoader sceneLoader;
    public GameObject RawImage;
    public GameObject Canvas;

    public void LoadNewScene()
    {
        Canvas.gameObject.SetActive(true);
        RawImage.gameObject.SetActive(true);
        Debug.Log("Loaded Scene 13");
        sceneLoader.LoadScene();
    }
}
