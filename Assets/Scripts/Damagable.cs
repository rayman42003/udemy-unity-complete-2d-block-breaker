using UnityEngine;

public class Damagable : MonoBehaviour
{
    [SerializeField]
    private int hitPoints = 1;

    [SerializeField]
    private int pointValue = 100;

    [SerializeField]
    private ScorableEvent onKilled = new ScorableEvent();

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
        onKilled.Invoke(pointValue);
        Destroy(gameObject);
    }
}
