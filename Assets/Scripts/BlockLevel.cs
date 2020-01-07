using UnityEngine;
using UnityEngine.Events;

public class BlockLevel : MonoBehaviour
{
    [SerializeField]
    private int numBlocks = 0;

    [SerializeField]
    private UnityEvent onLevelCleared = new UnityEvent();

    public void addBlock() {
        numBlocks++;
    }

    public void removeBlock() {
        numBlocks--;
        if (numBlocks <= 0) {
            onLevelCleared.Invoke();
        }
    }
}
