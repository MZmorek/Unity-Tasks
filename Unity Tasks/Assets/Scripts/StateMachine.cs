using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private BaseState currentlyActiveState;
    public void Start()
    {
        ChangeState(new MenuState(this));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeState(new GameState(this));
        }
    }

    private void OnDestroy()
    {
        currentlyActiveState?.DestroyState();
    }

    public void ChangeState(BaseState state)
    {
        currentlyActiveState?.DestroyState();
        currentlyActiveState = state;
        currentlyActiveState?.EnterState();
    }
}
