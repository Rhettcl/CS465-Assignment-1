using UnityEngine;

public class EditorOnlySimulator : MonoBehaviour
{
    void Awake()
    {
        #if !UNITY_EDITOR
            Destroy(gameObject);
        #endif
    }
}