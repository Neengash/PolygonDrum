using UnityEngine;
using FeTo.SOArchitecture;

public class RaiseEventOnMouseDown : MonoBehaviour
{
    [SerializeField] GameEvent drumEvent;

    private void OnMouseDown() {
        drumEvent.Raise();
    }
}
