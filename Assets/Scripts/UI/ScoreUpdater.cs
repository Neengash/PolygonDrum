using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FeTo.SOArchitecture;
using UnityEngine.UIElements;

public class ScoreUpdater : MonoBehaviour
{
    [SerializeField] FloatReference score;
    [SerializeField] BoolVariable isPlaying;
    Label scoreValueLabel;

    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        scoreValueLabel = root.Q<Label>("Score-Value");
    }

    private void Update() {
        if (isPlaying.Value) {
            scoreValueLabel.text = string.Format("{0:D3}", score);
        }
    }
}
