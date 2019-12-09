using UnityEngine;

public class Damagable : MonoBehaviour
{
    [SerializeField]
    private int hitPoints = 1;

    private void OnCollisionEnter2D(Collision2D collision) {
        damage();
    }

    private void damage() {
        hitPoints--;
        if (hitPoints == 0) {
            kill();
        }
    }

    private void kill() {
        Destroy(gameObject);
    }
}
