using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class CharacterAbilityBase : MonoBehaviour
{
    TopDownBaseCharacterController m_owner;
    public bool AbilityActive = false;

    protected InputManager m_inputManager;

    public virtual bool IsAbilityActive() { return false; }
    public bool InputManagerConnected => m_inputManager != null;

    protected float m_xMovement;
    protected float m_yMovement;

    protected virtual void Awake() { PreInitializeAbility(); }
    protected virtual void Start() { InitializeAbility(); }
    protected virtual void Update() { }

    protected virtual void PreInitializeAbility() { }

    protected virtual void InitializeAbility()
    {
        m_owner = GetComponentInParent<TopDownBaseCharacterController>();
        m_inputManager = m_owner.CharInputManager;
    }

    public virtual void BeforeProcessAbility() { HandleInput(); }
    public virtual void AfterProcessAbility() { }
    public virtual void ProcessAbility() { }


    protected virtual void HandleInput()
    {
        if (!InputManagerConnected) { return; }
        m_xMovement = m_inputManager.Movement.x;
        m_yMovement = m_inputManager.Movement.y;
        Debug.Log($"Input X : {m_xMovement}, Y : {m_yMovement}");
    }
}
