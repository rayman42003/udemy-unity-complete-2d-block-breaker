using UnityEngine;

public class MouseMovable : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;

    private void Start() {
    }

    private void Update() {
        var widthInWorldUnits = mainCamera.orthographicSize * 8 / 3;
        var mouseXPosInWorldUnits = Input.mousePosition.x / Screen.width * widthInWorldUnits;
        Vector2 paddlePos = new Vector2(mouseXPosInWorldUnits, transform.position.y);
        transform.position = paddlePos;
    }
}
