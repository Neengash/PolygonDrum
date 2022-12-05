using UnityEngine;
using FeTo.SOArchitecture;

public class StartPlay : MonoBehaviour
{
    [SerializeField] BoolVariable isPlaying;
    [SerializeField] BoolVariable[] notes;
    [SerializeField] FloatVariable remainingTime;
    [SerializeField] FloatVariable score;

    [SerializeField] FloatReference GameTime;

    public void ResetGame() {
        isPlaying.Value = true;
        remainingTime.Value = GameTime.Value;
        score.Value = 0;

        for (int i = 0; i < notes.Length; i++) {
            notes[i].Value = false;
        }
    }
}
