using UnityEngine;
using FeTo.SOArchitecture;
using FeTo.ObjectPool;

[RequireComponent(typeof(GameEventListener))]
public class PlayableNote : PoolableObject
{
    [SerializeField] string compassTag, bottomTag;
    [SerializeField] BoolVariable canPressNote;
    [SerializeField] GameEvent pressedNoteEvent;
    [SerializeField] FloatVariable score;
    GameEventListener eventListener;

    private void Awake() {
        eventListener = GetComponent<GameEventListener>();
        eventListener.Response.AddListener(ScoreNote);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag(compassTag)) {
            canPressNote.Value = true;
            pressedNoteEvent.RegisterListener(eventListener);
        } else if (collision.gameObject.CompareTag(bottomTag)) {
            score.Value -= 1;
            DestroyNote();
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.gameObject.CompareTag(compassTag)) {
            canPressNote.Value = false;
            pressedNoteEvent.UnregisterListener(eventListener);
        }
    }

    public void ScoreNote() {
        score.Value += 1;
        DestroyNote();
    }

    public void DestroyNote() {
        gameObject.SetActive(false);
    }
}
