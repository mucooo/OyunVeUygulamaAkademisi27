#region

using UnityEngine;
using UnityEngine.SceneManagement;

#endregion

public class FinalScene : MonoBehaviour
{
    public GameObject image;
    public GameObject text;
    public bool keyActive;
    public float timer;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        image.SetActive(true);
        text.SetActive(true);
        Debug.Log("FinalScene");
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) SceneManager.LoadScene("MainMenu");
    }
}