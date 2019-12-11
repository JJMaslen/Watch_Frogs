using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayHackingSound : MonoBehaviour
{
    public static bool playHackingSound;
    AudioSource audioCarHacking;

    // Start is called before the first frame update
    void Start()
    {
        playHackingSound = false;
        audioCarHacking = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playHackingSound == true)
        {
            audioCarHacking.Play();
            playHackingSound = false;
        }
    }
}