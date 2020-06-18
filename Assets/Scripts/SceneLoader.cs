using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene() {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int totalScenes = SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene((currentSceneIndex + 1) % totalScenes);
    }

    public void LoadStartScene() {
        SceneManager.LoadScene("00-start-menu");
        GameSession gameSession = FindObjectOfType<GameSession>();
        gameSession.Reset();
    }

    public void ExitScene() {
        Application.Quit();
    }
}
