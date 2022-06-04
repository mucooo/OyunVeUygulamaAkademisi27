#region

using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#endregion

public class MenuScripts : MonoBehaviour
{
    #region MainMenu

    public Button startGameButton;
    public Button loadGameButton;
    public Button settingsButton;
    public Button creditsButton;
    public GameObject AyarlarPanel;
    public SaveSystem saveSystem;
    public MenuController menuController;


    private void Start()
    {
        AyarlarPanel.SetActive(false);
    }


    public void StartGame()
    {
        SceneManager.LoadScene("1");  //1. scene
    }
    
    public void LoadGame()
    {
        Debug.Log(saveSystem.transform.position);
        Debug.Log("Load Game");
        saveSystem.LoadPlayerPosition(); //load player position
        saveSystem.LoadFlashlight(); //load flashlight
        SceneManager.LoadScene(PlayerPrefs.GetString("SceneName"));  //1. scene
    }

    public void Settings()
    {
        if (AyarlarPanel != null)
        {
            var isActive = AyarlarPanel.activeSelf;
            AyarlarPanel.SetActive(!isActive);
        }
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    #endregion

    #region SettingsPanel

    public Button backButton;
    public Button applyButton;

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Apply()
    {
        Debug.Log("Ayarlar kaydedildi.");
        SceneManager.LoadScene("MainMenu");
    }

    #endregion
}