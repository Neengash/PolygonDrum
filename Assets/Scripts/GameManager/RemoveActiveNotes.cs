using UnityEngine;

public class RemoveActiveNotes : MonoBehaviour
{
    [SerializeField] NotesRuntimeSet notes;

    public void RemoveNotes() {
        // Iterate backwards so that we can remove them without damaging the list
        for (int i = notes.Items.Count -1 ; i >= 0; i--) {
            notes.Items[i].gameObject.SetActive(false);
        }
    }
}
