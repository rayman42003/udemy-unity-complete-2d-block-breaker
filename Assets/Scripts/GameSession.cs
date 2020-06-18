using UnityEngine;

public class GameSession : MonoBehaviour
{
    [SerializeField]
    private IntEvent onScoreUpdated = new IntEvent();

    [SerializeField]
    private static int score = 0;

    private void Awake() {
        if (FindObjectsOfType<GameSession>().Length > 1) {
            gameObject.SetActive(false);
            Destroy(gameObject);
        } else {
            DontDestroyOnLoad(gameObject);
        }

        foreach (Damagable d in FindObjectsOfType<Damagable>()) {
            d.RegisterOnKilled((point) => ChangeScore(point));
        }

        BlockLevel level = FindObjectOfType<BlockLevel>();
        level.updateScore(score);
        onScoreUpdated.RemoveAllListeners();
        onScoreUpdated.AddListener((score) => level.updateScore(score));
    }

    public void ChangeScore(int value) {
        score += value;
        onScoreUpdated.Invoke(score);
    }

    public void Reset() {
        score = 0;
    }
}
