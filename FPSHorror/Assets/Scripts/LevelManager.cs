#region

using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#endregion

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    [SerializeField] private GameObject loaderCanvas;
    [SerializeField] private Image _progressBar;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public async void LoadLevel(string sceneName)
    {
        var scene = SceneManager.LoadSceneAsync(sceneName);
        scene.allowSceneActivation = false;
        
        loaderCanvas.SetActive(true);

        do
        {
            await Task.Delay(1);
            _progressBar.fillAmount = scene.progress;
        } while (scene.progress < 0.9f);
        
        scene.allowSceneActivation = true;
        loaderCanvas.SetActive(false);
        
    }
}