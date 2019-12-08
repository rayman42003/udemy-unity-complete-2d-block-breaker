using UnityEngine;

public class MouseMovable : MonoBehaviour
{
    [SerializeField]
    private float leftPad = 1;

    [SerializeField]
    private float rightPad = 1;

    [SerializeField]
    private Camera mainCamera;

    private void Start() {
    }

    private void Update() {
        var widthInWorldUnits = mainCamera.orthographicSize * 2 * Screen.width / Screen.height;
        var mouseXPosInWorldUnits = Input.mousePosition.x / Screen.width * widthInWorldUnits;
        var paddleXPos = Mathf.Clamp(mouseXPosInWorldUnits, leftPad, widthInWorldUnits - rightPad);
        Vector2 paddlePos = new Vector2(paddleXPos, transform.position.y);
        transform.position = paddlePos;
    }
}
