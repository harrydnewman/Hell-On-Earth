using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS4PlayMemories : MonoBehaviour
{
    public AudioClip memories;
    public AudioSource audioSource;

    public void Awake()
    {
        audioSource.PlayOneShot(memories);
    }
}
