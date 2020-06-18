using UnityEngine;
using UnityEngine.Events;

public class Damagable : MonoBehaviour
{
    [SerializeField]
    private int hitPoints = 1;

    [SerializeField]
    private int pointValue = 100;

    [SerializeField]
    private IntEvent onKilled = new IntEvent();

    [SerializeField]
    private IntEvent onDamaged = new IntEvent();

    private void OnCollisionEnter2D(Collision2D collision) {
        damage();
    }

    private void damage() {
        hitPoints--;
        if (hitPoints == 0) {
            kill();
        } else {
            onDamaged.Invoke(hitPoints);
        }
    }

    private void kill() {
        onKilled.Invoke(pointValue);
        Destroy(gameObject);
    }

    public void RegisterOnKilled(UnityAction<int> action) {
        onKilled.AddListener(action);
    }

    public void RegisterOnDamaged(UnityAction<int> action) {
        onDamaged.AddListener(action);
    }
}
