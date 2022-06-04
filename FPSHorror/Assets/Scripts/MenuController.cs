#region

using UnityEngine;

#endregion

public class MenuController : MonoBehaviour
{
    public GameObject menu;
    public GameObject settings;
    public SaveSystem saveSystem;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y)) menu.SetActive(true);

        if (menu.activeSelf)
        {
            Time.timeScale = 0;
            UnlockMouse();
        }
    }


    private void LockMouse()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void UnlockMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Continue() //continue the game
    {
        menu.SetActive(!menu.activeSelf);
        LockMouse();
        Time.timeScale = 1;
    }

    public void Settings() //settings menu
    {
        settings.SetActive(!settings.activeSelf);
        menu.SetActive(!menu.activeSelf);
    }

    public void SaveGameButton() //save game button
    {
        saveSystem.SavePlayerPosition();
        saveSystem.SaveFlashlight();
    }
}