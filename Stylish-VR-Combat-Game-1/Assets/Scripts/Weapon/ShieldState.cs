using UnityEngine;

public class ShieldState : WeaponState
{
    public ShieldState(WeaponContext context, WeaponStateMachine.EWeaponState estate) : base(context, estate)
    {
        WeaponContext Context = context;
    }
    public override void EnterState(){}
    public override void UpdateState(){}
    public override void ExitState(){}
    public override WeaponStateMachine.EWeaponState GetNextState()
    {
        return StateKey;
    }
    public override void OnTriggerEnter(Collider other){}
    public override void OnTriggerStay(Collider other){}
    public override void OnTriggerExit(Collider other){}
}
