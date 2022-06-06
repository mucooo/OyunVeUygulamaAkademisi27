#region

using System;
using UnityEngine;

#endregion

public class WeaponTake : MonoBehaviour
{
    public GameObject weapon;
    public bool isTrigger;
    public WeaponSpawner weaponSpawner;
    public GameObject weaponPanel;

    private void Start()
    {
        weaponPanel.SetActive(false);
        isTrigger = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        isTrigger = true;
        weaponPanel.SetActive(true);
    }
    
    private void OnTriggerExit(Collider other)
    {
        isTrigger = false;
        weaponPanel.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        isTrigger = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && weaponSpawner.isTriggerWeapon && isTrigger)
        {
            weapon.SetActive(false);
            Debug.Log("Weapon is taken");
            weaponPanel.SetActive(false);
        }
    }
}