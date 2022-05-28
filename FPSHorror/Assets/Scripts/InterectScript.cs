#region

using UnityEngine;

#endregion

public class InterectScript : MonoBehaviour
{
    public GameObject player;
    public GameObject book;
    public GameObject panel;
    public GameObject bookPanel;
    private bool inTrigger;

    private void Start()
    {
        panel.SetActive(false);
        bookPanel.SetActive(false);
        inTrigger = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) panel.SetActive(true);
        inTrigger = true;
    }

    private void Update()
    {
        if (inTrigger)
            if (Input.GetKeyDown(KeyCode.E))
            {
                bookPanel.SetActive(true);
                panel.SetActive(false);
                inTrigger = false;
            }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            panel.SetActive(false);
            bookPanel.SetActive(false);
            inTrigger = false;
        }
    }
}