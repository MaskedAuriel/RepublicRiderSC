using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classicController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveLeft()
    {        
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(-7, 0, 0);
    }

    public void moveRight()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(7, 0, 0);
    }

    public void moveUp()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 7);
    }

    public void moveDown()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -7);
    }
}
