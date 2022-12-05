using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FeTo.SOArchitecture;

public class GameOverRaise : MonoBehaviour
{
    [SerializeField] GameEvent GameOver;
    [SerializeField] BoolVariable isPlaying;
    [SerializeField] FloatVariable timeRemaining;

    private void Update() {
        if (isPlaying.Value && timeRemaining.Value <= 0) {
            isPlaying.Value = false;
            timeRemaining.Value = 0f;
            GameOver.Raise();
        }
    }
}
