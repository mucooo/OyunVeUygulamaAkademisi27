#region

using UnityEngine;

#endregion

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
        Debug.Log("Trigger before if");
        if (other.CompareTag("Player") && isTriggerWeapon)
        {
            Debug.Log("Trigger after if");
            textUnderWeapon.SetActive(true);
            weapon.SetActive(true);
            Debug.Log("Trigger after set active");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            textUnderWeapon.SetActive(true);
            weapon.SetActive(true);
        }
    }
}