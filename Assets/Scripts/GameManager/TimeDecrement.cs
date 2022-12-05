using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FeTo.SOArchitecture;

public class TimeDecrement : MonoBehaviour
{
    [SerializeField] BoolVariable isPlaying;
    [SerializeField] FloatVariable timeRemaining;

    void Update() {
        if (isPlaying.Value) {
            timeRemaining.Value -= Time.deltaTime * 1000f;
        }
    }
}
