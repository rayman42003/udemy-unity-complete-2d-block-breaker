using UnityEngine;

public class BlockLevel : MonoBehaviour
{
    [SerializeField]
    private int numBlocks = 0;

    public void addBlock() {
        numBlocks++;
    }

    public void removeBlock() {
        numBlocks--;
    }
}
