using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene2LoadNextScene : MonoBehaviour
{
    public SceneLoader sceneloader;

    public void AnimationEnding()
    {
        sceneloader.LoadScene();
    }
}
