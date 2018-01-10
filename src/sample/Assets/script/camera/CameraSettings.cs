using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSettings : MonoBehaviour
{

    public int Width = 800;
    public int Height = 600;
    public bool Fullscreen = true;

    private void Start()
    {
        SetResolution(Width, Height, Fullscreen);
    }

    void SetResolution(int TargetWidth, int TargetHeight, bool TargetFullscreen)
    {
        Screen.SetResolution(TargetWidth, TargetHeight, TargetFullscreen);
    }
}