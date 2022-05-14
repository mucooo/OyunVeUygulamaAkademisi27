#region

using UnityEngine;
using UnityEngine.SceneManagement;

#endregion

public class GameManager : MonoBehaviour
{
    private void Update()
    {
        checkESC();
    }

    private void checkESC()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) SceneManager.LoadScene("MainMenu");
        Debug.Log("ESC");
    }
}