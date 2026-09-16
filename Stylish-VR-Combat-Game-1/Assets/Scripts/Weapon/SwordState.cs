using UnityEngine;

public class SwordState : WeaponState
{
    public SwordState(WeaponContext context, WeaponStateMachine.EWeaponState estate) : base(context, estate)
    {
        WeaponContext Context = context;
    }
    public override void EnterState()
    {
        base.EnterState();
        Context.WeaponAnimator.SetBool("isRange", false);
        Context.WeaponAnimator.SetBool("isShield", false);
        Context.WeaponAnimator.SetBool("isSword", true);
    }
    public override void UpdateState()
    {
        base.UpdateState();
    }
    public override void ExitState()
    {
        
    }
    public override WeaponStateMachine.EWeaponState GetNextState()
    {
        if (!Context.GripValue.action.IsPressed())
        {
            return WeaponStateMachine.EWeaponState.Gun;
        }
        else if (Context.TriggerValue.action.IsPressed())
        {
            return WeaponStateMachine.EWeaponState.Shield;
        }
        else{
            return StateKey;
        }
    }
    public override void OnTriggerEnter(Collider other){}
    public override void OnTriggerStay(Collider other){}
    public override void OnTriggerExit(Collider other){}
}
