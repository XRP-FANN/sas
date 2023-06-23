using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Vector3 Teleport_Pont;

    private void OnTriggerStay(Collider other)
    {
        other.transform.position = Teleport_Pont;
    }
}
