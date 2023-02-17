using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAbilityBase : MonoBehaviour
{
    TopDownBaseCharacterController m_owner;
    public bool AbilityActive = false;

    public virtual bool IsAbilityActive() { return false; }

    protected virtual void Awake() { }
    protected virtual void Start() { }
    protected virtual void Update() { }

    protected virtual void InitializeAbility()
    {
    }

    public virtual void BeforeProcessAbility() { }
    public virtual void AfterProcessAbility() { }
    public virtual void ProcessAbility() { }
}
