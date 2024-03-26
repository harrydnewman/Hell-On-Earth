using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartScreenButtonUI : MonoBehaviour
{
    
    public SceneLoader sceneloader;
    public void StartButton()
    {
        sceneloader.LoadScene();
    }
}
