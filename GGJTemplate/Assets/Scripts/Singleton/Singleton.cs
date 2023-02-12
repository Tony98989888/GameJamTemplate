using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Component
{
    protected static T m_instance;

    public static bool HasInstance => m_instance != null;
    public static T TyrGetInstance => HasInstance ? m_instance : null;
    public static T CurrentInstance => m_instance;

    public static T Instance
    {
        get {
            if (m_instance ==null)
            {
                m_instance = FindObjectOfType<T>();
                if (m_instance == null)
                {
                    // Create a gameobject and make it a instance
                    GameObject instance = new GameObject(typeof(T).Name);
                    m_instance= instance.AddComponent<T>();
                }
            }
            return m_instance;
        }
    }

    protected virtual void Awake() 
    {
        Initialize();
    }

    protected virtual void Initialize() 
    {
        // Initialize only when in play mode
        if (!Application.isPlaying)
        {
            return;
        }
        m_instance = this as T;
    }
}
