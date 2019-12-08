using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverChecker : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        gameOver();
    }

    private void gameOver() {
        SceneManager.LoadScene("99-game-over");
    }
}
