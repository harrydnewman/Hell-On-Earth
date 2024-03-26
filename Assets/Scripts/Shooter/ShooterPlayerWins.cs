using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterPlayerWins : MonoBehaviour
{
    public GameObject Crosshair;
    public GameObject Timer;
    public GameObject Score;
    public GameObject LoadingScreen;
    public float waittime1 = 4;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    public void Update()
    {
        

    }
    public void Tester(float score)
    {
        if (score >= 10)
        {
            InvokeRepeating("JoeUpdate", 0, 1f);
        }
    }
    public void JoeUpdate()
    {
        waittime1 -= Time.deltaTime;
        if (waittime1 == 2)
        {
            Debug.Log("You Win!");
            Crosshair.SetActive(false);
            Timer.SetActive(false);
            Score.SetActive(false);
        }
        if (waittime1 == 0)
        {
            LoadingScreen.SetActive(true);
        }
    }

}
//everything fades to black, "You Win!, First Level Complete"
//start loading next scene
//loading screen appears
