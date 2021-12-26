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
        setVelocity(-5, 0);
    }

    public void moveRight()
    {
        setVelocity(5, 0);
    }

    public void moveUp()
    {
        setVelocity(0, 5);
    }

    public void moveDown()
    {
        setVelocity(0,-5);        
    }

    public void jump()
    {
        if(checkIfGrounded())
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 7, 0);
            //GetComponent<Rigidbody>().AddForce(new Vector3(0, 2, 0));
        }
        
    }

    private void manageGravity()
    {
        if (!checkIfGrounded())
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, -5, 0));
        }
    }
    private bool checkIfGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, GetComponent<Collider>().bounds.extents.y + 0.1f);
    }

    public void setVelocity(int x, int z)
    {
        /*int fallVelocity = 0;
        if(!checkIfGrounded())
        {
            fallVelocity = -6;
        }
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(x, fallVelocity, z);*/
        
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(x, -2, z);        
    }
}

