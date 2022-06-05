using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{
    public GameObject weapon;
    public GameObject textUnderWeapon;
    public bool isTriggerWeapon;

    private void Start()
    {
        weapon.SetActive(false);
        textUnderWeapon.SetActive(false);
        isTriggerWeapon = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        isTriggerWeapon = true;
        if (other.CompareTag("Player") && isTriggerWeapon)
        {
            textUnderWeapon.SetActive(true);
            weapon.SetActive(true);
        }
    }
}
