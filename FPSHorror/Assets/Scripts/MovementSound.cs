using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    public void PlaySound(int clip)
    {
        audioSource.clip = audioClips[clip];
        audioSource.Play();
    }

    private void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = audioClips[0];
            audioSource.Play();
        }
    }
}
