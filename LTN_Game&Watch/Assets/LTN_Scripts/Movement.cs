using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform[] luigiPos;
    public GameObject luigiChara;
    private int currentLPos = 0;

    public Transform[] MarioPos;
    public GameObject MarioChara;
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

            luigiChara.transform.position = luigiPos[currentLPos].transform.position;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            currentLPos -= 1;

            if (currentLPos <= 0)
            {
                currentLPos = 0;
            }

            luigiChara.transform.position = luigiPos[currentLPos].transform.position;
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

            MarioChara.transform.position = MarioPos[currentMPos].transform.position;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            currentMPos -= 1;

            if (currentMPos <= 0)
            {
                currentMPos = 0;
            }

            MarioChara.transform.position = MarioPos[currentMPos].transform.position;
        }
    }
}
