using UnityEngine;

public class WeaponContext
{
    private Animator _weaponAnimator;

    //Constructor
    public WeaponContext(Animator animator)
    {
        _weaponAnimator = animator;
    }

    // Read-only properties
    public Animator WeaponAnimator => _weaponAnimator;
}
