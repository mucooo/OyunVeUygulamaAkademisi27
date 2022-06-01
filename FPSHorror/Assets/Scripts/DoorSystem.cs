#region

using UnityEngine;

#endregion

public class DoorSystem : MonoBehaviour
{
    public GameObject door;
    public GameObject doorUI;
    public bool isOpen;
    public bool isTrigger;
    private Transform doorRotation;
    private Animator doorAnim;
    public AudioSource doorSoundOpen;
    public AudioSource doorSoundClose;

    private void Start()
    {
        isOpen = false;
        isTrigger = false;
        doorAnim = door.GetComponent<Animator>();
    }

    private void Update()
    {
        if (isTrigger)
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (isOpen == false)
                {
                    doorAnim.Play("DoorOpen", 0, -0.7f);
                    doorSoundOpen.Play();
                    isOpen = true;
                }
                else
                {
                    doorAnim.Play("DoorClose", 0, 0.3f);
                    doorSoundClose.Play();
                    isOpen = false;
                }
            }
    }
    // TODO: Change to isOpen values in Update function

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTrigger = true;
            doorUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTrigger = false;
            doorUI.SetActive(false);
        }
    }
}