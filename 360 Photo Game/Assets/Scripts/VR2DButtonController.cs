using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;
using UnityEngine.UI;

[RequireComponent(typeof(VRInteractiveItem))]
public class VR2DButtonController : MonoBehaviour
{
    VRInteractiveItem VRInteractive;
    Button button;
    // Start is called before the first frame update
    void Awake()
    {
        VRInteractive = GetComponent<VRInteractiveItem>();
        button = GetComponentInChildren<Button>();
    }

    // Update is called once per frame
    void OnEnable()
    {
        vrInteractive.OnClick += button.OnClick.Invoke;
    }
    void OnDisable()
    {
        vrInteractive.OnClick -= button.OnClick.Invoke;
    }
}
