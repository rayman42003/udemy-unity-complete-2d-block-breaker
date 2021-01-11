using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private float minVelocityMagnitude = 6.5f;

    [SerializeField]
    private float maxVelocityMagnitude = 8.0f;

    [SerializeField]
    private float recalibrationPeriod = 1.0f;

    [SerializeField]
    private bool shouldRecalibrate = false;

    private void Start() {
        StartCoroutine(recalibrationCooldown(recalibrationPeriod));
    }

    private void Update() {
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        float currVelocityMagnitude = rigidbody.velocity.magnitude;
        if (currVelocityMagnitude != 0 && shouldRecalibrate) {
            float clampedVelocityMagnitude = Mathf.Clamp(currVelocityMagnitude, minVelocityMagnitude, maxVelocityMagnitude);
            float scale = clampedVelocityMagnitude / currVelocityMagnitude;

            rigidbody.simulated = false;
            rigidbody.velocity *= scale;
            rigidbody.simulated = true;

            shouldRecalibrate = false;
            StartCoroutine(recalibrationCooldown(recalibrationPeriod));
        }
    }

    private IEnumerator recalibrationCooldown(float time) {
        yield return new WaitForSeconds(time);
        shouldRecalibrate = true;
    }
}
