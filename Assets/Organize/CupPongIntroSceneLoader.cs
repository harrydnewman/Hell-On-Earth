using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupPongIntroSceneLoader : MonoBehaviour
{
    public SceneLoader sl;
    public void LoadScene()
    {
        Debug.Log("SceneLoaded!");
        sl.LoadScene();
    }
}
