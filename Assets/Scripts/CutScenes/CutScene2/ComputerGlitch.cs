using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerGlitch : MonoBehaviour
{
    public GameObject OnScreens;
    public GameObject OffScreens;

    public void ComputerGoBoom()
    {

        OnScreens.gameObject.SetActive(false);
        OffScreens.gameObject.SetActive(true);
    }

}
