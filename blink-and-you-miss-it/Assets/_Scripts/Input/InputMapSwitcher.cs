using UnityEngine;
using UnityEngine.InputSystem;

public class InputMapSwitcher : MonoBehaviour
{
    private InputActionMap _inputs;
    public InputActionMap Inputs { get { return _inputs; } }

    void Awake() {
        _inputs = new InputActionMap();
    }
}
