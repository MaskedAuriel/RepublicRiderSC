using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerClimbableManager : MonoBehaviour
{
    
    [SerializeField] public bool isXAxis;
    private void OnTriggerEnter(Collider other)
    {
        print("Test");
        other.GetComponent<mainController>().canClimb = true;
        other.GetComponent<climbingController>().isXAxis = isXAxis;
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<mainController>().canClimb = false;
    }
}
