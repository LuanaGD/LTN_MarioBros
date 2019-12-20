using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //public Transform[] luigiPos;
    public GameObject luigiBottom;
    public GameObject luigiMid;
    public GameObject luigiUp;
    private int currentLPos = 0;

    //public Transform[] MarioPos;
    public GameObject marioBottom;
    public GameObject marioMid;
    public GameObject marioUp;
    private int currentMPos = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        LuigiMovement();
        MarioMovement();
    }

    public void LuigiMovement()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            currentLPos++;

            if (currentLPos >= 2)
            {
                currentLPos = 2;
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            currentLPos -= 1;

            if (currentLPos <= 0)
            {
                currentLPos = 0;
            }
        }

        if(currentLPos == 0) //activation default sprites
        {
            luigiBottom.gameObject.SetActive(true);
            luigiMid.gameObject.SetActive(false);
        }
        else if(currentLPos == 1)
        {
            luigiMid.gameObject.SetActive(true);
            luigiBottom.gameObject.SetActive(false);
            luigiUp.gameObject.SetActive(false);
        }
        else if(currentLPos == 2)
        {
            luigiUp.gameObject.SetActive(true);
            luigiMid.gameObject.SetActive(false);
        }
    }

    private void MarioMovement()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            currentMPos++;

            if (currentMPos >= 2)
            {
                currentMPos = 2;
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            currentMPos -= 1;

            if (currentMPos <= 0)
            {
                currentMPos = 0;
            }
        }

        if (currentMPos == 0) //activation default sprites
        {
            marioBottom.gameObject.SetActive(true);
            marioMid.gameObject.SetActive(false);
        }
        else if (currentMPos == 1)
        {
            marioMid.gameObject.SetActive(true);
            marioBottom.gameObject.SetActive(false);
            marioUp.gameObject.SetActive(false);
        }
        else if (currentMPos == 2)
        {
            marioUp.gameObject.SetActive(true);
            marioMid.gameObject.SetActive(false);
        }
    }
}
