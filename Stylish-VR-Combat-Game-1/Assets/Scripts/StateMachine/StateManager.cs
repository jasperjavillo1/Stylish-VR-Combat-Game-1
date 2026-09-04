using System.Collections.Generic;
using System;
using UnityEngine;

public abstract class StateManager<EState> : MonoBehaviour where EState : Enum
{
    protected Dictionary<EState, BaseState<EState>> States = new Dictionary<EState, BaseState<EState>>();
    protected BaseState<EState> CurrentState;
    //protected bool isTransitioning = false;

    void Start()
    {
        CurrentState.EnterState();
    }

    void Update()
    {
        EState nextStateKey = CurrentState.GetNextState();
        if (nextStateKey.Equals(CurrentState.StateKey))
        {
            CurrentState.UpdateState();
        }
        else
        {
            TransitionToState(nextStateKey);
        }
    }

    void TransitionToState(EState stateKey)
    {
        if (States.ContainsKey(stateKey))
        {
            //isTransitioning = true;
            CurrentState.ExitState();
            CurrentState = States[stateKey];
            CurrentState.EnterState();
            //isTransitioning = false;
        }
        else
        {
            Debug.LogError($"State {stateKey} not found in the state manager.");
        }
    }

    void onTriggerEnter(Collider other)
    {
        CurrentState.OnTriggerEnter(other);
    }
    void onTriggerStay(Collider other)
    {
        CurrentState.OnTriggerStay(other);
    }
    void onTriggerExit(Collider other)
    {
        CurrentState.OnTriggerExit(other);
    }

}
