using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CS5FadetoBlack : MonoBehaviour
{
    public GameObject blackOutSquare;
    public SceneLoader sceneLoader;
 //   private float xRange = -51f;
   // private float yrange = -29f;

    void Awake()
    {
        
        StartCoroutine(UnFadeBlackOutSquare());
        //blackOutSquare.gameObject.SetActive(false);
    }

    void Start()
    {
        //blackOutSquare.gameObject.SetActive(true);
       
    }

    public IEnumerator FadeBlackOutSquare(bool fadeToBlack = true, float fadeSpeed = 5f)
    {
        Debug.Log("Starting Fade");
        Color objectColor = blackOutSquare.GetComponent<Image>().color;
        float fadeAmount;

        if (fadeToBlack)
        {
            while (blackOutSquare.GetComponent<Image>().color.a < 1)
            {
                fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackOutSquare.GetComponent<Image>().color = objectColor;
                yield return null;
            }

            if (blackOutSquare.GetComponent<Image>().color.a > 1)
            {
                Debug.Log("Hello");
                sceneLoader.LoadScene();
            }
        }
        
    }
    public IEnumerator UnFadeBlackOutSquare(bool fadeToBlack = true, float fadeSpeed = 300f)
    {
        Debug.Log("Starting UnFade");
        Color objectColor = blackOutSquare.GetComponent<Image>().color;
        float fadeAmount;
        while (blackOutSquare.GetComponent<Image>().color.a > 0)
        {
            fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            blackOutSquare.GetComponent<Image>().color = objectColor;

            // Add a condition to exit the loop
            if (Mathf.Approximately(objectColor.a, 0f))
            {
                break;
            }

            yield return null;
        }
    }
}
