using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class climbingController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isXAxis;
    public void moveLeft()
    {
        if(isXAxis)
        {
            setVelocity(-5, 0, 0);
        }  
        else
        {
            setVelocity(0, 0, -5);
        }
    }

    public void moveRight()
    {
        if (isXAxis)
        {
            setVelocity(5, 0, 0);
        }
        else
        {
            setVelocity(0, 0, 5);
        }
    }

    public void moveUp()
    {
        setVelocity(0, 5, 0);
    }

    public void moveDown()
    {
        setVelocity(0, -5, 0);
    }

    public void setVelocity(int x, int y, int z)
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(x, y, z);
    }
}
