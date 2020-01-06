using UnityEngine;
using UnityEngine.Events;

public class Spawnable : MonoBehaviour
{
    [SerializeField]
    public UnityEvent onCreate;

    private void Start() {
        onCreate.Invoke();
    }
}
