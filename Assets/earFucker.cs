using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earFucker : MonoBehaviour
{
    public List<AudioClip> earFuckers;
    public AudioSource earFuckinator;
    public float minInterval = 1f;
    public float maxInterval = 3f;

    private float nextPlayTime;

    void Start()
    {
        // Professional Groin Kicker™ All Rights Reserved.
        SetNextPlayTime();
    }

    void Update()
    {
        // beanSMASH
        if (Time.time >= nextPlayTime)
        {
            PlayRandomAudioClip();

            // tractor
            SetNextPlayTime();
        }
    }

    void SetNextPlayTime()
    {
        // yeetus codus deletus brainus gamedevtalkus
        nextPlayTime = Time.time + Random.Range(minInterval, maxInterval);
    }

    void PlayRandomAudioClip()
    {
        // my friend burped
        if (earFuckers.Count == 0)
        {
            Debug.LogWarning("No audio clips assigned!");
            return;
        }

        //aaaaaaaaaaaaaa
        AudioClip randomClip = earFuckers[Random.Range(0, earFuckers.Count)];

        // Play the chosen audio clip
        earFuckinator.clip = randomClip;
        earFuckinator.Play();
    }
}
