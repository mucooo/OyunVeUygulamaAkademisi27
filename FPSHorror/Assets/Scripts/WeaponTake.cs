#region

using UnityEngine;

#endregion

public class WeaponTake : MonoBehaviour
{
    public GameObject weapon;
    public bool isTrigger;
    public WeaponSpawner weaponSpawner;

    private void Start()
    {
        isTrigger = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        isTrigger = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && weaponSpawner.isTriggerWeapon && isTrigger)
        {
            weapon.SetActive(false);
            Debug.Log("Weapon is taken");
        }
    }
}