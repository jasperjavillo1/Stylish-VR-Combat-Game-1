using UnityEngine;

public class GunState : WeaponState
{
    protected float _chargeLevel = 0;
    public GunState(WeaponContext context, WeaponStateMachine.EWeaponState estate) : base(context, estate)
    {
        WeaponContext Context = context;
    }

    public override void EnterState()
    {
        base.EnterState();
        Context.WeaponAnimator.SetBool("isSword", false);
        Context.WeaponAnimator.SetBool("isShield", false);
        Context.WeaponAnimator.SetBool("isRange", true);
    }

    public override void UpdateState()
    {
        base.UpdateState();
        ChargeWeapon();
        FireWeapon();
    }

    public override void ExitState()
    {
        _chargeLevel = 0; // Reset charge level when exiting the state
    }
    public override WeaponStateMachine.EWeaponState GetNextState()
    {
        if (Context.GripValue.action.IsPressed())
        {
            return WeaponStateMachine.EWeaponState.Sword;
        }
        else{
            return StateKey;
        }
    }
    public override void OnTriggerEnter(Collider other){}
    public override void OnTriggerStay(Collider other){}
    public override void OnTriggerExit(Collider other){}

    protected void ChargeWeapon()
    {
        // Implement the logic for charging the weapon here
        // For example, you can increase a charge level over time while the trigger is held down
        if (Context.TriggerValue.action.IsPressed() && _chargeLevel < 60)
        {
            _chargeLevel++;
            // You can add additional logic here, such as updating a UI element to show the charge level
        }
    }

    protected void FireWeapon()
    {
        // Implement the logic for firing the weapon here
        // For example, you can instantiate a projectile or apply damage to a target
        if (Context.Blast != null && Context.BlastSpawnOffset != null && Context.TriggerValue.action.WasReleasedThisFrame())
        {
            GameObject blastInstance = GameObject.Instantiate(Context.Blast, Context.BlastSpawnOffset.transform.position, Context.BlastSpawnOffset.transform.rotation);
            // Add any additional logic for the blast instance, such as applying force or damage
            Blast blastScript = blastInstance.GetComponent<Blast>();
            if (blastScript != null)
            {
                blastScript.MaxDistance = _chargeLevel; // Set the max distance based on the charge level
                _chargeLevel = 0; // Reset charge level after firing
            }
        }
    }
    
}
