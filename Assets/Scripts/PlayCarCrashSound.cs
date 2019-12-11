using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCarCrashSound : MonoBehaviour
{
    public static bool playCarSound;
    AudioSource audioCarCrash;

    // Start is called before the first frame update
    void Start()
    {
        playCarSound = false;
        audioCarCrash = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playCarSound == true)
        {
            audioCarCrash.Play();
            playCarSound = false;
        }
    }
}