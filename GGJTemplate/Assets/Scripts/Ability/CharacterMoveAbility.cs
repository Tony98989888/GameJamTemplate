using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveAbility : CharacterAbilityBase
{
    public float MovementSpeed;

    protected float m_xMove;
    protected float m_yMove;


    public override bool IsAbilityActive()
    {
        return base.IsAbilityActive();
    }

    public override void ProcessAbility()
    {
        base.ProcessAbility();
        if (!IsAbilityActive()) { return; }
    }

    protected override void HandleInput()
    {
        base.HandleInput();
        m_xMove = m_xMovement;
        m_yMove = m_yMovement;
    }
}
