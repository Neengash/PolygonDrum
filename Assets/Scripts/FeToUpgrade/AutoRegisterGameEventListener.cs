using FeTo.SOArchitecture;

public class AutoRegisterGameEventListener : GameEventListener
{
    private void OnEnable() {
        Event.RegisterListener(this);
    }

    private void OnDisable() {
        Event.UnregisterListener(this);
    }
}
