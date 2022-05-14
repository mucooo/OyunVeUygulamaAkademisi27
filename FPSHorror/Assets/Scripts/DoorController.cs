using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator doorAnimation;
    private bool doorOpen = false;

    private void Awake()
    {
        doorAnimation = GetComponent<Animator>();
    }
    
    public void OpenDoor()
    {
        if (!doorOpen)
        {
            doorAnimation.Play("DoorOpen", 0, 0.0f);
            doorOpen = true;
        }
        else
        {
            doorAnimation.Play("DoorClose", 0, 0.0f);
            doorOpen = false;
        }
    }
}
