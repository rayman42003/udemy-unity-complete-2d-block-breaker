using UnityEngine;
using UnityEngine.Events;

public class Collidable : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onCollide = new UnityEvent();

    private void OnCollisionEnter2D(Collision2D collision) {
        onCollide.Invoke();
    }
}
