#region

using UnityEngine;
using UnityEngine.SceneManagement;

#endregion

public class EnemyChoose : MonoBehaviour
{
    public bool isTrigger;
    public GameObject enemy;
    public GameObject enemyPanel;

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "7")
            //enemyPanel.SetActive(false);
            enemy.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) //enemyPanel.SetActive(true);
            isTrigger = true;
        Time.timeScale = 0;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) //enemyPanel.SetActive(false);
            isTrigger = false;
    }

    private void Update()
    {
        if (isTrigger && Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("EvetSon");
            Debug.Log("EvetSon");
        }

        if (isTrigger && Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("HayirSon");
            Debug.Log("HayirSon");
        }

        // if (isTrigger)
        // {
        //     new WaitForSeconds(10);
        //     SceneManager.LoadScene("SecimsizSon");
        //     Debug.Log("SecimsizSon");
        // }
    }
}