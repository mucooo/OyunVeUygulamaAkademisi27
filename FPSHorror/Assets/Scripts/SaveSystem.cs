#region

using System;
using UnityEngine;
using UnityEngine.SceneManagement;

#endregion

public class SaveSystem : MonoBehaviour
{
    public FlashlightSwitch flashlightSwitchScript;
    public float defaultX;
    public float defaultY;
    public float defaultZ;
    private float playerPosX;
    private float playerPosY;
    private float playerPosZ;


    private void Awake()
    {
        if (PlayerPrefs.GetInt("isSceneChanged",0) == 1)
        {
            SavePlayerPosition();
            PlayerPrefs.SetInt("isSceneChanged", 0);
        }
        LoadPlayerPosition();
        LoadFlashlight();
    }
    
    public void SavePlayerPosition() //Save player's position 
    {
        var position = transform.position;
        var getSceneName = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("SceneName", getSceneName);
        PlayerPrefs.SetFloat("PlayerPosX", position.x);
        PlayerPrefs.SetFloat("PlayerPosY", position.y);
        PlayerPrefs.SetFloat("PlayerPosZ", position.z);
        Debug.Log(position);
    }

    public void LoadPlayerPosition() //Load player's position
    {
        //PlayerPrefs.GetString("SceneName", "1");
        playerPosX = PlayerPrefs.GetFloat("PlayerPosX", defaultX);
        playerPosY = PlayerPrefs.GetFloat("PlayerPosY", defaultY);
        playerPosZ = PlayerPrefs.GetFloat("PlayerPosZ", defaultZ);
        transform.position = new Vector3(playerPosX, playerPosY, playerPosZ);
    }

    public void SaveFlashlight() //Save flashlight's state
    {
        PlayerPrefs.SetInt("FlashlightOnPlayer", flashlightSwitchScript.OnPlayer ? 1 : 0);
    }

    public void LoadFlashlight() //Load flashlight's state
    {
        flashlightSwitchScript.OnPlayer = Convert.ToBoolean(PlayerPrefs.GetInt("FlashlightOnPlayer", 0));
        if (flashlightSwitchScript.OnPlayer) flashlightSwitchScript.TakeFlashlight();
    }

    // private void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.Escape))
    //     {
    //         SavePlayerPosition();
    //         SaveFlashlight();
    //         Debug.Log("Saved");
    //     }
    // }
}