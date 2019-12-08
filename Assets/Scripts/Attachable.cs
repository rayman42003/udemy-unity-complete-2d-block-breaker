using UnityEngine;

public class Attachable : MonoBehaviour
{
    [SerializeField]
    private GameObject parentObject = null;

    [SerializeField]
    private Vector2 offset = new Vector2();

    private void Start() {
        var rigidbody2d = gameObject.GetComponent<Rigidbody2D>();
        if (rigidbody2d) {
            rigidbody2d.simulated = false;
        }
    }

    private void Update() {
        Vector2 paddlePos = new Vector2(parentObject.transform.position.x, parentObject.transform.position.y);
        gameObject.transform.position = paddlePos + offset;
    }
}
