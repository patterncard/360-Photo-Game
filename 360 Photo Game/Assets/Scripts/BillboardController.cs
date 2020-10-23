using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardController : MonoBehaviour
{
    public void MoveBillboard()
    {
        Vector3 newPosition = transfrom.position;
        newPosition.y += 1;

        transfrom.position = newPosition;
    }
}
