#region

using UnityEngine;
using UnityEngine.SceneManagement;

#endregion

public class LevelChanger : MonoBehaviour
{
    public GameObject door;
    public GameObject doorUI;
    public bool isOpen;
    public bool isTrigger;
    private Transform doorRotation;
    private Animator doorAnim;
    public AudioSource doorSoundOpen;
    public AudioSource doorSoundClose;
    public string nextScene;
    public GameObject player;
    private SaveSystem saveSystem;

    private void Start()
    {
        isOpen = false;
        isTrigger = false;
        doorAnim = door.GetComponent<Animator>();
        saveSystem = player.GetComponent<SaveSystem>();
    }

    private void Update()
    {
        if (isTrigger)
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (isOpen == false)
                {
                    SceneManager.LoadSceneAsync(nextScene);
                    PlayerPrefs.SetInt("isSceneChanged", 1);
                    doorSoundOpen.Play();
                    isOpen = true;
                }
                else
                {
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