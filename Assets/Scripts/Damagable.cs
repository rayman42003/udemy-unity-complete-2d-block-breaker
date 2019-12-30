using UnityEngine;
using UnityEngine.Events;

public class Damagable : MonoBehaviour
{
    [SerializeField]
    private int hitPoints = 1;

    [SerializeField]
    private UnityEvent onKilled = new UnityEvent();

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
        onKilled.Invoke();
        Destroy(gameObject);
    }
}
