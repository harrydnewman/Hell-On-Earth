using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene1SceneLoaded : MonoBehaviour
{
    public SceneLoader sceneloader;
    public GameObject windows;

    public void CutScene1AnimationEnding()
    {
        
        sceneloader.LoadScene();
    }
}

