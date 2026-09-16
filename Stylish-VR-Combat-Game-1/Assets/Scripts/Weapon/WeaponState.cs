using UnityEngine;

public abstract class WeaponState : BaseState<WeaponStateMachine.EWeaponState>
{
    protected WeaponContext Context;

    public WeaponState(WeaponContext context, WeaponStateMachine.EWeaponState stateKey) : base(stateKey)
    {
        Context = context;
    }

    public override void EnterState()
    {
        Debug.Log("Entering state: " + StateKey);
    }

    public override void UpdateState(){}
}
