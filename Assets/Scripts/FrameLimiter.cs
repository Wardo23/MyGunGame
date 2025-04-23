using UnityEngine;

public class FrameLimiter : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60; // Caps FPS to 60
    }
}