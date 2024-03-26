using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerStartup : MonoBehaviour
{
    public GameObject OnScreens;
    public GameObject OffScreens;
    public void ComputerTurnsOn()
    {
        OnScreens.gameObject.SetActive(true);
        OffScreens.gameObject.SetActive(false);
    }
}
