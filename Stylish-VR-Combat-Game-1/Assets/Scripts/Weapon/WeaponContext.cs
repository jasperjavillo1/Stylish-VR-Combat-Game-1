using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponContext
{
    private Animator _weaponAnimator;
    private InputActionProperty _triggerValue;
    private InputActionProperty _gripValue;

    //Constructor
    public WeaponContext(Animator animator, InputActionProperty triggerValue, InputActionProperty gripValue)
    {
        _weaponAnimator = animator;
        _triggerValue = triggerValue;
        _gripValue = gripValue;
    }

    // Read-only properties
    public Animator WeaponAnimator => _weaponAnimator;
    public InputActionProperty TriggerValue => _triggerValue;
    public InputActionProperty GripValue => _gripValue;
}
