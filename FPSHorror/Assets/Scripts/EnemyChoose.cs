#region

using UnityEngine;
using UnityEngine.SceneManagement;

#endregion

public class EnemyChoose : MonoBehaviour
{
    public bool isTrigger;
    public GameObject enemy;
    public GameObject enemyPanel;
    public AudioSource gunUsed;

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "7")
            //enemyPanel.SetActive(false);
            enemy.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enemyPanel.SetActive(true);
            isTrigger = true;
        }

        Time.timeScale = 0;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTrigger = false;
            enemyPanel.SetActive(false);
        }
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
            gunUsed.PlayOneShot(gunUsed.clip);
            WaitForSeconds wait = new WaitForSeconds(6);
            SceneManager.LoadSceneAsync("HayirSon");
            Debug.Log("HayirSon");
        }
    }
}