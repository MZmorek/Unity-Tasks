using UnityEngine;
public abstract class BaseState
{
    protected StateMachine stateMachine;

    public BaseState(StateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }

    public virtual void EnterState()
    {

    }

    public virtual void DestroyState()
    {

    }

}

