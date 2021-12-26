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

    public Material classicColor;
    public Material sliddingColor;
    //public Material rotatingColor;


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

    private void sliddingController()
    {
        playerMovementUp = GetComponent<sliddingController>().moveUp;
        playerMovementDown = GetComponent<sliddingController>().moveDown;
        playerMovementLeft = GetComponent<sliddingController>().moveLeft;
        playerMovementRight = GetComponent<sliddingController>().moveRight;
    }

    /*private void rotatingController()
    {
        playerMovementUp = GetComponent<rotatingController>().moveUp;
        playerMovementDown = GetComponent<rotatingController>().moveDown;
        playerMovementLeft = GetComponent<rotatingController>().moveLeft;
        playerMovementRight = GetComponent<rotatingController>().moveRight;
    }*/


    private void switchManager()
    {
        if (Input.GetKeyDown("e"))
        {
            
            GetComponent<MeshRenderer>().material = classicColor;
            playerMovement = classicController;
            playerMovement.Invoke();
        }
        if (Input.GetKeyDown("r"))
        {
           
            GetComponent<MeshRenderer>().material = sliddingColor;
            playerMovement = sliddingController;
            playerMovement.Invoke();

        }
        if (Input.GetKeyDown("f"))
        {
            /*GetComponent<MeshRenderer>().material = rotatingColor;
            playerMovement = rotatingController;*/
            playerMovement.Invoke();
            
        }
    }

    private void movementManager()
    {
        if (Input.GetKey("z"))
        {
            
            playerMovementUp.Invoke();
            
        }
        if (Input.GetKey("q"))
        {
            
            playerMovementLeft.Invoke();
            
        }
        if (Input.GetKey("s"))
        {
            
            playerMovementDown.Invoke();
            
        }
        if (Input.GetKey("d"))
        {
            
            playerMovementRight.Invoke();
            
        }
    }
}
