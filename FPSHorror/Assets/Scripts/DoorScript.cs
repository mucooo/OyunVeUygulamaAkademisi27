using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Transform playerCamera;
    [Header("MaxDistance you can open or close the door.")]
    public float maxDistance = 30;

    private bool _opened = false;
    private Animator _anim;
    private static readonly int Opened = Animator.StringToHash("opened");


    void Update()
    {
        //This will tell if the player press F on the Keyboard. P.S. You can change the key if you want.
        if (Input.GetKeyDown(KeyCode.F))
        {
            Pressed();
            //Delete if you dont want Text in the Console saying that You Press F.
            Debug.Log("You Press F");
        }
    }

    void Pressed()
    {
        //This will name the Raycasthit and came information of which object the raycast hit.
        RaycastHit doorhit;

        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out doorhit, maxDistance))
        {

            // if raycast hits, then it checks if it hit an object with the tag Door.
            if (doorhit.transform.CompareTag("Door"))
            {

                //This line will get the Animator from  Parent of the door that was hit by the raycast.
                _anim = doorhit.transform.GetComponentInParent<Animator>();

                //This will set the bool the opposite of what it is.
                _opened = !_opened;

                //This line will set the bool true so it will play the animation.
                _anim.SetBool(Opened, !_opened);
            }
        }
    }
}

//YouTube Channel Twin Gaming Studios :P