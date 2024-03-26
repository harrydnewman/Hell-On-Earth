using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CS5FadeToWhite2 : MonoBehaviour
{
    public GameObject whiteOutSquare;
    public GameObject blackImage;
    public GameObject blackOutSquare;
    public SceneLoader sceneLoader;
    private float xRange = -54f;
    private float yrange = -29f;

    void Awake()
    {
        blackImage.gameObject.SetActive(false);
        StartCoroutine(UnFadeBlackOutSquare());
        StartCoroutine(UnFadeWhiteOutSquare());
        //blackOutSquare.gameObject.SetActive(false);
    }

   // void Start()
    //{
        //StartCoroutine(FadeWhiteOutSquare());
        //blackOutSquare.gameObject.SetActive(true);

    //}

    void Update()
    {
        if (transform.position.x > xRange && transform.position.y < yrange)
        {
            
            Debug.Log("Hey Girl");
            Debug.Log(whiteOutSquare.GetComponent<Image>().color.a);
            StartCoroutine(FadeWhiteOutSquare());
        }
    }

    public IEnumerator FadeWhiteOutSquare(bool fadeToBlack = true, float fadeSpeed = 5f)
    {
        Debug.Log("Starting Fade");
        Color objectColor = whiteOutSquare.GetComponent<Image>().color;
        float fadeAmount;

        if (fadeToBlack)
        {
            while (whiteOutSquare.GetComponent<Image>().color.a < 1)
            {
                //Debug.Log(whiteOutSquare.GetComponent<Image>().color.a);
                fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                whiteOutSquare.GetComponent<Image>().color = objectColor;
                yield return null;
            }

            if (whiteOutSquare.GetComponent<Image>().color.a > 0.9)
            {
                //whiteOutSquare.SetActive(false);
                blackOutSquare.SetActive(true);
                
                StartCoroutine(FadeBlackOutSquare());
                //StartCoroutine(UnFadeWhiteOutSquare());
               
            }
        }

    }
    public IEnumerator UnFadeWhiteOutSquare(bool fadeToBlack = true, float fadeSpeed = 4f)
    {
        Debug.Log("Starting UnFade");
        Color objectColor = whiteOutSquare.GetComponent<Image>().color;
        float fadeAmount;
        while (whiteOutSquare.GetComponent<Image>().color.a > 0)
        {
            fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            whiteOutSquare.GetComponent<Image>().color = objectColor;

            // Add a condition to exit the loop
            if (whiteOutSquare.GetComponent<Image>().color.a < 0f)
            {
                
                break;
            }

            yield return null;
        }
    }
    public IEnumerator FadeBlackOutSquare(bool fadeToBlack = true, float fadeSpeed = 4f)
    {
        Debug.Log("Starting Fade");
        Color objectColor = blackOutSquare.GetComponent<Image>().color;
        float fadeAmount;
        
        if (fadeToBlack)
        {
            while (blackOutSquare.GetComponent<Image>().color.a < 1)
            {
                fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);
                Debug.Log(blackOutSquare.GetComponent<Image>().color.a);
                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackOutSquare.GetComponent<Image>().color = objectColor;
                yield return null;
            }

            if (blackOutSquare.GetComponent<Image>().color.a > 0.5)
            {

                blackImage.gameObject.SetActive(true);
            }
            if (blackOutSquare.GetComponent<Image>().color.a > 0.8)
            {
                
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
            if (blackOutSquare.GetComponent<Image>().color.a < 0f)
            {
                break;
            }

            yield return null;
        }
    }
    
}
