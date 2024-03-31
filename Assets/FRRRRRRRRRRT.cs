using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FRRRRRRRRRRT : MonoBehaviour
{
    public AudioClip fuckingRun;
    public AudioClip e;











    public AudioSource theFuckening;
    public AudioSource uvuvuvuvuuw;

    private bool firstClipPlayed = false;

    private void Start()
    {
        // i fucking fucked
        //
        //

        theFuckening.clip = fuckingRun;
        uvuvuvuvuuw.clip = e;













        uvuvuvuvuuw.loop = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        // mr e you fucking genius
        if (other.CompareTag("Player"))
        { if (!firstClipPlayed) { theFuckening.Play(); firstClipPlayed = true; }

            // i know you guys are gonna ask what the fuck
            // i dont fucking know either
            uvuvuvuvuuw.Play();
        }
    }
}