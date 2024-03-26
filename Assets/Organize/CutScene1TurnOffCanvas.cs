using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutScene1TurnOffCanvas : MonoBehaviour
{
    public Canvas canvas;
    public GameObject windows;
    public void TurnOffCanvas()
    {
        canvas.gameObject.SetActive(false);
        windows.gameObject.SetActive(true);
    }

}
