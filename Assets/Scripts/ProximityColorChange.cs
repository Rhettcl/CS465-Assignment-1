using UnityEngine;

public class ProximityColorChange : MonoBehaviour
{
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.blue;
    }

    void OnTriggerEnter(Collider other)
    {
        rend.material.color = Color.white;
    }

    void OnTriggerExit(Collider other)
    {
        rend.material.color = Color.blue;
    }
}