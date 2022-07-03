using UnityEngine;

public class GameState : BaseState
{
    public GameState(StateMachine stateMachine) : base(stateMachine)
    {

    }

    public override void EnterState()
    {
        Debug.Log("Entered GameState");
    }
}
