using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioColliderBath : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.loop = true;
            audioSource.Play();
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.loop = false;
            audioSource.Stop();
        }
    }

    
}
