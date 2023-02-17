using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using UnityEngine;

public class CharacterLogic : MonoBehaviour
{
    protected HashSet<CharacterAbilityBase> m_characterAbilities;

    protected Animator m_animator;
    public Animator CharAnimator => m_animator;

    protected virtual void Awake()
    {
        Initialize();
    }

    protected virtual void Update() 
    {
        BeforeProcessAbility();
        ProcessAbility();
        AfterProcessAbility();
    }

    protected virtual void Initialize()
    {
        InitializeAnimator();
    }

    protected virtual void AcquireAllAbilities()
    {
        m_characterAbilities = this.gameObject.GetComponents<CharacterAbilityBase>().ToHashSet();
    }

    protected virtual void InitializeAnimator()
    {
        if (m_animator == null)
        {
            m_animator = GetComponent<Animator>();
        }
    }


    protected virtual void BeforeProcessAbility() 
    {
        foreach (var ability in m_characterAbilities)
        {
            if (ability.AbilityActive && ability.enabled)
            {
                ability.BeforeProcessAbility();
            }
        }
    }
    protected virtual void AfterProcessAbility() 
    {
        foreach (var ability in m_characterAbilities)
        {
            if (ability.AbilityActive && ability.enabled)
            {
                ability.AfterProcessAbility();
            }
        }
    }
    protected virtual void ProcessAbility() 
    {
        foreach (var ability in m_characterAbilities)
        {
            if (ability.AbilityActive && ability.enabled)
            {
                ability.ProcessAbility();
            }
        }
    }
}
