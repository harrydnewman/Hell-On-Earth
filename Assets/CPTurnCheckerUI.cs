using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CPTurnCheckerUI : MonoBehaviour
{
    public GameObject TextObject;
    public TMP_Text tmpText;
    public bool isPlayerTurn = true;
    // Start is called before the first frame update
    void Start()
    {
        tmpText = TextObject.GetComponent<TMP_Text>();
        tmpText.text = "Player's Turn";
    }

    public void ChangeTurn(bool turn)
    {
        if(turn == true)
        {
            tmpText.text = "Player's Turn";
        }
        else if (turn == false)
        {
            tmpText.text = "Enemy's Turn";
        }
        isPlayerTurn = turn;
    }
}
