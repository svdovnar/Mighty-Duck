using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1.0f;
    }
    public void ReloadGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
