using UnityEngine;

public class GreenState : State
{
    [SerializeField] private SpriteRenderer rend;
        
    public override void Behaviour(bool activated)
    {
        if (activated)
        {
            rend.color = Color.green;
        }
    }
}