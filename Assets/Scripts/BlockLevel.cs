using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BlockLevel : MonoBehaviour
{
    private HashSet<int> blockIds = new HashSet<int>();

    [Range(0.1f, 2.0f)]
    [SerializeField]
    private float gameSpeed = 0.5f;

    [SerializeField]
    private Text scoreText;

    [SerializeField]
    private UnityEvent onLevelCleared = new UnityEvent();

    public void removeBlock(Damagable block) {
        blockIds.Remove(block.gameObject.GetInstanceID());
        if (blockIds.Count <= 0) {
            onLevelCleared.Invoke();
        }
    }

    public void updateScore(int score) {
        scoreText.text = score.ToString();
    }

    private void Start() {
        foreach (Block block in FindObjectsOfType<Block>()) {
            blockIds.Add(block.gameObject.GetInstanceID());
        }
    }

    private void Update() {
        Time.timeScale = gameSpeed;
    }
}
