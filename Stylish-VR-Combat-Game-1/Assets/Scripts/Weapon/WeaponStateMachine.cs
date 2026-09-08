using UnityEngine;
using UnityEngine.Assertions;

public class WeaponStateMachine : StateManager<WeaponStateMachine.EWeaponState>
{
    public enum EWeaponState
    {
        Gun,
        Sword,
        Shield
    }

    [SerializeField] private Animator _weaponAnimator;
    private WeaponContext _context;

    private void Awake()
    {
        ValidateConstraints();

        _context = new WeaponContext(_weaponAnimator);
    }

    private void ValidateConstraints()
    {
        Assert.IsNotNull(_weaponAnimator, "Weapon Animator is not assigned in the inspector.");
    }

    private void InitializeStates()
    {
        // Add States to the inherited StateManager "States" dictionary and Set Initial State
        States.Add(EWeaponState.Gun, new GunState(_context, EWeaponState.Gun));
        States.Add(EWeaponState.Sword, new SwordState(_context, EWeaponState.Sword));
        States.Add(EWeaponState.Shield, new ShieldState(_context, EWeaponState.Shield));
        CurrentState = States[EWeaponState.Gun];
    }
}
