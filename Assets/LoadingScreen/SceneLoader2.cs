using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;


public class SceneLoader2: MonoBehaviour
{
    [SerializeField] string targetScene;

    public void LoadScene()
    {
        LoadingData.sceneToLoad = targetScene;
        SceneManager.LoadScene("LoadingScreen");
    }

}

