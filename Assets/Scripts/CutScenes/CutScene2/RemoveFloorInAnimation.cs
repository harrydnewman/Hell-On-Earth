using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveFloorInAnimation : MonoBehaviour
{
    public GameObject trapdoor;
   

    public void FloorGoBye()
    {
        trapdoor.gameObject.SetActive(false);
        
    }
}
