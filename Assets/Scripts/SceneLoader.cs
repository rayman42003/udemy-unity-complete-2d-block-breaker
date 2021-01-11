using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene() {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int totalScenes = SceneManager.sceneCountInBuildSettings;
        int nextSceneIndex = (currentSceneIndex + 1) % totalScenes;
        StartCoroutine(delayLoad(0.3f, nextSceneIndex));
    }

    private IEnumerator delayLoad(float seconds, int sceneIndex) {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(sceneIndex);
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
