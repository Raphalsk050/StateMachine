using UnityEngine;


public abstract class State : MonoBehaviour
{
    protected StateMachine StateMachine;

    public virtual void Behaviour(bool activated)
    {
        
    }
}
