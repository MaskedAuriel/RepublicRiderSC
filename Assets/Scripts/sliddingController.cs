using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sliddingController : MonoBehaviour
{ 
    public void moveLeft()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-3, 0, 0));
    }

    public void moveRight()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(3, 0, 0));
    }

    public void moveUp()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 3));
    }

    public void moveDown()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -3));
    }
}


