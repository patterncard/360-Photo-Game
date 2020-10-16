using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;

[RequireComponent(typeof(VRInteractiveItem))]
public class VRCalloutController : MonoBehaviour
{
    public Canvas canvas;
    public bool isInitiallyVisible = false;
    public bool isHoverActivated = false;
    public bool isClickActivated = false;
    VRInteractiveItem vrInteractive;

    void Awake()
    {
        vrInteractive = GetComponent<VRInteractiveItem>();

        canvas.enabled = isInitiallyVisible;
    }

    void OnEnable()
    {
        if(isHoverActivated)
        {
            vrInteractive.OnOver += ShowCanvas;
            vrInteractive.OnOut += HideCanvas;
        }

        if(isClickActivated)
        {
            vrInteractive.OnClick += ToggleCanvas;
        }
    }

    void ToggleCanvas()
    {
        canvas.enabled = !canvas.enabled;
    }

    void OnDisable()
    {
        if(isHoverActivated)
        {
            vrInteractive.OnOver -= ShowCanvas;
            vrInteractive.OnOut -= HideCanvas;
        }
    }

    void ShowCanvas()
    {
        canvas.enabled = true;
    }

    void HideCanvas()
    {
        canvas.enabled = false;
    }
}
