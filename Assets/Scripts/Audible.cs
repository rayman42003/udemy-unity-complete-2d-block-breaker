using UnityEngine;

public class Audible : MonoBehaviour
{
    [SerializeField]
    private bool playAtCamera = false;

    private AudioSource audioSource;

    public void playSound() {
        if (playAtCamera) {
            AudioSource.PlayClipAtPoint(audioSource.clip, Camera.main.transform.position,
                audioSource.volume);
        } else {
            audioSource.Play();
        }
    }

    private void Start() {
        audioSource = GetComponent<AudioSource>();
    }
}
