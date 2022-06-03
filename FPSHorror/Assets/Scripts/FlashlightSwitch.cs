#region

using UnityEngine;

#endregion

public class FlashlightSwitch : MonoBehaviour
{
    public GameObject flashlightOnDesk;
    public GameObject flashlightOnPlayer;
    public bool OnPlayer;
    private Flashlight_PRO flashlightScript;

    private void Start()
    {
        flashlightScript = flashlightOnPlayer.GetComponent<Flashlight_PRO>();
    }

    public void TakeFlashlight()
    {
        OnPlayer = true;
        flashlightOnPlayer.SetActive(true);
        flashlightOnDesk.SetActive(false);
        Debug.Log("Flashlight alındı.");
    }

    private void Update()
    {
        if (OnPlayer)
            if (Input.GetKeyDown(KeyCode.F))
            {
                flashlightScript.Switch();
                Debug.Log("Flashlight açık");
            }
    }
}