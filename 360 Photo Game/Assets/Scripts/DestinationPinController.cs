using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets;
using VRStandardAssets.Utils;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(VRInteractiveItem))]
public class DestinationPinController : MonoBehaviour
{
    public string sceneName;
    VRInteractiveItem vrInteractive;
    // Start is called before the first frame update
    void Awake()
    {
        vrInteractive = GetComponent<VRInteractiveItem>();
    }

    void ChangeScene(){
        SceneManager.LoadScene(sceneName);
    }

    void OnEnable(){
        vrInteractive.OnClick += ChangeScene;
    }

    void OnDisable(){
        vrInteractive.OnClick -= ChangeScene;
    }
}
