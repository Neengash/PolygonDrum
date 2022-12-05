using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FeTo.SOArchitecture;
using FeTo.ObjectPool;

public class NoteSpawner : MonoBehaviour
{
    [SerializeField] FloatReference noteSpawnSpeed;

    [SerializeField] ObjectPool[] notePools;

    Coroutine spawnCoroutine;

    public void StartSpawn() {
        spawnCoroutine = StartCoroutine(NoteSpawnCoroutine());
    }

    private IEnumerator NoteSpawnCoroutine() {
        while(true) {
            SpawnNote();
            yield return new WaitForSeconds(noteSpawnSpeed);
        }
    }

    private void SpawnNote() {
        int sourcePool = Random.Range(0, notePools.Length);
        PlayableNote note = (PlayableNote)notePools[sourcePool].GetNext();
        note.transform.position = this.transform.position;
        note.gameObject.SetActive(true);
    }

    public void EndSpawn() {
        StopCoroutine(spawnCoroutine);
    }

}
