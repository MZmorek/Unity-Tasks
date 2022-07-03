using UnityEngine;
public class MenuState : BaseState
{
    public MenuState(StateMachine stateMachine) : base(stateMachine)
    {

    }

    public override void EnterState()
    {
        Debug.Log("Entered MenuState");
    }
}
