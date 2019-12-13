using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MarioMov;
    public float LuigiMov;

    public Rigidbody2D MarioChara;
    public Rigidbody2D Luigichara;

    public GameObject [] MarioPos;
    public GameObject[] LuigiPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MarioMovement();
        LuigiMovement();
    }

    public void MarioMovement()
    {
        int i = 0;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            i++;
            MarioChara.transform.position = MarioPos[i].transform.position;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            i = i-1;
            MarioChara.transform.position = MarioPos[i].transform.position;
        }
    }

    public void LuigiMovement()
    {
        int i = 0;
        
        if (Input.GetKeyDown(KeyCode.Z))
        {
            i++;
            Luigichara.transform.position = LuigiPos[i].transform.position;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            i = i - 1;
            Luigichara.transform.position = LuigiPos[i].transform.position;
        }
    }
}
/*Fait bouger Mario et Luigi
 renvoie ses infos au Game manager*/
