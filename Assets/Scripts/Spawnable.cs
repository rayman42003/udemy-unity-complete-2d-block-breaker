using UnityEngine;
using UnityEngine.Events;

public class Spawnable : MonoBehaviour
{
    [SerializeField]
    public UnityEvent onCreate;

    private void Start() {
        onCreate.Invoke();
    }

    public void RegisterOnSpawn(UnityAction action) {
        onCreate.AddListener(action);
    }
}
