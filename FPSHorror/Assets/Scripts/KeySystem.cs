#region

using UnityEngine;

#endregion

public class KeySystem : MonoBehaviour
{
    public GameObject key;
    public GameObject keyPanel;
    public bool isTriggerKey;

    private void Start()
    {
        PlayerPrefs.SetInt("Key", 0);
        isTriggerKey = false;
        keyPanel.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTriggerKey = true;
            keyPanel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTriggerKey = false;
            keyPanel.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isTriggerKey)
        {
            PlayerPrefs.SetInt("Key", 1);
            key.SetActive(false);
            Debug.Log("1.anahtar alındı");
            keyPanel.SetActive(false);
        }
    }
}