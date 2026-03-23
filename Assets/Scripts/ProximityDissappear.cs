using UnityEngine;

public class ProximityDisappear : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }
}