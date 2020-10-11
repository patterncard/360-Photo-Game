using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasFaceCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // get direction (position of canvas - position of the camera )
        Vector3 direction = transform.position - Camera.main.transform.position;

        // set forward of the canvas
        transform.forward = direction;
    }
}
