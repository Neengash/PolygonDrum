using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using FeTo.SOArchitecture;

public class TimeUpdater : MonoBehaviour
{
    [SerializeField] FloatReference remainingTime;
    [SerializeField] BoolVariable isPlaying;
    Label timeValueLabel;

    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        timeValueLabel = root.Q<Label>("Time-Value");
    }

    private void Update() {
        if (isPlaying.Value) {
            int seconds = (int)remainingTime / 1000;
            int secondCents = (int)(remainingTime % 1000)/10;
            timeValueLabel.text = string.Format("{0:D2}:{1:D2}", seconds, secondCents);
        }
    }

    public void SetTimerTo0() {
        timeValueLabel.text = "00:00";
    }
}
