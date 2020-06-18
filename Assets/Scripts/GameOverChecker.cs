using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverChecker : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        gameOver(collision);
    }

    private void gameOver(Collider2D collision) {
        if (FindObjectsOfType<Ball>().Length <= 1) {
            SceneManager.LoadScene("99-game-over");
        }
        Destroy(collision.gameObject);
    }
}
