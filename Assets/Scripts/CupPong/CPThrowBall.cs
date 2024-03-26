using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CPThrowBall : MonoBehaviour
{



    public GameObject ball;
    private Camera fpscam;
    public float clickcounter;
    //public GameObject PlayerBall;
    public float ballThrowingDistance = 2f;
    private float ballThrowingForce = 16f;
    public Camera EnemyCupsCamera;
    public Camera AimCamera;
    //private float zPos = 13.5f;
    public float ballThrowCount;
    public GameObject[] destroyBallObject;
    private float timer;
    public float enemyTurnCount = 0f;
    public bool playerTurn = false;
    public bool enemyTurn = false;
    public CPTimer cpTimer;
    public CPCountdown cpCountdown;
    public GameObject CountdownText;
    private int eBallPicker;
    public GameObject ballparent;
    public Transform[] hiddenballs;
    public GameObject PlayerCups;
    public GameObject enemyBall1;
    public GameObject enemyBall2;
    public GameObject enemyBall3;
    public GameObject enemyBall4;
    public GameObject enemyBall5;
    public GameObject enemyBall6;
    public GameObject enemyBall7;
    public GameObject enemyBall8;
    public GameObject enemyBall9;
    public GameObject enemyBall10;
    public GameObject FratBros;
    public CupPongAudio cpa;
    public CPTurnCheckerUI cptcui;
    [SerializeField]
    private LineRenderer LineRenderer;
    [SerializeField]
    private Transform ReleasePosition;
    //private float PlayerScore;
    [Header("Display Controls")]
    [SerializeField]
    [Range(10, 100)]
    private int LinePoints = 25;
    [SerializeField]
    [Range(0.01f, 0.25f)]
    private float TimeBetweenPoints = 0.1f;


    void Start()
    {
        fpscam = GetComponentInParent<Camera>();
        // hiddenballs = ballparent.GetComponentsInChildren<Transform>(true);
        // Debug.Log(hiddenballs);
        //ball.GetComponent<Rigidbody>().useGravity = false;

        EnemyCupsCamera.gameObject.SetActive(false);
        ballThrowCount = 0;
        clickcounter = 0;
        playerTurn = true;
        enemyTurn = false;
        enemyBall1.SetActive(false);
        enemyBall2.SetActive(false);
        enemyBall3.SetActive(false);
        enemyBall4.SetActive(false);
        enemyBall5.SetActive(false);
        enemyBall6.SetActive(false);
        enemyBall7.SetActive(false);
        enemyBall8.SetActive(false);
        enemyBall9.SetActive(false);
        enemyBall10.SetActive(false);
        PlayerCups.SetActive(true);


    }
    // Update is called once per frame
    void Update()
    {
        cptcui.ChangeTurn(playerTurn);
        //enemyBall10 = ballparent.transform.Find("EnemyBall10").gameObject;
        Debug.Log(playerTurn);
        CountdownText.SetActive(false);
        AimCamera.gameObject.SetActive(false);
        FratBros.gameObject.SetActive(true);
        fpscam.gameObject.SetActive(true);
        if (Input.GetMouseButtonDown(0) && playerTurn == true)
        {
            ballThrowCount += 1;
            if (ballThrowCount < 2)
            {
                timer = 3f;
                playerTurn = false;
                throwBall(ballThrowCount);

            }
        }
        if (Input.GetMouseButton(1) && playerTurn == true)
        {


            CountdownText.SetActive(true);
            DrawProjection();
        }
        else
        {
            LineRenderer.enabled = false;
        }

    }


    private void DrawProjection()
    {
        if (Input.GetMouseButtonDown(1))
        {
            clickcounter++;
            if (clickcounter < 2)
            {
                cpCountdown.CounterStart(6f);
            }

        }
        FratBros.gameObject.SetActive(false);
        AimCamera.gameObject.SetActive(true);
        LineRenderer.enabled = true;
        LineRenderer.positionCount = Mathf.CeilToInt(LinePoints / TimeBetweenPoints) + 1;
        Vector3 startPosition = fpscam.ViewportToWorldPoint(new Vector3(0.5f, 0.8f, 0));
        Vector3 startVelocity = ballThrowingForce * fpscam.transform.forward / ball.GetComponent<Rigidbody>().mass;
        int i = 0;
        LineRenderer.SetPosition(i, startPosition);
        for (float time = 0; time < LinePoints; time += TimeBetweenPoints)
        {
            i++;
            Vector3 point = startPosition + time * startVelocity;
            point.y = startPosition.y + startVelocity.y * time + (Physics.gravity.y / 2f * time * time);
            LineRenderer.SetPosition(i, point);

            Vector3 LastPosition = LineRenderer.GetPosition(i - 1);
        }
        if (Input.GetMouseButtonDown(0) && playerTurn == true || Input.GetButtonDown("Jump") && playerTurn == true)
        {
            FratBros.gameObject.SetActive(true);
            clickcounter = 0;
            CountdownText.SetActive(false);
            ballThrowCount += 1;
            if (ballThrowCount < 2)
            {
                timer = 3f;
                playerTurn = false;
                throwBall(ballThrowCount);
            }
        }
    }

    public void throwBall(float ballThrowCount)
    {
        //Debug.Log(ballThrowCount);
        if (ballThrowCount == 1)
        {
            PlayerCups.SetActive(false);
            EnemyCupsCamera.gameObject.SetActive(true);
            timer = 5f;
            Vector3 ballOrigin = fpscam.ViewportToWorldPoint(new Vector3(0.5f, 0.8f, 0));
            GameObject newball = Instantiate(ball, ballOrigin + fpscam.transform.forward * ballThrowingDistance, transform.rotation);
            newball.GetComponent<Rigidbody>().useGravity = true;
            newball.GetComponent<Rigidbody>().AddForce(fpscam.transform.forward * ballThrowingForce, ForceMode.Impulse);
            playerTurn = false;
            enemyTurn = true;
            cpTimer.TimerStart(timer);

        }
        else if (ballThrowCount > 1)
        {
            Debug.Log("Ball Throw Count > 1");
        }
    }

    //add enemy shit
    public void EnemyTurn(float enemyTurnCount)
    {

        //set random range of 1,15 maybe to start and if like 1 == true then enemy wins
        int eBallPicker = Random.Range(1, 11);
        //int eBallPicker = 10;
        Debug.Log(eBallPicker);
        enemyTurnCount += 1;
        Debug.Log(enemyTurnCount);
        if (enemyTurnCount == 1)
        {
            if (enemyTurnCount == 1)
            {
                if (eBallPicker == 1 && enemyTurn == true)
                {
                    playerTurn = true;
                    enemyTurn = false;
                    ballThrowCount = 0;
                    enemyBall1.SetActive(true);
                    return;
                }
                else if (eBallPicker == 2 && enemyTurn == true)
                {
                    playerTurn = true;
                    enemyTurn = false;
                    ballThrowCount = 0;
                    enemyBall2.SetActive(true);
                    return;
                }
                else if (eBallPicker == 3 && enemyTurn == true)
                {
                    playerTurn = true;
                    enemyTurn = false;
                    ballThrowCount = 0;
                    enemyBall3.SetActive(true);
                    return;
                }
                else if (eBallPicker == 4 && enemyTurn == true)
                {
                    playerTurn = true;
                    enemyTurn = false;
                    ballThrowCount = 0;
                    enemyBall4.SetActive(true);
                    return;
                }
                else if (eBallPicker == 5 && enemyTurn == true)
                {
                    playerTurn = true;
                    enemyTurn = false;
                    ballThrowCount = 0;
                    enemyBall5.SetActive(true);
                    return;
                }
                else if (eBallPicker == 6 && enemyTurn == true)
                {
                    playerTurn = true;
                    enemyTurn = false;
                    ballThrowCount = 0;
                    enemyBall6.SetActive(true);
                    return;
                }
                else if (eBallPicker == 7 && enemyTurn == true)
                {
                    playerTurn = true;
                    enemyTurn = false;
                    ballThrowCount = 0;
                    enemyBall7.SetActive(true);
                    return;
                }
                else if (eBallPicker == 8 && enemyTurn == true)
                {
                    playerTurn = true;
                    enemyTurn = false;
                    ballThrowCount = 0;
                    enemyBall8.SetActive(true);
                    return;
                }
                else if (eBallPicker == 9 && enemyTurn == true)
                {
                    playerTurn = true;
                    enemyTurn = false;
                    ballThrowCount = 0;
                    enemyBall9.SetActive(true);
                    return;
                }
                else if (eBallPicker == 10 && enemyTurn == true)
                {
                    playerTurn = true;
                    enemyTurn = false;
                    ballThrowCount = 0;
                    enemyBall10.SetActive(true);
                    return;
                }
                else if (enemyTurn = true && eBallPicker > 10)
                {
                    Debug.Log("Enemy Miss!");
                    cpa.EnemyMissesAudio();
                    playerTurn = true;
                    enemyTurn = false;
                    ballThrowCount = 0;
                    return;
                }



            }
        }
    }


    public void ResetClickCounter()
    {
        playerTurn = false;
        enemyTurn = true;
        Debug.Log("Click Counter Has Been Reset!");
        clickcounter = 0;
        timer = 1f;
        cpTimer.TimerStart(timer);

    }
}
    


