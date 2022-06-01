using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFlashlight : MonoBehaviour
{
    public GameObject flashlightOnDesk;
    public GameObject flashlightOnPlayer;
    public GameObject flashlightUI;
    private bool OnPlayer;
    private bool isTrigger;
    public GameObject flashlightchargeUI; //TODO: create a flashlight charge UI and charge system with battery
    
   

    private void Start()
    {
        flashlightUI.SetActive(false);
        flashlightOnPlayer.SetActive(false);
        flashlightOnDesk.SetActive(true);
        OnPlayer = false;
        isTrigger = false;
        
        if (OnPlayer == true)
        {
            flashlightchargeUI.SetActive(true);
            Debug.Log("Şarj sistemi açık");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            flashlightUI.SetActive(true);
            isTrigger = true;
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            flashlightUI.SetActive(false);
            isTrigger = false;
        }
    }

    private void Update()
    {
        if (OnPlayer == false && isTrigger == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                flashlightOnPlayer.SetActive(true);
                flashlightOnDesk.SetActive(false);
                Debug.Log("Alındı.");
                OnPlayer = true;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Zaten var.");
            }
        }
    }
}
