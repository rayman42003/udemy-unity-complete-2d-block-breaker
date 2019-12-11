using UnityEngine;

public class Audible : MonoBehaviour
{
    private AudioSource myAudioSource;

    public void playSound() {
        myAudioSource.Play();
    }

    private void Start() {
        myAudioSource = GetComponent<AudioSource>();
    }
}
