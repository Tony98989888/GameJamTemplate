using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveAbility : CharacterAbilityBase
{
    public float MovementSpeed;



    public override bool IsAbilityActive()
    {
        return base.IsAbilityActive();
    }

    public override void ProcessAbility()
    {
        base.ProcessAbility();
        if (!IsAbilityActive()) { return; }
    }
}
