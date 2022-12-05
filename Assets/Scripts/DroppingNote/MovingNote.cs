using UnityEngine;
using FeTo.SOArchitecture;

[RequireComponent(typeof(Rigidbody2D))]
public class MovingNote : MonoBehaviour
{
    [SerializeField] FloatReference SpeedMultiplier;

    Rigidbody2D rb2d;

    private void Awake() {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void OnEnable() {
        rb2d.velocity = new Vector2(0f, -1 * SpeedMultiplier);
    }
}
