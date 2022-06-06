#region

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
    public GameObject CreditsPanel;
    public MenuController menuController;
    public GameObject DLCPanel;


    private void Start()
    {
        AyarlarPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        DLCPanel.SetActive(false);
    }


    public void StartGame()
    {
        SceneManager.LoadScene("1"); //1. scene
    }

    public void LoadGame()
    {
        Debug.Log(saveSystem.transform.position);
        Debug.Log("Load Game");
        saveSystem.LoadPlayerPosition(); //load player position
        saveSystem.LoadFlashlight(); //load flashlight
        SceneManager.LoadScene(PlayerPrefs.GetString("SceneName")); //1. scene
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
        if (CreditsPanel != null)
        {
            var isActive = CreditsPanel.activeSelf;
            CreditsPanel.SetActive(!isActive);
        }
        DLCPanel.SetActive(false);
    }

    public void DLC()
    {
        if (DLCPanel != null)
        {
            var isActive = DLCPanel.activeSelf;
            DLCPanel.SetActive(!isActive);
        }
        CreditsPanel.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
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