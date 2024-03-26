using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CS5FadetoWhite : MonoBehaviour
{
    public GameObject whiteOutSquare;
    public CS5FadetoBlack fadetoBlack;
    private float xRange = -51f;
    private float yrange = -29f;

    void Awake()
    {

        StartCoroutine(UnFadeWhiteOutSquare());
        //blackOutSquare.gameObject.SetActive(false);
    }

    void Start()
    {
        //blackOutSquare.gameObject.SetActive(true);

    }

    void Update()
    {
        if (transform.position.x > xRange && transform.position.y < yrange)
        {
            StartCoroutine(FadeWhiteOutSquare());
            Debug.Log("Hey Girl");
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
                Debug.Log(whiteOutSquare.GetComponent<Image>().color.a);
                fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                whiteOutSquare.GetComponent<Image>().color = objectColor;
                yield return null;
            }

            if (whiteOutSquare.GetComponent<Image>().color.a > 1)
            {
                fadetoBlack.FadeBlackOutSquare();
            }
        }

    }
    public IEnumerator UnFadeWhiteOutSquare(bool fadeToBlack = true, float fadeSpeed = 300f)
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
            if (Mathf.Approximately(objectColor.a, 0f))
            {
                break;
            }

            yield return null;
        }
    }
}
