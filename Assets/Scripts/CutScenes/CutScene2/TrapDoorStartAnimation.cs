using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoorStartAnimation : MonoBehaviour
{
    public GameObject trapdoor;

    public void TrapDoorTurnedOn()
    {
        trapdoor.gameObject.SetActive(true);
    }
}
