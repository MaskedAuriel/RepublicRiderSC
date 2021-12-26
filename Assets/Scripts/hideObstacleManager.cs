using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideObstacleManager : MonoBehaviour
{
    public GameObject objectToDeactivateOrActivate;
    private void OnTriggerEnter(Collider other)
    {
        objectToDeactivateOrActivate.GetComponent<MeshRenderer>().enabled = false;
    }
}
