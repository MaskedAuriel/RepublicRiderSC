using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class rotatingController : MonoBehaviour
{
    public GameObject pivotToMove;
    private bool isRotating;
    public int timeRotation;
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveLeft()
    {    
        if(!isRotating)
        {
            StartCoroutine(rotationCoroutine(90));
        }
    }

    public void moveRight()
    {
        if (!isRotating)
        {
            StartCoroutine(rotationCoroutine(-90));
        }
    }

    public void moveUp()
    {
        
    }

    public void moveDown()
    {
        
    }

    private IEnumerator rotationCoroutine(int side)
    {        
        isRotating = true;
        float startTime = Time.time;
        float actualRotation = pivotToMove.transform.localEulerAngles.x;
        print(pivotToMove.transform.localEulerAngles.x + side);
        while (Time.time < startTime + timeRotation)
        {
            float delta = (Time.time - startTime) / timeRotation;
            float interpolatedValue = Mathf.Lerp(0, side, delta);
            print(actualRotation);
            print(actualRotation + interpolatedValue);
            pivotToMove.transform.localEulerAngles = new Vector3(actualRotation + interpolatedValue, pivotToMove.transform.localEulerAngles.y, pivotToMove.transform.localEulerAngles.z);
            
            yield return null;
        }
        pivotToMove.transform.localEulerAngles = new Vector3((float)Math.Round(pivotToMove.transform.localEulerAngles.x), pivotToMove.transform.localEulerAngles.y, pivotToMove.transform.localEulerAngles.z);        
        isRotating = false;
    }
}
