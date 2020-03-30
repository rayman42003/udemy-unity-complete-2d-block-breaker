﻿using UnityEngine;
using UnityEngine.Events;

public class BlockLevel : MonoBehaviour
{
    [Range(0.1f, 2.0f)]
    [SerializeField]
    private int numBlocks = 0;

    [SerializeField]
    private float gameSpeed = 0.5f;

    [SerializeField]
    private UnityEvent onLevelCleared = new UnityEvent();

    public void addBlock() {
        numBlocks++;
    }

    public void removeBlock() {
        numBlocks--;
        if (numBlocks <= 0) {
            onLevelCleared.Invoke();
        }
    }

    private void Update() {
        Time.timeScale = gameSpeed;
    }
}
