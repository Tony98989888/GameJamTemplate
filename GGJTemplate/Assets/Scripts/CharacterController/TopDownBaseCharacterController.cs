using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using UnityEngine;

public class TopDownBaseCharacterController : MonoBehaviour
{
    // Drives player movement
    public Vector2 CurrentMoveVelocity;
    protected Vector2 m_impactForce;
    public bool UsingGravity = false;
    public bool CanMove = false;

    [SerializeField]
    InputManager m_inputManager;
    public InputManager CharInputManager => m_inputManager;

    protected virtual void Awake()
    {
    }

    protected virtual void LateUpdate() { }
    protected virtual void Update() { }
    protected virtual void FixedUpdate() { }

    protected virtual void OnImpactReceived() { }

    protected virtual void ResetController()
    {
        m_impactForce = Vector2.zero;
        UsingGravity = false;
        CanMove = false;
    }

    // We change object movements by changing velocity of rigidbody
    public virtual void SetMovement(Vector2 velocity) { }
}
