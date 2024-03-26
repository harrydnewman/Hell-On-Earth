using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupPongWinLoadNextScene : MonoBehaviour
{
    public SceneLoader sceneLoader;
    public void Loader()
    {
        sceneLoader.LoadScene();

    }
}
