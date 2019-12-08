using UnityEngine;
using UnityEngine.Events;

public class Launchable : MonoBehaviour
{
    [SerializeField]
    private Vector2 launchForce = new Vector2();

    [SerializeField]
    private UnityEvent onLaunch = new UnityEvent();

    [SerializeField]
    private int numLaunches = 1;

    private void Start() {
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            onLaunch.Invoke();
            GetComponent<Rigidbody2D>().velocity = launchForce;

            numLaunches--;
            if (numLaunches == 0) {
                Destroy(this);
            }
        }
    }
}
