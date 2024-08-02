using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathHandler : MonoBehaviour
{
    public Canvas gameOverCanvas;
    private void Start()
    {
        gameOverCanvas.enabled = false;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if( other.gameObject.CompareTag("Wall") )
        {
            HandleDeath();
        }
    }
    public void HandleDeath()
    {
        gameOverCanvas.enabled = true;
        Time.timeScale = 0;
    }
}
