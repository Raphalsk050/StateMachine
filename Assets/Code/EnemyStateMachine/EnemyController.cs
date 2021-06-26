using UnityEngine;

public class EnemyController : StateMachine
{
    [SerializeField] private State[] states;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            SetState(states[1]);
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            SetState(states[0]);
        }
    }
}
