using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMemoriesCS3 : MonoBehaviour
{
    public AudioClip memories;
    public AudioSource audioSource;

    public void PlayMemories()
    {
        audioSource.PlayOneShot(memories);
    }
}
