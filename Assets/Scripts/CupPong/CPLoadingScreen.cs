using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPLoadingScreen : MonoBehaviour
{
    public GameObject LoadingScreens;
    public GameObject WinScreen;
    public GameObject LossScreen;
    public GameObject LoadingScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayerWins()
    {
        LoadingScreens.SetActive(true);
        LoadingScreen.SetActive(false);
        WinScreen.SetActive(true);
        LossScreen.SetActive(false);
    }
    public void EnemyWins()
    {
        LoadingScreens.SetActive(true);
        LoadingScreen.SetActive(false);
        WinScreen.SetActive(false);
        LossScreen.SetActive(true);
    }
}
