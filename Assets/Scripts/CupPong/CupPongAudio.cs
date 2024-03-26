using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupPongAudio : MonoBehaviour
{
    public AudioSource fratboy1;
    public AudioSource fratboy2;
    public AudioSource fratboy3;
    public AudioSource fratboy4;
    public AudioSource fratboy5;
    public AudioSource fratboy6;
    public AudioSource fratboy7;
    public AudioSource fratboy8;
    public AudioSource fratboy9;
    public AudioSource fratboy10;
    public AudioSource fratboy11;
    public AudioSource fratboy12;
    public AudioSource fratboy13;
    public AudioSource fratboy14;
    public AudioSource fratboy15;
    public AudioSource fratboy16;

    public AudioClip cheering;
    public AudioClip booing;
    public AudioClip bro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerScoresAudio()
    {
        fratboy1.PlayOneShot(booing, 1f);
        fratboy2.PlayOneShot(booing, 1f);
        fratboy3.PlayOneShot(booing, 1f);
        fratboy4.PlayOneShot(booing, 1f);
        fratboy5.PlayOneShot(booing, 1f);
        fratboy6.PlayOneShot(booing, 1f);
        fratboy7.PlayOneShot(booing, 1f);
        fratboy8.PlayOneShot(booing, 1f);
        fratboy9.PlayOneShot(booing, 1f);
        fratboy10.PlayOneShot(booing, 1f);
        fratboy11.PlayOneShot(booing, 1f);
        fratboy12.PlayOneShot(booing, 1f);
        fratboy13.PlayOneShot(booing, 1f);
        fratboy14.PlayOneShot(booing, 1f);
        fratboy15.PlayOneShot(booing, 1f);
        fratboy16.PlayOneShot(booing, 1f);
    }
    public void EnemyScoresAudio()
    {
        fratboy1.PlayOneShot(cheering, 1f);
        fratboy2.PlayOneShot(cheering, 1f);
        fratboy3.PlayOneShot(cheering, 1f);
        fratboy4.PlayOneShot(cheering, 1f);
        fratboy5.PlayOneShot(cheering, 1f);
        fratboy6.PlayOneShot(cheering, 1f);
        fratboy7.PlayOneShot(cheering, 1f);
        fratboy8.PlayOneShot(cheering, 1f);
        fratboy9.PlayOneShot(cheering, 1f);
        fratboy10.PlayOneShot(cheering, 1f);
        fratboy11.PlayOneShot(cheering, 1f);
        fratboy12.PlayOneShot(cheering, 1f);
        fratboy13.PlayOneShot(cheering, 1f);
        fratboy14.PlayOneShot(cheering, 1f);
        fratboy15.PlayOneShot(cheering, 1f);
        fratboy16.PlayOneShot(cheering, 1f);
    }
    public void EnemyMissesAudio()
    {
        fratboy1.PlayOneShot(bro, 1f);
        fratboy2.PlayOneShot(bro, 1f);
        fratboy3.PlayOneShot(bro, 1f);
        fratboy4.PlayOneShot(bro, 1f);
        fratboy5.PlayOneShot(bro, 1f);
        fratboy6.PlayOneShot(bro, 1f);
        fratboy7.PlayOneShot(bro, 1f);
        fratboy8.PlayOneShot(bro, 1f);
        fratboy9.PlayOneShot(bro, 1f);
        fratboy10.PlayOneShot(bro, 1f);
        fratboy11.PlayOneShot(bro, 1f);
        fratboy12.PlayOneShot(bro, 1f);
        fratboy13.PlayOneShot(bro, 1f);
        fratboy14.PlayOneShot(bro, 1f);
        fratboy15.PlayOneShot(bro, 1f);
        fratboy16.PlayOneShot(bro, 1f);
    }
}
