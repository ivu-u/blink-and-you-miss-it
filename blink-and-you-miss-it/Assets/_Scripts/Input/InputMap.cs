using UnityEngine;

public abstract class InputMap
{
    protected ActionMap actionMap;

    public InputMap(ActionMap actionMap) {
        this.actionMap = actionMap;
    }

    public abstract void EnableMap();
}
