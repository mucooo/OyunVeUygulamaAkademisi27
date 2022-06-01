#region

using System;
using UnityEngine;

#endregion

public class TriggerFlashlight : MonoBehaviour
{
    public GameObject flashlightUI;
    public bool isTrigger;
    private Flashlight_PRO _flashlightPro;
    public GameObject player;
    private FlashlightSwitch _flashlightSwitchScript;

    private void Start()
    {
        flashlightUI.SetActive(false);
        isTrigger = false;
        _flashlightSwitchScript = player.GetComponent<FlashlightSwitch>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            flashlightUI.SetActive(true);
            isTrigger = true;
            Debug.Log("Trigger girildi");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _flashlightSwitchScript.TakeFlashlight();
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
}