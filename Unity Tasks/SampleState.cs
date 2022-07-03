using UnityEngine;

public class SampleState : BaseState
{
    public override void InitializeState(StateMachine stateMachine)
    {
        base.InitializeState(stateMachine);
        Debug.Log("Init");
    }

    public override void UpdateState()
    {
        base.UpdateState();
        Debug.Log("Update");
    }

    public override void DestroyState()
    {
        base.DestroyState();
        Debug.Log("Destroy");
    }
}

