using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponContext
{
    private Animator _weaponAnimator;
    private InputActionProperty _triggerValue;
    private InputActionProperty _gripValue;
    private GameObject _blast;
    private GameObject _blastSpawnOffset;

    //Constructor
    public WeaponContext(Animator animator, InputActionProperty triggerValue, InputActionProperty gripValue, GameObject blast, GameObject blastSpawnOffset)
    {
        _weaponAnimator = animator;
        _triggerValue = triggerValue;
        _gripValue = gripValue;
        _blast = blast;
        _blastSpawnOffset = blastSpawnOffset;
    }

    // Read-only properties
    public Animator WeaponAnimator => _weaponAnimator;
    public InputActionProperty TriggerValue => _triggerValue;
    public InputActionProperty GripValue => _gripValue;
    public GameObject Blast => _blast;
    public GameObject BlastSpawnOffset => _blastSpawnOffset;
}
