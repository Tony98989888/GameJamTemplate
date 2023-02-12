using UnityEngine;

public class InputManager : Singleton<InputManager>
{
    // (xMovement, yMovement)
    protected Vector2 m_movement;

    public Vector2 Movement => m_movement;

    public bool IsInputActive = true;

    protected virtual void Update() 
    {
        if (!IsInputActive) { return; }
        Get4DirMovement();
    }

    protected virtual void Get4DirMovement() 
    {
        if (!IsInputActive)
        {
            return;
        }
        m_movement.x = Input.GetAxisRaw("Horizontal");
        m_movement.y = Input.GetAxisRaw("Vertical");
    }
}
