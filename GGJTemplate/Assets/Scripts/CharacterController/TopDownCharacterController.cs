using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : TopDownBaseCharacterController
{
    protected Rigidbody2D m_rb2d;
    protected float m_imapctDecreaseFactor = 1.0f;

    protected override void Awake()
    {
        base.Awake();
        m_rb2d = GetComponent<Rigidbody2D>();
    }

    protected override void OnImpactReceived()
    {
        if (m_impactForce.magnitude > 0)
        {
            m_rb2d.AddForce(m_impactForce);
        }
        m_impactForce = Vector2.Lerp(m_impactForce, Vector2.zero, m_imapctDecreaseFactor * Time.deltaTime);
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        // Deal with impact first
        OnImpactReceived();
        if (!CanMove)
        {
            return;
        }
        m_rb2d.velocity = CurrentMoveVelocity;
    }

}
