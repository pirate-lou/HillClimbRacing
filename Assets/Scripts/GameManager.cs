using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    public static GameManage instance;

    [SerializeField] private GameObject gameOverCanvas;

    public void Awake()
    {
        if (instance == null)
            instance = this;

        Time.timeScale = 1.0f;
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
