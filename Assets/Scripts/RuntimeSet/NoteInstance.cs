using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteInstance : MonoBehaviour
{
    [SerializeField] NotesRuntimeSet notes;

    private void OnEnable() => notes.Add(this);
    private void OnDisable() => notes.Remove(this);
}
