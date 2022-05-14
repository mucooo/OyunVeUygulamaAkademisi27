using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRaycast : MonoBehaviour
{
    [SerializeField] private int rayLength = 5;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private string excludeTag = null;
    
    private DoorController doorControler;

    [SerializeField] private KeyCode openKey = KeyCode.E;
    [SerializeField] private KeyCode closeKey = KeyCode.E;

    private bool isCrosshairVisible;
    private bool doOnce;
    
    private const string interactableTag = "Interactable";

    private void Update()
    {
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        
        int mask = 1 << LayerMask.NameToLayer(excludeTag) | layerMask.value;

        if (Physics.Raycast(transform.position, forward, out hit, rayLength, mask))
        {
            if (hit.collider.CompareTag(interactableTag))
            {
                if(!doOnce)
                {
                    doorControler = hit.collider.GetComponent<DoorController>();
                    
                }
                doOnce = true;
                if (Input.GetKeyDown(openKey))
                {
                    doorControler.OpenDoor();
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(closeKey))
            {
                doorControler = null;
            }
        }
        {
            
        }
    }
}
