using UnityEngine;

public class RedState : State
{
    [SerializeField] private SpriteRenderer rend;
    
    public override void Behaviour(bool activated)
    {
        if (activated)
        {
            rend.color = Color.red;
        }
    }
}