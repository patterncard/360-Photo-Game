using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using VRStandardAssets.Utils;

[RequireComponent(typeof(VRInteractiveItem))]
public class VR2DButton : MonoBehaviour
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
        
    }
         void OnDisable()
    {
        
    }
}
