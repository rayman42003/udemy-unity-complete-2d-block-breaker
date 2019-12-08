using UnityEngine;

public class Attachable : MonoBehaviour
{
    [SerializeField]
    private GameObject parentObject = null;

    [SerializeField]
    private Vector2 offset = new Vector2();

    private bool originalSimulatedValue;

    public void detach() {
        transform.parent = null;
        var rigidbody2d = gameObject.GetComponent<Rigidbody2D>();
        if (rigidbody2d) {
            rigidbody2d.simulated = originalSimulatedValue;
        }
    }

    public void attach() {
        var rigidbody2d = gameObject.GetComponent<Rigidbody2D>();
        if (rigidbody2d) {
            originalSimulatedValue = rigidbody2d.simulated;
            rigidbody2d.simulated = false;
        }

        transform.parent = parentObject.transform;
        transform.position = getOffsetFromGameObj(parentObject, offset);
    }

    private void Start() {
        attach();
    }

    private void Update() {
    }

    private Vector2 getOffsetFromGameObj(GameObject gameObj, Vector2 offset) {
        Vector2 gameObjPos = new Vector2(gameObj.transform.position.x, gameObj.transform.position.y);
        return gameObjPos + offset;
    }
}
