using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CupPongInstructionsButtonUI : MonoBehaviour
{
    public SceneLoader sceneloader;
    public void OKButton()
    {
        sceneloader.LoadScene();
    }
}
