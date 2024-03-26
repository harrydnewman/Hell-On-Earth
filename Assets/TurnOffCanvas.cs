using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffCanvas : MonoBehaviour
{
    public GameObject canvas;
    void Awake()
    {
        canvas.gameObject.SetActive(false);
    }
}
