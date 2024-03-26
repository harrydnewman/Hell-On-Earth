using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CutScene1EndLoadNextScene : MonoBehaviour
{
    

    public GameObject windows;
    public Canvas canvas;
    public SceneLoader sl;
    // Start is called before the first frame update
     
    public void Joe()
    {
        windows.gameObject.SetActive(false);
        canvas.gameObject.SetActive(true);
        sl.LoadScene();


    }
}

