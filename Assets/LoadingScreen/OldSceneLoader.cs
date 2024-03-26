using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OldSceneLoader : MonoBehaviour
{
    public void LoadScene(int levelIndex)
    {
        StartCoroutine(LoadSceneAsyncronously(levelIndex));
    }

    IEnumerator LoadSceneAsyncronously(int levelIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(levelIndex);
        while (!operation.isDone)
        {
            Debug.Log(operation.progress);
            yield return null;
        }
    }
}
