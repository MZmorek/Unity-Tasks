using UnityEngine;

public interface IState
{
    void DoThis();
    void DoThat();
}
public class StateMachine : MonoBehaviour
{
    private IState currentState;

    public void ChangeState(IState state)
    {
        currentState = state;
    }

    public void DoThis()
    {
        currentState.DoThis();
    }

    public void DoThat()
    {
        currentState.DoThat();
    }
}
