using UnityEngine;
public abstract class BaseState
{
    protected StateMachine stateMachine;

    public virtual void InitializeState(StateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }

    public virtual void UpdateState()
    {

    }

    public virtual void DestroyState()
    {

    }
}

