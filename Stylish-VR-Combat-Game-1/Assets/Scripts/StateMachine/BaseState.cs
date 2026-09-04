using UnityEngine;
using System;

public abstract class BaseState<EState> where EState : Enum
{
    BaseState(EState stateKey)
    {
        StateKey = stateKey;
    }

    public abstract EState StateKey { get; protected set;}

    public abstract void EnterState();
    public abstract void ExitState();
    public abstract void UpdateState();
    public abstract EState GetNextState();
    public abstract void OnTriggerEnter(Collider other);
    public abstract void OnTriggerStay(Collider other);
    public abstract void OnTriggerExit(Collider other);
    

}
