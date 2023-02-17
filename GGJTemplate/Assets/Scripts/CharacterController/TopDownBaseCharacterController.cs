using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TopDownBaseCharacterController : MonoBehaviour
{
    public Vector2 CurrentMoveVelocity;
    protected Vector2 m_impactForce;
    public bool UsingGravity = false;
    public bool CanMove = false;

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
}
