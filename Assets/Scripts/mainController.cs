using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainController : MonoBehaviour
{
    public delegate void delegateConstroller();
    public delegateConstroller playerMovement;
    public delegateConstroller playerMovementUp;
    public delegateConstroller playerMovementDown;
    public delegateConstroller playerMovementLeft;
    public delegateConstroller playerMovementRight;


    private void Start()
    {
        playerMovement = classicController;
        playerMovement.Invoke();
    }
    private void Update()
    {
        switchManager();
        movementManager();        
    }

    private void classicController()
    {
        playerMovementUp = GetComponent<classicController>().moveUp;
        playerMovementDown = GetComponent<classicController>().moveDown ;
        playerMovementLeft =  GetComponent<classicController>().moveLeft;
        playerMovementRight = GetComponent<classicController>().moveRight;
    }

    private void switchManager()
    {
        if (Input.GetKeyDown("e"))
        {
            print("e");
            playerMovement = classicController;
            playerMovement.Invoke();
        }
        if (Input.GetKeyDown("r"))
        {
            print("r");
            //playerMovement = ;
        }
        if (Input.GetKeyDown("f"))
        {
            print("f");
            //playerMovement = ;
        }
    }

    private void movementManager()
    {
        if (Input.GetKey("z"))
        {
            print("z");
            playerMovementUp.Invoke();
            
        }
        if (Input.GetKey("q"))
        {
            print("q");
            playerMovementLeft.Invoke();
            
        }
        if (Input.GetKey("s"))
        {
            print("s");
            playerMovementDown.Invoke();
            
        }
        if (Input.GetKey("d"))
        {
            print("d");
            playerMovementRight.Invoke();
            
        }
    }
}
