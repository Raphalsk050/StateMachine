using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private State _state;
    private State _previousState;

    protected virtual void SetState(State state)
    {
        if (_state == null)
        {
            _state = state;
        }
        
        _previousState = _state;
        _previousState.Behaviour(false);
        _state = state;
        _state.Behaviour(true);
    }
    
    protected virtual State GetPreviousState()
    {
        return _state;
    }

    protected virtual State GetState()
    {
        return _previousState;
    }
}
