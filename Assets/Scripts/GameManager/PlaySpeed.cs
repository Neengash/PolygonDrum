using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySpeed : MonoBehaviour
{
    private void Awake() {
        Time.timeScale = 0.9f;
    }
}
