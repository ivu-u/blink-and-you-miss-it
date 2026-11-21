using UnityEngine;
using UnityEngine.InputSystem;

public class TypingMap : InputMap {
    public TypingMap(ActionMap actionMap) : base(actionMap) {}

    public event System.Action OnKeyPressPerformed;

    public override void EnableMap() {
        actionMap.TypingMinigame.Enable();

        actionMap.TypingMinigame.KeyPress.performed += KeyPressPerformed;
    }

    private void KeyPressPerformed(InputAction.CallbackContext _) =>
        OnKeyPressPerformed?.Invoke();

}
