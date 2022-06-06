#region

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

#endregion

public class FinalSceneBad : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(41);
        SceneManager.LoadScene("MainMenu");
    }
}