using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainController : MonoBehaviour
{
    public delegate void delegateConstroller();
    public delegateConstroller playerMovement;


    private void Start()
    {
        playerMovement = classicController;
    }
    private void Update()
    {
        switchManager();
        movementManager();        
    }

    private void classicController()
    {

    }

    private void switchManager()
    {
        if (Input.GetKeyDown("e"))
        {
            print("e");
            playerMovement = classicController;
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
        if (Input.GetKeyDown("z"))
        {
            print("z");
            
        }
        if (Input.GetKeyDown("q"))
        {
            print("q");
            
        }
        if (Input.GetKeyDown("s"))
        {
            print("s");
            
        }
        if (Input.GetKeyDown("d"))
        {
            print("d");
            
        }
    }
}
