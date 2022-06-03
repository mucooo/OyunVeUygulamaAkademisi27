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


    private void Start()
    {
        AyarlarPanel.SetActive(false);
    }


    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
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