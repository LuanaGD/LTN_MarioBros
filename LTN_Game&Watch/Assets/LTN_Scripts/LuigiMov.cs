using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuigiMov : MonoBehaviour
{
    public Transform[] luigiPos;
    public GameObject luigiChara;
    private int currentPos = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        LuigiMovement();
    }

    public void LuigiMovement()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            currentPos++;

            if(currentPos >= 2)
            {
                currentPos = 2;
            }

            luigiChara.transform.position = luigiPos[currentPos].transform.position;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            currentPos -= 1;

            if(currentPos <= 0)
            {
                currentPos = 0;
            }

            luigiChara.transform.position = luigiPos[currentPos].transform.position;
        }
    }
}
